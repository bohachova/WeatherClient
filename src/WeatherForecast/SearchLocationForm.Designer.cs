namespace WeatherForecast
{
    partial class searchLocationForm
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
            this.searchLocationTb = new System.Windows.Forms.TextBox();
            this.searchLocationBtn = new System.Windows.Forms.Button();
            this.searchResultsLb = new System.Windows.Forms.ListBox();
            this.selectCityBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchLocationTb
            // 
            this.searchLocationTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.searchLocationTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchLocationTb.Location = new System.Drawing.Point(12, 29);
            this.searchLocationTb.Name = "searchLocationTb";
            this.searchLocationTb.Size = new System.Drawing.Size(611, 30);
            this.searchLocationTb.TabIndex = 0;
            this.searchLocationTb.TextChanged += new System.EventHandler(this.searchLocationTb_TextChanged);
            // 
            // searchLocationBtn
            // 
            this.searchLocationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.searchLocationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchLocationBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.searchLocationBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.searchLocationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchLocationBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchLocationBtn.ForeColor = System.Drawing.Color.White;
            this.searchLocationBtn.Location = new System.Drawing.Point(629, 29);
            this.searchLocationBtn.Name = "searchLocationBtn";
            this.searchLocationBtn.Size = new System.Drawing.Size(159, 30);
            this.searchLocationBtn.TabIndex = 1;
            this.searchLocationBtn.Text = "Search";
            this.searchLocationBtn.UseVisualStyleBackColor = false;
            this.searchLocationBtn.Click += new System.EventHandler(this.searchLocationBtn_Click);
            // 
            // searchResultsLb
            // 
            this.searchResultsLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.searchResultsLb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchResultsLb.ForeColor = System.Drawing.Color.DimGray;
            this.searchResultsLb.FormattingEnabled = true;
            this.searchResultsLb.ItemHeight = 22;
            this.searchResultsLb.Location = new System.Drawing.Point(12, 87);
            this.searchResultsLb.Name = "searchResultsLb";
            this.searchResultsLb.Size = new System.Drawing.Size(611, 268);
            this.searchResultsLb.TabIndex = 2;
            this.searchResultsLb.SelectedIndexChanged += new System.EventHandler(this.searchResultsLb_SelectedIndexChanged);
            // 
            // selectCityBtn
            // 
            this.selectCityBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.selectCityBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectCityBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.selectCityBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.selectCityBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectCityBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectCityBtn.ForeColor = System.Drawing.Color.White;
            this.selectCityBtn.Location = new System.Drawing.Point(629, 325);
            this.selectCityBtn.Name = "selectCityBtn";
            this.selectCityBtn.Size = new System.Drawing.Size(159, 30);
            this.selectCityBtn.TabIndex = 3;
            this.selectCityBtn.Text = "Select";
            this.selectCityBtn.UseVisualStyleBackColor = false;
            this.selectCityBtn.Click += new System.EventHandler(this.selectCityBtn_Click);
            // 
            // searchLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectCityBtn);
            this.Controls.Add(this.searchResultsLb);
            this.Controls.Add(this.searchLocationBtn);
            this.Controls.Add(this.searchLocationTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "searchLocationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchLocationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchLocationTb;
        private System.Windows.Forms.Button searchLocationBtn;
        private System.Windows.Forms.ListBox searchResultsLb;
        private System.Windows.Forms.Button selectCityBtn;
    }
}