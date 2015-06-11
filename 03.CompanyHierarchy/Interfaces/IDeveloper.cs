using System;
using System.Collections.Generic;
using Humans.Persons.Employees.RegularEmployees.DeveloperUnits;

namespace Humans.Persons.Employees.Developers
{
    public interface IDeveloper
    {
        void AddProject(Project newProject);
        List<Project> Projects { get; set; }
    }
}
