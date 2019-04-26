using static System.Console;
class DemoSalesperson4
{
   static void Main()
   {
      CommissionEmployee salesperson = new CommissionEmployee();
   }
}
class Employee
{
   private int idNum;
   protected double salary;
   public Employee()
   {
      WriteLine("Employee constructed");
   }
}
class CommissionEmployee : Employee
{
   private double commissionRate;
   public CommissionEmployee()
   {
      WriteLine("CommissionEmployee constructed");
   }
}
