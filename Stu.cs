namespace StudentEncapApp
{
    internal class Student
    {
        private string name;
        //validation for string name
        public string Name
        {
            get
            { return name; }
            set
            {
                if (value.Length > 5)
                    name = value;
                else
                    name = " ";
            }
        }

        //validation for cgpa
        private double cgpa;

        public double CGPA
        {
            get { return cgpa; }
            set
            {
                if (value >= 1 && value <= 10)
                    cgpa = value;
                else
                    cgpa = 0;
            }
        }

        // validation for roll number

        private int rollno;

        public int Rollno 
        { get
            { return rollno;
            }
            set { if (value >= 1)
                    rollno = value;
                if (value <= 0)
                    throw new ArgumentException("roll number should be positive");
            }
        }

        public double PercentageDisplay()
        {
            double per = this.cgpa * 9.5;
            return per;

        }
        static void Main(string[] args)
        {
           
            Student s1 = new Student();
            s1.Name = "Payal"
;           s1.CGPA = 8.5;
            s1.Rollno = 1;
            Console.WriteLine($"student 1 name: {s1.Name}");
            Console.WriteLine($"student 1 cgpa: {s1.CGPA}");
            Console.WriteLine($"student 1 roll no: {s1.Rollno}");
            Console.WriteLine($"student 1  percentage: {s1.PercentageDisplay()}");

            Console.WriteLine();

            Student s2 = new Student();
            s2.Name = "Alok";
            s2.CGPA = 3.5;
            s2.Rollno = 11 ;
            Console.WriteLine($"student 2 name: {s2.Name}");
            Console.WriteLine($"student 2 cgpa: {s2.CGPA}");
            Console.WriteLine($"student 2 roll no: {s2.Rollno}");
            Console.WriteLine($"student 2  percentage: {s2.PercentageDisplay()}");





        }
    }
}
