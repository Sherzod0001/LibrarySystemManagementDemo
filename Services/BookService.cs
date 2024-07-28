using System.Collections.Generic;
using LibrarySystemManagementDemo.Models;
using static LibrarySystemManagementDemo.Models.BookModel;

namespace LibrarySystemManagementDemo.Services
{
    public class BookService
    {
        private List<Book> books = new List<Book>();

        // Kitob qo'shish metod
        public void AddBook(Book newBook)
        {
            books.Add(newBook);
        }

        // Kitob o'chirish metod
        public void RemoveBook(string name)
        {
            var book = books.Find(b => b.Name == name);
            if (book != null)
            {
                books.Remove(book);
            }
        }

        // Kitobni yangilash metod
        public void UpdateBook(string name, Book updatedBook)
        {
            var book = books.Find(b => b.Name == name);
            if (book != null)
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
