using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace My_Friend_Tracker
{
    /// <summary>
    /// The Add Friend Form Class
    /// </summary>
    public partial class Form2 : Form
    {

        /// <summary>
        /// Reference to the main form
        /// </summary>
        private Form1 form;

        /// <summary>
        /// The Forms Constructor
        /// </summary>
        public Form2(Form1 form)
        {
            //Initialize the form.
            InitializeComponent();

            //Set the form.
            this.form = form;

            //Hide the form.
            form.Hide();
        }

        /// <summary>
        /// Called when the form is closing
        /// </summary>
        private void Form2_Closing(object sender, FormClosingEventArgs e)
        {
            //Show the form.
            form.Show();
        }
        
        /// <summary>
        /// Called when the Add Friend button is clicked
        /// </summary>
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            //The message if one of the inputs are empty
            string message = "";

            //The new friends name.
            string name = Name_Input.Text;

            //The new friends likes.
            string likes = Likes_Input.Text;

            //The new friends dislikes.
            string dislikes = Dislikes_Input.Text;

            //The new friends DOB.
            string dob = DOB_Input.SelectionRange.Start.ToShortDateString();

            //If the name is empty.
            if(name.Length == 0)
            {
                message = "Please enter your friends name.";
            }
            //If the likes are empty.
            else if(likes.Length == 0)
            {
                message = "Please enter what your friend likes.";
            }
            //If the dislikes are empty.
            else if (dislikes.Length == 0)
            {
                message = "Please enter what your friend dislikes.";
            }

            //If the message is empty.
            if (message.Length == 0)
            {
                //Add the friend.
                form.AddFriend(name, likes, dislikes, dob);

                //Show the form.
                form.Show();

                //Close this form
                this.Close();
            }
            else
            {
                //Show the message.
                MessageBox.Show(message);
            }
        }
    }
}
