using System;
using System.Collections.Generic;
using System.Text;

namespace _19_Exceptions
{
    class Cup
    {
        public string Color { get; set; }
        public List<Cup> CupsCollection = new List<Cup>();


        public void AddCup (Cup newCup)
        {
            if(newCup == this)
            {
                throw new SameCupException("Diese Tasse gibt es schon");
            }
            if (Color != "weiss")
            {
                throw new SameCupException("Nus weisse Tassen kommen in den Stapel");
            }
            this.CupsCollection.Add(newCup);                
        }


       
    }
}
