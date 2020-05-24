using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CrossPlatformApp
{
  internal class LibraryImport_x64 : ILibraryImport
  {
    
    [DllImport("MyCrossplatformLib-x64.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = false, EntryPoint = "pow")]
    private static extern int PowInternal(int number, int pow);
    [DllImport("MyCrossplatformLib-x64.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = false, EntryPoint = "returnPI")] 
    private static extern float ReturnPIInternal();
    public int Pow(int number, int pow)
    {
      return PowInternal(number, pow);
    }
    public float ReturnPI()
    {
      return ReturnPIInternal();
    }
  }
}