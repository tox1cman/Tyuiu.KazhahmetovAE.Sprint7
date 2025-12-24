using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
namespace Tyuiu.Kazhahmetov.Sprint7.V4.Lib
{
    public class Book
    {
        public string Title { get; set; } //Название
        public string Author { get; set; } //Автор
        public int Year { get; set; } //Год издания
        public string Genre { get; set; } //Жанр книги
        public DateTime DateAdded { get; set; } // Дата добавления
        public string Notes { get; set; } // Заметки



        public Book() // Конструктор по умолчанию
        {
            Genre = "Не указан";
            DateAdded = DateTime.Now;
            Notes = "";
        }

        public Book(string title, string author, int year, string genre) // Основной конструктор
        {
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
            DateAdded = DateTime.Now;
            Notes = "";
        }

        public override string ToString() // Строковое представление книги
        {
            return $"{Title} ({Author}, {Year})";
        }
    }



    public class LibraryService
    {
        private List<Book> books = new List<Book>(); // Список книг


        public LibraryService() // Инициализация библиотеки
        {
            books = new List<Book>();
        }



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

        public void AddTestBooks() // Тестовые книги
        {
            books.Add(new Book("Война и мир", "Толстой Л.Н. ", 1869, "Роман"));
            books.Add(new Book("Преступление и наказание", "Достоевский Ф.М.", 1866, "Роман"));
            books.Add(new Book("Мастер и Маргарита", "Булгаков М.А.", 1967, "Фэнтези"));
        }

        public void RemoveBookAt(int index) // Удаляет книгу по индексу
        {
            if (index >= 0 && index < books.Count)
            {
                books.RemoveAt(index);
            }
        }

        public bool RemoveBook(Book book) // Удаляет конкретный обьект книги
        {
            bool removedFromBooks = books.Remove(book);
            return removedFromBooks;
        }

        public Book GetBookAt(int index) // Получает книгу по индексу
        {
            if (index >= 0 && index <= books.Count)
            {
                return books[index];
            }
            return null;
        }



        public void SaveToCSV(string filePath) // Сохраняет все книги в CSV
        {
            using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.UTF8))
            {
                sw.WriteLine("Название;Автор;Год;Жанр;ДатаДобавления;Заметки");

                foreach (var book in books)
                {
                    string title = book.Title.Replace("\"", "\"\"");
                    string author = book.Author.Replace("\"", "\"\"");
                    string genre = book.Genre.Replace("\"", "\"\"");
                    string notes = book.Notes.Replace("\"", "\"\"");
                    sw.WriteLine($"\"{title}\";\"{author}\";{book.Year};\"{genre}\";{book.DateAdded:yyyy-MM-dd HH:mm:ss};\"{notes}\"");
                }
            }
        }

        public void LoadFromCSV(string filePath) // Загружает книги из CSV
        {
            books.Clear();

            if (!File.Exists(filePath)) return;

            string[] lines = File.ReadAllLines(filePath, System.Text.Encoding.UTF8);

            bool hasDateColumn = lines.Length > 0 && lines[0].Contains("ДатаДобавления");
            bool hasNotesColumn = lines.Length > 0 && lines[0].Contains("Заметки");


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
                        
                        //Загружаем дату если есть
                        if (hasDateColumn && parts.Length >= 5 && !string.IsNullOrEmpty(parts[4]))
                        {
                            try { book.DateAdded = DateTime.Parse(RemoveQuotes(parts[4])); }
                            catch { book.DateAdded = DateTime.Now; }
                        }
                        else
                        {
                            book.DateAdded = DateTime.Now;
                        }

                        //Загружаем заметки если есть
                        if (hasNotesColumn && parts.Length >= 6)
                        {
                            book.Notes = RemoveQuotes(parts[5]);
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

        private string[] SplitCSVLine(string line) // Разделяет строку на части с учетом кавычек
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

        private string RemoveQuotes(string text) // Удаляет кавычки
        {
            return text.Trim().Trim('"').Replace("\"\"", "\"");
        }




        public void SortBooksByTitle(bool ascending = true) // Сортировка по названию
        {
            if (ascending)
                books = books.OrderBy(b => b.Title).ToList();
            else
                books = books.OrderByDescending(b => b.Title).ToList();
        }

        public void SortBooksByAuthor(bool ascending = true) // Сортировка по автору
        {
            if (ascending)
                books = books.OrderBy(b => b.Author).ToList();
            else
                books = books.OrderByDescending(b => b.Author).ToList();
        }

        public void SortBooksByYear(bool ascending = true) // Сортировка по году
        {
            if (ascending)
                books = books.OrderBy(b => b.Year).ToList();
            else
                books = books.OrderByDescending(b => b.Year).ToList();
        }
        public void SortBooksByDateAdded(bool ascending = true) // Сортировка по дате добавления
        {
            if (ascending)
                books = books.OrderBy(b => b.DateAdded).ToList(); 
            else
                books = books.OrderByDescending(b => b.DateAdded).ToList(); 
        }


        public bool UpdateBook(Book oldBook, Book updateBook) // Обновление данных о книге
        {
            int index = books.IndexOf(oldBook);
            if (index >= 0)
            {
                updateBook.DateAdded = oldBook.DateAdded;

                books[index] = updateBook;

                return true;
            }

            return false;
        }
    }




}