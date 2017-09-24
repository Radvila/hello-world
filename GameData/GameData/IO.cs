using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
    class IO
    {
        public void Write(string goalTime, string goalTeam, string goalBar, int totalScore)
        {
            string filePath = @"C:\Users\Radvila\source\repos\GameData\GameData\GoalInfo.txt";

            File.WriteAllText(filePath, goalTime +" "+ goalTeam +" "+ goalBar+" "+ "total score is "+totalScore + Environment.NewLine);
            if(totalScore == 8)
            {
                File.WriteAllText(filePath, "Komanda " + goalTeam + "Laimejo!" + Environment.NewLine);
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
