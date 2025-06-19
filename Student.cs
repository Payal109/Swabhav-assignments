using System.Runtime.Intrinsics.X86;

namespace StudentGrading
{
    class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public char Grade { get; set; }


        //constrctuors bana yaha
        public Student (string name)
        {  Name = name; 
        }

        public Student (string name, int marks)
        { 
            Name = name;
            Marks = marks;
           
        }

        public Student(string name, int marks, char grade) 
        {
            Name = name;
            Marks = marks;
            Grade = grade;
        } 

        public void AssignGrade()
        {
            if (Marks >= 90)

            {
                Grade = 'A';

            }
            else if (Marks >= 80 && Marks <=89)
            {
                Grade ='B';
            }

            else if (Marks >= 70 && Marks <= 79)
            {
                Grade = 'C';
            }

            else 
            {
                Grade = 'D';
            }
        }
        public void DisplayInfo()
        {
            
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Marks: {Marks}");
                Console.WriteLine($"Grade: {Grade}");
             
        }
        static void Main(string[] args)
        {
            Student s1 = new Student("Payal");
            s1.Marks = 80;
            s1.AssignGrade();
            s1.DisplayInfo();


            Student s2 = new Student("Rohit", 97);
            s2.AssignGrade();
            s2.DisplayInfo();

            Console.WriteLine("enter name");
            string n = Console.ReadLine();
            Console.WriteLine("enter marks");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("enter grade");
            char g =char.Parse(Console.ReadLine());

            Student s3 = new Student(n,m,g);
            s3.DisplayInfo();

        }

        
    }
}
