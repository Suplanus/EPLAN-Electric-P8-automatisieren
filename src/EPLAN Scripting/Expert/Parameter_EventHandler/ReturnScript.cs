using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;
using System.Windows.Forms;

public class ReturnScript
{
  [DeclareAction("ReturnScript")]
  public void Action(ActionCallingContext acc)
  {
    string text = null;
    acc.GetParameter("text", ref text);

    string result = "Result: " + text;
    acc.AddParameter("result", result);    
  }

  [Start]
  public void Start()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();
    ActionCallingContext acc = new ActionCallingContext();
    acc.AddParameter("text", "Knock knock Neo!");
    cli.Execute("ReturnScript", acc);

    string result = null;
    acc.GetParameter("result", ref result);

    MessageBox.Show(result);
  }
}

