using System;

namespace Task2_5
{
    public class Employee : User
    {
        private int _workExperience;
        private string _position;

        public Employee(string secondName, string name, string patronymic, DateTime dateOfBirth, int age,
            int workExperience, string position) :
            base(secondName, name, patronymic, dateOfBirth, age)
        {
            _workExperience = workExperience;
            _position = position;
        }

        public int WorkExperience
        {
            get { return _workExperience; }
            set { _workExperience = value; }
        }

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $" Work Experience: {WorkExperience} | Position: {Position}";
        }
    }
}