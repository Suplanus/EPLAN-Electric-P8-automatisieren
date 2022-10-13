using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class ExportLabels
{
  [Start]
  public void AutoTreat()
  {
    ActionCallingContext context1 = new ActionCallingContext();
    context1.AddParameter("configscheme", "Summarized parts list");
    context1.AddParameter("filterscheme", "");
    context1.AddParameter("sortscheme", "");
    context1.AddParameter("language", "de_DE");
    context1.AddParameter("destinationfile", @"$(MD_DOCUMENTS)\Artikelsummen.txt");
    context1.AddParameter("recrepeat", "1");
    context1.AddParameter("taskrepeat", "1");
    context1.AddParameter("showoutput", "0");
    context1.AddParameter("type", "PROJECT");
    new CommandLineInterpreter().Execute("label", context1);

    ActionCallingContext context2 = new ActionCallingContext();
    context2.AddParameter("configscheme", "Device tag list");
    context2.AddParameter("filterscheme", "");
    context2.AddParameter("sortscheme", "");
    context2.AddParameter("language", "de_DE");
    context2.AddParameter("destinationfile", @"$(MD_DOCUMENTS)\BM-Liste.txt");
    context2.AddParameter("recrepeat", "1");
    context2.AddParameter("taskrepeat", "1");
    context2.AddParameter("showoutput", "0");
    context2.AddParameter("type", "PROJECT");
    new CommandLineInterpreter().Execute("label", context2);
  }
}
