using System;
using static System.Console;
using System.IO;
class DebugFourteen1
{
   static void Main()
   {
      string fileName;
      string directory;
      string path;
      string[] files;
      int x;
      Write("Enter a directory ");
      directory = ReadLine();
      if(Directory.exists(directory))
      {
          files = Directory.GetFiles(directory);
          if(files.Length = 0)
              WriteLine("There are no files in " + directory);
          else
          {
             WriteLine(directory + " contains the following files");
             for(x = 0; x < 20; ++x)
                 WriteLine("  " + files[x]);
             Write("\nEnter a file name ");
             fileName = ReadLine();
             path = directory + "\\" + fileName;
             if(File.Exists(path))
             {
                WriteLine("  File exists and was created " + File.GetCreationTime(path));
                WriteLine("File was created " +
                File.GetCreationtime(fileName));
                WriteLine("File was last accessed " +
                File.GetLastAccesstime(fileName));
                WriteLine("File was last written to " +
                File.GetLastWriteTime(fileName));
             }
             else
                 WriteLine("  " + fileName + " does not exist in the " + directory + " directory");
             
         }
      }
      else
      {
          WriteLine("Directory " + directory + " does not exist");
      }
  }
}