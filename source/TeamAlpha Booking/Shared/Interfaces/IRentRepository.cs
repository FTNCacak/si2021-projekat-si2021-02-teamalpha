using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IRentRepository
    {
        int InsertRent(Rent rent);
        List<Rent> GetAllRents();
        int UpdateRentData(Rent rent);
        int RemoveRent(int RentId);
        int GetRentCount();
        decimal CalculateRevenue();
        List<Rent> GetUserRents(int UserID);
        int DeleteRentByApartment(int apt_id);
        int DeleteRentByUserOrLandlord(int user_id);
    }
}
