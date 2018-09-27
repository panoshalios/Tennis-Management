using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Management_Software
{
    [Serializable]
    public class LessonFees
    {
        public float PrivateFee { get; set; } //4 bytes
        public float SemiPrivateFee { get; set; } //4 bytes
        public float GroupFee { get; set; } //4 bytes

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.LessonFees class.
        /// </summary>
        public LessonFees()
        {
            PrivateFee = 0;
            GroupFee = 0;
            SemiPrivateFee = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.LessonFees class.
        /// </summary>
        public LessonFees(float privateLessonFee, float semiPrivateLessonFee, float groupLessonFee)
        {
            this.PrivateFee = privateLessonFee;
            this.GroupFee = groupLessonFee;
            this.SemiPrivateFee = semiPrivateLessonFee;
        }
    }//12 bytes total
}
