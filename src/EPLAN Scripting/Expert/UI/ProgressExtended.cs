using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class ProgressExtended
{
  [Start]
  public void Function()
  {
    Progress progress = new Progress("EnhancedProgress");
    progress.SetAllowCancel(false);
    progress.SetTitle("ProgressExtended");
    progress.ShowImmediately();

    try
    {
      progress.BeginPart(33, "Part 1");
      new CommandLineInterpreter().Execute("generate /TYPE:CONNECTIONS");
      progress.EndPart();

      progress.BeginPart(33, "Part 2");
      new CommandLineInterpreter().Execute("reports");
      progress.EndPart();

      progress.BeginPart(33, "Part 3");
      new CommandLineInterpreter().Execute("compress /FILTERSCHEME:Standard");
      progress.EndPart();
    }
    finally
    {
      progress.EndPart(true);
    }
  }
}