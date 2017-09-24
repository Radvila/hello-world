using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
    class GoalInfo
    {
        public string goalTime { get; set; }
        public string goalTeam { get; set; }
        public string goalBar { get; set; }
        public static int totalScore { get; set; }

        public GoalInfo(string goalTime2, string goalTeam2, string goalBar2)
        {
            goalTime = goalTime2;
            goalTeam = goalTeam2;
            goalBar = goalBar2;
            totalScore++;
        }

        public GoalInfo()
        {
            goalTime = this.goalTime;
            goalTeam = this.goalTeam;
            goalBar = this.goalBar;
        }
    }
}
