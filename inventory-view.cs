using System;

public class InventoryView
{
    private InventoryService service = new InventoryService();

    public void Run()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. View Inventory");
            Console.WriteLine("2. Update Stock");
            Console.WriteLine("3. Reset Inventory");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                DisplayInventory();
            }
            else if (choice == "2")
            {
                UpdateStock();
            }
            else if (choice == "3")
            {
                service.ResetInventory();
                Console.WriteLine("Inventory reset.");
            }
            else if (choice == "4")
            {
                running = false;
            }

            Console.WriteLine();
        }
    }

    private void DisplayInventory()
    {
        var products = service.GetProducts();

        Console.WriteLine("Inventory:");
        for (int i = 0; i < products.GetLength(1); i++)
        {
            Console.WriteLine((i + 1) + ". " + products[0, i] + " - Stock: " + products[1, i]);
        }
    }

    private void UpdateStock()
    {
        var products = service.GetProducts();

        DisplayInventory();
        Console.Write("Select product number: ");
        int index = Convert.ToInt32(Console.ReadLine()) - 1;

        if (index >= 0 && index < products.GetLength(1))
        {
            Console.Write("Enter new stock: ");
            string qty = Console.ReadLine();
            service.UpdateStock(index, qty);
            Console.WriteLine("Stock updated.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
}
