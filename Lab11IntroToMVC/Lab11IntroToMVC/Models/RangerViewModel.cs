using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Lab11IntroToMVC.Models.Person;

namespace Lab11IntroToMVC.Models
{
    public class RangerViewModel
    {
        public int firstYear { get; set; }
        public int lastYear { get; set; }

        public void RangeFinder(int firstYear, int lastYear)
        {
             for (int i = firstYear; i < lastYear; i++)
            {
                 GetPOTY();
            }
          
        }
    }
}
