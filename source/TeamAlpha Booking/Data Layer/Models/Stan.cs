using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Models
{
    public class Stan
    {
        public int Stan_ID { get; set; }
        public string Mesto { get; set; }
        public string Adresa { get; set; }
        public int Br_soba { get; set; }
        public decimal Kvadratura { get; set; }
        public int Pos_br { get; set; }
        public decimal Cena { get; set; }
        public decimal Depozit { get; set; }
        public int Br_sprata { get; set; }
        public int Id_korisnika { get; set; }

        public Stan() { }

        public Stan(int stan_ID, string mesto, string adresa, int br_soba, decimal kvadratura, int pos_br, decimal cena, decimal depozit, int br_sprata, int id_korisnika)
        {
            Stan_ID = stan_ID;
            Mesto = mesto;
            Adresa = adresa;
            Br_soba = br_soba;
            Kvadratura = kvadratura;
            Pos_br = pos_br;
            Cena = cena;
            Depozit = depozit;
            Br_sprata = br_sprata;
            Id_korisnika = id_korisnika;
        }
    }
}
