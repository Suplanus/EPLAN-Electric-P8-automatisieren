using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;
using System.Windows.Forms;

public class ChangeSetting
{
  [Start]
  public void Function()
  {
    Settings settings = new Settings();
    string path = "USER.TrDMProject.UserData.Identification";
    settings.SetStringSetting(path, "TEST", 0);
    MessageBox.Show("Einstellung wurde gesetzt.");
  }
}