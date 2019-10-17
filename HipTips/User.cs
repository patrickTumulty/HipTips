using System;
using System.Collections.Generic;
using SQLite;

namespace HipTips
{
    public class User
    {
        public User()
        {
        }

        private int _id;
        private List<Shift> _shifts = new List<Shift>();


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

        public List<Shift> Shifts
        {
            get
            {
                return _shifts;
            }
            set
            {
                _shifts = value;
            }
        }
    }
}
