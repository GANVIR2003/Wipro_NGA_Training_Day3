// See https://aka.ms/new-console-template for more information
public partial class Program
{
    public static void Main(string[] args)
    {

        Wipro_NGA_Training_Day3.BankAudit.CorporateAccount corpAcct = new Wipro_NGA_Training_Day3.BankAudit.CorporateAccount("Chinni890", "345", 45690m, 8.98m, "MGR");

        corpAcct.Deposit(45690);
        corpAcct.ApplyCorporateInterest();
        Console.WriteLine("Corporate Account interest applied successfully");

    }
}
