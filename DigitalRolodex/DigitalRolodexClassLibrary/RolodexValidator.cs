using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DigitalRolodexClassLibrary {
    public class RolodexValidator : IRolodexValidator {

        private Dictionary<string, string> _errorMessages = new Dictionary<string, string>() {
            //error types and corresponding messages
            {"name", "* Invalid Name (Length: 2-25)"},
            {"phone", "* Invalid Phone Number"},
            {"email", "* Invalid Email (xxx@example.com)"},
            {"address", "* Invalid Address (Length: 6-50)"}
        };

        private IPhoneNumberValidator PhoneNumberValidator { get; set; }

        public RolodexValidator(IPhoneNumberValidator phoneNumberValidator) {

            PhoneNumberValidator = phoneNumberValidator;
        }

        private Error GetError(string type) {
        
            if(!_errorMessages.ContainsKey(type)) {
            
                return null;
            }

            return new Error(type, _errorMessages[type]);
        }

        #region Name Validations
        private bool IsValidNameLength(string name) {

            return name.Length >= 2 && name.Length <= 25;
        }

        private bool IsLegalNameFormat(string name) {

            return Regex.IsMatch(name, @"^[A-z][A-z\s]+'?[A-z\s]*$");
        }

        public bool IsValidName(string name) {

            name = name.Trim().ToLower();

            return IsValidNameLength(name) && IsLegalNameFormat(name);
        }
        #endregion

        #region Phone Number Validations
        public bool IsValidPhoneNumber(string phoneNumber) {

            return PhoneNumberValidator.IsValidPhoneNumber(phoneNumber);
        }
        #endregion

        #region Email Validations
        private bool IsValidEmailFormat(string email) {

            return Regex.IsMatch(email, @"^\w+@\w+\.(com|org)$");
        }

        private bool IsValidEmailLength(string email) {

            return email.Length >= 6 && email.Length <= 40;
        }

        public bool IsValidEmail(string email) {

            email = email.Trim();

            return IsValidEmailFormat(email) && IsValidEmailLength(email);
        }
        #endregion

        #region Address Validations
        private bool IsValidAddressLength(string address) {

            return address.Length >= 6 && address.Length <= 50;
        }

        private bool IsLegalCharacters(string address) {

            return Regex.IsMatch(address, @"^[A-z\d\s'-\(\)\.]+$");
        }

        public bool IsValidAddress(string address) {

            address = address.Trim();

            return IsValidAddressLength(address) && IsLegalCharacters(address);
        }
        #endregion

        #region Search Box Validations
        public bool IsValidSearchText(string searchText, string placeholder) {

            searchText = searchText.Trim();

            return searchText != string.Empty && searchText != placeholder;
        }
        #endregion

        public Error[] FindInputErrors(string[] inputs) {

            var errors = new List<Error>();

            if(!IsValidName(inputs[0])) errors.Add(GetError("name"));
            if(!IsValidPhoneNumber(inputs[1])) errors.Add(GetError("phone"));
            if(!IsValidEmail(inputs[2])) errors.Add(GetError("email"));
            if(!IsValidAddress(inputs[3])) errors.Add(GetError("address"));

            return errors.ToArray();
        }
    }
}