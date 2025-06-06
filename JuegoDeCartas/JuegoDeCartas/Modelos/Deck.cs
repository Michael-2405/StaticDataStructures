using JuegoDeCartas.Enums;

namespace JuegoDeCartas.Modelos
{
  public class Deck
  {
    private readonly List<Card> _cards;

    public Deck()
    {
      _cards = new List<Card>();
      foreach(Suit suit in Enum.GetValues(typeof(Suit)))
      {
        foreach(Rank rank in Enum.GetValues(typeof(Rank)))
        {
          _cards.Add(new Card(suit, rank));
        }
      }
    }

    public List<Card> Cards => _cards;

    public Card DrawCard()
    {
      if(_cards.Count == 0)
      {
        throw new InvalidOperationException("El mazo ta vacio");
      }

      var card = _cards[0];
      _cards.RemoveAt(0);
      return card;
    }
  }
}
