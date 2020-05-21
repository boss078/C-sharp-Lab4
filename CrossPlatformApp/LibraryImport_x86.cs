using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CrossPlatformApp
{
  internal class LibraryImport_x86 : ILibraryImport
  {
    [DllImport("CrossPlatformLibrary-x86", CallingConvention = CallingConvention.StdCall, ExactSpelling = false, EntryPoint = "_ProcessData@12")]
    private static extern int powInternal(int number, int pow);

    [DllImport("CrossPlatformLibrary-x86", CallingConvention = CallingConvention.StdCall, ExactSpelling = false, EntryPoint = "_ProcessData@12")]
    private static extern float returnPIInternal();

    public int pow(int number, int pow)
    {
      return powInternal(number, pow);
    }
    public float returnPI()
    {
      return returnPI();
    }
  }
}