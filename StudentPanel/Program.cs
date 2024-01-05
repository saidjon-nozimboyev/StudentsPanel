using StudentPanel;

class Program
{
    static void Main()
    {
    place:
        bool isProcess = true;
        while (isProcess)
        {
            Console.WriteLine("Welcome to student panel");
            Console.WriteLine("1.   Register");
            Console.WriteLine("2.   List of students");
            Console.WriteLine("3.   Login");
            Console.WriteLine("4.   Clear");
            Console.WriteLine("5.   Exit");
            Console.Write("Please enter your choice: ");
            byte cmd = byte.Parse(Console.ReadLine());
            switch (cmd)
            {
                case 1:
                    Console.Write("Please enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Please enter surname: ");
                    string surname = Console.ReadLine();
                    Console.Write("Please enter age: ");
                    byte age = byte.Parse(Console.ReadLine());
                    Console.Write("Please enter phone number: ");
                    string number = Console.ReadLine();
                    Console.Write("Please enter password: ");
                    string password = Console.ReadLine();

                    recordStudent.AddStudent(name, surname, age, number, password);
                    break;

                case 2:
                    recordStudent.DisplayStudents();
                    break;

                case 3:
                    Console.Write("Enter number: ");
                    string number_lg = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string password_lg = Console.ReadLine();
                    recordStudent.Login(number_lg, password_lg);
                    break;
                case 4:
                    Console.Clear();
                    goto place;
                case 5:
                    isProcess = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}
