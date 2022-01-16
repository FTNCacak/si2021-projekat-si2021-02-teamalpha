using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IApartmentBusiness
    {
        int GetApartmentCount();
        List<Apartment> GetAllApartments();
        int RemoveApartment(int ApartmentId);
        int UpdateApartment(Apartment apartment);
        List<Apartment> GetCurrentUserApartments(int UserId);
        Apartment GetApartmentByID(int ApartmentId);
        int InsertApartment(Apartment apartment);
        int RemoveApartmentByUser(int user_id);

    }
}
