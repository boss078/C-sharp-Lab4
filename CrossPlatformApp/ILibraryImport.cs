using System.Runtime.InteropServices;

namespace CrossPlatformApp
{
  public interface ILibraryImport
  {
    int pow(int number, int pow);

    float returnPI();
  }
}