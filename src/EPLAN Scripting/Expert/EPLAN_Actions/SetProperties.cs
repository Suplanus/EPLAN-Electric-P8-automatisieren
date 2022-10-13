using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class SetProperties
{
  [Start]
  public void Function()
  {
    string projectId = "10011";
    string projectIndex = "0";
    string projectValue = "My project description";
    SetProjectProperty(projectId, projectIndex, projectValue);

    string pageId = "11011";
    string pageIndex = "0";
    string pageValue = "My page description";
    SetPageProperty(pageId, pageIndex, pageValue);
  }

  private void SetProjectProperty(string id, string index, string value)
  {
    ActionCallingContext acc = new ActionCallingContext();
    acc.AddParameter("PropertyId", id);
    acc.AddParameter("PropertyIndex", index);
    acc.AddParameter("PropertyValue", value);
    new CommandLineInterpreter().Execute("XEsSetProjectPropertyAction", acc);
  }

  private void SetPageProperty(string id, string index, string value)
  {
    ActionCallingContext acc = new ActionCallingContext();
    acc.AddParameter("PropertyId", id);
    acc.AddParameter("PropertyIndex", index);
    acc.AddParameter("PropertyValue", value);
    new CommandLineInterpreter().Execute("XEsSetPagePropertyAction", acc);
  }
}