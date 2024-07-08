using Demo.Inheritance;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook(3);

            phoneBook.AddPerson(0, "Maha", 123);
            phoneBook.AddPerson(1, "Omar", 456);
            phoneBook.AddPerson(2, "Aya", 789);

            phoneBook.setNumber("Omar", 9999);
            Console.WriteLine(phoneBook.GetNumber("Omar")); ;
            //2
            phoneBook["Omar"] = 123456;
            Console.WriteLine(phoneBook["Omar"]);

            for (int i = 0; i < phoneBook.Size; i++)
            {
                Console.WriteLine(phoneBook[i]);
            }

            //3 

            Car car ;
            car = new Car(10 , "BMW" , 320);
        
            Parent parent = new Parent(1,2);
            Console.WriteLine(parent.Product());
            Console.WriteLine(parent);

            Child child = new Child(1 , 2 , 3);
            Console.WriteLine(child.Product());
            Console.WriteLine(child);
        }
    }
}
