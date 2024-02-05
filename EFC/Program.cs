// See https://aka.ms/new-console-template for more information

using EFC;
using EFC.Entities;



        using var db = new PlayerContext();

        PlayerLogic playerLogic = new PlayerLogic(db);
        HoleScoreLogic holeScoreLogic = new HoleScoreLogic(db);
        Player player = new Player();
        player.Name = "Ola";
        player.MembershipType = "Basic";
        player.MembershipFee = 600.00;
        player.Age = 56;

        
        //await playerLogic.CreateAsync(player);
        //Console.WriteLine("Added player");

        Console.WriteLine("Querying for this player");
        Player? plays = playerLogic.GetPlayerByName(1);
        Console.WriteLine("Player found" + plays.Name);

        HoleScore hole = new HoleScore();
        hole.HoleId = 14;
        hole.PlayerId = 1;
        hole.RoundId = 13;
        hole.NumOfStrikes = 12;
        await holeScoreLogic.CreateAsync(hole);
        Console.WriteLine("Added hole ");



        Console.WriteLine("Took average number of strikes");
        Task<Double> number = holeScoreLogic.GetAverageNumberOfStrikes(14);
        Console.WriteLine(number.Result);



        Console.WriteLine("Took the sum  of strikes");
        Task<Int32> number2 = holeScoreLogic.GeSumOfStrikes(13, 1);
        Console.WriteLine(number2.Result);


        Console.WriteLine("Calculated Handicap");
        Task<double> handy = holeScoreLogic.CalculateHandicap( 1);
        Console.WriteLine(handy.Result);
