namespace TeamSelector
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
            this.teams = new System.Windows.Forms.ListBox();
            this.allPrice = new System.Windows.Forms.Label();
            this.Vikings = new System.Windows.Forms.Label();
            this.Twins = new System.Windows.Forms.Label();
            this.Giants = new System.Windows.Forms.Label();
            this.Bulldogs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teams
            // 
            this.teams.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.teams.FormattingEnabled = true;
            this.teams.ItemHeight = 39;
            this.teams.Items.AddRange(new object[] {
            "Minnesota Vikings",
            "Minnesota Twins",
            "New York Giants",
            "UMD Bulldogs"});
            this.teams.Location = new System.Drawing.Point(225, 145);
            this.teams.Name = "teams";
            this.teams.Size = new System.Drawing.Size(451, 277);
            this.teams.TabIndex = 0;
            this.teams.SelectedIndexChanged += new System.EventHandler(this.teams_SelectedIndexChanged_1);
            this.teams.MouseLeave += new System.EventHandler(this.teams_MouseLeave);
            this.teams.MouseHover += new System.EventHandler(this.teams_MouseHover);
            // 
            // allPrice
            // 
            this.allPrice.AutoSize = true;
            this.allPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.allPrice.Location = new System.Drawing.Point(734, 158);
            this.allPrice.Name = "allPrice";
            this.allPrice.Size = new System.Drawing.Size(74, 156);
            this.allPrice.TabIndex = 1;
            this.allPrice.Text = "$10\r\n$10\r\n$10\r\n$10";
            this.allPrice.Visible = false;
            // 
            // Vikings
            // 
            this.Vikings.AutoSize = true;
            this.Vikings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Vikings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Vikings.Location = new System.Drawing.Point(866, 158);
            this.Vikings.Name = "Vikings";
            this.Vikings.Size = new System.Drawing.Size(87, 63);
            this.Vikings.TabIndex = 2;
            this.Vikings.Text = "10";
            this.Vikings.Visible = false;
            this.Vikings.Click += new System.EventHandler(this.label1_Click);
            // 
            // Twins
            // 
            this.Twins.AutoSize = true;
            this.Twins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Twins.ForeColor = System.Drawing.Color.White;
            this.Twins.Location = new System.Drawing.Point(866, 204);
            this.Twins.Name = "Twins";
            this.Twins.Size = new System.Drawing.Size(87, 63);
            this.Twins.TabIndex = 3;
            this.Twins.Text = "10";
            this.Twins.Visible = false;
            // 
            // Giants
            // 
            this.Giants.AutoSize = true;
            this.Giants.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Giants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Giants.Location = new System.Drawing.Point(866, 245);
            this.Giants.Name = "Giants";
            this.Giants.Size = new System.Drawing.Size(87, 63);
            this.Giants.TabIndex = 4;
            this.Giants.Text = "10";
            this.Giants.Visible = false;
            // 
            // Bulldogs
            // 
            this.Bulldogs.AutoSize = true;
            this.Bulldogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Bulldogs.ForeColor = System.Drawing.Color.Maroon;
            this.Bulldogs.Location = new System.Drawing.Point(866, 289);
            this.Bulldogs.Name = "Bulldogs";
            this.Bulldogs.Size = new System.Drawing.Size(87, 63);
            this.Bulldogs.TabIndex = 5;
            this.Bulldogs.Text = "10";
            this.Bulldogs.Visible = false;
            this.Bulldogs.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 768);
            this.Controls.Add(this.Bulldogs);
            this.Controls.Add(this.Giants);
            this.Controls.Add(this.Twins);
            this.Controls.Add(this.Vikings);
            this.Controls.Add(this.allPrice);
            this.Controls.Add(this.teams);
            this.Name = "Form1";
            this.Text = "Team Selector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teams;
        private System.Windows.Forms.Label allPrice;
        private System.Windows.Forms.Label Vikings;
        private System.Windows.Forms.Label Twins;
        private System.Windows.Forms.Label Giants;
        private System.Windows.Forms.Label Bulldogs;
    }
}

