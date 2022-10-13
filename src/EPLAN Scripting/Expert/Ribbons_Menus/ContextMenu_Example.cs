using Eplan.EplApi.Scripting;
using System.Windows.Forms;

public class ContextMenu_Example
{
  [DeclareMenu]
  public void MenuFunction()
  {
    Eplan.EplApi.Gui.ContextMenuLocation contextMenuLocation = 
      new Eplan.EplApi.Gui.ContextMenuLocation("GedEditGuiText", "1002");

    Eplan.EplApi.Gui.ContextMenu menu = new Eplan.EplApi.Gui.ContextMenu();

    string buttonText = "MenuItem in ContextMenu";
    string action = "ContextMenu_Example";
    menu.AddMenuItem(contextMenuLocation, buttonText, action, true, false);

  }

  [DeclareAction("ContextMenu_Example")]
  public void Function()
  {
    MessageBox.Show("Action ausgeführt");
  }
}