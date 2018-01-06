using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace DigitalRolodexClassLibrary {
    public class PhoneNumberValidator : IPhoneNumberValidator {

        private HashSet<string> AreaCodes { get; set; }

        public PhoneNumberValidator(string fileName) {

            AreaCodes = GetAreaCodes(fileName);
        }

        #region Area Code Validations
        private HashSet<string> GetAreaCodes(string fileName) {

            try {

                return new HashSet<string>(File.ReadAllLines(fileName));
            }
            catch(Exception exception) {

                Console.WriteLine(exception.Message);

                throw exception;
            }
        }

        public bool IsValidAreaCode(string areaCode) {

            return AreaCodes.Contains(areaCode);
        }
        #endregion

        #region Phone Number Validations
        private string GetDigits(string phoneNumber) {

            return Regex.Replace(phoneNumber.Trim(), @"\D", "");
        }

        private bool HasLetters(string phoneNumber) {

            return Regex.IsMatch(phoneNumber, "[A-z]");
        }

        public bool IsValidPhoneNumber(string phoneNumber) {

            string digits = GetDigits(phoneNumber);

            if(digits.Length != 10 || HasLetters(phoneNumber)) {

                return false;
            }

            return IsValidAreaCode(digits.Substring(0, 3));
        }
        #endregion
    }
}