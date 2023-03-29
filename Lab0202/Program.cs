using System;

public class Company
{
    private static int numCompanies = 0;

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

        numCompanies++;
    }

    public static int NumCompanies
    {
        get { return numCompanies; }
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
public class CompanyArray
{
    private Company[] companies;
    private int count;
    public CompanyArray(int size)
    {
        companies = new Company[size];
        count = 0;
    }

    public void AddCompany(Company company)
    {
        companies[count] = company;
        count++;
    }

    public void PrintCompanies()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("{0}: {1} - кiлькiсть продуктiв, ${2} - рiчний об'єм продажу, {3}% - частина ринку", companies[i].Name, companies[i].NumProducts, companies[i].AnnualSales, companies[i].MarketShare);
        }
    }
    public Company FindCompanyWithMinMarketShare()
    {

        Company minMarketShareCompany = companies[0];

        for (int i = 1; i < count; i++)
        {
            if (companies[i].MarketShare < minMarketShareCompany.MarketShare)
            {
                minMarketShareCompany = companies[i];
            }
        }

        return minMarketShareCompany;
    }
}
public class Program
{
        public static void Main()
    {
        CompanyArray companyArray = new CompanyArray(3);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Введiть назву компанiї:");
            string name = Console.ReadLine();

            Console.WriteLine("Введiть кiлькiсть продуктiв:");
            int numProducts = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть рiчний об'єм продажу:");
            double annualSales = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть частину ринку:");
            double marketShare = double.Parse(Console.ReadLine());

            Company company = new Company(name, numProducts, annualSales, marketShare);
            companyArray.AddCompany(company);
        }

        companyArray.PrintCompanies();

        Company oracle = new Company("Oracle", 1, 2500000000, 31.01);
        Company ibm = new Company("IBM", 3, 2400000000, 29.25);
        Company microsoft = new Company("Microsoft", 2, 1000000000, 13.01);

        Console.WriteLine("{0}: {1} - кiлькiсть продуктiв, ${2} - рiчний об'єм продажу, {3}% - частина ринку", oracle.Name, oracle.NumProducts, oracle.AnnualSales, oracle.MarketShare);
        Console.WriteLine("{0}: {1} - кiлькiсть продуктiв, ${2} - рiчний об'єм продажу, {3}% - частина ринку", ibm.Name, ibm.NumProducts, ibm.AnnualSales, ibm.MarketShare);
        Console.WriteLine("{0}: {1} - кiлькiсть продуктiв, ${2} - рiчний об'єм продажу, {3}% - частина ринку", microsoft.Name, microsoft.NumProducts, microsoft.AnnualSales, microsoft.MarketShare);
        
        Console.WriteLine("Кiлькiсть створених компанiй: {0}", Company.NumCompanies);

        Company companyWithMinMarketShare = companyArray.FindCompanyWithMinMarketShare();
        Console.WriteLine("Компанія з мінімальною часткою ринку: {0}: {1}% - частка ринку", companyWithMinMarketShare.Name, companyWithMinMarketShare.MarketShare);

        if (Company.NumCompanies<7)
        {
            Console.WriteLine("Кiлькiсть компанiй не перевищує граничне значення");
                }
        else if (Company.NumCompanies>6)
        {
            Console.WriteLine("Кiлькiсть компанiй перевищує граничне значення");
                }
    }
}



