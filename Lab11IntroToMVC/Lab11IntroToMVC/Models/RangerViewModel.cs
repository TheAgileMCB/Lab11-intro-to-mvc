using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Lab11IntroToMVC.Models.Person;

namespace Lab11IntroToMVC.Models
{
    public class RangerViewModel : IEnumerable
    {
        public int firstYear { get; set; }
        public int lastYear { get; set; }
        int count;
        T items;

        public void RangeFinder(int firstYear, int lastYear)
        {
             for (int i = firstYear; i < lastYear; i++)
            {
                 GetPOTY();
            }
          
        }

        public IEnumerator<Person> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return person[i];
            }
        }

        // Non-generic, just do this because we have to
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

   
}
