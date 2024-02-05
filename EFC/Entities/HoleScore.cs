using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EFC.Entities;

[PrimaryKey(nameof(HoleId) , nameof(PlayerId), nameof(RoundId))]
public class HoleScore
{
    [Key]
    [Range(1, 15, ErrorMessage = "must be between x and y")]
    public int HoleId { get; set; }
    [Key]
    public int RoundId { get; set; }
    [Range(1, 10, ErrorMessage = "must be between x and y")]
    public int NumOfStrikes { get; set; }
    [Key]
    public int PlayerId { get; set; }
    
    public HoleScore()
    {
        //empty
    }
}