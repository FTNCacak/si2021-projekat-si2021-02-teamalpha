using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Models
{
    public class Renta
    {
        public int Korisnik_Id { get; set; }
        public int Stan_Id { get; set; }
        public int Id_korisnika { get; set; }
        public DateTime Dat_pocetka { get; set; }
        public Boolean Nacin_placanja { get; set; }
        public string Br_kartice { get; set; }

        public Renta() { }

        public Renta(int korisnik_Id, int stan_Id, int id_korisnika, DateTime dat_pocetka, bool nacin_placanja, string br_kartice)
        {
            Korisnik_Id = korisnik_Id;
            Stan_Id = stan_Id;
            Id_korisnika = id_korisnika;
            Dat_pocetka = dat_pocetka;
            Nacin_placanja = nacin_placanja;
            Br_kartice = br_kartice;
        }
    }
}
