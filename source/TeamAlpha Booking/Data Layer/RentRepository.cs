using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Dapper;
using System.Data.SqlClient;
using Shared.Interfaces;

namespace Data_Layer
{
    public class RentRepository : IRentRepository
    {
        public int InsertRent(Rent rent) // CREATE
        {
            String InsertQuery = "INSERT INTO Rente VALUES(@StartDate, @TotalDays, @PaymentMethod, @CardNo, @UserID, @ApartmentID, @LandlordID)";

            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                var QueryParameters = new DynamicParameters(); // parameterized query to prevent SQL injection

                QueryParameters.Add("@StartDate", rent.Datum_pocetka);
                QueryParameters.Add("@TotalDays", rent.Broj_dana);
                QueryParameters.Add("@PaymentMethod", rent.Nacin_placanja);
                QueryParameters.Add("@CardNo", rent.Broj_kartice);
                QueryParameters.Add("@UserID", rent.Id_Korisnika);
                QueryParameters.Add("@ApartmentID", rent.Id_Stana);
                QueryParameters.Add("@LandlordID", rent.Id_Stanodavca);

                return connection.Execute(InsertQuery, QueryParameters); // Execute method provided by Dapper
            }
        }

        public List<Rent> GetAllRents() // READ
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                return connection.Query<Rent>("SELECT * FROM Rente").ToList();
            }
        }

        public int UpdateRentData(Rent rent) // UPDATE, must pass new apartment object with updated data
        {
            String UpdateQuery = "UPDATE Rente SET " +
                "Datum_pocetka = @StartDate," +
                "Broj_dana = @TotalDays," +
                "Nacin_placanja = @PaymentMethod," +
                "Broj_kartice = @CardNo," +
                "Id_Korisnika = @UserID," +
                "Id_Stana = @ApartmentID," +
                "Id_Stanodavca = @LandlordID," +
                " WHERE Id_Rente = @RentID";

            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                var QueryParameters = new DynamicParameters();

                QueryParameters.Add("@StartDate", rent.Datum_pocetka);
                QueryParameters.Add("@TotalDays", rent.Broj_dana);
                QueryParameters.Add("@PaymentMethod", rent.Nacin_placanja);
                QueryParameters.Add("@CardNo", rent.Broj_kartice);
                QueryParameters.Add("@UserID", rent.Id_Korisnika);
                QueryParameters.Add("@ApartmentID", rent.Id_Stana);
                QueryParameters.Add("@LandlordID", rent.Id_Stanodavca);

                QueryParameters.Add("@RentID", rent.Id_Rente);

                return connection.Execute(UpdateQuery, QueryParameters);
            }
        }

        public int RemoveRent(int RentId) // DELETE
        {
            String DeleteQuery = "DELETE Rente WHERE Id_Rente = @Id";

            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                return connection.Execute(DeleteQuery, new { Id = RentId });
            }
        }

        public int GetRentCount()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                return connection.ExecuteScalar<int>("SELECT COUNT(*) FROM Rente");
            }
        }

        public decimal CalculateRevenue()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                return connection.ExecuteScalar<Decimal>("SELECT SUM(Rente.Broj_dana*Stanovi.Cena_nocenja) FROM Rente JOIN Stanovi ON Rente.Id_Stana=Stanovi.Id_Stana");
            }
        }

        public List<Rent> GetUserRents(int UserID)
        {
            String dBQuery = "SELECT * FROM Rente r WHERE r.Id_Korisnika = @Id";
            using (SqlConnection connection = new SqlConnection(ConnectionStringProvider.GetConnectionString("AlphaBookingDB")))
            {
                return connection.Query<Rent>(dBQuery, new { Id = UserID }).ToList();
            }
        }
    }
}
