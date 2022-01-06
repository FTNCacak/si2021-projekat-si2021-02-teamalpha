using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Apartment
    {
        public int Id_Stana { get; set; }
        public string Mesto { get; set; }
        public string Adresa { get; set; }
        public int Broj_soba { get; set; }
        public decimal Kvadratura { get; set; }
        public int Postanski_broj { get; set; }
        public decimal Cena_nocenja { get; set; }
        public decimal Depozit { get; set; }
        public int Broj_sprata { get; set; }
        public int Id_Korisnika { get; set; }

        public Apartment() { }

        public Apartment(int id_Stana, string mesto, string adresa, int broj_soba, decimal kvadratura, int postanski_broj, decimal cena_nocenja, decimal depozit, int broj_sprata, int id_Korisnika)
        {
            this.Id_Stana = id_Stana;
            this.Mesto = mesto;
            this.Adresa = adresa;
            this.Broj_soba = broj_soba;
            this.Kvadratura = kvadratura;
            this.Postanski_broj = postanski_broj;
            this.Cena_nocenja = cena_nocenja;
            this.Depozit = depozit;
            this.Broj_sprata = broj_sprata;
            this.Id_Korisnika = id_Korisnika;
        }
    }
}
