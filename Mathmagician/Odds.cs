﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Odds
    {
        public List<int> ListOdds(int input)
        {
            
            List<int> _listOdds = new List<int>();
            int i = 0; //limit based on input value
            int j = 0; //new integer for odd values
            
            while (i < input)
            {
                
                if (j % 2 == 1)
                {
                    _listOdds.Add(j);
                    i++;
                }
                j++;    
               
            }

            return _listOdds;
            
         //   throw new NotImplementedException();
       }

    }
}
