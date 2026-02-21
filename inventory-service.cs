
    using System;

public class InventoryService
{
    private string[,] products =
    {
        { "Apples", "Milk", "Bread" },
        { "10", "5", "20" }
    };

    private string[] initialStock = { "10", "5", "20" };

    public string[,] GetProducts()
    {
        return products;
    }

    public void UpdateStock(int index, string quantity)
    {
        products[1, index] = quantity;
    }

    public void ResetInventory()
    {
        for (int i = 0; i < initialStock.Length; i++)
        {
            products[1, i] = initialStock[i];
        }
    }
}
