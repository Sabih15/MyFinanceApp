namespace MyFinanceAppLibrary.Models;

public class ExpenseDetailsDTO
{
    #nullable disable
    public ulong Id { get; }
    public DateTime EDate { get;}
    public string BankDescription { get; }
    public string ECategoryDescription { get; }
    public string ECategoryColor { get; }
    public string Comments { get; }
    public decimal Amount { get; }
    public string Address { get; }
    #nullable enable
}
