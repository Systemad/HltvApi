using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Fizzler.Systems.HtmlAgilityPack;
using System.Linq;
using System.Threading.Tasks;
using HltvApi.Models;
using HltvApi.Models.Enums;
using HltvApi.Parsing;

namespace HltvApi
{
    class Program
    {
        static void Main(string[] args)
        {
            //var task = HltvParser.GetMatch(2349612);

            var task = HltvParser.GetUpcomingMatches();
            /*
            foreach (var veto in task.Result.Vetos)
            {
                //Console.WriteLine($"{veto.Team.Name} {veto.Action} {veto.Map}");
                //Console.WriteLine($"{veto.Map} {veto.Action}");
                //Console.WriteLine($"{veto.Team.Name}");
                
                Console.WriteLine();
                //Console.WriteLine($"{veto.Team.Name} {veto.Action} {veto.Map}");
                if (veto.Team.Name == null)
                    return;
                //Console.WriteLine($"{veto.Map} {veto.Action}");
                else
                    Console.WriteLine($"{veto.Team.Name} {veto.Action} {veto.Map}");

            }
*/
            //var model = new FullMatch();
            
            //model = HltvParser.GetMatch(2349612);
            
            //var task = HltvParser.GetMatchResults();
            
            //var result = HltvParser.GetUpcomingMatches(); //HltvParser.GetMatch(2333833);
            
            //var list = new List<UpcomingMatch>();
            
            //List<UpcomingMatch> upcomingMatches = new List<UpcomingMatch>();
            

            
            //Console.Write(result);
            task.Wait();
            
        }
    }
}
