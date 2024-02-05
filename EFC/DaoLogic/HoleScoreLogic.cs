using EFC.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EFC;

public class HoleScoreLogic
{
    private readonly PlayerContext context;

    public HoleScoreLogic(PlayerContext context)
    {
        this.context = context;
    }

    public async Task<HoleScore> CreateAsync(HoleScore player)
    {
        EntityEntry<HoleScore> newPolygon = await context.HoleScores.AddAsync(player);
        try
        {
            await context.SaveChangesAsync();
        }

        catch(Exception e)
        {
            Console.WriteLine(e);
        }

        return newPolygon.Entity;
    }
    public  HoleScore? GetHoleScoreById(int holeid )
    {
        
        return context.HoleScores.FirstOrDefault(u => u.HoleId == holeid);
        

    }

    public async Task<IEnumerable<HoleScore>> GetAllHoleScores()
    {
        IQueryable<HoleScore> query = context.HoleScores;
        
        List<HoleScore> allPolygons = await query.ToListAsync();

        return allPolygons;
    }

    public async Task<double> GetAverageNumberOfStrikes(int holeid)
    {
        return context.HoleScores
            .Where(u => u.HoleId == holeid)
            .Average(r => r.NumOfStrikes);
     
       
       
    }
    
    public async Task<int> GeSumOfStrikes(int roundid, int id)
    {
        return context.HoleScores
            .Where(u => u.PlayerId == id)
            .Where(u => u.RoundId == roundid)
            .Sum(r => r.NumOfStrikes);
    }
    
    public async Task<double> CalculateHandicap(int id)
    {
        int sumofstrikes =  context.HoleScores
            .Where(u => u.PlayerId == id)
            .Sum(r => r.NumOfStrikes);
        IQueryable<HoleScore> count =  context.HoleScores.Where(u => u.PlayerId == id);
        
        Console.WriteLine(sumofstrikes);
        Console.WriteLine(count.Count());
        int triple = 3 * count.Count();
        return (sumofstrikes-triple)/count.Count();
    }
}