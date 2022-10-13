using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;
using System.Windows.Forms;

public class FileDeciders
{
  [Start]
  public void Function()
  {
    FileSelectDecisionContext fileSelectDecisionContext = new FileSelectDecisionContext();
    fileSelectDecisionContext.Title = "Title";
    fileSelectDecisionContext.DefaultExtension = "txt";
    fileSelectDecisionContext.OpenFileFlag = false;
    fileSelectDecisionContext.AddFilter("Textfile (*.txt)", "*.txt");
    fileSelectDecisionContext.AddFilter("All files (*.*)", "*.*");
    var result = new Decider().Decide(fileSelectDecisionContext);
    if (result == EnumDecisionReturn.eOK)
    {
      var filename = fileSelectDecisionContext.GetFiles()[0];
      MessageBox.Show(filename);
    }
  }
}