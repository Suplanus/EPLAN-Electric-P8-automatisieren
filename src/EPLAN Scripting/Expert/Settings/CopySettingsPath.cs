using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;
using System.Windows.Forms;

public class CopySettingsPath
{
  [Start]
  public void Function()
  {
    Settings settings = new Settings();
    string path = "USER.EnfMVC.ContextMenuSetting.ShowExtended";
    bool value = settings.GetBoolSetting(path, 0);
    value = !value;
    settings.SetBoolSetting(path, value, 0);

    MessageBox.Show("Einstellung wurde gesetzt: " + value);
    // USER.TrDMProject.UserData.Identification 0
  }
}