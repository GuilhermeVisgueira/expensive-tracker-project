using System.Net.Sockets;

namespace ExpenseTracker;

public class Custo
{
    public double Amount { private set; get; }
    public string Description { private set; get; } = string.Empty;
    public DateTime Date { private set; get; }
    private int _id;
    
    public int GetId()
    {
        return _id;
    }

    public Custo(int id, string description, double amount)
    {
        _id = id;
        Description = description;
        Amount = amount;
        Date = DateTime.Now;
    }

    
}