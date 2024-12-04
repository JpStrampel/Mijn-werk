using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace ziescherper_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opdracht10_1();
            //Opdracht10_2();
            //Opdracht10_3();
            
        }

        private static void Opdracht10_3()
        {
            // Create mama and pappa objects
            Mens mama = new Mens { Geslacht = Geslachten.Vrouw, MaxLengte = 175 };
            Mens pappa = new Mens { Geslacht = Geslachten.Man, MaxLengte = 186 };

            // Create a baby object using the PlantVoort method
            Mens baby = mama.PlantVoort(pappa);

            // Print the result
            Console.WriteLine($"Baby gemaakt met Geslacht {baby.Geslacht} en MaxLengte {baby.MaxLengte}");

            // Maak een array van type Student met een grootte van 3
            Student[] students = new Student[3];

            // Initialiseer de array met Student objecten
            students[0] = new Student("Alice");
            students[1] = new Student("Bob");
            students[2] = new Student("Charlie");

            var tof = Student.FindStudentByName(students, students[1].Naam);

            if (tof == null)
            {
                Console.WriteLine("Naam niet gevonden");
            }
            else
            {
                Console.WriteLine(tof.Naam);
            }

            var tof2 = Student.FindStudentByName(students, "Ali");

            if (tof2 == null)
            {
                Console.WriteLine("Naam niet gevonden");
            }
            else
            {
                Console.WriteLine(tof2.Naam);
            }
        }

        private static void VerhoogParameter(int parameter)
        {
            parameter++;
            Console.WriteLine("Parameter in methode: " + parameter);
        }

        private static void Opdracht10_1()
        {
            int waarde = 5;
            Console.WriteLine("Parameter voor methode aanroep: " + waarde);
            VerhoogParameter(waarde);
            Console.WriteLine("Parameter na methode aanroep: " + waarde);

            Student studentA = new Student("Abba");
            Student studentB = new Student("Queen");

            Console.WriteLine("Naam student a: " + studentA.Naam);
            Console.WriteLine("Naam student b: " + studentB.Naam);

            // Toewijzing zodat beide naar hetzelfde object verwijzen
            studentB = studentA;

            Console.WriteLine("Naam student a: " + studentA.Naam);
            Console.WriteLine("Naam student b: " + studentB.Naam);
        }

        private static void Opdracht10_2()
        {
            Student stud1 = null;

            if (stud1 != null)
            {
                Console.WriteLine(stud1.Naam);
            }
            else
            {
                Console.WriteLine("Oei. Object bestaat niet.");
            }

            // Maak een array van Student objecten
            Student[] students = new Student[]
            {
                new Student("Abba"),
                new Student("Queen"),
                new Student("David")
            };

            // Zoek naar een bestaande student
            string searchName1 = "Abba";
            Student foundStudent1 = Student.FindStudentByName(students, searchName1);
            Console.WriteLine(foundStudent1 != null
                ? $"Naam: {foundStudent1.Naam}"
                : $"Naam {searchName1} niet gevonden.");

            // Zoek naar een niet-bestaande student
            string searchName2 = "John";
            Student foundStudent2 = Student.FindStudentByName(students, searchName2);
            Console.WriteLine(foundStudent2 != null
                ? $"Naam: {foundStudent2.Naam}"
                : $"Naam {searchName2} niet gevonden.");
        }
    }

    public class Student
    {
        public string Naam { get; set; }

        public Student(string naam)
        {
            Naam = naam;
        }

        public static Student FindStudentByName(Student[] students, string searchName)
        {
            foreach (Student student in students)
            {
                if (student.Naam.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    return student;
                }
            }
            return null;
        }
    }

    public class Meting
    {
        public int Temperatuur { get; set; }
        public string OpgemetenDoor { get; set; }

        public void ToonMetingInKleur()
        {
            Console.WriteLine($"Temperatuur: {Temperatuur}, Opgemeten door: {OpgemetenDoor}");
        }

        public void VoegMetingToeEnVerwijder(ref Meting meting)
        {
            this.Temperatuur += meting.Temperatuur;
            this.OpgemetenDoor = meting.OpgemetenDoor;
            meting = null;
        }

        public Meting GenereerRandomMeting()
        {
            Random rand = new Random();
            return new Meting
            {
                Temperatuur = rand.Next(-10, 40),
                OpgemetenDoor = "Random Person"
            };
        }
    }

    public class Mens
    {
        public Geslachten Geslacht { get; set; }
        public int MaxLengte { get; set; }

        //internal mens Praat ""

        public static int  hoi()
        {
           Console.WriteLine ("hoi");
            return 34;
        }

        public static void Hallo ()
        {
            Console.WriteLine("Hallo");
        }



        private static Meting Meten(Meting meetlint)
        {
            Meting meting = new Meting();
            return meting;
        }

        public Mens PlantVoort(Mens partner, string dag="zaterdag" , Mens stalker=null)
        {
            Random random = new Random();
            Geslachten babyGeslacht = (Geslachten)random.Next(2); // Randomly assigns 0 (Man) or 1 (Vrouw)
            int babyMaxLengte = (this.MaxLengte + partner.MaxLengte) / 2;

            Mens klaas = new Mens { Geslacht = babyGeslacht, MaxLengte = babyMaxLengte };
        return klaas;
            
            Meting Meting = new Meting();

        }

    }

    public enum Geslachten
    {
        Man,
        Vrouw
    }
}
