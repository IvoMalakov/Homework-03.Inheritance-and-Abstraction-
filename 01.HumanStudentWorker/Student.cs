using System;

public class Student : Human
{
    private string facultyNumber;
    private const int minFacultyNumberLength = 5;
    private const int maxFacultyNumberLength = 10;

    public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get { return this.facultyNumber; }

        set
        {
            if (value.ToString().Length < minFacultyNumberLength || value.ToString().Length > maxFacultyNumberLength)
            {
                throw new ArgumentException("Your faculty number must be between 5 and 10 digits or letters");
            }

            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        return String.Format("{0} Faculty Number: {1}", base.ToString(), this.FacultyNumber);
    }
}
