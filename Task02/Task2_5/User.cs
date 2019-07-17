using System;

namespace Task2_5
{
    public class User
    {
        private string _secondName;
        private string _name;
        private string _patronymic;
        private DateTime _dateOfBirth;
        private int _age;

        public User(string secondName, string name, string patronymic, DateTime dateOfBirth, int age)
        {
            _secondName = secondName;
            _name = name;
            _patronymic = patronymic;
            _dateOfBirth = dateOfBirth;
            _age = age;
        }

        public string SecondName
        {
            get { return _secondName; }
            set { _secondName = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public override string ToString()
        {
            return
                $"Second Name: {SecondName} | Name: {Name} | Patronymic: {Patronymic} | Date Of Birth: {DateOfBirth} | Age: {Age} |";

        }
    }
}