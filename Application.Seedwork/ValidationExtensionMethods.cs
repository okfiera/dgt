using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Crosscutting.Validator;

namespace Application.Seedwork
{
    public static class ValidationExtensionMethods
    {
        /// <summary>
        /// Validate Entity calling IValidatableObject.Validate
        /// </summary>
        /// <param name="item">Entity to validate</param>
        public static void Validate<TEntity>(this TEntity item)
            where TEntity : class, new()
        {
            //Recover validator
            var validator = EntityValidatorFactory.CreateValidator();

            //Validate entity
            if (!validator.IsValid(item))
                throw new ApplicationValidationErrorsException(validator.GetInvalidMessages(item));
        }
    }
}
