using System;
using System.Collections.Generic;
using System.Text;

namespace _19_Exceptions
{
    class Owner
    {
        List<Cup> myCups = new List<Cup>();


        public void AddCups (Cup newCup)
        {
            if (true)
            {
                if (myCups.Contains(newCup))
                {
                    throw new SameCupException("Diese Tasse gibt es schon");
                }
            }
            myCups.Add(newCup);
        }



    }
}
