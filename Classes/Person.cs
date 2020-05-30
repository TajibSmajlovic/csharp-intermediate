using System;

namespace Classes
{
    public class Person
    {
        public DateTime BirthDate { get; private set; }

        public int Age
        {
            get
            {
                return (DateTime.Today - BirthDate).Days / 365;
            }
        }

        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }

        //public void SetDateOfBirth(DateTime dateOfBirth)
        //{
        //    _dateOfBirth = dateOfBirth;
        //}

        //public DateTime GetDateOfBirth()
        //{
        //    return _dateOfBirth;
        //}
    }
}