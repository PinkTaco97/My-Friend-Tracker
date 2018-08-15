using System;
using System.Collections.Generic;

namespace My_Friend_Tracker
{
    public class Month
    {
        //List that hold all of the friends data.
        public List<Friend> friends = new List<Friend>();

        //The name of the month.
        public string name;

        public Month(string name)
        {
            //Set the name of the month.
            this.name = name;
        }

        public void PrintAll()
        {
            foreach (Friend friend in friends)
            {
                Console.WriteLine(friend.name + ", " + friend.dob);
            }
        }
    }
}
