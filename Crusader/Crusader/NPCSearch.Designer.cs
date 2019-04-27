namespace Crusader
{
    partial class NPCSearch
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNPCName = new System.Windows.Forms.TextBox();
            this.txtSkill = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtFaction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(156, 307);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NPCName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Skill:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Faction:";
            // 
            // txtNPCName
            // 
            this.txtNPCName.Location = new System.Drawing.Point(178, 60);
            this.txtNPCName.Name = "txtNPCName";
            this.txtNPCName.Size = new System.Drawing.Size(100, 20);
            this.txtNPCName.TabIndex = 5;
            // 
            // txtSkill
            // 
            this.txtSkill.Location = new System.Drawing.Point(178, 113);
            this.txtSkill.Name = "txtSkill";
            this.txtSkill.Size = new System.Drawing.Size(100, 20);
            this.txtSkill.TabIndex = 6;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(178, 174);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 7;
            // 
            // txtFaction
            // 
            this.txtFaction.Location = new System.Drawing.Point(178, 233);
            this.txtFaction.Name = "txtFaction";
            this.txtFaction.Size = new System.Drawing.Size(100, 20);
            this.txtFaction.TabIndex = 8;
            // 
            // NPCSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 396);
            this.Controls.Add(this.txtFaction);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtSkill);
            this.Controls.Add(this.txtNPCName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Name = "NPCSearch";
            this.Text = "NPCSearch";
            this.Load += new System.EventHandler(this.NPCSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNPCName;
        private System.Windows.Forms.TextBox txtSkill;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtFaction;
    }
}