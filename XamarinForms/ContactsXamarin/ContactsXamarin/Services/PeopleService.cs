using System.Collections.Generic;

namespace ContactsXamarin.Services
{
    public static class PeopleService
    {
        private static readonly IList<Person> Persons = new List<Person>
        {
            new Person{ FirstName = "Simona", LastName = "Morasca", Image = "photo01.jpg" },
            new Person{ FirstName = "Mitsue", LastName = "Tollner", Image = "photo02.jpg" },
            new Person{ FirstName = "Leota", LastName = "Dilliard", Image = "photo03.jpg" },
            new Person{ FirstName = "Sage", LastName = "Wieser", Image = "photo04.jpg" },
            new Person{ FirstName = "Kris", LastName = "Marrier", Image = "photo05.jpg" },
            new Person{ FirstName = "Minna", LastName = "Amigon", Image = "photo06.jpg" },
            new Person{ FirstName = "Abel", LastName = "Maclead", Image = "photo07.jpg" },
            new Person{ FirstName = "Kiley", LastName = "Caldarera", Image = "photo08.jpg" },
            new Person{ FirstName = "Graciela", LastName = "Ruta", Image = "photo09.jpg" },
            new Person{ FirstName = "Cammy", LastName = "Albares", Image = "photo10.jpg" },
            new Person{ FirstName = "Mattie", LastName = "Poquette", Image = "photo11.jpg" },
            new Person{ FirstName = "Meaghan", LastName = "Garufi", Image = "photo12.jpg" }
        };

        public static IList<Person> GetAll()
        {
            return Persons;
        }

        public static Person GetByIndex(int index)
        {
            return Persons[index];
        }
    }
}
