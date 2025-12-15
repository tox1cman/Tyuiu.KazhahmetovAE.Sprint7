using System;
using System.Collections.Generic;
namespace Tyuiu.Kazhahmetov.Sprint7.V4.Lib
{
    public class Book
    {
        public string Title {  get; set; } //Название
        public string Author { get; set; } //Автор
        public int Year {  get; set; } //Год издания
        public string Genre {  get; set; } //Жанр книги



        public Book()
        {
            Genre = "Не указан";
        }

        public Book(string title, string author, int year, string genre)
        {
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{Title} ({Author}, {Year})";
        }
    }


    public class LibraryService
    {
        private List<Book> books = new List<Book>(); // Список книг

        public void AddBook(Book book) // Добавить книгу
        {
            books.Add(book);
        }

        public List<Book> GetAllBooks() // Получить все книги
        {
            return books;
        }

        public int GetBookCount() // Количество книг
        {
            return books.Count;
        }

        public void AddTestBooks()
        {
            books.Add(new Book("Война и мир", "Толстой Л.Н. ", 1869, "Роман"));
            books.Add(new Book("Преступление и наказание", "Достоевский Ф.М.", 1866, "Роман"));
            books.Add(new Book("Мастер и Маргарита", "Булгаков М.А.", 1967, "Фэнтези"));
        }
    }
}
