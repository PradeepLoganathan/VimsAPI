namespace VimsAPI;
public class Driver
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string LicenseNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string ContactNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string LicenseClass { get; set; }
    public DateTime LicenseExpiryDate { get; set; }
    public bool IsActive { get; set; }

    public Driver(string firstName, string lastName, string licenseNumber, DateTime dateOfBirth, string contactNumber, string email, string address, string licenseClass, DateTime licenseExpiryDate, bool isActive)
    {
        FirstName = firstName;
        LastName = lastName;
        LicenseNumber = licenseNumber;
        DateOfBirth = dateOfBirth;
        ContactNumber = contactNumber;
        Email = email;
        Address = address;
        LicenseClass = licenseClass;
        LicenseExpiryDate = licenseExpiryDate;
        IsActive = isActive;
    }

    // Additional methods or properties can be added as needed.
}