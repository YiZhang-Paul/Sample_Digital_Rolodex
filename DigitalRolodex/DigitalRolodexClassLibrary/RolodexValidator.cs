using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DigitalRolodexClassLibrary {
    public class RolodexValidator : IRolodexValidator {

        private bool IsValidLength(string name) {

            return name.Length >= 2 && name.Length <= 25;
        }

        private bool IsLegalCharacter(string name) {

            return Regex.IsMatch(name, @"^[A-z][A-z\s]+'?[A-z\s]*$");
        }

        public bool IsValidName(string name) {

            name = name.Trim().ToLower();

            return IsValidLength(name) && IsLegalCharacter(name);
        }
    }
}