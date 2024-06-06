public class Reception : Event
{
    public string RSVPEmail { get; private set; }

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RSVPEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {RSVPEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Reception\nTitle: {Title}\nDate: {Date}";
    }
}
