using Eplan.EplApi.Scripting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

public class XmlFile
{
  [Start]
  public void Function()
  {
    List<Person> persons = new List<Person>();

    Person max = new Person();
    max.FirstName = "Max";
    max.LastName = "Mustermann";
    persons.Add(max);

    Person maria = new Person("Maria", "Musterfrau");
    persons.Add(maria);

    string path = @"C:\test\XmlFile.xml";
    WriteXml(persons, path);

    var newPersons = ReadXml(path);
    foreach (Person person in newPersons)
    {
      person.ShowFullName();
    }
  }

  private List<Person> ReadXml(string path)
  {
    XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
    XmlWriterSettings settings = new XmlWriterSettings();
    settings.Indent = true;
    settings.Encoding = Encoding.UTF8;

    using (StreamReader reader = new StreamReader(path))
    {
      List<Person> persons = (List<Person>)serializer.Deserialize(reader);
      return persons;
    }
  }

  private void WriteXml(List<Person> persons, string path)
  {
    XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
    XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();
    XmlWriterSettings settings = new XmlWriterSettings();
    settings.Indent = true;
    settings.Encoding = Encoding.UTF8;

    using (XmlWriter writer = XmlWriter.Create(path, settings))
    {
      serializer.Serialize(writer, persons, xmlns);
      writer.Close();
    }
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