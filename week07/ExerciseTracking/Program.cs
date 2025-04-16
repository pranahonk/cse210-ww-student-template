// Ensure these using statements are at the top of your Program.cs file
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private DateTime _date;
        private int _lengthMinutes;

        public Activity(DateTime date, int lengthMinutes)
        {
            _date = date;
            _lengthMinutes = lengthMinutes;
        }


        protected int LengthMinutes => _lengthMinutes;
        protected DateTime Date => _date;

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();


        public virtual string GetSummary()
        {
            string activityType = GetType().Name;
            string dateStr = _date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
            double distance = GetDistance();
            double speed = GetSpeed();
            double pace = GetPace();


            return $"{dateStr} {activityType} ({_lengthMinutes} min)- Distance {distance:F1} km, Speed {speed:F1} kph, Pace: {pace:F2} min per km";
        }
    }


    public class Running : Activity
    {
        private double _distanceKm;

        public Running(DateTime date, int lengthMinutes, double distanceKm)
            : base(date, lengthMinutes)
        {
            _distanceKm = distanceKm;
        }

        public override double GetDistance()
        {
            return _distanceKm;
        }

        public override double GetSpeed()
        {
            if (LengthMinutes == 0) return 0;
            return (_distanceKm / LengthMinutes) * 60.0;
        }

        public override double GetPace()
        {
            if (_distanceKm == 0) return 0;
            return LengthMinutes / _distanceKm;
        }
    }

    public class Cycling : Activity
    {
        private double _speedKph; // Speed specific to cycling

        public Cycling(DateTime date, int lengthMinutes, double speedKph)
            : base(date, lengthMinutes)
        {
            _speedKph = speedKph;
        }

        public override double GetDistance()
        {
            return (_speedKph / 60.0) * LengthMinutes;
        }

        public override double GetSpeed()
        {
            return _speedKph;
        }

        public override double GetPace()
        {
            if (_speedKph == 0) return 0;
            return 60.0 / _speedKph;
        }
    }

    public class Swimming : Activity
    {
        private int _laps; // Number of laps specific to swimming
        private const double MetersPerLap = 50.0;
        private const double MetersPerKm = 1000.0;

        public Swimming(DateTime date, int lengthMinutes, int laps)
            : base(date, lengthMinutes)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {

            return _laps * MetersPerLap / MetersPerKm;
        }

        public override double GetSpeed()
        {
            // Speed (kph) = (distance / minutes) * 60
            double distance = GetDistance();
            if (LengthMinutes == 0) return 0; // Avoid division by zero
            return (distance / LengthMinutes) * 60.0;
        }

        public override double GetPace()
        {
            // Pace (min/km) = minutes / distance
            double distance = GetDistance();
            if (distance == 0) return 0; // Avoid division by zero
            return LengthMinutes / distance;
        }
    }

    // --- Main Program ---
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            Running runningActivity = new Running(new DateTime(2022, 11, 3), 30, 4.8); // 4.8 km
            Cycling cyclingActivity = new Cycling(new DateTime(2022, 11, 4), 45, 24.1); // 24.1 kph (~15 mph)
            Swimming swimmingActivity = new Swimming(new DateTime(2022, 11, 5), 60, 40); // 40 laps


            activities.Add(runningActivity);
            activities.Add(cyclingActivity);
            activities.Add(swimmingActivity);

            Console.WriteLine("Exercise Summary Report:");
            Console.WriteLine("------------------------");
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
            Console.WriteLine("------------------------");
        }
    }
}