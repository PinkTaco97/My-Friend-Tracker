namespace My_Friend_Tracker
{
    /// <summary>
    /// The Form2.Designer Class
    /// </summary>
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Likes_Input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Dislikes_Input = new System.Windows.Forms.TextBox();
            this.DOB_Input = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // Name_Input
            // 
            this.Name_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Input.Location = new System.Drawing.Point(30, 37);
            this.Name_Input.Name = "Name_Input";
            this.Name_Input.Size = new System.Drawing.Size(227, 29);
            this.Name_Input.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Likes:";
            // 
            // Likes_Input
            // 
            this.Likes_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Likes_Input.Location = new System.Drawing.Point(30, 106);
            this.Likes_Input.Name = "Likes_Input";
            this.Likes_Input.Size = new System.Drawing.Size(227, 29);
            this.Likes_Input.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(25, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dislikes:";
            // 
            // Dislikes_Input
            // 
            this.Dislikes_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dislikes_Input.Location = new System.Drawing.Point(30, 179);
            this.Dislikes_Input.Name = "Dislikes_Input";
            this.Dislikes_Input.Size = new System.Drawing.Size(227, 29);
            this.Dislikes_Input.TabIndex = 5;
            // 
            // DOB_Input
            // 
            this.DOB_Input.Location = new System.Drawing.Point(30, 256);
            this.DOB_Input.Name = "DOB_Input";
            this.DOB_Input.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(26, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date of Birth:";
            // 
            // Add_Btn
            // 
            this.Add_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Btn.Location = new System.Drawing.Point(30, 425);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(227, 31);
            this.Add_Btn.TabIndex = 8;
            this.Add_Btn.Text = "Add Friend";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(284, 462);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DOB_Input);
            this.Controls.Add(this.Dislikes_Input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Likes_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_Input);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Add a Friend";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Likes_Input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Dislikes_Input;
        private System.Windows.Forms.MonthCalendar DOB_Input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add_Btn;
    }
}

