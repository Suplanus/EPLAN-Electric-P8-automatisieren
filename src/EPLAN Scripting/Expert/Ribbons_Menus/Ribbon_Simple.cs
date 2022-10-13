using Eplan.EplApi.Gui;
using Eplan.EplApi.Scripting;
using System.Windows.Forms;

public class Ribbon_Simple
{
  const string ACTION_NAME = "Ribbon_Simple";
  const string TAB_NAME = "My Tab 1";

  [DeclareRegister]
  public void Register()
  {
    RibbonBar ribbonBar = new RibbonBar();
    var tab = ribbonBar.AddTab(TAB_NAME);
    var group = tab.AddCommandGroup("My group 1");
    group.AddCommand("My button 1", ACTION_NAME);
  }

  [DeclareUnregister]
  public void UnRegister()
  {
    RibbonBar ribbonBar = new RibbonBar();
    var tab = ribbonBar.GetTab(TAB_NAME);
    if (tab != null)
    {
      tab.Remove();
    }
  }

  [DeclareAction(ACTION_NAME)]
  public void Function()
  {
    MessageBox.Show("Action ausgeführt!");
  }
}