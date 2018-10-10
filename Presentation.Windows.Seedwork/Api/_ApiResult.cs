using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Windows.Seedwork.Api
{
    public class ErrorItem
    {
        public string path { get; set; }
        public string message { get; set; }
    }

    public abstract class ApiResultBase
    {
        public Boolean ok { get; set; }
        public string message { get; set; }
    }

    public class ApiResult<T> : ApiResultBase
    {
        public T result { get; set; }
    }

    public class ApiResultError : ApiResultBase
    {
        private List<ErrorItem> _errors = null;

        public List<ErrorItem> errors
        {
            get
            {
                if (_errors == null)
                    _errors = new List<ErrorItem>();

                return _errors;
            }
            set { _errors = new List<ErrorItem>(value); }
        }
    }
}
