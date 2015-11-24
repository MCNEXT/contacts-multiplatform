using Xamarin.Forms;

namespace ContactsXamarin.Services
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }

        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

        public ImageSource ImageSource
        {
            get { return ImageSource.FromResource("ContactsXamarin.Images." + Image); }
        }
    }
}
