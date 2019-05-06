using System;

namespace ObjectOrientedProgram1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("InventoryManagement_Program");

                Console.WriteLine("Enter your choice");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InventoryManagement.InventoryManagerClass inventory = new InventoryManagement.InventoryManagerClass();
                        inventory.ManagerFunction();
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
