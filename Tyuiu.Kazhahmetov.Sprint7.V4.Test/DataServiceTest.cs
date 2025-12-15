using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Kazhahmetov.Sprint7.V4.Lib;
namespace Tyuiu.Kazhahmetov.Sprint7.V4.Test
{
    [TestClass]
    public sealed class Day1Test
    {
        [TestMethod]
        public void TestBookCreation()
        {
            Book book = new Book("Война и мир", "Толстой", 1869, "Роман");

            Assert.AreEqual("Война и мир", book.Title);
            Assert.AreEqual("Толстой", book.Author);
            Assert.AreEqual(1869, book.Year);
            Assert.AreEqual("Роман", book.Genre);
        }

        [TestMethod]
        public void TestBookToString()
        {
            Book book = new Book("Мастер и Маргарита", "Булгаков", 1967, "Фэнтези");

            string result = book.ToString();

            Assert.IsTrue(result.Contains("Мастер и Маргарита"));
            Assert.IsTrue(result.Contains("Булгаков"));
            Assert.IsTrue(result.Contains("1967"));
        }

        [TestMethod]
        public void TestBookServiceAddBook()
        {
            LibraryService ls = new LibraryService();
            Book book = new Book("Книга", "Автор", 2023, "Тест");

            ls.AddBook(book);
            ls.AddTestBooks();
            Assert.AreEqual(4, ls.GetBookCount());
        }
    }
}
