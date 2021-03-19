using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] arrInput = input.Split(";");

                string teamName = arrInput[1];

                try
                {
                    switch (arrInput[0])
                    {
                        case "Team":
                            teams.Add(new Team(teamName));
                            break;

                        case "Add":
                            string playerName = arrInput[2];
                            Endurance endurance = new Endurance(byte.Parse(arrInput[3]));
                            Sprint sprint = new Sprint(byte.Parse(arrInput[4]));
                            Dribble dribble = new Dribble(byte.Parse(arrInput[5]));
                            Passing passing = new Passing(byte.Parse(arrInput[6]));
                            Shooting shooting = new Shooting(byte.Parse(arrInput[7]));

                            int counter = 0;

                            foreach (var team in teams)
                            {
                                if (team.Name == teamName)
                                {
                                    Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                                    
                                    team.AddPlayer(player);
                                    counter++;
                                }
                            }
                            if (counter == 0)
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                            }
                            break;

                        case "Remove":
                            string playerNamee = arrInput[2];
                            int counterr = 0;
                            foreach (var team in teams)
                            {
                                if (team.Name == teamName)
                                {
                                    foreach (var player in team.players)
                                    {
                                        if (player.Name == playerNamee)
                                        {
                                            team.RemovePlayer(player);
                                            counterr++;
                                            break;
                                        }

                                    }
                                    if (counterr == 0)
                                    {
                                        Console.WriteLine($"Player {playerNamee} is not in {team.Name} team.");

                                    }
                                }
                            }
                            break;

                        case "Rating":
                            int counterrr = 0;
                            
                            foreach (var team in teams)
                            {
                                if (team.Name == teamName)
                                {
                                    Console.WriteLine($"{team.Name} - {team.Rating}");
                                    counterrr++;
                                    break;
                                }                        
                            }

                            if (counterrr == 0)
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }
        }
    }
}
