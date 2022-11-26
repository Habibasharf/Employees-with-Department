using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
   struct HiringData
    {
        #region struct of hiring data
        #region fields
        int day;
        int month;
        int year;
        #endregion
        #region constractors
        #endregion
        #region property
        public int Day
        {
            set
            {
                if (value >= 1 && value <= 30) day = value;
            }
            get
            {
                return day;
            }
        }
        public int Month
        {
            set
            {
                if (value >= 1 && value <= 12) month = value;
            }
            get
            {
                return month;
            }
        }
        public int Year
        {
            set
            {
                if (value > 2000 && value <= 2022) year = value;
            }
            get
            {
                return year;
            }
        }
        #endregion
        public HiringData( int x,int y ,int s)
        {
            day = x;
            month = y;
            year = s;

        }
        #region methods
        public string Hire()
        {
            return $"({day} / {month} / {year})";
        }
        #endregion
        #endregion
    }

}
