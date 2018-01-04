using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRolodexClassLibrary {
    public interface IRolodexValidator {

        bool IsValidName(string name);
        bool IsValidPhoneNumber(string phoneNumber);
        bool IsValidEmail(string email);
        bool IsValidAddress(string address);
    }
}