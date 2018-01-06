using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DigitalRolodexClassLibrary {
    public class Contact : IContact {

        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }

        public Contact(string name, string phoneNumber, string email, string address) {

            Name = name;
            Phone = FormatPhoneNumber(phoneNumber);
            Email = email;
            Address = address;
        }

        private string FormatPhoneNumber(string phoneNumber) {

            string digits = Regex.Replace(phoneNumber, @"\D", "");

            if(digits.Length != 10) {

                throw new ArgumentException("Phone Number Must Contain Exactly 10 Digits.");
            }

            string areaCode = digits.Substring(0, 3);
            string localNumber = digits.Substring(3, 3) + "-" + digits.Substring(6);

            return "(" + areaCode + ")" + localNumber;
        }
    }
}