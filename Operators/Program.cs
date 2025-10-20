using System;

namespace EmployeeComparisonApp
{
    // Define the Employee class
    public class Employee
    {
        // Property for Employee ID
        public int Id { get; set; }

        // Property for First Name
        public string FirstName { get; set; }

        // Property for Last Name
        public string LastName { get; set; }

        // Overload the '==' operator to compare Employees by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both references are the same or both null
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            // If either is null, return false
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            {
                return false;
            }

            // Return true if Ids match
            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator (must be done in pair with '==')
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite of ==
            return !(emp1 == emp2);
        }

        // Override Equals to support proper equality comparison
        public override bool Equals(object obj)
        {
            // Return false if object is not an Employee
            if (!(obj is Employee))
                return false;

            // Use the overloaded == operator
            return this == (Employee)obj;
        }

        // Override GetHashCode to maintain consistency with Equals
        public override int GetHashCode()
        {
            // Use the Id's hash code
            return Id.GetHashCode();
        }
    }

    // Main class for the console application
    class Program
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            // Create first Employee object and set its properties
            Employee employee1 = new Employee
            {
                Id = 1,
                FirstName = "Nada",
                LastName = "AlAsali"
            };

            // Create second Employee object with the same Id
            Employee employee2 = new Employee
            {
                Id = 1,
                FirstName = "Nada",
                LastName = "Ahmed"
            };

            // Compare the two Employee objects using the overloaded '==' operator
            if (employee1 == employee2)
            {
                Console.WriteLine("employee1 and employee2 are equal (same Id).");
            }
            else
            {
                Console.WriteLine("employee1 and employee2 are NOT equal (different Ids).");
            }

            // Compare using the '!=' operator
            if (employee1 != employee2)
            {
                Console.WriteLine("employee1 and employee2 are NOT equal (using !=).");
            }
            else
            {
                Console.WriteLine("employee1 and employee2 are equal (using !=).");
            }

            // Keep console open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
