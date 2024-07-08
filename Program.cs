namespace Assigment_OOP_2
{
    internal class Program
    {
        static int boxingCount = 0;
        static int unBoxingCount = 0;
        static int CompareByHireDate(Employee employee1 , Employee employee2 )
        {
            boxingCount += 2;

            unBoxingCount += 2;

            int result = employee1.HireDate.Year.CompareTo(employee2.HireDate.Year);

            if (result == 0)
            {
                result = employee1.HireDate.Month.CompareTo(employee2.HireDate.Month);
            }

            if (result == 0)
            {
                result = employee1.HireDate.Day.CompareTo(employee2.HireDate.Day);
            }

            return result;
        }
        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "Alice", SecurityLevel.DBA, 7000, new HiringDate(1, 1, 2020) , 'F');
            EmpArr[1] = new Employee(2, "Bob", SecurityLevel.Guest, 5000, new HiringDate(15, 9, 2021), 'M');
            EmpArr[2] = new Employee(3, "Charlie", SecurityLevel.SecurityOfficer, 9000, new HiringDate(24, 5, 2016), 'M');
            foreach (var employee in EmpArr)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine(EmpArr[0].HireDate.Year.CompareTo(EmpArr[1].HireDate.Year));
            Array.Sort(EmpArr , CompareByHireDate);
            Console.WriteLine();

            foreach (var employee in EmpArr)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
