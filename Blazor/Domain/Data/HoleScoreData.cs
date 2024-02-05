using Blazor.Domain.Models;

namespace Blazor.Domain.Data;

public static class HoleScoreData
{
    public static List<HoleScore> HoleScores { get; set; } = GetHoleScores();

    private static List<HoleScore> GetHoleScores()
    {
        return new List<HoleScore>
        {
            new HoleScore(1, 1, 3),
            new HoleScore(2, 1, 4),
            new HoleScore(3, 1, 5),
            new HoleScore(4, 1, 3),
            
        };
    }
}