using System;
using System.Collections.Generic;

namespace Task2_3
{
    public class User
    {
        private string _secondName;
        private string _name; 
        private string _patronymic;
        private DateTime _dateOfBirth;
        private int _age;

        public User(List<string> userData)
        {
            _secondName = userData[0];
            _name = userData[1];
            _patronymic = userData[2];
            if (DateTime.TryParse(userData[3], out DateTime dateOfBirth))
            {
                _dateOfBirth = dateOfBirth;
            }
            else
            {
                throw new ArgumentException("Wrong date or time format!");
            }
            
            if (int.TryParse(userData[4], out int age))
            {
                _age = age;
            }
            else
            {
                throw new ArgumentException("Wrong age format!");
            }
            
        }

        public override string ToString()
        {
            return $"Second Name: {_secondName} | Name: {_name} | Patronymic: {_patronymic} | Date Of Birth: {_dateOfBirth} | Age: {_age} \n";

        }
    }
}