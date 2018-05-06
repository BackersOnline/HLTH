using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKTH
{
    public class Activity
    {
        public int activityId { get; set; }
        public int activityParentId { get; set; }
        public string activityParentName { get; set; }
        public int calories { get; set; }
        public string description { get; set; }
        public double distance { get; set; }
        public int duration { get; set; }
        public bool hasStartTime { get; set; }
        public bool isFavorite { get; set; }
        public DateTime lastModified { get; set; }
        public object logId { get; set; }
        public string name { get; set; }
        public string startDate { get; set; }
        public string startTime { get; set; }
        public int steps { get; set; }
    }

    public class Goals
    {
        public int activeMinutes { get; set; }
        public int caloriesOut { get; set; }
        public double distance { get; set; }
        public int steps { get; set; }
    }

    public class Distance
    {
        public string activity { get; set; }
        public double distance { get; set; }
    }

    public class Summary
    {
        public int activeScore { get; set; }
        public int activityCalories { get; set; }
        public int caloriesBMR { get; set; }
        public int caloriesOut { get; set; }
        public List<Distance> distances { get; set; }
        public int fairlyActiveMinutes { get; set; }
        public int lightlyActiveMinutes { get; set; }
        public int marginalCalories { get; set; }
        public int sedentaryMinutes { get; set; }
        public int steps { get; set; }
        public int veryActiveMinutes { get; set; }
    }

    public class RootObject
    {
        public List<Activity> activities { get; set; }
        public Goals goals { get; set; }
        public Summary summary { get; set; }
    }
}
