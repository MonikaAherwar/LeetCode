using System;

namespace LeetCode.JulyChallenge2020
{
    class Day14_AngleBetweenHandsOfAClock
    {
        public double AngleClock(int hour, int minutes)
        {
            const double anglePerHour = 360 / 12;
            const double anglePerMinute = 360 / 60;

            double minuteAngle = minutes * anglePerMinute;

            double extraHourAngle = (minuteAngle / 360) * 30;

            double hourAngle = (hour * anglePerHour) + extraHourAngle;

            var angle = Math.Abs(minuteAngle - hourAngle);

            return angle < 180 ? angle : (360 - angle);
        }
    }
}
