using System;
using SQLite;

namespace HipTips
{
    public class Shift
    {

        public Shift(double tips, double hours, DateTime _dateTime)
        {

            Tips = tips;
            HoursWorked = hours;
            Hourly = Calc_Hourly();
            //ShiftDay = new DateTime().DayOfWeek;
            ShiftDate = _dateTime;
        }

        public Shift()
        {
           
        }

        private int _id;
        private double _tips;
        private double _hourly;
        private double _hoursWorked;
        //private string _position;
        private DateTime _shiftDate;
        private DateTime _shiftDay;


        [PrimaryKey, AutoIncrement]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public double Tips
        {
            get
            {
                return _tips;
            }
            set
            {
                _tips = value;
            }
        }

        public double Hourly
        {
            get
            {
                return _hourly;
            }
            set
            {
                _hourly = value;
            }
        }

        public double HoursWorked
        {
            get
            {
                return _hoursWorked;
            }
            set
            {
                _hoursWorked = value;
            }
        }

        //public string Position
        //{
        //    get
        //    {
        //        return _position;
        //    }
        //    set
        //    {
        //        _position = value;
        //    }
        //}

        public DateTime ShiftDate
        {
            get
            {
                return _shiftDate;
            }
            set
            {
                _shiftDate = value;
            }
        }

        public DateTime ShiftDay
        {
            get
            {
                return _shiftDay;
            }
            set
            {
                _shiftDay = value;
            }
        }

        private double Calc_Hourly()
        {
            double val = Math.Round( Tips / HoursWorked, 2);
            return val;
        }
      
    }
}
