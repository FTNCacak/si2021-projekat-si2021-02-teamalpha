using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Data_Layer;
using Data_Layer.Models;

namespace Data_Layer
{
    public class ApartmentRepository
    {
        public int InsertApartment(Stan apartment) // CREATE
        {
            String InsertQuery = "INSERT INTO Stanovi VALUES(@City, @Address, @NoRooms,  @Size, @PostNumber, @PricePerNight, @Deposit, @FloorNo, @LandlordId)";

            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                var QueryParameters = new DynamicParameters(); // parameterized query to prevent SQL injection

                QueryParameters.Add("@City", apartment.Mesto);
                QueryParameters.Add("@Address", apartment.Adresa);
                QueryParameters.Add("@NoRooms", apartment.Br_soba);
                QueryParameters.Add("@Size", apartment.Kvadratura);
                QueryParameters.Add("@PostNumber", apartment.Pos_br);
                QueryParameters.Add("@PricePerNight", apartment.Cena);
                QueryParameters.Add("@Deposit", apartment.Depozit);
                QueryParameters.Add("@FloorNo", apartment.Br_sprata);
                QueryParameters.Add("@LandlordId", apartment.Id_korisnika);

                return connection.Execute(InsertQuery, QueryParameters); // Execute method provided by Dapper
            }
        }

        public List<Stan> GetAllApartments() // READ
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                return connection.Query<Stan>("SELECT * FROM Stanovi").ToList();
            }
        }

        public int UpdateApartmentData(Stan apartment) // UPDATE, must pass new apartment object with updated data
        {
            String UpdateQuery = "UPDATE Stanovi SET " +
                "Id_Stana = @ApartmentId," +
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

                QueryParameters.Add("@ApartmentId", apartment.Stan_ID);
                QueryParameters.Add("@City", apartment.Mesto);
                QueryParameters.Add("@Address", apartment.Adresa);
                QueryParameters.Add("@NoRooms", apartment.Br_soba);
                QueryParameters.Add("@Size", apartment.Kvadratura);
                QueryParameters.Add("@PostNumber", apartment.Pos_br);
                QueryParameters.Add("@PricePerNight", apartment.Cena);
                QueryParameters.Add("@Deposit", apartment.Depozit);
                QueryParameters.Add("@FloorNo", apartment.Br_sprata);
                QueryParameters.Add("@LandlordId", apartment.Id_korisnika);

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
    }
}
