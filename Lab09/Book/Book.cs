class Book : Item
{
    private string author;
    private string title;
    private string publisher;
    private int pages;
    private int year;
    private static double price = 9;
    private bool returnSrok;

    public Book(string author, string title, string publisher, int pages, int year)
    {
        this.author = author;
        this.title = title;
        this.publisher = publisher;
        this.pages = pages;
        this.year = year;
    }
    public Book(string author, string title, string publisher, int pages, int year, long invNumber, bool taken) : base(invNumber, taken)
    {
        this.author = author;
        this.title = title;
        this.publisher = publisher;
        this.pages = pages;
        this.year = year;
    }

    public Book() { }

    static Book()
    {
        price = 10;
    }

    public static void SetPrice(double price)
    {
        Book.price = price;
    }

    public override void Show()
    { 
        Console.WriteLine(
        $"\nКнига:" +
        $"\nАвтор: {author}" +
        $"\nНазвание: {title}" +
        $"\nГод издание: {year}" +
        $"\n{pages} стр." +
        $"\nСтоимость аренды: {price}");
        base.Show();
    }

    public double PriceBook(int days)
    {
        double cust = price * days;
        return cust;
    }

    //public void TakeItem()
    //{
    //    if (this.IsAvailable())
    //    {
    //        this.Take();
    //    }
    //}

    public void ReturnSrok()
    { 
        returnSrok = true;
        //Console.WriteLine("Returnsrok");
    }

    public override void Return()
    {
        ReturnSrok();
        if (returnSrok == true)
        {
            taken = true;
            //Console.WriteLine("return flag");
        }
        else
        {
            taken = false;
            //Console.WriteLine("NO return flag");
        }
    }

}
