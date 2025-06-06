using JuegoDeCartas.Modelos;

namespace JuegoDeCartas.Interfaces
{
  public interface IDealer
  {
    void Shuffle(Deck deck);
    void Deal(Deck deck, List<Player> players, int cardPerPlayer);
  }
}
