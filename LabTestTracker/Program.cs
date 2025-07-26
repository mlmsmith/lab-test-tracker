namespace LabTestTracker;

public class Program
{
    public static void Main(string[] args)
    {
        var requestEntry = new RequestEntry();
        var patient = requestEntry.CreatePatient(50);
        
    }
}