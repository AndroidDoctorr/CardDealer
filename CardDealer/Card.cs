public enum Suit { Hearts, Diamonds, Spades, Clubs }

public class Card
{
    // Blank constructor
    public Card() { }
    // Full constructor
    public Card(Suit suit, int value)
    {
        Suit = suit;
        Value = value;
    }
    // Another overload (version)
    public Card(int suit, int value)
    {
        Suit = (Suit) suit;
        Value = value;
    }

    public Suit Suit { get; set; }
    public int Value { get; set; }
    public string Name
    {
        get
        {
            if (Value == 1) return "Ace";
            if (Value == 11) return "Jack";
            if (Value == 12) return "Queen";
            if (Value == 13) return "King";
            return Value.ToString();
        }

        /*
        get => Value switch
        {
            1 => "Ace",
            11 => "Jack",
            12 => "Queen",
            13 => "King",
            _ => Value.ToString(),
        };
        */
    }

    public override string ToString()
    {
        return $"{Name} of {Suit}";
    }
}
