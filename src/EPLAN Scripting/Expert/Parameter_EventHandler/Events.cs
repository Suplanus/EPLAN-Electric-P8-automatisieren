using Eplan.EplApi.Scripting;
using System.Windows.Forms;

public class Events
{
  [DeclareRegister]
  public void Register()
  {
    MessageBox.Show("Loaded");
  }

  [DeclareUnregister]
  public void Unregister()
  {
    MessageBox.Show("Unloaded");
  }

  [DeclareEventHandler("onActionStart.String.XPrjActionProjectClose")]
  public void CustomEvent()
  {
    MessageBox.Show("Project closing");
  }
}

