using System;
using System.Collections.Generic;

public class Order {
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;

        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        double shippingCost = customer.IsInUSA() ? 5.0 : 35.0;
        totalCost += shippingCost;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label: ";

        foreach (var product in products)
        {
            packingLabel += $"{product.GetProductDetails()} ";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label: {customer.GetCustomerDetails()}";
    }
}