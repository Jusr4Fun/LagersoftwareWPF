namespace Datenbank.Models;

public class StorageDevice : Device 
{ 
    public double Capacity { get; set; }
    public int FormFactorID { get; set; }

    public FormFactor FormFactor { get; set; }
}