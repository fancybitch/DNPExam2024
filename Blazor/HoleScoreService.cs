using Blazor.Domain.Data;
using Blazor.Domain.Models;

namespace Blazor;

public class HoleScoreService
{
    public List<HoleScore> GetHoleScores()
    {
        return HoleScoreData.HoleScores;
    }

    public void AddHoleScore(HoleScore holeScore)
    {
        HoleScoreData.HoleScores.Add(holeScore);
    }
}