using System;
using ContactsXamarin.Services;
using Xamarin.Forms;

namespace ContactsXamarin.Views
{
    public partial class ListPage : ContentPage
    {
        public event EventHandler ItemSelected;

        protected virtual void RaiseItemSelected(Person person)
        {
            EventHandler handler = ItemSelected;
            if (handler != null) handler(this, new PersonEventArgs(person));
        }


        public ListPage()
        {
            InitializeComponent();
        }

        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Person person = e.SelectedItem as Person;
            if (person != null)
                RaiseItemSelected(person);
        }
    }
}
