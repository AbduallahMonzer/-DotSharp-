using System;
public class Person
{
		string? firstName;
	string? lastName;
	DateOnly birthdate;
	string? country;

	//properties
	public string FirstName
	{
		get { return firstName; }
		set { firstName = value; }
	}
	public string LastName
	{
		get { return lastName; }
		set { lastName = value; }
	}
	public DateOnly BirthDate { get; set; }
	public string? Country { get; set; }
}
