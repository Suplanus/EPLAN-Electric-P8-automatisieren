using Eplan.EplApi.Scripting;
using System.Windows.Forms;

public class OwnClass
{
  [Start]
  public void Function()
  {
    Person max = new Person();
    max.FirstName = "Max";
    max.LastName = "Mustermann";
    MessageBox.Show(max.FullName);

    Person maria = new Person("Maria", "Musterfrau");
    maria.ShowFullName();
  }

  public class Person
  {
    public Person()
    {
    }

    public Person(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName
    {
      get
      {
        return FirstName + " " + LastName;
      }
    }

    public void ShowFullName()
    {
      MessageBox.Show(this.FullName);
    }
  }
}