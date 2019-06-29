using System.Collections.Generic;
using System.Diagnostics;
using GoldAdmin.Entity;

[assembly: DebuggerDisplay("Nombre de Usuario: {Username} Es Pérez?: {LastName == \"Pérez\"}", Target = typeof(User))]

namespace DebuggerDisplay
{
    public class Library
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<User> Users { get; set; }

        public void Initialize()
        {
            Books = LoadBooks();
            Users = LoadUsers();
        }

        #region Private Methods
        private List<Book> LoadBooks()
        {
            return new List<Book>()
            {
                new Book(){Id = 1, Author = "", Title = "Don Quijote de la Mancha", Year = 1605 },
                new Book(){Id = 2, Author = "Charles Dickens", Title = "Historia de dos ciudades", Year = 1859},
                new Book(){Id = 14, Author = "Antoine de Saint-Exupéry", Title = "Le Petit Prince", Year = 1943},
                new Book(){Id = 15, Author = "J. R. R. Tolkien", Title = "El hobbit", Year = 1937},
                new Book(){Id = 16, Author = "Cao Xueqin", Title = "Sueño en el pabellón rojo", Year = 1791},
                new Book(){Id = 17, Author = "Lewis Carroll", Title = "Las aventuras de Alicia en el país de las maravillas", Year = 1865},
                new Book(){Id = 28, Author = "Jiang Zemin ", Title = "La triple representatividad", Year = 2003},
                new Book(){Id = 29, Author = "Agatha Christie", Title = "Ten little niggers", Year = 1939},
                new Book(){Id = 210, Author = "C. S. Lewis", Title = "The Lion, the Witch and the Wardrobe", Year = 1984},
                new Book(){Id = 211, Author = " H. Rider Haggard", Title = "She", Year = 1886},
                new Book(){Id = 212, Author = "Dan Brown", Title = "El código Da Vinci", Year = 2003},
                new Book(){Id = 13, Author = "J. D. Salinger", Title = "The Catcher in the Rye", Year = 1951},
                new Book(){Id = 14, Author = "Paulo Coelho", Title = "Alquimista", Year = 1988},
                new Book(){Id = 15, Author = "Johanna Spyri", Title = "Heidis Lehr- und Wanderjahre", Year = 1880 },
                new Book(){Id = 16, Author = "J. R. R. Tolkien", Title = "The Lord of the Rings", Year = 1954},

            };
        }

        private List<User> LoadUsers()
        {
            return new List<User>()
            {
                new User(){Username  = "tomi234", Name = "Tomás", LastName = "Rodríguez"},
                new User(){Username  = "jazmiin234", Name = "Jazmín", LastName = "Pérez"},
                new User(){Username  = "naniitevez", Name = "Nicole", LastName = "Tévez"},
            };
        }
        #endregion
    }
}
