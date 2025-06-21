namespace InheritanceExample
{
    public class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }

        public void Displaydetails()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Gender : {Gender}");
        }
        

        
    }

    public class Student : Person
    { 
        //student is a person having name age gender and also has
     //student specific properties like follows:

        public int StudentId { get; set; }
        public string Course { get; set; }

        public void DisplayStudentDetails()
        {
            base.Displaydetails();
            Console.WriteLine($"Student ID : {StudentId}");
            Console.WriteLine($"Course : {Course}");
        }
    
    
    
    }

    public class Faculty : Person
    { 
        public int EmpId {  get; set; }
        public string Subject {  get; set; }

        public void DisplayFacultyDetails()
        {

            base.Displaydetails();
            Console.WriteLine($"Employee ID : {EmpId}");
            Console.WriteLine($"Subject : {Subject}");

        }
    
    
    
    }

    class Program
    {
        static void Main(string[] args)
        { 
            Student studentobj = new Student();
            studentobj.Name = "Payal";
            studentobj.Age = 22;
            studentobj.StudentId = 1;
            studentobj.Gender = 'F';
            studentobj.Course = "CS";

            Console.WriteLine("--student detailss--");
           
            studentobj.DisplayStudentDetails();
           
            //create a faculty object and set its values

            Faculty facultyobj = new Faculty();
            facultyobj.Name = "rohit";
            facultyobj.Age = 32;
            facultyobj.EmpId = 22;
            facultyobj.Gender = 'M';
            facultyobj.Subject = "maths";

            Console.WriteLine("---faculty details ---");
            facultyobj.DisplayFacultyDetails();

        }
    
    }
}
