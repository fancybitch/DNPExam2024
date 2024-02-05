using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EFC.Entities;

public class Player
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string? Phone { get; set; }
    public double MembershipFee { get; set; }
    public string MembershipType { get; set; }
    [JsonIgnore]
    public ICollection<HoleScore> HoleScores { get; set; }
    
    public Player()
    {
        //empty
    }
}