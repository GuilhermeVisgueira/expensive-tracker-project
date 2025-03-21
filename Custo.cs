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

    public void ChangeDescription(string newDescription)
    {
        Description = newDescription;
    }

    public void ChangeAmount(double newAmount)
    {
        Amount = newAmount;
    }

    

    
    
    /// <summary>
    /// Construtor
    /// </summary>
    /// <param name="id"> id do cadastro </param>
    /// <param name="description"> oq é </param>
    /// <param name="amount"> valor </param>
    public Custo(int id, string description, double amount)
    {
        _id = id;
        Description = description;
        Amount = amount;
        Date = DateTime.Now;
    }

    
}