public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public string GetStreet()
    {
        return street;
    }

    public void SetStreet(string street)
    {
        this.street = street;
    }

    public string GetCity()
    {
        return city;
    }

    public void SetCity(string city)
    {
        this.city = city;
    }

    public string GetState()
    {
        return state;
    }

    public void SetState(string state)
    {
        this.state = state;
    }

    // Getter and Setter for Country
    public string GetCountry()
    {
        return country;
    }

    public void SetCountry(string country)
    {
        this.country = country;
    }

    // Method to get the full address
    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}
