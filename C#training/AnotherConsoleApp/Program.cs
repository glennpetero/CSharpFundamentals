Console.WriteLine("Hello, Crazy World!");

Player player = new() { Name = "Alice", Score = 100 };
player.CallPlayer(player);

class Player
{
    public string Name { get; set; }
    public int Score { get; set; }

    public void CallPlayer(Player player)
    {
        Console.WriteLine($"*** Player: {player.Name}, Score: {player.Score}");
    }
}




