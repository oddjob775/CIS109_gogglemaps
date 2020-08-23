namespace gogglemaps
{
    partial class frm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.zipcodeLabel = new System.Windows.Forms.Label();
            this.zipcodeTextbox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateTextbox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextbox = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.streetTextbox = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.zipcodeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.zipcodeTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.stateLabel);
            this.splitContainer1.Panel1.Controls.Add(this.stateTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.cityLabel);
            this.splitContainer1.Panel1.Controls.Add(this.cityTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.streetLabel);
            this.splitContainer1.Panel1.Controls.Add(this.streetTextbox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(1582, 707);
            this.splitContainer1.SplitterDistance = 527;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(19, 620);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(495, 72);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // zipcodeLabel
            // 
            this.zipcodeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.zipcodeLabel.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipcodeLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.zipcodeLabel.Location = new System.Drawing.Point(12, 465);
            this.zipcodeLabel.Name = "zipcodeLabel";
            this.zipcodeLabel.Size = new System.Drawing.Size(502, 74);
            this.zipcodeLabel.TabIndex = 10;
            this.zipcodeLabel.Text = "Zipcode";
            this.zipcodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zipcodeTextbox
            // 
            this.zipcodeTextbox.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipcodeTextbox.Location = new System.Drawing.Point(19, 542);
            this.zipcodeTextbox.Multiline = true;
            this.zipcodeTextbox.Name = "zipcodeTextbox";
            this.zipcodeTextbox.Size = new System.Drawing.Size(495, 72);
            this.zipcodeTextbox.TabIndex = 9;
            this.zipcodeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stateLabel
            // 
            this.stateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.stateLabel.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.ForeColor = System.Drawing.Color.Gold;
            this.stateLabel.Location = new System.Drawing.Point(12, 313);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(502, 74);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "State";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateTextbox
            // 
            this.stateTextbox.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateTextbox.Location = new System.Drawing.Point(19, 390);
            this.stateTextbox.Multiline = true;
            this.stateTextbox.Name = "stateTextbox";
            this.stateTextbox.Size = new System.Drawing.Size(495, 72);
            this.stateTextbox.TabIndex = 7;
            this.stateTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cityLabel
            // 
            this.cityLabel.BackColor = System.Drawing.SystemColors.Control;
            this.cityLabel.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.Red;
            this.cityLabel.Location = new System.Drawing.Point(12, 161);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(502, 74);
            this.cityLabel.TabIndex = 6;
            this.cityLabel.Text = "City";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityTextbox
            // 
            this.cityTextbox.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextbox.Location = new System.Drawing.Point(19, 238);
            this.cityTextbox.Multiline = true;
            this.cityTextbox.Name = "cityTextbox";
            this.cityTextbox.Size = new System.Drawing.Size(495, 72);
            this.cityTextbox.TabIndex = 5;
            this.cityTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // streetLabel
            // 
            this.streetLabel.BackColor = System.Drawing.SystemColors.Control;
            this.streetLabel.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.streetLabel.Location = new System.Drawing.Point(12, 9);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(502, 74);
            this.streetLabel.TabIndex = 4;
            this.streetLabel.Text = "Street";
            this.streetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // streetTextbox
            // 
            this.streetTextbox.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetTextbox.Location = new System.Drawing.Point(19, 86);
            this.streetTextbox.Multiline = true;
            this.streetTextbox.Name = "streetTextbox";
            this.streetTextbox.Size = new System.Drawing.Size(495, 72);
            this.streetTextbox.TabIndex = 0;
            this.streetTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1051, 707);
            this.webBrowser1.TabIndex = 0;
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 707);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm";
            this.Text = "Welcome to [LAWSUIT PENDING] maps!";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox streetTextbox;
        private System.Windows.Forms.Label zipcodeLabel;
        private System.Windows.Forms.TextBox zipcodeTextbox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox stateTextbox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextbox;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Button btnSearch;
    }
}

