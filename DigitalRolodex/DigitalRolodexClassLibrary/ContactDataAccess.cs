using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DigitalRolodexClassLibrary {
    public class ContactDataAccess : IContactDataAccess {

        //TODO: Testing & Refactor

        #region Connection String and SQL Connections
        private string _path = "DigitalRolodex.Properties.Settings.DataConnection";

        private string GetConnectionString() {

            var setting = ConfigurationManager.ConnectionStrings[_path];

            if(setting == null) {

                return null;
            }

            return setting.ConnectionString;
        }

        private SqlConnection GetConnection() {

            string connectionString = GetConnectionString();

            if(connectionString == null) {

                return null;
            }

            return new SqlConnection(connectionString);
        }
        #endregion

        #region Select Queries
        public DataSet Retrieve() {

            var result = new DataSet();

            using(var connection = GetConnection()) {

                using(var command = new SqlCommand(null, connection)) {

                    command.CommandText = @"SELECT * FROM Contact";

                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(result, "Contact");
                }
            }

            return result;
        }

        public DataSet Retrieve(string name) {

            var result = new DataSet();

            using(var connection = GetConnection()) {

                using(var command = new SqlCommand(null, connection)) {

                    command.CommandText = @"SELECT * FROM Contact 
                                             WHERE Name = @name";

                    command.Parameters.AddWithValue("@name", name);

                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(result, "ContactByName");
                }
            }

            return result;
        }
        #endregion

        #region Insert Operations
        public void Insert(IContact contact) {

            using(var connection = GetConnection()) {

                connection.Open();

                using(var command = new SqlCommand(null, connection)) {

                    command.CommandText = @"INSERT INTO Contact
                                            (Name, Phone, Email, Address)
                                            VALUES
                                            (@name, @phone, @email, @address)";

                    command.Parameters.AddWithValue("@name", contact.Name);
                    command.Parameters.AddWithValue("@phone", contact.Phone);
                    command.Parameters.AddWithValue("@email", contact.Email);
                    command.Parameters.AddWithValue("@address", contact.Address);

                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Update Operations
        public void Update(IContact contact, int id) {

            using(var connection = GetConnection()) {

                connection.Open();

                using(var command = new SqlCommand(null, connection)) {

                    command.CommandText = @"UPDATE Contact SET
                                               Name = @name, 
                                              Phone = @phone, 
                                              Email = @email, 
                                            Address = @address
                                             WHERE id = @id";

                    command.Parameters.AddWithValue("@name", contact.Name);
                    command.Parameters.AddWithValue("@phone", contact.Phone);
                    command.Parameters.AddWithValue("@email", contact.Email);
                    command.Parameters.AddWithValue("@address", contact.Address);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Delete Operations
        public void Delete(int id) {

            using(var connection = GetConnection()) {

                connection.Open();

                using(var command = new SqlCommand(null, connection)) {

                    command.CommandText = @"DELETE FROM Contact
                                            WHERE id = @id";

                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}