    internal class Program
    {
        static void Main()
        {
            Book book0 = new Book();
            book0.SetBook("Л.Н.Толстой", "Война и мир", 1300, 1869);
            Book book1 = new Book();
            book1.SetBook("Дж.Р.Р. Толкин", "Братство кольца", 480, 1954);
            Book book2 = new Book();
            book2.SetBook("Ф.Герберт", "Дюна", 704, 1965);
            Book book3 = new Book();
            book3.SetBook("Д. Симмонс", "Гиперион", 703, 1989);

            Book[] books = { book1, book3, book0, book2 };
            Array.Sort(books);

            foreach (Book item in books)
            {
                item.Show();
            }
        }
    }
