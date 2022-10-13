using Eplan.EplApi.Scripting;
using System.Diagnostics;
using System.Windows.Forms;

public class Debug_Test
{
  [Start]
  public void Function()
  {
    if (Debugger.IsAttached)
    {
      Debugger.Break();
    }

    int number1 = 10;
    int number2 = 3;
    int result1 = number1 / number2; // 3[.33]

    MessageBox.Show(result1.ToString());

    try
    {
      int number3 = 10;
      int number4 = 0;
      int result2 = number3 / number4;

      MessageBox.Show(result2.ToString());
    }
    catch (System.Exception exception)
    {
      MessageBox.Show(exception.Message);
    }
  }
}