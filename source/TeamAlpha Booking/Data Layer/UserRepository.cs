﻿using System;
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
            String InsertQuery = "INSERT INTO Korisnici VALUES(@Password, @FirstName, @LastName,  @Email, @BirthDate, @PhoneNumber, @Role)";

            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlfaDB")))
            {
                var QueryParameters = new DynamicParameters(); // parameterized query to prevent SQL injection

                QueryParameters.Add("@Password", user.Lozinka);
                QueryParameters.Add("@FirstName", user.Ime);
                QueryParameters.Add("@LastName", user.Prezime);
                QueryParameters.Add("@Email", user.Email);
                QueryParameters.Add("@PhoneNumber", user.Br_telefona);
                QueryParameters.Add("@BirthDate", user.Datum_rodjenja);
                QueryParameters.Add("@Role", user.Stanodavac);
                
                return connection.Execute(InsertQuery, QueryParameters); // Execute method provided by Dapper
            }
        }

        public List<Korisnik> GetAllUsers() // READ
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlfaDB")))
            {
                return connection.Query<Korisnik>("SELECT * FROM Korisnici").ToList();
            }
        }

        public int UpdateUserData(Korisnik UpdatedUser) // UPDATE, must pass new user object with updated data
        {
            String UpdateQuery = "UPDATE Korisnici SET Lozinka = @Password, Email = @Email, Ime = @FirstName, Prezime = @LastName, Datum_rodjenja = @BirthDate, Stanodvac = @Role WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlfaDB")))
            {
                var QueryParameters = new DynamicParameters();

                QueryParameters.Add("@Password", UpdatedUser.Lozinka);
                QueryParameters.Add("@FirstName", UpdatedUser.Ime);
                QueryParameters.Add("@LastName", UpdatedUser.Prezime);
                QueryParameters.Add("@Email", UpdatedUser.Email);
                QueryParameters.Add("@PhoneNumber", UpdatedUser.Br_telefona);
                QueryParameters.Add("@BirthDate", UpdatedUser.Datum_rodjenja);
                QueryParameters.Add("@Role", UpdatedUser.Stanodavac);
                QueryParameters.Add("@Id", UpdatedUser.Korisnik_ID); // make sure to pass correct ID

                return connection.Execute(UpdateQuery, QueryParameters);
            }
        }

        public int RemoveUser (int UserId) // DELETE
        {
            String DeleteQuery = "DELETE Korisnici Id_Korisnika = @Id";

            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlfaDB")))
            {
                return connection.Execute(DeleteQuery, new {Id = UserId});
            }
        } 
    }
}
