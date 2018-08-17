using System;

namespace My_Friend_Tracker
{
    /// <summary>
    /// The Freind Class
    /// </summary>
    public class Friend
    {
        /// <summary>
        /// The Friends Name
        /// </summary>
        public string name;

        /// <summary>
        /// The Friends Likes
        /// </summary>
        public string likes;

        /// <summary>
        /// The Friends Dislikes
        /// </summary>
        public string dislikes;

        /// <summary>
        /// The Friends Date of Birth
        /// </summary>
        public string dob;

        /// <summary>
        /// The Freind Constructor
        /// </summary>
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