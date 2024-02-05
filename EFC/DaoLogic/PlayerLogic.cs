using EFC.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EFC;

public class PlayerLogic
{
    private readonly PlayerContext context;

    public PlayerLogic(PlayerContext context)
    {
        this.context = context;
    }

    public async Task<Player> CreateAsync(Player player)
    {
        EntityEntry<Player> play = await context.Players.AddAsync(player);
        try
        {
            await context.SaveChangesAsync();
        }

        catch(Exception e)
        {
            Console.WriteLine(e);
        }

        return play.Entity;
    }
    public  Player? GetPlayerByName(int userid)
    {
        
        return context.Players.FirstOrDefault(u => u.Id == userid);
        

    }

    public async Task<IEnumerable<Player>> GetAllPlayers()
    {
        IQueryable<Player> query = context.Players;
        
        List<Player> allPolygons = await query.ToListAsync();

        return allPolygons;
    }
    
    
    public async void DeletePlayer(Player player)
    {
        context.Remove(player);
        try
        {
            await context.SaveChangesAsync();
        }

        catch(Exception e)
        {
            Console.WriteLine(e);
        }



    }
}