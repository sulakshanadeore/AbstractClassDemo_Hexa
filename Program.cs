using OOPsContinuedAbstractDemo;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Employee employee;
        //Developer d=new Developer();
        //Console.WriteLine("Enter your name");
        //d.EmpName = Console.ReadLine();

        //Console.WriteLine("Enter desigantion");
        //d.Designation = Console.ReadLine();

        //d.CalculateSalary(10000);

        //Console.WriteLine("Your empid= " + d.Empid);
        //Console.WriteLine("Your Salary=" + d.TotalSalary);

        //Developer d1=new Developer();
        //Console.WriteLine("Enter name");
        //d1.EmpName = Console.ReadLine();
        //Console.WriteLine("Enter desigantion");
        //d1.Designation = Console.ReadLine();

        //d1.CalculateSalary(10000);

        //Console.WriteLine("Your empid= " + d1.Empid);
        //Console.WriteLine("Your Salary=" + d1.TotalSalary);


        //Developer d2 = new Developer();
        //Console.WriteLine("Enter name");
        //d2.EmpName = Console.ReadLine();
        //Console.WriteLine("Enter desigantion");
        //d2.Designation = Console.ReadLine();

        //d2.CalculateSalary(10000);

        //Console.WriteLine("Your empid= " + d2.Empid);
        //Console.WriteLine("Your Salary=" + d2.TotalSalary);

        //TechLead lead=new TechLead();
        //Console.WriteLine("Enter your name");
        //lead.EmpName = Console.ReadLine();
        //Console.WriteLine("Your empid= " + lead.Empid);
        //lead.CalculateSalary(10000);
        //Console.WriteLine("Your Salary=" + lead.TotalSalary);

        TechLead lead=new TechLead();
        lead.EmpName = "Sara";
        lead.CalculateSalary(10000);
        Console.WriteLine(lead.TotalSalary);
        lead.ExpInYrs = 10;
        Console.WriteLine("Experience of Techlead=" + lead.ExpInYrs);
        lead.WorkingHrs = 100;
        Console.WriteLine($"Lead Working Hrs={lead.WorkingHrs}");
        Console.WriteLine("TechLead Empid= " + lead.Empid);

        Console.WriteLine("-----------------------------------------------");
        Developer dev=new Developer();
        dev.EmpName = "Niraj";
        dev.CalculateSalary(10000);
        Console.WriteLine(dev.TotalSalary);
        dev.ExpInYrs = 10;
        Console.WriteLine("Experience of Developer=" + dev.ExpInYrs);
        dev.WorkingHrs = 100;
        Console.WriteLine($"Developer Working Hrs={dev.WorkingHrs}");
        Console.WriteLine("Developer Empid= " + dev.Empid);








    }
}