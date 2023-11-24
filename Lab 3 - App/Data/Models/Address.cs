namespace Data;

public class Address
{
    public string City { get; set; }
    public string Street { get; set; }

    //[RegularExpression("[0-9]{2}-[0-9]{3}")]
    public string PostalCode { get; set; }
    public string Region { get; set; }
}