using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziescherper_10.classes
{
    public class student
    {
        public string Naam { get; set; }

        public student(string naam)
        {
            Naam = naam;
        }
        static student ZoekStudent(student[] array, string naam)
        {
            student gevonden = null;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Naam == naam)
                    gevonden = array[i];
            }

            return gevonden;
        }
    }
}
