using System;

namespace session6 // Note: actual namespace depends on the project name.
{  

public class Person
{
  
private string _firstName;
public string FirstName
{
  get { return _firstName; }
  set { _firstName = value; }
}

private string _lastName;
public string LastName
{
  get { return _lastName; }
  set { _lastName = value; }
}
public Person(string firstname , string lastname)
{
  this._firstName = firstname;
  this._lastName = lastname;
}
public string ShowName(string middlename){

string fullName = $" {_firstName} {middlename} {_lastName}";
return fullName;

}

}
}