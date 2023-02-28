using Class_122_Midterm;

internal static class MainWindowHelpers
{

    public static string DisplayInformationToRun(Product product)
    {
        string formattedString = $"" +
            $"Product Name: {product.Name}\n" +
            $"Sku: {product.Sku}\n";

        if (product.inStock)
        {
            formattedString += $"This product is in stock";

        }
        else
        {


            formattedString += $"This product is out of stock";
        }

        return formattedString;
    }
}