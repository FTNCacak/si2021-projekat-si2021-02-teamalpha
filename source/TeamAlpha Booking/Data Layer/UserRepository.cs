using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper; // Dapper je ORM (object–relational mapping) alat koji olaksava mapiranje instanci entiteta baze u objekte
using Data_Layer.Models;

namespace Data_Layer
{
    public class UserRepository
    {
        public int InsertUser(Korisnik user) // CREATE
        {
            String Query = "INSERT INTO Korisnici VALUES(@Password, @FirstName, @LastName,  @Email, @BirthDate, @PhoneNumber, @Role)";

            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlfaDB")))
            {
          
                var QueryParameters = new DynamicParameters(); // parametrizovan upit je otporan na SQL injection napad,

                QueryParameters.Add("@Password", user.Lozinka);
                QueryParameters.Add("@FirstName", user.Ime);
                QueryParameters.Add("@LastName", user.Prezime);
                QueryParameters.Add("@Email", user.Email);
                QueryParameters.Add("@PhoneNumber", user.Br_telefona);
                QueryParameters.Add("@BirthDate", user.Datum_rodjenja);
                QueryParameters.Add("@Role", user.Stanodavac);
                
                return connection.Execute(Query, QueryParameters); // Execute metodu obezbedjuje dapper
            }
            
        }

        public List<Korisnik> GetAllUsers() // READ
        {
            throw new NotImplementedException();
        }

        public void UpdateUserInfo(Korisnik user) // UPDATE
        {
            throw new NotImplementedException();
        }

        public void RemoveUser (int UserId) // DELETE
        {
            throw new NotImplementedException();
        }
 
    }
}
