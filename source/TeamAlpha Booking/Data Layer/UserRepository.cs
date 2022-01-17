using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper; // Dapper je ORM (object–relational mapping) alat koji olaksava mapiranje instanci entiteta baze u objekte
using Shared.Models;
using Shared.Interfaces;

namespace Data_Layer
{
    public class UserRepository : IUserRepository
    {
        public int InsertUser(User user) // CREATE
        {
            String InsertQuery = "INSERT INTO Korisnici VALUES(@Password, @FirstName, @LastName,  @Email, @BirthDate, @PhoneNumber, @Role)";

            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                var QueryParameters = new DynamicParameters(); // parameterized query to prevent SQL injection

                QueryParameters.Add("@Password", user.Lozinka);
                QueryParameters.Add("@FirstName", user.Ime);
                QueryParameters.Add("@LastName", user.Prezime);
                QueryParameters.Add("@Email", user.Email);
                QueryParameters.Add("@PhoneNumber", user.Broj_telefona);
                QueryParameters.Add("@BirthDate", user.Datum_rodjenja);
                QueryParameters.Add("@Role", user.Stanodavac);
                
                return connection.Execute(InsertQuery, QueryParameters); // Execute method provided by Dapper
            }
        }

        public List<User> GetAllUsers() // READ
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                return connection.Query<User>("SELECT * FROM Korisnici").ToList();
            }
        }

        public int UpdateUserData(User UpdatedUser) // UPDATE, must pass new user object with updated data
        {
            String UpdateQuery = "UPDATE Korisnici SET " +
                "Lozinka = @Password, " +
                "Email = @Email, " +
                "Ime = @FirstName, " +
                "Prezime = @LastName," +
                "Datum_rodjenja = @BirthDate, " +
                "Stanodvac = @Role WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                var QueryParameters = new DynamicParameters();

                QueryParameters.Add("@Password", UpdatedUser.Lozinka);
                QueryParameters.Add("@FirstName", UpdatedUser.Ime);
                QueryParameters.Add("@LastName", UpdatedUser.Prezime);
                QueryParameters.Add("@Email", UpdatedUser.Email);
                QueryParameters.Add("@PhoneNumber", UpdatedUser.Broj_telefona);
                QueryParameters.Add("@BirthDate", UpdatedUser.Datum_rodjenja);
                QueryParameters.Add("@Role", UpdatedUser.Stanodavac);
                QueryParameters.Add("@Id", UpdatedUser.Id_Korisnika); // make sure to pass correct ID

                return connection.Execute(UpdateQuery, QueryParameters);
            }
        }

        public int RemoveUser (int UserId) // DELETE
        {
            String DeleteQuery = "DELETE Korisnici WHERE Id_Korisnika = @Id";

            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                return connection.Execute(DeleteQuery, new {Id = UserId});
            }
        }
        public Boolean EmailExists(string email)
        {
            String dBQuery = "SELECT COUNT(*) FROM Korisnici k WHERE k.Email = @Email";
            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                var QueryParameters = new DynamicParameters();

                QueryParameters.Add("@Email", email);

                return ((Int32)connection.ExecuteScalar(dBQuery, QueryParameters) > 0 ? true : false);
            }           
        }

        public string GetPassByEmail(string email)
        {
            String dBQuery = "SELECT Lozinka FROM Korisnici k WHERE k.Email = @Email";
            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                var QueryParameters = new DynamicParameters();

                QueryParameters.Add("@Email", email);

                return (string)connection.ExecuteScalar(dBQuery, QueryParameters);
            }
        }

        public User GetUserByEmail(string email)
        {
            String dBQuery = "SELECT TOP 1 * FROM Korisnici k WHERE k.Email = @Email";
            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                //return (User)connection.ExecuteScalar(dBQuery, new { Email = email });
                return connection.Query<User>(dBQuery, new { Email = email}).First();
            }
        }
       
        public int GetUserCount()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                return connection.ExecuteScalar<int>("SELECT COUNT(*) FROM Korisnici");
            }
        }

        public string GetUserNameById(int userId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                return connection.ExecuteScalar<string>("SELECT Ime+' '+Prezime FROM Korisnici WHERE Id_Korisnika = @Id", new { Id = userId });
            }
        }
    }
}

