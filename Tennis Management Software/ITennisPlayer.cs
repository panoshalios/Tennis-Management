using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tennis_Management_Software.Timetabling;

namespace Tennis_Management_Software
{
    interface ITennisPlayer<T> where T : Timetable
    {
        TennisPlayerInformation<T> TennisPlayerInfo { get; set; }
    }
}
