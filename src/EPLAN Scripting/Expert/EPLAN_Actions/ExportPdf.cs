using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;
using System.Diagnostics;
using System.IO;  

public class ExportPdf
{
  [Start]
  public void Function()
  {
    string path = PathMap.SubstitutePath("$(P)");
    path = Path.GetDirectoryName(path);

    string filename = PathMap.SubstitutePath("$(PROJECTNAME)");
    string fullFileName = Path.Combine(path, filename + ".pdf");

    ActionCallingContext acc = new ActionCallingContext();
    acc.AddParameter("TYPE", "PDFPROJECTSCHEME");
    acc.AddParameter("EXPORTFILE", fullFileName);
    acc.AddParameter("EXPORTSCHEME", "EPLAN_default_value");
    new CommandLineInterpreter().Execute("export", acc);

    Process.Start(fullFileName);
  }
}