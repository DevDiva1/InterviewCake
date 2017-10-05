using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arrays
{
    //Your company built an in-house calendar tool called HiCal. 
    //You want to add a feature to see the times in a day when everyone is available.
    class MergeMeeting
    {
        public static List<Meeting> MergeMeetingTimes(List<Meeting> meetings)
        {
            
            var sortedMeetingList = meetings.Select(m => new Meeting(m.StartTime, m.EndTime))
                .OrderBy(m => m.StartTime).ToList();
            //Case 1(1,3) (2,4)
            //Case 2(1,3) (2,3)
            //Case 3(1,4) (2,3)
            var result = new List<Meeting> {sortedMeetingList[0]};

            foreach (var current in sortedMeetingList)
            {
                var lastMergedMeeting = result.Last();
                //If overlap
                if (lastMergedMeeting.EndTime >= current.StartTime)
                {
                    //key steps
                    lastMergedMeeting = new Meeting(lastMergedMeeting.StartTime,
                        Math.Max(lastMergedMeeting.EndTime, current.EndTime));
                    result[result.Count - 1] = lastMergedMeeting;
                }
                else
                {
                    result.Add(current);
                }
            }
            return result;
        }
    }

    public class Meeting
    {
        public int StartTime { get; }

        public int EndTime { get; }

        public Meeting(int startTime, int endTime)
        {
            // Number of 30 min blocks past 9:00 am
            StartTime = startTime;
            EndTime = endTime;
        }

        public override string ToString()
        {
            return $"({StartTime}, {EndTime})";
        }
    }
}
