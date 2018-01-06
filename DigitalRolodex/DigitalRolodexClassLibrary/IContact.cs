using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRolodexClassLibrary {
    public interface IContact {

        string Name { get; }
        string Phone { get; }
        string Email { get; }
        string Address { get; }
    }
}