using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CrossPlatformApp
{
  internal class LibraryImport_x64 : ILibraryImport
  {
    [DllImport("MyCrossplatformLib.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = false, EntryPoint = "pow")]
    private static extern int powInternal(int number, int pow);
    [DllImport("MyCrossplatformLib.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = false, EntryPoint = "returnPI")] 
    private static extern float returnPIInternal();
    public int pow(int number, int pow)
    {
      return powInternal(number, pow);
    }
    public float returnPI()
    {
      return returnPIInternal();
    }
  }
}