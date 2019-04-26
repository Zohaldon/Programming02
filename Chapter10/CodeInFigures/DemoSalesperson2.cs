using static System.Console;
class DemoSalesperson2
{
   static void Main()
   {
      CommissionEmployee salesperson = new CommissionEmployee();
      salesperson.IdNum = 345;
      WriteLine(salesperson.GetGreeting());
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
         return Salary;
      }
      set
      {
         double MINIMUM = 15000;
         if(value < MINIMUM)
            Salary = MINIMUM;
         else
            Salary = value;
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
         Salary = 0;
      }
   }
   new public string GetGreeting()
   {
      string greeting = base.GetGreeting();
      greeting += "\nI work on commission.";
      return greeting;
   }
}
