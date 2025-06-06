using JuegoDeCartas.Interfaces;
using JuegoDeCartas.Modelos;

namespace JuegoDeCartas.Servicios
{
  public class Dealer : IDealer
  {
    private readonly IShuffler _shuffler;

    public Dealer(IShuffler shuffler)
    {
      _shuffler = shuffler;
    }

    public void Shuffle(Deck deck)
    {
      _shuffler.Shuffle(deck.Cards);
    }

    public void Deal(Deck deck, List<Player> players, int cardPerPlayer)
    {
      for(int i=0; i < players.Count; i++)
      {
        foreach (var player in players)
        {
          player.ReceiveCard(deck.DrawCard());
        }
      }
    }
  }
}
