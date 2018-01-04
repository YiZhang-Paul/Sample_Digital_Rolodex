using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DigitalRolodexClassLibrary {
    public class RolodexValidator : IRolodexValidator {

        private bool ContainsDigit(string name) {

            return Regex.IsMatch(name, @"\d");
        }

        private bool IsValidLength(string name) {

            return name.Length >= 2 && name.Length <= 25;
        }

        public bool IsValidName(string name) {

            name = name.Trim().ToLower();

            return IsValidLength(name) && !ContainsDigit(name);
        }
    }
}