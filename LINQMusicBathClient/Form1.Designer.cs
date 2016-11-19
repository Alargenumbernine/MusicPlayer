namespace LINQMusicBathClient
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
            this.lblSongID = new System.Windows.Forms.Label();
            this.txtSongID = new System.Windows.Forms.TextBox();
            this.btnGetSong = new System.Windows.Forms.Button();
            this.lblSongDetails = new System.Windows.Forms.Label();
            this.txtSongDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSongID
            // 
            this.lblSongID.AutoSize = true;
            this.lblSongID.Location = new System.Drawing.Point(34, 13);
            this.lblSongID.Name = "lblSongID";
            this.lblSongID.Size = new System.Drawing.Size(46, 13);
            this.lblSongID.TabIndex = 0;
            this.lblSongID.Text = "Song ID";
            // 
            // txtSongID
            // 
            this.txtSongID.Location = new System.Drawing.Point(87, 13);
            this.txtSongID.Name = "txtSongID";
            this.txtSongID.Size = new System.Drawing.Size(100, 20);
            this.txtSongID.TabIndex = 1;
            // 
            // btnGetSong
            // 
            this.btnGetSong.Location = new System.Drawing.Point(194, 9);
            this.btnGetSong.Name = "btnGetSong";
            this.btnGetSong.Size = new System.Drawing.Size(107, 23);
            this.btnGetSong.TabIndex = 2;
            this.btnGetSong.Text = "&Get Song Details";
            this.btnGetSong.UseVisualStyleBackColor = true;
            this.btnGetSong.Click += new System.EventHandler(this.btnGetSong_Click);
            // 
            // lblSongDetails
            // 
            this.lblSongDetails.AutoSize = true;
            this.lblSongDetails.Location = new System.Drawing.Point(34, 55);
            this.lblSongDetails.Name = "lblSongDetails";
            this.lblSongDetails.Size = new System.Drawing.Size(39, 13);
            this.lblSongDetails.TabIndex = 3;
            this.lblSongDetails.Text = "Details";
            this.lblSongDetails.Click += new System.EventHandler(this.lblSongDetails_Click);
            // 
            // txtSongDetails
            // 
            this.txtSongDetails.Location = new System.Drawing.Point(75, 52);
            this.txtSongDetails.Multiline = true;
            this.txtSongDetails.Name = "txtSongDetails";
            this.txtSongDetails.Size = new System.Drawing.Size(226, 173);
            this.txtSongDetails.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 262);
            this.Controls.Add(this.txtSongDetails);
            this.Controls.Add(this.lblSongDetails);
            this.Controls.Add(this.btnGetSong);
            this.Controls.Add(this.txtSongID);
            this.Controls.Add(this.lblSongID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSongID;
        private System.Windows.Forms.TextBox txtSongID;
        private System.Windows.Forms.Button btnGetSong;
        private System.Windows.Forms.Label lblSongDetails;
        private System.Windows.Forms.TextBox txtSongDetails;
    }
}

