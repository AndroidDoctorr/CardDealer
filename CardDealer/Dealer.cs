public class Dealer
{
    // Field (because private - use underscore and lowercase)
    private List<Card> _deck = new List<Card>();

    // Constructor = constructs an object
    public Dealer()
    {
        FillDeck();
    }


    public Card Deal()
    {
        if (_deck.Count == 0) return null;

        // Choose a random card from the deck and return it
        Random rng = new Random();
        int selection = rng.Next(_deck.Count);

        Card card = _deck[selection];
        _deck.Remove(card);

        return card;
    }

    public List<Card> DealHand()
    {
        return DealHand(5);
    }
    public List<Card> DealHand(int number)
    {
        List<Card> hand = new List<Card>();
        for (int i = 0; i < number; i++)
        {
            Card card = Deal();
            hand.Add(card);
        }
        return hand;
    }

    public void FillDeck()
    {
        _deck.Clear();
        // Add 52 cards to the Deck
        for (int s = 0; s < 4; s++)
        {
            // For each suit
            // Nested loop:
            FillSuit(s);
            // Moved the loop to another method so it's easier to read
            // The code runs exactly the same way either way
        }
    }

    private void FillSuit(int s)
    {
        for (int v = 1; v <= 13; v++)
        {
            // Add a card
            Card card = new Card(s, v);

            // Card card = new Card();
            // Cast
            // card.Suit = (Suit) s;
            // card.Value = v;

            _deck.Add(card);
        }
    }
}