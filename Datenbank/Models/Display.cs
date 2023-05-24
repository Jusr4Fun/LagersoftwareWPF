namespace Datenbank.Models;

public class Display : Device
{ 
    public int ScreenSizeID { get; set; }
    public ScreenSize ScreenSize { get; set; }
}