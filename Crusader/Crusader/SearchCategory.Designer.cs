﻿namespace Crusader
{
    partial class SearchCategory
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
            this.btnNPC = new System.Windows.Forms.Button();
            this.btnHero = new System.Windows.Forms.Button();
            this.btnChapter = new System.Windows.Forms.Button();
            this.btnResource = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNPC
            // 
            this.btnNPC.Location = new System.Drawing.Point(34, 58);
            this.btnNPC.Name = "btnNPC";
            this.btnNPC.Size = new System.Drawing.Size(75, 23);
            this.btnNPC.TabIndex = 0;
            this.btnNPC.Text = "NPC";
            this.btnNPC.UseVisualStyleBackColor = true;
            this.btnNPC.Click += new System.EventHandler(this.btnNPC_Click);
            // 
            // btnHero
            // 
            this.btnHero.Location = new System.Drawing.Point(200, 123);
            this.btnHero.Name = "btnHero";
            this.btnHero.Size = new System.Drawing.Size(75, 23);
            this.btnHero.TabIndex = 1;
            this.btnHero.Text = "Hero";
            this.btnHero.UseVisualStyleBackColor = true;
            this.btnHero.Click += new System.EventHandler(this.btnHero_Click);
            // 
            // btnChapter
            // 
            this.btnChapter.Location = new System.Drawing.Point(157, 58);
            this.btnChapter.Name = "btnChapter";
            this.btnChapter.Size = new System.Drawing.Size(75, 23);
            this.btnChapter.TabIndex = 1;
            this.btnChapter.Text = "Chapter";
            this.btnChapter.UseVisualStyleBackColor = true;
            this.btnChapter.Click += new System.EventHandler(this.btnChapter_Click);
            // 
            // btnResource
            // 
            this.btnResource.Location = new System.Drawing.Point(135, 181);
            this.btnResource.Name = "btnResource";
            this.btnResource.Size = new System.Drawing.Size(75, 23);
            this.btnResource.TabIndex = 1;
            this.btnResource.Text = "Resource";
            this.btnResource.UseVisualStyleBackColor = true;
            this.btnResource.Click += new System.EventHandler(this.btnResource_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(60, 123);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 23);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // SearchCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 299);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnResource);
            this.Controls.Add(this.btnChapter);
            this.Controls.Add(this.btnHero);
            this.Controls.Add(this.btnNPC);
            this.Name = "SearchCategory";
            this.Text = "SearchCategory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNPC;
        private System.Windows.Forms.Button btnHero;
        private System.Windows.Forms.Button btnChapter;
        private System.Windows.Forms.Button btnResource;
        private System.Windows.Forms.Button btnUser;
    }
}