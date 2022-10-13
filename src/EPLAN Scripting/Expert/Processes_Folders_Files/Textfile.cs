using Eplan.EplApi.Scripting;
using System.IO;
using System.Text;
using System.Windows.Forms;

public class Textfile
{
  [Start]
  public void Function()
  {
    string path = @"C:\test\TextFile.txt";

    StringBuilder sb = new StringBuilder();
    sb.AppendLine("First line");
    sb.AppendLine("Second line");

    string content = sb.ToString();
    File.WriteAllText(path, content, Encoding.UTF8);

    string result = File.ReadAllText(path, Encoding.UTF8);
    MessageBox.Show(result);
  }
}