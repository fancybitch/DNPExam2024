namespace Blazor.Domain.Models;

public class Player
{
   

    public string Name { get; set; }
    public int Age { get; set; }
    public string? Phone { get; set; }
    public double MembershipFee { get; set; }
    public string MembershipType { get; set; }
    
    public IList<HoleScore> HoleScores { get; set; }
    
}

