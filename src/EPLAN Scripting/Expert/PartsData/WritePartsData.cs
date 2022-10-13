using Eplan.EplApi.MasterData;
using Eplan.EplApi.Scripting;
using System.Linq; 

public class WritePartsData
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

      foreach (var part in parts)
      {
        part.Properties.ARTICLE_DESCR1 = "Motorschutzschalter";
      }
    }
  }
}