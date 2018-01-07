using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DigitalRolodexClassLibrary {
    public interface IContactDataAccess {

        //TODO: Double Check

        DataSet Retrieve();
        DataSet Retrieve(string name);
        void Insert(IContact contact);
        void Update(IContact contact, int id);
        void Delete(int id);
    }
}