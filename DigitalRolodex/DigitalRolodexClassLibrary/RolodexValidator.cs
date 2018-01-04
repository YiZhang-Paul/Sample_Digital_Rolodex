using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DigitalRolodexClassLibrary {
    public class RolodexValidator : IRolodexValidator {

        private IPhoneNumberValidator PhoneNumberValidator { get; set; }

        public RolodexValidator(IPhoneNumberValidator phoneNumberValidator) {

            PhoneNumberValidator = phoneNumberValidator;
        }

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

        public bool IsValidPhoneNumber(string phoneNumber) {

            return PhoneNumberValidator.IsValidPhoneNumber(phoneNumber);
        }

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
    }
}