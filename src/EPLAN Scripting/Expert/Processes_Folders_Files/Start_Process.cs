using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;
using System.Diagnostics;  

public class Start_Process
{
  [Start]
  public void Function()
  {
    string file = @"C:\test\test.svg";
    Process.Start(file);

    string name = "explorer";
    string path = PathMap.SubstitutePath("$(PROJECTPATH)");

    string QUOTE = "\"";

    ProcessStartInfo processStartInfo = new ProcessStartInfo();
    processStartInfo.FileName = name;
    processStartInfo.Arguments = QUOTE + path + QUOTE;
    Process.Start(processStartInfo);
  }
}