using System;

namespace EmployeeInterfaceApp
{
    // Define the IQuittable interface
    public interface IQuittable
    {
        // Declare a method called Quit with no return value
        void Quit();
    }

    // Define the Employee class which implements the IQuittable interface
    public class Employee : IQuittable
    {
        // Property for Employee ID
        public int Id { get; set; }

        // Property for First Name
        public string FirstName { get; set; }

        // Property for Last Name
        public string LastName { get; set; }

        // Implement the Quit method from IQuittable interface
        public void Quit()
        {
            // Output a message to indicate the employee has quit
            Console.WriteLine($"{FirstName} {LastName} has quit the job. (Employee ID: {Id})");
        }

        // Overload the '==' operator to compare Employees by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, emp2))
                return true;

            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals method to match the overloaded '=='
        public override bool Equals(object obj)
        {
            if (!(obj is Employee))
                return false;

            return this == (Employee)obj;
        }

        // Override GetHashCode to support Equals override
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    // Main Program class
    class Program
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            // Create an instance of Employee
            Employee employee1 = new Employee
            {
                Id = 101,
                FirstName = "Nada",
                LastName = "AlAsali"
            };

            // Use polymorphism to create an IQuittable object from Employee
            IQuittable quittableEmployee = employee1;

            // Call the Quit() method using the IQuittable reference
            quittableEmployee.Quit();

            // Keep the console open until a key is pressed
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
