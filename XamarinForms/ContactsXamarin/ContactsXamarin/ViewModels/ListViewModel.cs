using System.Collections.Generic;
using ContactsXamarin.Services;

namespace ContactsXamarin.ViewModels
{
    public class ListViewModel
    {
        public IList<Person> Persons { get; set; }

        public ListViewModel()
        {
            Persons = PeopleService.GetAll();
        }
    }
}
