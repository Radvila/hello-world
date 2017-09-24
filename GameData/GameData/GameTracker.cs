using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GameData
{
    class GameTracker
    {
        public GameTracker()
        {
            Team team1 = new Team();
            Team team2 = new Team();
            GoalInfo goalInfo = new GoalInfo();
            Stopwatch timer = new Stopwatch();
            TimeSpan ts = new TimeSpan();
            IO r = new IO();
            timer.Start();


            team1.teamName = "Komanda 1";
            team2.teamName = "Komanda 2";
            team2.totalScore = 7;

            while (true)
            {
                if (/*team1 goal*/true)
                {
                    team1.totalScore++;
                    r.Write(string.Format("{0:HH:mm:ss}", DateTime.Now), teamName: team1.teamName, goalBar: goalInfo.goalBar, totalScore: team1.totalScore, ts: ts, timer: timer);
                }
                if (/*team2 goal*/true)
                {
                    team2.totalScore++;
                    r.Write(string.Format("{0:HH:mm:ss}", DateTime.Now), teamName: team2.teamName, goalBar: goalInfo.goalBar, totalScore: team2.totalScore, ts: ts, timer: timer);
                }
                if (/*stop*/ true)
                {
                    timer.Reset();
                    break;
                }
            }
        }

    }
}
