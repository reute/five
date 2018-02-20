using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace five.Models
{
    public class Order
    {      
        public DateTime Datum { get; set; }  

        public Kategorie Kategorie { get; set; }  

        public string Detail { get; set; }  
      
        public Referent Referent { get; set; }  
       
        public int Menge { get; set; } 
   
        public decimal Einzelpreis { get; set; }        

        public decimal Gesamtpreis { get; set; } 

        //public List<Kategorie> KatList { get; set; } = new List<Kategorie> { Kategorie.Bremsbelag, Kategorie.Kurbel, Kategorie.Schlauch };
    }

    public enum Kategorie
    {
        Schlauch,
        Kette,        
        Bremsbelag,
        Zug,
        Reifen,      
        Kasette,
        Klingel,
        Griffe,
        Licht,
        Birne,
        Kurbel,
        Lenkerband,
        Verschieden
    }

    public enum Referent
    {
        Jr,
        Jc,
        Cf
    }
}

