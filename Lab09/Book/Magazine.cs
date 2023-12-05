using System.Diagnostics;
using System.Numerics;

class Magazine : Item, IPubs
{
    private string volume;
    private int number;
    private string title;
    private int year;
    public bool IfSubs { get; set; }

    public Magazine(string volume, int number, string title, int year, int invNumber, bool taken) : base(invNumber, taken)
    { 
        this.volume = volume;
        this.number = number;
        this.title = title;
        this.year = year;
    }

    public Magazine() { }

    public override void Show()
    {
        Console.WriteLine(
        $"\nЖурнал:" +
        $"\nТом: {volume}" +
        $"\nНомер: {number}" +
        $"\nНазвание: {title}" +
        $"\nГод выпускка: {year}");
        base.Show();
    }

    public override void Return()
    {
        taken = true;
    }

    public void Subs()
    {
        Console.WriteLine($"Подписка на журнал {title}: {IfSubs}");
    }
}

