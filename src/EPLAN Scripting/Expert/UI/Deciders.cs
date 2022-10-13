using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;
using System.Windows.Forms;

public class Deciders
{
  [Start]
  public void Function()
  {
    new Decider().Decide(
      EnumDecisionType.eOkDecision, "OK", "Deciers",
      EnumDecisionReturn.eOK, EnumDecisionReturn.eOK,
      "Deciders1", true, EnumDecisionIcon.eINFORMATION);

    var result = new Decider().Decide(
      EnumDecisionType.eYesNoCancelDecision, "OK?", "Deciers",
      EnumDecisionReturn.eYES, EnumDecisionReturn.eYES,
      "Deciders2", false, EnumDecisionIcon.eQUESTION);

    switch(result)
    {
      case EnumDecisionReturn.eOK:
        MessageBox.Show("YES");
        break;
        default:
        MessageBox.Show("No or Cancel");
        break;
    }

  }
}