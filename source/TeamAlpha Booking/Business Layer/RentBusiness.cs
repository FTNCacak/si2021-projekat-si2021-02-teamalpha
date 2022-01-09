using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class RentBusiness
    {
        private readonly IRentRepository rentRepo;

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



    }
}
