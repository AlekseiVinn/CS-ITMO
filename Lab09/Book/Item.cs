using System.Threading.Channels;

abstract class Item
{
    protected long invNumber;
    protected bool taken;

    public Item(long invNumber, bool taken)
    { 
        this.invNumber = invNumber;
        this.taken = taken;
    }

    public Item()
    { 
        this.taken = true;
    }
    
    public bool IsAvailable()
    { 
        if (taken) return true;
        else return false;
    }

    public long GetInvNumber() => invNumber;

    private void Take() => taken = false;
    
    abstract public void Return();

    public virtual void Show() => Console.WriteLine(
        $"Состояние единицы хранения:\n" +
        $"Инвентарный номер: {invNumber},\n"+
        $"Наличие: {taken}.\n"
        );

    public void TakeItem()
    {
        if (this.IsAvailable())
        {
            this.Take();
        }
    }
}