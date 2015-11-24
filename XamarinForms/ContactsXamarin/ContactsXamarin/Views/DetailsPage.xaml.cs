using ContactsXamarin.Services;
using ContactsXamarin.ViewModels;
using Xamarin.Forms;

namespace ContactsXamarin.Views
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Person person)
        {
            InitializeComponent();
            BindingContext = new DetailsViewModel(person);
        }
    }
}
