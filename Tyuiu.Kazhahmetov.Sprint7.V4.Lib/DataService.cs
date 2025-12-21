using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
namespace Tyuiu.Kazhahmetov.Sprint7.V4.Lib
{
    public class Book
    {
        public string Title { get; set; } //Название
        public string Author { get; set; } //Автор
        public int Year { get; set; } //Год издания
        public string Genre { get; set; } //Жанр книги
        public DateTime DateAdded { get; set; } // Дата добавления



        public Book()
        {
            Genre = "Не указан";
            DateAdded = DateTime.Now;
        }

        public Book(string title, string author, int year, string genre)
        {
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
            DateAdded = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Title} ({Author}, {Year})";
        }
    }



    public class LibraryService
    {
        private List<Book> books = new List<Book>(); // Список книг

        private List<Book> originalOrderBooks;

        public LibraryService()
        {
            books = new List<Book>();
            originalOrderBooks = new List<Book>();
        }



        public void AddBook(Book book) // Добавить книгу
        {
            books.Add(book);
            originalOrderBooks.Add(book);
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

        public void RemoveBookAt(int index)
        {
            if (index >= 0 && index < books.Count)
            {
                books.RemoveAt(index);
            }
        }

        public Book GetBookAt(int index)
        {
            if (index >= 0 && index <= books.Count)
            {
                return books[index];
            }
            return null;
        }



        public void SaveToCSV(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.UTF8))
            {
                sw.WriteLine("Название;Автор;Год;Жанр;ДатаДобавления");

                foreach (var book in books)
                {
                    string title = book.Title.Replace("\"", "\"\"");
                    sw.WriteLine($"\"{title}\";\"{book.Author}\";{book.Year};\"{book.Genre}\";{book.DateAdded:yyyy-MM-dd HH:mm:ss}");
                }
            }
        }

        public void LoadFromCSV(string filePath)
        {
            books.Clear();

            if (!File.Exists(filePath)) return;

            string[] lines = File.ReadAllLines(filePath, System.Text.Encoding.UTF8);

            bool hasDateColumn = lines.Length > 0 && lines[0].Contains("ДатаДобавления");

            for (int i = 1; i < lines.Length; i++)
            {
                try
                {
                    string[] parts = SplitCSVLine(lines[i]);

                    if (parts.Length >= 4)
                    {
                        Book book = new Book(
                            RemoveQuotes(parts[0]),
                            RemoveQuotes(parts[1]),
                            int.Parse(parts[2]),
                            RemoveQuotes(parts[3]));

                        if (hasDateColumn && parts.Length >= 5 && !string.IsNullOrEmpty(parts[4]))
                        {
                            try
                            {
                                book.DateAdded = DateTime.Parse(RemoveQuotes(parts[4]));
                            }
                            catch
                            {
                                book.DateAdded = DateTime.Now;
                            }
                        }
                        else
                        {
                            book.DateAdded = DateTime.Now;
                        }

                        books.Add(book);
                    }
                }

                catch
                {
                    continue;
                }
            }
        }

        private string[] SplitCSVLine(string line)
        {
            List<string> result = new List<string>();
            bool inQuotes = false;
            string current = "";

            foreach (char c in line)
            {
                if (c == '"')
                {
                    inQuotes = !inQuotes;
                }
                else if (c == ';' && !inQuotes)
                {
                    result.Add(current);
                    current = "";
                }
                else
                {
                    current += c;
                }
            }

            result.Add(current);
            return result.ToArray();
        }

        private string RemoveQuotes(string text)
        {
            return text.Trim().Trim('"').Replace("\"\"", "\"");
        }




        public void SortBooksByTitle(bool ascending = true)
        {
            if (ascending)
                books = books.OrderBy(b => b.Title).ToList();
            else
                books = books.OrderByDescending(b => b.Title).ToList();
        }

        public void SortBooksByAuthor(bool ascending = true)
        {
            if (ascending)
                books = books.OrderBy(b => b.Author).ToList();
            else
                books = books.OrderByDescending(b => b.Author).ToList();
        }

        public void SortBooksByYear(bool ascending = true)
        {
            if (ascending)
                books = books.OrderBy(b => b.Year).ToList();
            else
                books = books.OrderByDescending(b => b.Year).ToList();
        }
        public void SortBooksByDateAdded(bool ascending = true)
        {
            if (ascending)
                books = books.OrderBy(b => b.DateAdded).ToList(); 
            else
                books = books.OrderByDescending(b => b.DateAdded).ToList(); 
        }



    }




}