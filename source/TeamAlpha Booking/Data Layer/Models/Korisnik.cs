using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Models
{
    public  class Korisnik
    {
        public int Korisnik_ID { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public DateTime Datum_rodjenja { get; set; }
        public string Br_telefona { get; set; }
        public Boolean Stanodavac { get; set; }

        public Korisnik() { }

        public Korisnik(int korisnik_ID, string lozinka, string ime, string prezime, string email, DateTime datum_rodjenja, string br_telefona, bool stanodavac)
        {
            Korisnik_ID = korisnik_ID;
            Lozinka = lozinka;
            Ime = ime;
            Prezime = prezime;
            Email = email;
            Datum_rodjenja = datum_rodjenja;
            Br_telefona = br_telefona;
            Stanodavac = stanodavac;
        }
    }

    
}
