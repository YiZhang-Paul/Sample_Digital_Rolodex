using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DigitalRolodexClassLibrary {
    public class PhoneNumberValidator {

        private HashSet<string> AreaCodes { get; set; }

        public PhoneNumberValidator(string fileName) {

            AreaCodes = GetAreaCodes(fileName);
        }

        private HashSet<string> GetAreaCodes(string fileName) {

            try {

                return new HashSet<string>(File.ReadAllLines(fileName));
            }
            catch(Exception exception) {

                Console.WriteLine(exception.Message);

                throw exception;
            }
        }

        public bool IsValidPhoneNumber(string phoneNumber) {

            return false;
        }
    }
}