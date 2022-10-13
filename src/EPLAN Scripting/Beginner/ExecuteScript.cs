using Eplan.EplApi.Scripting;
using System.Windows.Forms;

public class ExecuteScript
{
  [Start]
  public void Function()
  {
    MessageBox.Show("Hallo"); // Comment
  }
}