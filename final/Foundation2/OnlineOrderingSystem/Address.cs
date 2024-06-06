public class Address
{
    private string streetAddress;
    private string city;
    private string stateOrProvince;
    private string country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    public string StreetAddress { get { return streetAddress; } }
    public string City { get { return city; } }
    public string StateOrProvince { get { return stateOrProvince; } }
    public string Country { get { return country; } }

    public bool IsInUSA()
    {
        return country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"{streetAddress}\n{city}, {stateOrProvince}\n{country}";
    }
}
