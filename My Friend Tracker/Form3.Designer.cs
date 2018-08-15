namespace My_Friend_Tracker
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Month_Text = new System.Windows.Forms.Label();
            this.Previous_Btn = new System.Windows.Forms.Button();
            this.Next_Btn = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Month_Text);
            this.panel1.Controls.Add(this.Previous_Btn);
            this.panel1.Controls.Add(this.Next_Btn);
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(-8, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 56);
            this.panel1.TabIndex = 0;
            // 
            // Month_Text
            // 
            this.Month_Text.AutoSize = true;
            this.Month_Text.BackColor = System.Drawing.SystemColors.Menu;
            this.Month_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Month_Text.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Month_Text.Location = new System.Drawing.Point(247, 9);
            this.Month_Text.MinimumSize = new System.Drawing.Size(200, 37);
            this.Month_Text.Name = "Month_Text";
            this.Month_Text.Size = new System.Drawing.Size(200, 37);
            this.Month_Text.TabIndex = 2;
            this.Month_Text.Text = "Month";
            this.Month_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Previous_Btn
            // 
            this.Previous_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous_Btn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Previous_Btn.Location = new System.Drawing.Point(202, 7);
            this.Previous_Btn.Name = "Previous_Btn";
            this.Previous_Btn.Size = new System.Drawing.Size(40, 40);
            this.Previous_Btn.TabIndex = 1;
            this.Previous_Btn.Text = "<";
            this.Previous_Btn.UseVisualStyleBackColor = true;
            this.Previous_Btn.Click += new System.EventHandler(this.Previous_Btn_Click);
            // 
            // Next_Btn
            // 
            this.Next_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Btn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Next_Btn.Location = new System.Drawing.Point(452, 7);
            this.Next_Btn.Name = "Next_Btn";
            this.Next_Btn.Size = new System.Drawing.Size(40, 40);
            this.Next_Btn.TabIndex = 0;
            this.Next_Btn.Text = ">";
            this.Next_Btn.UseVisualStyleBackColor = true;
            this.Next_Btn.Click += new System.EventHandler(this.Next_Btn_Click);
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
            this.data.Location = new System.Drawing.Point(-4, 52);
            this.data.Margin = new System.Windows.Forms.Padding(10);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersWidth = 4;
            this.data.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(695, 264);
            this.data.TabIndex = 1;
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(684, 312);
            this.Controls.Add(this.data);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Upcoming Birthdays";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_Closing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Month_Text;
        private System.Windows.Forms.Button Previous_Btn;
        private System.Windows.Forms.Button Next_Btn;
        private System.Windows.Forms.DataGridView data;
    }
}

