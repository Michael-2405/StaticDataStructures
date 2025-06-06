namespace JuegoDeCartas.Modelos
{
  public class Player
  {
    public string? Name { get; }
    public List<Card> Hand { get; }

    public Player(string name)
    {
      Name= name;
      Hand = new List<Card>();
    }

    public void ReceiveCard(Card card)
    {
      Hand.Add(card);
    }
  }
}
