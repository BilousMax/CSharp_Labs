using System;

public class Company
{
    private string name;
    private int numProducts;
    private double annualSales;
    private double marketShare;

    public Company(string name, int numProducts, double annualSales, double marketShare)
    {
        this.name = name;
        this.numProducts = numProducts;
        this.annualSales = annualSales;
        this.marketShare = marketShare;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int NumProducts
    {
        get { return numProducts; }
        set { numProducts = value; }
    }

    public double AnnualSales
    {
        get { return annualSales; }
        set { annualSales = value; }
    }

    public double MarketShare
    {
        get { return marketShare; }
        set { marketShare = value; }
    }
}

public class Program
{
    public static void Main()
    {
        Company oracle = new Company("Oracle", 1, 2500000000, 31.01);
        Company ibm = new Company("IBM", 3, 2400000000, 29.25);
        Company microsoft = new Company("Microsoft", 2, 1000000000, 13.01);

        Console.WriteLine("{0}: {1} - кiлькiсть продуктiв, ${2} - рiчний об'єм продажу, {3}% - частина ринку", oracle.Name, oracle.NumProducts, oracle.AnnualSales, oracle.MarketShare);
        Console.WriteLine("{0}: {1} - кiлькiсть продуктiв, ${2} - рiчний об'єм продажу, {3}% - частина ринку", ibm.Name, ibm.NumProducts, ibm.AnnualSales, ibm.MarketShare);
        Console.WriteLine("{0}: {1} - кiлькiсть продуктiв, ${2} - рiчний об'єм продажу, {3}% - частина ринку", microsoft.Name, microsoft.NumProducts, microsoft.AnnualSales, microsoft.MarketShare);
    }
}
