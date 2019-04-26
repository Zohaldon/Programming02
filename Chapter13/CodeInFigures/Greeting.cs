using static System.Console;
delegate void GreetingDelegate(string s);
class Greeting
{
   public static void Hello(string s)
   {
      WriteLine("Hello, {0}!", s);
   }
   public static void Goodbye(string s)
   {
      WriteLine("Goodbye, {0}!", s);
   }
   static void Main()
   {
      GreetingDelegate firstDel, secondDel;
      firstDel = new GreetingDelegate(Hello);
      secondDel = new GreetingDelegate(Goodbye);
      GreetMethod(firstDel, "Cathy");
      GreetMethod(secondDel, "Bob");
   }
   public static void GreetMethod(GreetingDelegate gd, string name)
   {
      WriteLine("The greeting is:");
      gd(name);
   }
}
