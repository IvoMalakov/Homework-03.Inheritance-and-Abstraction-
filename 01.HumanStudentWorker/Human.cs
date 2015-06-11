using System;

public abstract class Human
{
    private string firstName;
    private string lastName;

    protected Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName 
    {
        get { return this.firstName; }

        set
        {
            if (String.IsNullOrEmpty(value.Trim()))
            {
                throw new ArgumentNullException("Your first name can not be empty");
            }

            this.firstName = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }

        set
        {
            if (String.IsNullOrEmpty(value.Trim()))
            {
                throw new ArgumentNullException("Your last name can not be empty");
            }

            this.lastName = value;
        }
    }

    public override string ToString()
    {
        return String.Format("First Name : {0}, Last Name: {1}", this.FirstName, this.LastName);
    }
}