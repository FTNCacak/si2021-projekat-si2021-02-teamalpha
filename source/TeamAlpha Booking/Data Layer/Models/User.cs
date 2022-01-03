using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Models
{
    public  class User
    {
        public int Id_Korisnika { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public DateTime Datum_rodjenja { get; set; }
        public string Broj_telefona { get; set; }
        public Boolean Stanodavac { get; set; }

        public User() { }

        public User(int id_Korisnika, string lozinka, string ime, string prezime, string email, DateTime datum_rodjenja, string broj_telefona, bool stanodavac)
        {
            this.Id_Korisnika = id_Korisnika;
            this.Lozinka = lozinka;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.Datum_rodjenja = datum_rodjenja;
            this.Broj_telefona = broj_telefona;
            this.Stanodavac = stanodavac;
        }
    }

    
}
