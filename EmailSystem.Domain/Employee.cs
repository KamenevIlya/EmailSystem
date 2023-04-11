using System;

namespace EmailSystem.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string GivenName { get; set; }

        public string Position { get; set; }

        public int ExperienceMonth { get; set; }
    }
}
