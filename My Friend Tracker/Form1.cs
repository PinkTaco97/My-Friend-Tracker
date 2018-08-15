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
    public partial class Form1 : Form
    {
        //List that hold all of the friends data.
        public List<Friend> friends = new List<Friend>();

        //The index of the current friend.
        public int currentFriend = 99;

        //The datatable.
        DataTable dataTable = new DataTable();

        //If using the buttons to navigate.
        private bool button = false;

        //Constructor.
        public Form1()
        {
            //Initialize the form.
            InitializeComponent();
            
            //Load the freinds from the .csv file.
            ReadFriends();
            
            //Create the table.
            CreateTable();
        }

        //Called when the form loads.
        private void Form1_Load(object sender, EventArgs e)
        {
            //Add the Selection Changed Event Handler.
            this.data.SelectionChanged += new System.EventHandler(this.data_SelectionChanged);

            //For each of the columns in the Data View
            foreach (DataGridViewColumn column in data.Columns)
            {
                //Make them not sortable.
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        //Called when the window is closing.
        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            //Update the .csv file.
            WriteFriends();
        }

        //Read the friends from the .csv
        public void ReadFriends()
        {
            //Read the file.
            using (var reader = new StreamReader(@"MyFriendsData.csv"))
            {
                //While there are still lines in the file.
                while (!reader.EndOfStream)
                {
                    //Read the current line.
                    var line = reader.ReadLine();

                    //Split the line into the seperate values.
                    var values = line.Split(',');

                    //Create a new friend.
                    Friend friend = new Friend(values[0], values[1], values[2], values[3]);

                    //Add the new friend to the list of friends.
                    friends.Add(friend);
                }
            }
        }

        //Write the friends to the .csv file.
        private void WriteFriends()
        {
            //The file path.
            StringBuilder sb = new StringBuilder();

            //For each of our friends.
            for (int i = 0; i < friends.Count; i++)
            {
                //Make a line in the .csv file for them.
                sb.AppendLine(friends[i].name + "," + friends[i].likes + "," + friends[i].dislikes + "," + friends[i].dob);
            }

            //Clear the .csv file.
            System.IO.File.WriteAllText(@"MyFriendsData.csv", string.Empty);

            //Update the .csv file.
            File.AppendAllText(@"MyFriendsData.csv", sb.ToString());
        }

        //Create the Datatable.
        private void CreateTable()
        {
            //Add the columns.
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Likes");
            dataTable.Columns.Add("Dislikes");
            dataTable.Columns.Add("Date of Birth");

            //Set the datagrids datasource.
            data.DataSource = dataTable;

            //Load the friends into the table.
            LoadTable();
        }

        //Load the friends into the table.
        private void LoadTable()
        {
            dataTable.Clear();

            //The row for the datatable.
            DataRow row;

            //For each of friends
            for (int i = 0; i < friends.Count; i++)
            {
                //Create a new row.
                row = dataTable.NewRow();

                //Add the data to the row.
                row[0] = friends[i].name;
                row[1] = friends[i].likes;
                row[2] = friends[i].dislikes;
                row[3] = friends[i].dob;

                //Add the row to the datatable.
                dataTable.Rows.Add(row);
            }

            //Load the first friend.
            LoadFriend(0);
        }

        //Called when the selection in the data grid changes.
        private void data_SelectionChanged(object sender, EventArgs e)
        {
            //Load the selected friend if the buttons werent used.
            if(data.CurrentCell != null && !button)
            {
                //Load the selected friend into the form
                LoadFriend(data.CurrentCell.RowIndex);
            }
        }

        //Called when the Seach text changes.
        private void Search_Text_TextChanged(object sender, EventArgs e)
        {
            //Get the search request
            string query = Search_Text.Text;

            //Search for the friend.
            Search(query);
        }

        //Search for the friend.
        private void Search(string query)
        {
            //Clear the current selected friend.
            data.ClearSelection();
            
            //For each friend.
            for (int i = 0; i < friends.Count; i++)
            {
                //If the friends name matches the query.
                if (friends[i].name.Contains(query))
                {
                    //Set the row to selected.
                    data.Rows[i].Selected = true;

                    //Set the scroll index.
                    data.FirstDisplayedScrollingRowIndex = data.SelectedRows[0].Index;

                    //Load the friend into the form.
                    LoadFriend(i);
                }
            }
        }

        //Load the selected friend into the form.
        private void LoadFriend(int index)
        {
            //make sure the friend isnt the current friend.
            if(index != currentFriend)
            {
                //Set the current friend.
                currentFriend = index;

                //Set the row to selected.
                data.Rows[index].Selected = true;

                //Set the scroll index.
                data.FirstDisplayedScrollingRowIndex = data.SelectedRows[0].Index;

                //Get the selected friend.
                Friend friend = friends[index];

                //Set the name text.
                Name_Text.Text = friend.name;

                //Set the likes text.
                Likes_Text.Text = friend.likes;

                //Set the dislikes text.
                Dislikes_Text.Text = friend.dislikes;

                //Set the D.O.B text.
                DateTime dob = DateTime.Parse(friend.dob);
                DOB.SetDate(dob);

                //Set button to false.
                button = false;
            }
        }

        //Update the selected friend.
        private void UpdateFriend(int index)
        {
            //If there is a friend to Update
            if (friends.Count > 0)
            {
                //Get the selected friend.
                Friend friend = friends[index];

                //Update the Name.
                friend.name = Name_Text.Text;

                //Update the likes.
                friend.likes = Likes_Text.Text;

                //Update the dislikes.
                friend.dislikes = Dislikes_Text.Text;

                //Update the DOB
                friend.dob = DOB.SelectionRange.Start.ToShortDateString();
            }
        }

        //Add friend.
        public void AddFriend(string name, string likes, string dislikes, string dob)
        {
            //Create a new friend.
            Friend friend = new Friend(name, likes, dislikes, dob);

            //Add the friend to the list of friends.
            friends.Add(friend);

            //Update the data table.
            LoadTable();
        }

        //Delete the selected friend.
        private void DeleteFriend(int index)
        {
            //Ask if they are sure.
            if (MessageBox.Show("Are you sure you want to delete this friend?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //If there is a friend to delete.
                if (friends.Count > 0)
                {
                    //Delete the friend.
                    friends.RemoveAt(index);

                    //Update the table.
                    LoadTable();
                }
            }
        }

        //Called when the Update Friend Button is Clicked.
        private void Update_Btn_Click(object sender, EventArgs e)
        {
            //Update the current friend.
            UpdateFriend(currentFriend);

            //Update the Data Table.
            LoadTable();
        }
        
        //Called when the Delete Friend Button is Clicked.
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            //Delete the current friend.
            DeleteFriend(currentFriend);

            //Update the Data Table.
            LoadTable();
        }

        //Called when the Add Friend Button is Clicked.
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        //Called when the Next Button is clicked.
        private void Next_Btn_Click(object sender, EventArgs e)
        {
            //We are useing the buttons to navigate.
            button = true;

            //If the current friend isnt the last.
            if (currentFriend < (friends.Count - 1))
            {
                //Load the next friend.
                LoadFriend((currentFriend + 1));   
            }
            else
            {
                //Load the First friend.
                LoadFriend(0);
            }
        }

        //Called when the Previous Button is clicked.
        private void Previous_Btn_Click(object sender, EventArgs e)
        {
            //We are useing the buttons to navigate.
            button = true;

            //If the current friend isnt the first.
            if (currentFriend >= 1)
            {
                //Load the previous friend.
                LoadFriend((currentFriend - 1));
            }
            else
            {
                //Load the Last friend.
                LoadFriend((friends.Count - 1));
            }
        }

        //Called when the First Button is clicked.
        private void First_Btn_Click(object sender, EventArgs e)
        {
            //We are useing the buttons to navigate.
            button = true;

            //Load the First friend.
            LoadFriend(0);
        }

        //Called when the Last Button is clicked.
        private void Last_Btn_Click(object sender, EventArgs e)
        {
            //We are useing the buttons to navigate.
            button = true;

            //Load the Last friend.
            LoadFriend((friends.Count - 1));
        }

        //Called when the Upcoming Birthdays Button is Clicked.
        private void Birthday_Btn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }
    }
}
