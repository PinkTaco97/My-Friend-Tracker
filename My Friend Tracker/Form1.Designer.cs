namespace My_Friend_Tracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Birthday_Btn = new System.Windows.Forms.Button();
            this.First_Btn = new System.Windows.Forms.Button();
            this.Last_Btn = new System.Windows.Forms.Button();
            this.Previous_Btn = new System.Windows.Forms.Button();
            this.Next_Btn = new System.Windows.Forms.Button();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Search_Text = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.Likes = new System.Windows.Forms.Label();
            this.Likes_Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dislikes_Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Update_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.DOB = new System.Windows.Forms.MonthCalendar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.First_Btn);
            this.panel1.Controls.Add(this.Last_Btn);
            this.panel1.Controls.Add(this.Previous_Btn);
            this.panel1.Controls.Add(this.Next_Btn);
            this.panel1.Location = new System.Drawing.Point(0, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 50);
            this.panel1.TabIndex = 0;
            // 
            // Birthday_Btn
            // 
            this.Birthday_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday_Btn.Location = new System.Drawing.Point(5, 5);
            this.Birthday_Btn.Name = "Birthday_Btn";
            this.Birthday_Btn.Size = new System.Drawing.Size(172, 30);
            this.Birthday_Btn.TabIndex = 17;
            this.Birthday_Btn.Text = "Upcoming Birthdays";
            this.Birthday_Btn.UseVisualStyleBackColor = true;
            this.Birthday_Btn.Click += new System.EventHandler(this.Birthday_Btn_Click);
            // 
            // First_Btn
            // 
            this.First_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_Btn.Location = new System.Drawing.Point(5, 10);
            this.First_Btn.Name = "First_Btn";
            this.First_Btn.Size = new System.Drawing.Size(100, 30);
            this.First_Btn.TabIndex = 16;
            this.First_Btn.Text = "First";
            this.First_Btn.UseVisualStyleBackColor = true;
            this.First_Btn.Click += new System.EventHandler(this.First_Btn_Click);
            // 
            // Last_Btn
            // 
            this.Last_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_Btn.Location = new System.Drawing.Point(320, 10);
            this.Last_Btn.Name = "Last_Btn";
            this.Last_Btn.Size = new System.Drawing.Size(100, 30);
            this.Last_Btn.TabIndex = 14;
            this.Last_Btn.Text = "Last";
            this.Last_Btn.UseVisualStyleBackColor = true;
            this.Last_Btn.Click += new System.EventHandler(this.Last_Btn_Click);
            // 
            // Previous_Btn
            // 
            this.Previous_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous_Btn.Location = new System.Drawing.Point(110, 10);
            this.Previous_Btn.Name = "Previous_Btn";
            this.Previous_Btn.Size = new System.Drawing.Size(100, 30);
            this.Previous_Btn.TabIndex = 15;
            this.Previous_Btn.Text = "Previous";
            this.Previous_Btn.UseVisualStyleBackColor = true;
            this.Previous_Btn.Click += new System.EventHandler(this.Previous_Btn_Click);
            // 
            // Next_Btn
            // 
            this.Next_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Btn.Location = new System.Drawing.Point(215, 10);
            this.Next_Btn.Name = "Next_Btn";
            this.Next_Btn.Size = new System.Drawing.Size(100, 30);
            this.Next_Btn.TabIndex = 14;
            this.Next_Btn.Text = "Next";
            this.Next_Btn.UseVisualStyleBackColor = true;
            this.Next_Btn.Click += new System.EventHandler(this.Next_Btn_Click);
            // 
            // Add_Btn
            // 
            this.Add_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Btn.Location = new System.Drawing.Point(183, 5);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(172, 30);
            this.Add_Btn.TabIndex = 3;
            this.Add_Btn.Text = "Add Friend";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(11, 45);
            this.label4.MinimumSize = new System.Drawing.Size(100, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Search:";
            // 
            // Search_Text
            // 
            this.Search_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Text.Location = new System.Drawing.Point(133, 45);
            this.Search_Text.MaxLength = 10;
            this.Search_Text.Name = "Search_Text";
            this.Search_Text.Size = new System.Drawing.Size(219, 29);
            this.Search_Text.TabIndex = 1;
            this.Search_Text.TextChanged += new System.EventHandler(this.Search_Text_TextChanged);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeColumns = false;
            this.data.AllowUserToResizeRows = false;
            this.data.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data.GridColor = System.Drawing.SystemColors.Control;
            this.data.Location = new System.Drawing.Point(-2, 0);
            this.data.Margin = new System.Windows.Forms.Padding(10);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersWidth = 4;
            this.data.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(425, 458);
            this.data.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // Name_Text
            // 
            this.Name_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Text.Location = new System.Drawing.Point(468, 127);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(277, 29);
            this.Name_Text.TabIndex = 3;
            // 
            // Likes
            // 
            this.Likes.AutoSize = true;
            this.Likes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Likes.Location = new System.Drawing.Point(466, 159);
            this.Likes.Name = "Likes";
            this.Likes.Size = new System.Drawing.Size(58, 24);
            this.Likes.TabIndex = 4;
            this.Likes.Text = "Likes:";
            // 
            // Likes_Text
            // 
            this.Likes_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Likes_Text.Location = new System.Drawing.Point(468, 186);
            this.Likes_Text.Name = "Likes_Text";
            this.Likes_Text.Size = new System.Drawing.Size(129, 29);
            this.Likes_Text.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(603, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dislikes:";
            // 
            // Dislikes_Text
            // 
            this.Dislikes_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dislikes_Text.Location = new System.Drawing.Point(603, 186);
            this.Dislikes_Text.Name = "Dislikes_Text";
            this.Dislikes_Text.Size = new System.Drawing.Size(142, 29);
            this.Dislikes_Text.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(466, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Birthday:";
            // 
            // Update_Btn
            // 
            this.Update_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Btn.Location = new System.Drawing.Point(492, 426);
            this.Update_Btn.Name = "Update_Btn";
            this.Update_Btn.Size = new System.Drawing.Size(227, 30);
            this.Update_Btn.TabIndex = 11;
            this.Update_Btn.Text = "Update Friend";
            this.Update_Btn.UseVisualStyleBackColor = true;
            this.Update_Btn.Click += new System.EventHandler(this.Update_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Btn.Location = new System.Drawing.Point(492, 467);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(227, 30);
            this.Delete_Btn.TabIndex = 12;
            this.Delete_Btn.Text = "Delete Friend";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(492, 247);
            this.DOB.Name = "DOB";
            this.DOB.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.Add_Btn);
            this.panel2.Controls.Add(this.Birthday_Btn);
            this.panel2.Controls.Add(this.Search_Text);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(426, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 84);
            this.panel2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.Update_Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dislikes_Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Likes_Text);
            this.Controls.Add(this.Likes);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "My Friend Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Search_Text;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.Label Likes;
        private System.Windows.Forms.TextBox Likes_Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Dislikes_Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Update_Btn;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.MonthCalendar DOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Previous_Btn;
        private System.Windows.Forms.Button Next_Btn;
        private System.Windows.Forms.Button Last_Btn;
        private System.Windows.Forms.Button First_Btn;
        private System.Windows.Forms.Button Birthday_Btn;
        private System.Windows.Forms.Panel panel2;
    }
}

