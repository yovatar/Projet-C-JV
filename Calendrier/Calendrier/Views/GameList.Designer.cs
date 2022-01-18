
namespace Calendrier
{
    partial class GameList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameList));
            this.btnBack = new System.Windows.Forms.Button();
            this.lstGameList = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBack.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(184, 62);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstGameList
            // 
            this.lstGameList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstGameList.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGameList.FormattingEnabled = true;
<<<<<<< HEAD
            this.lstGameList.Location = new System.Drawing.Point(539, 78);
=======
            this.lstGameList.ItemHeight = 32;
            this.lstGameList.Location = new System.Drawing.Point(161, 146);
>>>>>>> 5156de79929d1eef09165977f63e3974311a8829
            this.lstGameList.Name = "lstGameList";
            this.lstGameList.Size = new System.Drawing.Size(613, 580);
            this.lstGameList.TabIndex = 1;
            this.lstGameList.SelectedIndexChanged += new System.EventHandler(this.lstGameList_SelectedIndexChanged);
            // 
            // GameList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calendrier.Properties.Resources._32;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1437, 798);
=======
            this.ClientSize = new System.Drawing.Size(1047, 874);
>>>>>>> 5156de79929d1eef09165977f63e3974311a8829
            this.Controls.Add(this.lstGameList);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameList";
            this.Text = "Game Finder List";
            this.Load += new System.EventHandler(this.GameList_Load);
            this.Resize += new System.EventHandler(this.GameList_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstGameList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}