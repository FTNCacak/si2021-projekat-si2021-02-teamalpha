using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Shared.Interfaces;
using Shared.Models;

namespace Data_Layer
{
    public class ApartmentRepository : IApartmentRepository
    {
        public int InsertApartment(Apartment apartment) // CREATE
        {
            String InsertQuery = "INSERT INTO Stanovi VALUES(@City, @Address, @NoRooms,  @Size, @PostNumber, @PricePerNight, @Deposit, @FloorNo, @LandlordId)";

            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                var QueryParameters = new DynamicParameters(); // parameterized query to prevent SQL injection

                QueryParameters.Add("@City", apartment.Mesto);
                QueryParameters.Add("@Address", apartment.Adresa);
                QueryParameters.Add("@NoRooms", apartment.Broj_soba);
                QueryParameters.Add("@Size", apartment.Kvadratura);
                QueryParameters.Add("@PostNumber", apartment.Postanski_broj);
                QueryParameters.Add("@PricePerNight", apartment.Cena_nocenja);
                QueryParameters.Add("@Deposit", apartment.Depozit);
                QueryParameters.Add("@FloorNo", apartment.Broj_sprata);
                QueryParameters.Add("@LandlordId", apartment.Id_Korisnika);

                return connection.Execute(InsertQuery, QueryParameters); // Execute method provided by Dapper
            }
        }

        public List<Apartment> GetAllApartments() // READ
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                return connection.Query<Apartment>("SELECT * FROM Stanovi").ToList();
            }
        }

        public int UpdateApartmentData(Apartment apartment) // UPDATE, must pass new apartment object with updated data
        {
            String UpdateQuery = "UPDATE Stanovi SET " +
                "Mesto = @City," +
                "Adresa = @Address," +
                "Broj_soba = @NoRooms," +
                "Kvadratura = @Size," +
                "Postanski_broj = @PostNumber," +
                "Cena_nocenja = @PricePerNight," +
                "Depozit = @Deposit," +
                "Broj_sprata = @FloorNo," +
                "Id_Korisnika = @LandlordId" +
                " WHERE Id_Stana = @ApartmentId";

            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                var QueryParameters = new DynamicParameters();

                QueryParameters.Add("@ApartmentId", apartment.Id_Stana);
                QueryParameters.Add("@City", apartment.Mesto);
                QueryParameters.Add("@Address", apartment.Adresa);
                QueryParameters.Add("@NoRooms", apartment.Broj_soba);
                QueryParameters.Add("@Size", apartment.Kvadratura);
                QueryParameters.Add("@PostNumber", apartment.Postanski_broj);
                QueryParameters.Add("@PricePerNight", apartment.Cena_nocenja);
                QueryParameters.Add("@Deposit", apartment.Depozit);
                QueryParameters.Add("@FloorNo", apartment.Broj_sprata);
                QueryParameters.Add("@LandlordId", apartment.Id_Korisnika); // make sure to pass correct id

                return connection.Execute(UpdateQuery, QueryParameters);
            }
        }

        public int RemoveApartment(int ApartmentId) // DELETE
        {
            String DeleteQuery = "DELETE Stanovi WHERE Id_Stana = @Id";

            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                return connection.Execute(DeleteQuery, new {Id = ApartmentId});
            }
        }

        public int GetApartmentCount()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                return connection.ExecuteScalar<int>("SELECT COUNT(*) FROM Stanovi");
            }
        }

        public Apartment GetApartmentByID(int ApartmentId)
        {
            String dBQuery = "SELECT TOP 1 * FROM Stanovi s WHERE s.Id_Stana = @Id";
            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                return connection.Query<Apartment>(dBQuery, new { Id = ApartmentId }).First();
            }
        }

        public int RemoveApartmentByUser(int user_id)
        {
            String dBQuery = "DELETE FROM Stanovi WHERE Id_Korisnika = @Id";
            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                return connection.ExecuteScalar<int>(dBQuery, new { Id = user_id });
            }
        }
    }
}
