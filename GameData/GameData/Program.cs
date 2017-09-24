using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalInfo goalInfo = new GoalInfo(string.Format("{0:HH:mm:ss}", DateTime.Now), "Komanda 1", "Penketas");
            IO r = new IO();

            //Console.WriteLine(value: $"{ goalInfo.goalTime } { goalInfo.goalTeam } { goalInfo.goalBar } total score is { GoalInfo.totalScore }");
                
            r.Write(goalTime: goalInfo.goalTime, goalTeam: goalInfo.goalTeam, goalBar: goalInfo.goalBar, totalScore: GoalInfo.totalScore);
            r.Read();
            Console.ReadLine();
        }
    }
}
