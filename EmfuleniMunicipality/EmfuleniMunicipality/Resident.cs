public class Resident
{
    public string Name { get; set; }
    public string IdNumber { get; set; }
    public string AccountNumber { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    public int monthlyUseage { get; set; }
    public Resident(string name, string idNumber, string accountNumber, string address, string contactNumber, int monthlyUsage)
    {
        Name = name;
        IdNumber = idNumber;
        AccountNumber = accountNumber;
        Address = address;
        ContactNumber = contactNumber;
        monthlyUseage = monthlyUsage;
    }

    public String GetResidentInfo()
    {
        return $"Name: {Name}," +
            $" ID Number: {IdNumber}, " +
            $"\nAccount Number: {AccountNumber}, " +
            $"\nAddress: {Address}, " +
            $"\nContact Number: {ContactNumber}," +
            $"\nMonthly Usage: {monthlyUseage}";
    }
}
