using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing6
{
    public class clsStaff
    {

        private Int32 mStaffID;
        public Int32 StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }

        private String mStaffName;
        public String StaffName
        {
            get
            {
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            }
        }

        private String mJobRole;
        public String JobRole
        {
            get
            {
                return mJobRole;
            }
            set
            {
                mJobRole = value;
            }
        }

        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        private Boolean mIsManager;
        public bool IsManager
        {
            get
            {
                return mIsManager;
            }
            set
            {
                mIsManager = value;
            }
        }

        public bool Find(int StaffID)
        {
            mStaffID = 1;
            mStaffName = "Staff Name";
            mJobRole = "Job Role";
            mDateAdded = Convert.ToDateTime("20/03/2021");
            mIsManager = true;
            return true;
        }
    }
}

