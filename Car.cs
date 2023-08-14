public class Car
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string ChasisNo { get; set; }
    public string CarName { get; set; }
    public string CompanyName { get; set; }
    public string CarType { get; set; }

    public Car()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        EmailAddress = string.Empty;
        ChasisNo = string.Empty;
        CarName = string.Empty;
        CompanyName = string.Empty;
        CarType = string.Empty;
    }
}
