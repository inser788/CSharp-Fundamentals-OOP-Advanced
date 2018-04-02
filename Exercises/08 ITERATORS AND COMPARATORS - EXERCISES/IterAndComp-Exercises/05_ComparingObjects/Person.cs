using System;public class Person:IComparable<Person>
{
    public string Name { get; set; }

    public int Age { get; set; }

    public string Town { get; set; }

    public Person(string name, int age, string town)
    {
        this.Name = name;
        this.Age = age;
        this.Town = town;
    }


    public int CompareTo(Person otherPerson)
    {
        int result = this.Name.CompareTo(otherPerson.Name);
        if (result==0)
        {
            result = this.Age.CompareTo(otherPerson.Age);
            if (result==0)
            {
                result = this.Town.CompareTo(otherPerson.Town);
            }
        }

        return result;
    }
}

