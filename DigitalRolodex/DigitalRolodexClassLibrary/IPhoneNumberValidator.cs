using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRolodexClassLibrary {
    public interface IPhoneNumberValidator {

        bool IsValidPhoneNumber(string phoneNumber);
    }
}