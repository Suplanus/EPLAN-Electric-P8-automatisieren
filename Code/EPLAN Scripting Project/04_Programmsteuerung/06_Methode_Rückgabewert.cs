﻿using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _04_Programmsteuerung_06_Methode_Rueckgabewert
{
  [DeclareAction("MethodeIntRückgabewert")]
  public void Function(int int1, int int2)
  {
    int intResult = Calc(int1, int2);

    MessageBox.Show(
        int1.ToString() +
        " + " + int2.ToString() +
        " = " + intResult.ToString()
        );

    FinishedMessageBox();

    return;
  }

  private static int Calc(int int1, int int2)
  {
    return int1 + int2;
  }

  private static void FinishedMessageBox()
  {
    MessageBox.Show("Berechnung abgeschlossen.");

    return;
  }

}