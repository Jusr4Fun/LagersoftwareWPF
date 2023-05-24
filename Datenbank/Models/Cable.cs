namespace Datenbank.Models;

public class Cable : Item
{
    public double Length { get; set; }
    public int CableTypeID { get; set; }
    public CableType CableType { get; set; }
}
