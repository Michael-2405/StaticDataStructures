using JuegoDeCartas.Modelos;

namespace JuegoDeCartas.Interfaces
{
  public interface IShuffler
  {
    void Shuffle(List<Card> cards);
  }
}
