using System;
using System.Collections.Generic;

namespace My_Friend_Tracker
{
    /// <summary>
    /// The Month Class
    /// </summary>
    public class Month
    {
        /// <summary>
        /// A List of Friends who have birthdays in this month
        /// </summary>
        public List<Friend> friends = new List<Friend>();

        /// <summary>
        /// The Name of the month
        /// </summary>
        public string name;

        /// <summary>
        /// The Months Constructor
        /// </summary>
        public Month(string name)
        {
            //Set the name of the month.
            this.name = name;
        }
    }
}
