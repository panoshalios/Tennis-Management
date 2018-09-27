using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using Tennis_Management_Software.Timetabling.Visualization;

namespace Tennis_Management_Software.Tournament
{
    [Serializable]
    public class TournamentSettings
    {
        public int NumberOfPersons;
        public bool DrawLines;
        public bool TournamentStarted;
        public List<Color> ColorList;
        public List<bool> SubscribedToDoubleClick;
        public List<List<string>> cellText;

        public TournamentSettings()
        {
            NumberOfPersons = 2;
            DrawLines = false;
            TournamentStarted = false;
            ColorList = new List<Color>();
            SubscribedToDoubleClick = new List<bool>();
            cellText = new List<List<string>>();
        }
    }
}
