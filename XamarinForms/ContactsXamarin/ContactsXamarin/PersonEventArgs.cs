using System;
using ContactsXamarin.Services;

namespace ContactsXamarin
{
    public class PersonEventArgs : EventArgs
    {
        public Person Person { get; private set; }

        public PersonEventArgs(Person person)
        {
            Person = person;
        }
    }
}
