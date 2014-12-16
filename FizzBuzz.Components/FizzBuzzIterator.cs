using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzBuzz.Components.Entities;

namespace FizzBuzz.Components
{
    public class FizzBuzzIterator
    {
        public static string IterateLoop(List<Combination> combinations)
        {
            if(combinations == null || combinations.Count < 1) throw new ArgumentNullException("combinations");
            if (combinations.Select(x => x.Divisor < 0).FirstOrDefault()) throw new ArgumentOutOfRangeException("combinations");

            var sb = new StringBuilder();            

            for (var i = 1; i <= 100; i++)
            {                
                var combo = combinations.Where(c => i%c.Divisor == 0).ToList();                
                if (combo.Any())
                    sb.AppendFormat("{0} - {1}",i,string.Join("", combo.Select(x => x.Text)));
                else
                    sb.AppendFormat("{0}", i);

                sb.AppendLine();
            }            

            return sb.ToString();
        }
    }
}
