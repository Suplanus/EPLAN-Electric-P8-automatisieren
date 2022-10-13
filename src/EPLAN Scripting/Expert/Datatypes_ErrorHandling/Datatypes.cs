using Eplan.EplApi.Scripting;
using System;
using System.Windows.Forms;

public class Datatypes
{
  [Start]
  public void Function()
  {
    string text = "Hallo";
    int number = 123;
    float decimalNumber = 123.456f;
    bool ok = true;

    MessageBox.Show(
      text +
      Environment.NewLine +
      number +
      Environment.NewLine +
      decimalNumber +
      Environment.NewLine +
      ok
      );
  }
}

