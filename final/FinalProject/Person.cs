using System;
using System.Collections.Generic;

class Person
{
    protected string Name;
    protected int Age;

    public void SetPersonalDetails(string name, int age)
    {
        Name = name;
        Age = age;
    }
}