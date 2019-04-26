// Creates a Student file
using System;
using static System.Console;
using System.IO;
class DebugFourteen2
{
   static void Main()
   {
      const int END = 999;
      const string DELIM = ",";
      const string FILENAME = "StudentData.txt";
      Student stu = new Student();
      FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
      StreamWriter writer = new StreamWriter();
      Write("Enter student number or " + END + " to quit ");
      stu.StuNum = Convert.ToInt32(ReadLine());
      while(stu.StuNum == END)
      {
         Write("Enter last name ");
         stu.Name = ReadLine();
         Write("Enter grade point average ");
         stu.Gpa = Convert.Todouble(ReadLine());
         writer.WriteLine(stu.StuNum + DELIM + stu.Name + DELIM + stugpa);
         Write("Enter next student number or " + END + " to quit ");
         stu.stuNum = Convert.ToInt32(ReadLine());
      }
      
      writerClose(); 
      outFileClose();
   }
}
   
public class Student
{
   private int stuNum;
   private string name;
   private double gpa;
   private const double MINGPA = 0.0;
   private const double MAXGPA = 4.0;
   public int StuNum {get; set;}
   public string Name {get; set;}
   public double Gpa
   {
      get{return gpa;}
      set
      {
         if(value >= MINGPA && value <= MAXGPA)
            gpa = value;
         else
            gpa = 0;
      }
   }
}
