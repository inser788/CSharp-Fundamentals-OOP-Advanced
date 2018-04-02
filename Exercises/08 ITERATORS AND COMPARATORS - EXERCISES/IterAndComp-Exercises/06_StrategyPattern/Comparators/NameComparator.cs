using System.Collections.Generic;

public class NameComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        int result = x.Name.Length.CompareTo(y.Name.Length);
        if (result==0)
        {
            var xFirstLetter = char.ToLower(x.Name[0]);
            var yFirstLetter = char.ToLower(y.Name[0]);

            result = xFirstLetter.CompareTo(yFirstLetter);
        }

        return result;
    }
}

