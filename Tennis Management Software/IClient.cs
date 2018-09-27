using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Management_Software
{
    interface IClient
    {
        float GetMoneyPayingForPrivateLessons(float privateLessonFee);
        float GetMoneyPayingForGroupLessons(float groupLessonFee);
        float GetMoneyPayingForSemiPrivateLessons(float semiPrivateLessonFee);
        float GetTotalPayingMoney(float privateLessonFee, float groupLessonFee, float semiPrivateLessonFee);
    }
}
