﻿namespace Dreaw
{
    partial class world
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userRoomList = new System.Windows.Forms.FlowLayoutPanel();
            this.usrname = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Dreaw.Properties.Resources.join2;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(417, 866);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(345, 31);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Dreaw.Properties.Resources.use2;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(429, 762);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(338, 33);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Dreaw.Properties.Resources.create2;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(1038, 760);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(321, 37);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Dreaw.Properties.Resources.sigout2;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(1054, 866);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(273, 35);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Dreaw.Properties.Resources.wolrd2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1766, 1000);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // userRoomList
            // 
            this.userRoomList.AutoScroll = true;
            this.userRoomList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.userRoomList.Location = new System.Drawing.Point(300, 193);
            this.userRoomList.Name = "userRoomList";
            this.userRoomList.Size = new System.Drawing.Size(1204, 515);
            this.userRoomList.TabIndex = 10;
            // 
            // usrname
            // 
            this.usrname.AutoEllipsis = true;
            this.usrname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(126)))));
            this.usrname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrname.Location = new System.Drawing.Point(39, 154);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(108, 28);
            this.usrname.TabIndex = 11;
            this.usrname.Text = "Tùng Goku";
            this.usrname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // world
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 954);
            this.Controls.Add(this.usrname);
            this.Controls.Add(this.userRoomList);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "world";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "world";
            this.Load += new System.EventHandler(this.world_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.FlowLayoutPanel userRoomList;
        private System.Windows.Forms.Label usrname;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}