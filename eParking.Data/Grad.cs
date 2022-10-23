using System;
using System.Collections.Generic;
using System.Text;

namespace eParking.Data
{
    public class Grad
    {
        public int GradID { get; set; }
        public string Naziv { get; set; }
        public string Skracenica { get; set; }
        public Drzava Drzava { get; set; }
        public int DrzavaID { get; set; }
    }
}
