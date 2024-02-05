
using Blazor.Domain.Data;
using Blazor.Domain.Models;

namespace Blazor;

public class PlayerService
{
    public List<Player> GetPlayers()
    {
        return PlayerData.Players;
    }

    public void AddPlayer(Player player)
    {
        PlayerData.Players.Add(player);
        Console.WriteLine(PlayerData.Players.Count);
        
    }
    
    
}