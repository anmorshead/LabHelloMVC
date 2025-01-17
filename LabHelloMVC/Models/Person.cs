namespace LabHelloMVC.Models;

public class Person
{
    // Primary key
    public int PersonId{ get; set; }
    
    public string FirstName { get;set; } = string.Empty;
    
    public string LastName { get;set; } = string.Empty;
}