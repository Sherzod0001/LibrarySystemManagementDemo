using System.Collections.Generic;
using LibrarySystemManagementDemo.Models;
using static LibrarySystemManagementDemo.Models.BookModel;

namespace LibrarySystemManagementDemo.Services
{
    internal class bookService
            {
                book.Author = updatedBook.Author;
                book.Name = updatedBook.Name;
            }
        }

        // Kitobni qidirish metod
        public Book FindBook(string name)
        {
            return books.Find(b => b.Name == name);
        }

        // Barcha kitoblarni ro'yxatini qaytarish metod
        public List<Book> GetAllBooks()
        {
            return new List<Book>(books);
        }
    }
}
