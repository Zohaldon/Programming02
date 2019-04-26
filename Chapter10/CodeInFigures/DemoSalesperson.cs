using static System.Console;
class DemoSalesperson
{
   static void Main()
   {
      CommissionEmployee salesperson = new CommissionEmployee();
      salesperson.IdNum = 345;
      salesperson.Salary = 20000;
      salesperson.CommissionRate = 0.07;
      WriteLine("Salesperson #{0} makes {1} per year",
         salesperson.IdNum,
         salesperson.Salary.ToString("C"));
      WriteLine("...plus {0} commission on all sales",
         salesperson.CommissionRate.ToString("P"));
   }
}
class Employee
{
   private int idNum;
   protected double salary;
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
         double MINIMUM = 15000;
         if(value < MINIMUM)
            salary = MINIMUM;
         else
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
         salary = 0;
      }
   }
}
