using Eplan.EplApi.MasterData;
using Eplan.EplApi.Scripting;
using System.Linq;
using System.Windows.Forms;

public class ReadPartsData
{
  [Start]
  public void Function()
  {
    MDPartsManagement partsManagement = new MDPartsManagement();
    using (var database = partsManagement.OpenDatabase())
    {
      var parts = database.Parts.Where(obj => 
      obj.ProductSubGroup == MDPartsDatabaseItem.Enums.ProductSubGroup.MotorOverloadSwitch
      ).ToList();
      int count = parts.Count;

      MessageBox.Show(count.ToString());
    }
  }
}