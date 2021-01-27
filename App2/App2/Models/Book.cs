using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();
            // seeding data here
            books.Add(new Book {BookId =1,Title = "Vulpate",Author = "1",CoverImage = "Assets/1.png" });
            books.Add(new Book {BookId =2,Title = "Vulpate2",Author = "2",CoverImage = "Assets/2.png" });
            books.Add(new Book {BookId =3,Title = "Vulpate3",Author = "3",CoverImage = "Assets/3.png" });
            books.Add(new Book {BookId =4,Title = "Vulpate4",Author = "4",CoverImage = "Assets/4.png" });
            books.Add(new Book {BookId =5,Title = "Vulpate5",Author = "5",CoverImage = "Assets/5.png" });
            books.Add(new Book {BookId =6,Title = "Vulpate6",Author = "6",CoverImage = "Assets/6.png" });
            books.Add(new Book {BookId =7,Title = "Vulpate7",Author = "7",CoverImage = "Assets/7.png" });
            books.Add(new Book {BookId =8,Title = "Vulpate8",Author = "8",CoverImage = "Assets/8.png" });
            books.Add(new Book {BookId =9,Title = "Vulpate9",Author = "9",CoverImage = "Assets/9.png" });
            books.Add(new Book {BookId =10,Title = "Vulpate10",Author = "10",CoverImage = "Assets/10.png" });
            books.Add(new Book {BookId =11,Title = "Vulpate11",Author = "11",CoverImage = "Assets/11.png" });
            books.Add(new Book {BookId =12,Title = "Vulpate12",Author = "12",CoverImage = "Assets/12.png" });
            books.Add(new Book {BookId =13,Title = "Vulpate13",Author = "13",CoverImage = "Assets/13.png" });
            return books;
        }
    }
}
