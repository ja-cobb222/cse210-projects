using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;
    private const decimal USA_SHIPPING_COST = 5.00m;
    private const decimal INTERNATIONAL_SHIPPING_COST = 35.00m;

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.TotalCost();
        }
        totalCost += customer.IsInUSA() ? USA_SHIPPING_COST : INTERNATIONAL_SHIPPING_COST;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var product in products)
        {
            sb.AppendLine($"Name: {product.Name}, Product ID: {product.ProductId}");
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Name: {customer.Name}\nAddress:\n{customer.Address}";
    }
}
