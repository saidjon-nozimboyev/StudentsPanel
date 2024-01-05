namespace StudentPanel
{
    internal class cntId
    {
        public int id = 0;

        public void plusID()
        {
            this.id++;
        }
    }

    internal class Student
    {
        public string name;
        public string surname;
        public byte age;
        public string number;
        public string password;

        public Student(string name, string surname, byte age, string number, string password)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.number = number;
            this.password = password;
        }
    }

    internal class recordStudent
    {
        private static cntId cntId = new cntId();
        private static List<Student> studentList = new List<Student>();

        public static void AddStudent(string name, string surname, byte age, string number, string password)
        {
            cntId.plusID();
            int num = cntId.id;

            Student newStudent = new Student(name, surname, age, number, password);
            studentList.Add(newStudent);

            Console.WriteLine($"Student {num} added successfully.");
        }

        public static void DisplayStudents()
        {
            Console.WriteLine("List of Students:");
            Console.WriteLine("| {0,-15} | {1,-15} | {2,-5} | {3,-15} |", "Name", "Surname", "Age", "Number");

            foreach (var student in studentList)
            {
                Console.WriteLine("| {0,-15} | {1,-15} | {2,-5} | {3,-15} |", student.name, student.surname, student.age, student.number);
            }
            Console.Write("Please press any button to continue ");
            Console.ReadKey();
        }

        public static void Login(string inputNumber, string inputPassword)
        {
            var matchingStudent = studentList.Find(student => student.number == inputNumber && student.password == inputPassword);

            if (matchingStudent != null)
            {
                Console.WriteLine("Login successful.");
            }
            else
            {
                Console.WriteLine("Error: Invalid number or password.");
            }
        }
    }
}
