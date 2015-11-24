using ContactsXamarin.Services;

namespace ContactsXamarin.ViewModels
{
    public class DetailsViewModel
    {
        public Person Person { get; set; }

        public DetailsViewModel(Person person)
        {
            Person = person;
        }
    }
}
