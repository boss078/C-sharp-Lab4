using System;
using System.Collections.Generic;
using System.Text;

namespace CrossPlatformApp
{
  class Program
  {
    static void Main(string[] args)
    {
      ILibraryImport import = LibraryImport.Select();
      Console.WriteLine(string.Format("pow(2, 8): {0}", import.pow(2, 8)));
      Console.WriteLine(string.Format("returnPI(): {0}", import.returnPI()));
    }
  }
}