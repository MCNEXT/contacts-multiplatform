using System;
using ContactsXamarin.Services;
using ContactsXamarin.Views;
using Xamarin.Forms;

namespace ContactsXamarin
{
    public class Mainpage : NavigationPage
    {
        private static readonly ListPage MenuPage = new ListPage();

        public Mainpage()
            : base(MenuPage)
        {
            MenuPage.ItemSelected += (sender, args) => NavigateTo(((PersonEventArgs) args).Person);
        }

        private void NavigateTo(Person person)
        {
            PushAsync(new DetailsPage(person));
        }
    }
}