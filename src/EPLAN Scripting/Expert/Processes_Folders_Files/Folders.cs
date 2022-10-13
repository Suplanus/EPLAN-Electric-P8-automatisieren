using Eplan.EplApi.Scripting;
using System.IO;

public class Folders
{
  [Start]
  public void Function()
  {
    string path = @"C:\test\test\";

    if (!Directory.Exists(path))
    {
      Directory.CreateDirectory(path);
    }
  }
}