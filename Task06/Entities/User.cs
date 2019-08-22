using System;

namespace Entities
{
    public class User
    {
        public int Id { get; private set; }

        private string Name { get; set; }

        private DateTime DateOfBirth { get; set; }

        private int Age { get; set; }
        
        public User(int id, string name, DateTime dateOfBirth)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            Age = GetAge(dateOfBirth);
        }
        
        public override string ToString()
        {
            return $"{Id} {Name} {DateOfBirth} {Age}";
        }
        
        private static int GetAge(DateTime birthDate)
        {
            DateTime now = DateTime.Today;
            return now.Year - birthDate.Year - 1 + 
                   ((now.Month > birthDate.Month || now.Month == birthDate.Month && now.Day >= birthDate.Day) ? 1 : 0);
        }
        
    }
}