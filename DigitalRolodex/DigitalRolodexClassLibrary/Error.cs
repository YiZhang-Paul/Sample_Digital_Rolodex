using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRolodexClassLibrary {
    public class Error : IError {

        public string Type { get; private set; }
        public string Message { get; private set; }

        public Error(string type, string message) {

            if(type.Trim() == string.Empty) {

                throw new ArgumentException("Type Cannot be Empty.");
            }

            Type = type;
            Message = message;
        }
    }
}