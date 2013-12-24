using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Ajax.WCF.RandomPresent
{
    [ServiceBehavior(Namespace = "http://schemas.ajax/randompresentservice")]
    public class RandomPresentService : IRandomPresentService
    {
        public RandomPresentService()
        {
        }

        public string ObtainPresent()
        {
            string[] presents = { "Moro bar", "Football", "Cabbage", "Drill press" };

            Random r = new Random();
            return presents[r.Next(presents.Length)];
        }
    }
}
