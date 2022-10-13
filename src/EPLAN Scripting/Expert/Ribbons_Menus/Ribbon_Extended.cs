using Eplan.EplApi.Base;
using Eplan.EplApi.Gui;
using Eplan.EplApi.Scripting;
using System.Windows.Forms;

public class Ribbon_Extended
{
  const string ACTION_NAME = "Ribbon_Extended";
  public MultiLangString TAB_NAME
  {
    get
    {
      return GetMultiLangString("My Tab 2", "Meine Registerkarte 2");
    }
  }

  private static MultiLangString GetMultiLangString(string english, string german)
  {
    MultiLangString multiLangString = new MultiLangString();
    multiLangString.AddString(ISOCode.Language.L_en_US, english);
    multiLangString.AddString(ISOCode.Language.L_de_DE, german);
    return multiLangString;
  }

  [DeclareRegister]
  public void Register()  
  {
    RibbonBar ribbonBar = new RibbonBar();
    var tab = ribbonBar.AddTab(TAB_NAME);

    var groupName = GetMultiLangString("My group 2", "Meine Gruppe 2");
    var group = tab.AddCommandGroup(groupName);

    var buttonText = GetMultiLangString("My button 2", "Mein Knopf 2");
    var tooltip = GetMultiLangString("My tooltip 2", "Meine Kurzinfo 2");
    var description = GetMultiLangString("My description 2", "Meine Beschreibung 2");

    string imagePath = @"C:\test\test.svg";
    var icon = ribbonBar.AddIcon(imagePath);

    group.AddCommand(buttonText, ACTION_NAME, tooltip, description, icon);
  }

  [DeclareUnregister]
  public void UnRegister()
  {
    RibbonBar ribbonBar = new RibbonBar();
    var tab = ribbonBar.GetTab(TAB_NAME, true);
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