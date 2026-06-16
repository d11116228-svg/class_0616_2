using System;

public class Student
{
    public int Mid;
    public int Final;
    public string[] Names;

    public Student()
    {
        Names = new string[3];
        Names[0] = "AAA";
        Names[1] = "BBB";
        Names[2] = "CCC";
    }

    public string this[int pos]
    {
        get
        {
            return this.Names[pos];
        }
        set
        {
            this.Names[pos] = value;
        }
    }
}