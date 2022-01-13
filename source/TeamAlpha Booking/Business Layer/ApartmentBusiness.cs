using Data_Layer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class ApartmentBusiness : IApartmentBusiness
    {
        private readonly IApartmentRepository apartmentRepository;

        public ApartmentBusiness(IApartmentRepository _apartmentRepository)
        {
            apartmentRepository = _apartmentRepository;
        }

        public List<Apartment> GetAllApartments()
        {
            return apartmentRepository.GetAllApartments();
        }

        public int RemoveApartment(int ApartmentId)
        {
            return apartmentRepository.RemoveApartment(ApartmentId);
        }

        public int UpdateApartment(Apartment apartment)
        {
            return apartmentRepository.UpdateApartmentData(apartment);
        }

        public List<Apartment> GetCurrentUserApartments(int UserId)
        {
            return apartmentRepository.GetAllApartments().Where(apartment =>  apartment.Id_Korisnika == UserId).ToList();
        }

        public int GetApartmentCount()
        {
            return apartmentRepository.GetApartmentCount();
        }
    }
}
