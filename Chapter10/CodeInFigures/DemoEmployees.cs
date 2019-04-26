using static System.Console;
class DemoEmployees
{
   static void Main()
   {
      Employee clerk = new Employee();
      CommissionEmployee salesperson = new CommissionEmployee();
      clerk.IdNum = 123;
      clerk.Salary = 30000.00;
      salesperson.IdNum = 234;
      salesperson.Salary = 20000.00;
      salesperson.CommissionRate = 0.07;
      WriteLine("\n" + clerk.GetGreeting());
      WriteLine("Clerk #{0} salary: {1} per year",
         clerk.IdNum, clerk.Salary.ToString("C"));
      WriteLine("\n" + salesperson.GetGreeting());
      WriteLine("Salesperson #{0} salary: {1} per year",
         salesperson.IdNum, salesperson.Salary.ToString("C"));
      WriteLine("...plus {0} commission on all sales",
         salesperson.CommissionRate.ToString("P"));
   }
}
class Employee
{
   private int idNum;
   private double salary;
   public int IdNum
   {
      get
      {
         return idNum;
      }
      set
      {
         idNum = value;
      }
   }
   public double Salary
   {
      get
      {
         return salary;
      }
      set
      {
         salary = value;
      }
   }
   public string GetGreeting()
   {
      string greeting = "Hello. I am employee #" + IdNum;
      return greeting;
   }
}

class CommissionEmployee : Employee
{
   private double commissionRate;
   public double CommissionRate
   {
      get
      {
          return commissionRate;
      }
      set
      {
          commissionRate = value;
      }
   }
}

