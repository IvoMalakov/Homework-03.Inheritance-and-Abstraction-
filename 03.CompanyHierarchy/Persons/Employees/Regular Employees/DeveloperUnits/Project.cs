using System;

namespace Humans.Persons.Employees.RegularEmployees.DeveloperUnits
{
    public class Project
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private string state;

        public Project(string projectName, DateTime projectStartDate, string details)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.State = "open";
        }

        public Project(string projectName, DateTime projectStartDate) : this (projectName, projectStartDate, null)
        {
            this.State = "open";
        }

        public string ProjectName
        {
            get { return this.projectName; }

            set
            {
                if (String.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Your Project's name can not be empty");
                }

                this.projectName = value;
            }
        }

        public string State
        {
            get { return this.state; }

            set
            {
                if (!(value.Equals("open".Trim()) || value.Equals("closed".Trim())))
                {
                    throw new ArgumentException("The state of your project can be only \"open\" or \"closed\" ");
                }

                this.state = value;
            }
        }

        public DateTime ProjectStartDate { get; set; }
        public string Details { get; set; }

        public void CloseProject()
        {
            this.State = "closed";
        }

        public override string ToString()
        {
            return String.Format("Name of the project : \"{0}\", This project starts at: {1}, Some details: {2}," +
                                 "Status: This project is: {3}", this.ProjectName, this.ProjectStartDate, this.Details
                                 ?? "none", this.State);
        }
    }
}
