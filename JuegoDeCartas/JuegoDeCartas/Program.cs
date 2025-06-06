using JuegoDeCartas.Interfaces;
using JuegoDeCartas.Modelos;
using JuegoDeCartas.Servicios;

class Program
{
  public static void Main(string[] args)
  {
    IShuffler shuffler = new Shuffler();
    IDealer dealer = new Dealer(shuffler);

    Deck deck = new Deck();
    dealer.Shuffle(deck);

    var players = new List<Player>
    {
      new Player("Michael"),
      new Player("Alexander")
    };

    dealer.Deal(deck, players, 5);
    
    foreach(var player in players) 
    {
      Console.WriteLine($"\n{player.Name} recibio: ");
      foreach(var card in player.Hand)
      {
        Console.WriteLine($"- {card}");
      }
    }
  }
}
