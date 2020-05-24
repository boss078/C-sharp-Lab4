using System.Runtime.InteropServices;

namespace CrossPlatformApp
{
  public interface ILibraryImport
  {
    int Pow(int number, int pow);

    float ReturnPI();
  }
}