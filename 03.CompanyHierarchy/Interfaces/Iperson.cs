using System;

namespace Humans.Persons
{
    public interface IPerson
    {
        string ID { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}
