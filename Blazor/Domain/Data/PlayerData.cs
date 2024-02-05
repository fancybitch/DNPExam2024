using Blazor.Domain.Models;

namespace Blazor.Domain.Data;

public static class PlayerData
{
    public static List<Player> Players { get; set; } = new List<Player>
    {
        new Player
        {
            Name = "John Doe",
            Age = 25,
            Phone = "12345678",
            MembershipFee = 1000,
            MembershipType = "Full",
HoleScores = new List<HoleScore>
            {
                new HoleScore(1, 1, 3),
                new HoleScore(2, 1, 4),
                new HoleScore(3, 1, 5),
                new HoleScore(4, 1, 3),
                new HoleScore(5, 1, 4),
                new HoleScore(6, 1, 5),
                
            }
            
        },
        new Player
        {
            Name = "Jane Doe",
            Age = 25,
            Phone = "12345678",
            MembershipFee = 1000,
            MembershipType = "Full"
        },
        new Player
        {
            Name = "John Smith",
            Age = 25,
            Phone = "12345678",
            MembershipFee = 1000,
            MembershipType = "Full"
        }
    };
}
