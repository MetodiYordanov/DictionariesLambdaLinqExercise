Dictionary<string, double[]> productsWithPrice = new Dictionary<string, double[]>();

string[] product = Console.ReadLine()
                   .Split(' ')
                   .ToArray();

while (product[0] != "buy")
{
    if (!productsWithPrice.ContainsKey(product[0]))
    {
        double productPrice = double.Parse(product[1]);
        double productQuantity = double.Parse(product[2]);

        productsWithPrice[product[0]] = new double[] { productPrice, productQuantity };
    }
    else
    {
        if (productsWithPrice[product[0]][0] != double.Parse(product[1]))
        {
            productsWithPrice[product[0]][0] = double.Parse(product[1]);
        }
        productsWithPrice[product[0]][1] += double.Parse(product[2]);
    }

    product = Console.ReadLine()
                   .Split(' ')
                   .ToArray();
}

foreach (var currentProduct in productsWithPrice)
{
    Console.WriteLine($"{currentProduct.Key} -> {(currentProduct.Value[0] * currentProduct.Value[1]):F2}");
}