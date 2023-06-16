Dealer dealer = new Dealer();

List<Card> hand = dealer.DealHand();

Console.WriteLine("Your hand:");
foreach (Card card in hand)
{
    Console.BackgroundColor = ConsoleColor.White;

    // == and || are operators - they return a Boolean (true or false)
    if (card.Suit == Suit.Hearts ||
        card.Suit == Suit.Diamonds)
        Console.ForegroundColor = ConsoleColor.Red;
    else
        Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine(card);
}
Console.WriteLine("\n");

for (int i = 0; i < 60; i++)
{
    Card card = dealer.Deal();

    if (card != null)
    {
        if (card.Suit == Suit.Hearts ||
        card.Suit == Suit.Diamonds)
            Console.ForegroundColor = ConsoleColor.Red;
        else
            Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(card);
    }
    else
    {
        Console.WriteLine("Out of cards!");

        Console.WriteLine("Do you want to refill the deck?");
        string answer = Console.ReadLine().ToLower();
        if (answer == "y" || answer == "yes")
            dealer.FillDeck();
        else
        {
            Console.WriteLine("Ok.");
            break;
        }
    }
}
