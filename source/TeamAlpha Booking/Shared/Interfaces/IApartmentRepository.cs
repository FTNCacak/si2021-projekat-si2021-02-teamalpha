using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IApartmentRepository
    {
        int InsertApartment(Apartment apartment);
        List<Apartment> GetAllApartments();
        int UpdateApartmentData(Apartment apartment);
        int RemoveApartment(int ApartmentId);
        int GetApartmentCount();
    }
}
