using System;

public class Worker : Human
{
    private decimal weekSalary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) :
        base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get { return this.weekSalary; }

        set
        {
            if (value <= 0m)
            {
                throw new ArgumentException("Your weekSalary must have a positive value");
            }

            this.weekSalary = value;
        }
    }

    public decimal WorkHoursPerDay
    {
        get { return this.workHoursPerDay; }

        set
        {
            if (value < 0m)
            {
                throw new ArgumentException("Your work hours per day can not be negative");
            }

            this.workHoursPerDay = value;
        }
    }

    public decimal MoneyPerHour()
    {
        decimal paymentForAHour = this.WeekSalary / (this.WorkHoursPerDay * 5);
        return paymentForAHour;
    }

    public override string ToString()
    {
        return String.Format("{0} Week Salary: {1}, Work Hours Per Day : {2}", base.ToString(), 
            this.WeekSalary, this.WorkHoursPerDay);
    }
}