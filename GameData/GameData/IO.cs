using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GameData
{
    class IO
    {
        public void Write(string goalTime, string teamName, string goalBar, int totalScore, TimeSpan ts, Stopwatch timer)
        {
            string filePath = @"C:\Users\Radvila\source\repos\GameData\GameData\GoalInfo.txt";

            ts = timer.Elapsed;
            File.AppendAllText(filePath, goalTime +" "+ teamName +" "+ goalBar +" "+ "total score is "+ totalScore +" "+ ts + Environment.NewLine);
            if(totalScore == 8)
            {
                timer.Reset();
                File.AppendAllText(filePath, teamName + " Laimejo!" + Environment.NewLine);
            }
        }

        public void Read()
        {
            string filePath = @"C:\Users\Radvila\source\repos\GameData\GameData\GoalInfo.txt";

            List<GoalInfo> goals = new List<GoalInfo>();

            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (var line in lines)
            {
                string[] entries = line.Split(' ');

                GoalInfo newGoal = new GoalInfo();

                newGoal.goalTime = entries[0];
                newGoal.goalTeam = entries[2];
                newGoal.goalBar = entries[3];
                //Console.WriteLine(value: $"{ newGoal.goalTime } { entries[0] } sfsdfsdf");
                goals.Add(newGoal);
            }

            foreach (var newGoal in goals)
            {
                // Console.WriteLine(value: $"{ goals.goalTime } { goals.goalTeam } { goals.goalBar }");
                Console.WriteLine(value: $"{ newGoal.goalTime } { newGoal.goalTeam } { newGoal.goalBar } { GoalInfo.totalScore }");
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
