using System;
using System.Collections.Generic;
using Humans.Persons.Employees.Developers;
using Humans.Persons.Employees.RegularEmployees.DeveloperUnits;

namespace Humans.Persons.Employees.RegularEmployees
{
    public class Developer : Employee, IDeveloper
    {
        List<Project> projects = new List<Project>();

        public Developer(string id, string firstName, string lastName, decimal salary, string departament) :
            base(id, firstName, lastName, salary, departament)
        {
            this.Projects = new List<Project>();
        }

        public Developer(string id, string firstName, string lastName, decimal salary, string departament, 
            List<Project> projects) : base(id, firstName, lastName, salary, departament)
        {
            this.Projects = projects;
        }

        public List<Project> Projects
        {
            get { return this.projects; }

            set { this.projects = value; }
        }

        public void AddProject(Project newProject)
        {
            projects.Add(newProject);
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", base.ToString(), String.Join("\n", this.Projects));
        }
    }
}
