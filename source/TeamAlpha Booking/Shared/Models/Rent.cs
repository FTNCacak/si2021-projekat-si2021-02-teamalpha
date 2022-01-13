using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Rent
    {
        public int Id_Rente { get; set; }
        public DateTime Datum_pocetka { get; set; }
        public int Broj_dana { get; set; }
        public bool Nacin_placanja { get; set; }
        public string Broj_kartice { get; set; }
        public int Id_Korisnika { get; set; }
        public int Id_Stana { get; set; }
        public int Id_Stanodavca { get; set; }

        public Rent() { }

        public Rent(int id_Rente, DateTime datum_pocetka, int broj_dana, bool nacin_placanja, string broj_kartice, int id_Korisnika, int id_Stana, int id_Stanodavca)
        {
            this.Id_Rente = id_Rente;
            this.Datum_pocetka = datum_pocetka;
            this.Broj_dana = broj_dana;
            this.Nacin_placanja = nacin_placanja;
            this.Broj_kartice = broj_kartice;
            this.Id_Korisnika = id_Korisnika;
            this.Id_Stana = id_Stana;
            this.Id_Stanodavca = id_Stanodavca;
        }
    }
}
