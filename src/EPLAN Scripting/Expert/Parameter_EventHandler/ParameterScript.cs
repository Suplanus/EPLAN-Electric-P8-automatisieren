using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;
using System.Windows.Forms;

public class ParameterScript
{
  [DeclareAction("ParameterScript")]
  public void Action(ActionCallingContext acc)
  {
    string text = null;
    acc.GetParameter("text", ref text);
    MessageBox.Show(text);
  }

  [Start]
  public void Start()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();
    const string QUOTE = "\"";
    cli.Execute("ParameterScript /text:" + QUOTE + "Knock knock Neo!" + QUOTE);
  }
}

