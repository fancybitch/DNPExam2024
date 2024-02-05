namespace Blazor.Domain.Models;

public class HoleScore
{
   public int HoleId { get; set; }
   public int RoundId { get; set; }
   public int NumOfStrikes { get; set; }
   
   
   public HoleScore(int holeId, int roundId, int numOfStrikes)
   {
      HoleId = holeId;
      RoundId = roundId;
      NumOfStrikes = numOfStrikes;
     
   }

   
}