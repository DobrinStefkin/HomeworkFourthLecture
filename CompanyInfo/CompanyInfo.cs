using System;

class CompanyInfo
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        if (faxNumber=="")
        {
            faxNumber = "(no fax)";
        }
        string webSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        byte age = byte.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Tel. " + phoneNumber);
        Console.WriteLine("Fax: " + faxNumber);
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, age, managerPhone);
    }
}
