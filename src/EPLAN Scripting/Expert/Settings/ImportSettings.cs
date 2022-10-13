using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting; 

public class ImportSettings
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();

    // Project
    ActionCallingContext accProject = new ActionCallingContext();
    string project = PathMap.SubstitutePath("$(P)");
    accProject.AddParameter("Project", project);

    string file = @"C:\test\Project.xml";
    accProject.AddParameter("XmlFile", file);

    cli.Execute("XSettingsImport", accProject);

    // User
    file = @"C:\test\User.xml";
    new Settings().ReadSettings(file);
  }
}