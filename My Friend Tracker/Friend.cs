using System;

namespace My_Friend_Tracker
{
    public class Friend
    {

        //Public attributes
        public string name;
        public string likes;
        public string dislikes;
        public string dob;

        //Constructor
        public Friend(string name, string likes, string dislikes, string dob)
        {
            //Set the variables
            this.name = name;
            this.likes = likes;
            this.dislikes = dislikes;
            this.dob = dob;
        }
    }
}