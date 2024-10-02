namespace stacks_conway_david
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card[] myCardsArry = new Card[]
            {
                new Card("Ace","Spades"),
                new Card("Jack","Clubs"),
                new Card("Queen","Dimonds"),
                new Card("Queen","Dimonds"),
                new Card("10","Hearts"),
                new Card("2","Dimonds"),
                new Card("6","Spades"),
                new Card("9","Clubs"),
                new Card("Ace","Dimonds")
            };

            Stack<Card> startingDeck = new Stack<Card>(myCardsArry);

            Console.WriteLine("cards in deck:");
            foreach(Card card in startingDeck) 
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

            Console.WriteLine($"cards in the deck: {startingDeck.Count}");

            List<Card> myHand = new List<Card>(myCardsArry);
            myHand.Add(new Card("Jack", "Diamonds"));
            myHand.Add(new Card("8", "Hearts"));
            myHand.Add(new Card("3", "Diamonds"));

            Console.WriteLine("got any 8's?");
            if (startingDeck.Count > 0 ) 
            { 
                myHand.Add(startingDeck.Pop());
            }

            Console.WriteLine($"cards in the stack: {startingDeck.Count}");

            startingDeck.Push(myHand[0]);
            myHand.RemoveAt(0);

            Console.WriteLine("cards in deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

        }
    }
}