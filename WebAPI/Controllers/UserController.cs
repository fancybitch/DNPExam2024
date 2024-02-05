using Blazor.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;


[ApiController]
[Route("[controller]")]
public class UserController: ControllerBase
{
    
    private static List<Player> playerList = new()
    {
        new Player
        {
            Name = "John Doe",
            Age = 25,
            Phone = "123-456-7890",
            MembershipFee = 100.00,
            MembershipType = "Standard",
            HoleScores = new List<HoleScore>
            {
                new HoleScore(1,2,3),
                new HoleScore(1,2,3),
                
            }
        },
        new Player
        {
            Name = "Jane Doe",
            Age = 25,
            Phone = "123-456-7890",
            MembershipFee = 100.00,
            MembershipType = "Standard",
            HoleScores = new List<HoleScore>
            {
                new HoleScore(1,2,3),
                new HoleScore(1,2,3),
                
            }
        },
    };

   


    [HttpPost]
    public async Task<ActionResult<Player> >Create([FromBody] Player player)
    {
        try
        {
            playerList.Add(player);
            return Created($"/players/{player.Name}", player);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpGet]
    public async Task<ActionResult<IList<Player>>> GetAsync(
        [FromQuery] string? name)
    {
        try
        {
            IEnumerable<Player> result = playerList
                .Where(player => 
                    (name == null || player.Name.Equals(name)) 
                    
                );
                    List<Player> list = result.ToList();
            return Ok(list);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
    
       
    [HttpPost("{name}/scores")]
    public ActionResult<Player> AddScore([FromRoute] string name, [FromBody] HoleScore holeScore)
    {
        try
        {
            Player? player = playerList.FirstOrDefault(player => player.Name.Equals(name));
            if (player == null)
            {
                return NotFound($"Player with name: {name} was not found");
            }
            player.HoleScores.Add(holeScore);
            return Ok(player);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}