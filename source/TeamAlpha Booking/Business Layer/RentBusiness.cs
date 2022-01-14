using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class RentBusiness : IRentBusiness
    {
        private readonly IRentRepository rentRepo;

        public RentBusiness(IRentRepository _rentRepo)
        {
            rentRepo = _rentRepo;
        }

        public int InsertRent(Rent rent)
        {
            return rentRepo.InsertRent(rent);
        }

        public List<Rent> GetAllRents()
        {
            return rentRepo.GetAllRents();
        }

        public int UpdateRentData(Rent rent)
        {
            return rentRepo.UpdateRentData(rent);
        }

        public int RemoveRent(int RentId)
        {
            return rentRepo.RemoveRent(RentId);
        }

        public int GetRentCount()
        {
            return rentRepo.GetRentCount();
        }

        public decimal CalculateRevenue()
        {
            return rentRepo.CalculateRevenue();
        }
    }
}
