using JuegoDeCartas.Interfaces;
using JuegoDeCartas.Modelos;

namespace JuegoDeCartas.Servicios
{
  public class Shuffler : IShuffler
  {
    private readonly Random _random = new Random();

    public void Shuffle(List<Card> cards)
    {
      int n = cards.Count;
      for (int i = n -1; i > 0; i--)
      {
        int j = _random.Next(n);
        (cards[i], cards[j]) = (cards[j], cards[i]);
      }
    }
  }
}
