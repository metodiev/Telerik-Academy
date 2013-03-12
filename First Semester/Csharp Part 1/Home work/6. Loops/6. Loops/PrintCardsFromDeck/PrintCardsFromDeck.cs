using System;

//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
//The cards should be printed with their English names. Use nested for loops and switch-case.

class PrintCardsFromDeck
{
    static void Main()
    {
        string[] cardsNames = {"Two","Three","Four","Five","Six","Seven","Eight",
        "Nine","Ten","Jack","Queen","King","Ace"};

        string[] cardsSuits = { "Spades", "Hearts", "Diamonds", "Clubs" };

        for (int i = 0; i < cardsNames.Length; i++)
        {
            for (int j = 0; j < cardsSuits.Length; j++)
            {
                switch (j)
                {
                    case 0: Console.WriteLine("{0} of {1}", cardsNames[i], cardsSuits[j]);
                        break;
                    case 1: Console.WriteLine("{0} of {1}", cardsNames[i], cardsSuits[j]);
                        break;
                    case 2: Console.WriteLine("{0} of {1}", cardsNames[i], cardsSuits[j]);
                        break;
                    case 3: Console.WriteLine("{0} of {1}", cardsNames[i], cardsSuits[j]);
                        break;
                    case 4: Console.WriteLine("{0}  of {1}", cardsNames[i], cardsSuits[j]);
                        break;
                    default: Console.WriteLine("Error");
                        break;
                }
            }
        }
    }
}

