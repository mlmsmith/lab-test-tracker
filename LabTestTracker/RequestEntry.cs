namespace LabTestTracker;

public class RequestEntry
{
    public Patient CreatePatient(int age)
    {
        Patient patient = new Patient(age);
        return patient;
    }

    /*public int GenerateLabNumber()
    {
        
    }*/
}