using Eplan.EplApi.Scripting;
using System.Windows.Forms;

public class LoadScript
{
  [DeclareAction("LoadScript")]
  public void Function()
  {
    MessageBox.Show("Hallo"); // Comment
  }
}

