    internal class Book : IComparable
    {
        public string author { get; private set; }
        public string title { get; private set; }
        public int pages { get; private set; }
        public int year { get; private set; }

        public void SetBook(string author, string title, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
            this.year = year;
        }

        public void Show()
        {
            Console.WriteLine($"\nКнига: \n Автор: {author} \n Название: {title}\n Год издания: {year} \n {pages} стр.");
        }

        public int CompareTo(object obj)
        {
            Book otherBook = obj as Book;
            if (otherBook == null || year > otherBook.year)
            {
                return 1;
            }
            else if (year == otherBook.year)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }


    }
