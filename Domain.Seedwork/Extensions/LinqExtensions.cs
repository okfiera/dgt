using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Data.Entity;

namespace Domain.Seedwork.Extensions
{
    public static partial class LinqExtensions
    {
        public class Node<T>
        {
            internal Node() { }

            public int Level { get; internal set; }
            public Node<T> Parent { get; internal set; }
            public T Item { get; internal set; }
            public IList<Node<T>> Children { get; internal set; }
        }

        public static IEnumerable<Node<T>> ByHierarchy<T>(
            this IEnumerable<T> source,
            Func<T, bool> startWith,
            Func<T, T, bool> connectBy)
        {
            return source.ByHierarchy<T>(startWith, connectBy, null);
        }

        private static IEnumerable<Node<T>> ByHierarchy<T>(
            this IEnumerable<T> source,
            Func<T, bool> startWith,
            Func<T, T, bool> connectBy,
            Node<T> parent)
        {
            int level = (parent == null ? 0 : parent.Level + 1);

            if (source == null)
                throw new ArgumentNullException("source");

            if (startWith == null)
                throw new ArgumentNullException("startWith");

            if (connectBy == null)
                throw new ArgumentNullException("connectBy");

            foreach (T value in from item in source
                                where startWith(item)
                                select item)
            {
                var children = new List<Node<T>>();
                Node<T> newNode = new Node<T>
                {
                    Level = level,
                    Parent = parent,
                    Item = value,
                    Children = children.AsReadOnly()
                };

                foreach (Node<T> subNode in source.ByHierarchy<T>(possibleSub => connectBy(value, possibleSub),
                                                                  connectBy, newNode))
                {
                    children.Add(subNode);
                }

                yield return newNode;
            }
        }

        public static void DumpHierarchy<T>(this IEnumerable<Node<T>> nodes, Func<T, string> display)
        {
            DumpHierarchy<T>(nodes, display, 0);
        }

        private static void DumpHierarchy<T>(IEnumerable<LinqExtensions.Node<T>> nodes, Func<T, string> display, int level)
        {
            foreach (var node in nodes)
            {
                for (int i = 0; i < level; i++) Console.Write("  ");
                Console.WriteLine(display(node.Item));
                if (node.Children != null)
                    DumpHierarchy(node.Children, display, level + 1);
            }
        }

        /// <summary>
        /// Traverse a hierarchical structure with LINQ-to-Hierarchical
        /// <see cref="http://social.msdn.microsoft.com/Forums/en-US/linqtosql/thread/fe90c616-3e2a-480a-9d6a-59b3eb467130/"/>
        /// </summary>
        public static IEnumerable<T> Flatten<T>(this IEnumerable<T> items, Func<T, IEnumerable<T>> before, Func<T, IEnumerable<T>> after)
        {
            foreach (var item in items)
            {
                if (before != null)
                {
                    foreach (var b in before(item))
                    {
                        yield return b;
                    }
                }
                yield return item;
                if (after != null)
                {
                    foreach (var a in after(item))
                    {
                        yield return a;
                    }
                }
            }
        }

        /// <summary>
        /// Adds an equivalent SQL WHERE IN() clause to the query, restricting results to a given range
        /// </summary>
        /// <typeparam name="TEntity">Type of entity to query</typeparam>
        /// <typeparam name="TValue">Type of value to query against</typeparam>
        /// <param name="query">Existing query</param>
        /// <param name="selector">Expression to retrieve query field</param>
        /// <param name="collection">Collection of values to limit query</param>
        /// <returns>Query with added WHERE IN() clause</returns>
        public static IEnumerable<TEntity> WhereIn<TEntity, TValue>
        (
            this ObjectQuery<TEntity> query,
            Expression<Func<TEntity, TValue>> selector,
            IEnumerable<TValue> collection
        )
        {
            ParameterExpression p = selector.Parameters.Single();

            //if there are no elements to the WHERE clause,
            //we want no matches:
            if (!collection.Any()) return query.Where(x => false);

            if (collection.Count() > 3000) //could move this value to config
                throw new ArgumentException("Collection too large - execution will cause stack overflow", "collection");

            IEnumerable<Expression> equals = collection.Select(value =>
               (Expression)Expression.Equal(selector.Body,
                    Expression.Constant(value, typeof(TValue))));

            Expression body = equals.Aggregate(Expression.Or);

            return query.Where(Expression.Lambda<Func<TEntity, bool>>(body, p));
        }
    }
}
