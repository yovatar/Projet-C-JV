
namespace Calendrier
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.lblGameFinder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEvent
            // 
            this.btnEvent.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEvent.Location = new System.Drawing.Point(328, 133);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(213, 85);
            this.btnEvent.TabIndex = 0;
            this.btnEvent.Text = "Event";
            this.btnEvent.UseVisualStyleBackColor = false;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGame.Location = new System.Drawing.Point(24, 133);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(213, 85);
            this.btnGame.TabIndex = 1;
            this.btnGame.Text = "Liste";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // lblGameFinder
            // 
            this.lblGameFinder.AutoSize = true;
            this.lblGameFinder.BackColor = System.Drawing.Color.Black;
            this.lblGameFinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameFinder.ForeColor = System.Drawing.Color.White;
            this.lblGameFinder.Location = new System.Drawing.Point(226, 9);
            this.lblGameFinder.Name = "lblGameFinder";
            this.lblGameFinder.Size = new System.Drawing.Size(215, 37);
            this.lblGameFinder.TabIndex = 2;
            this.lblGameFinder.Text = "Game Finder";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(643, 307);
            this.Controls.Add(this.lblGameFinder);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.Text = "Game Finder";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Resize += new System.EventHandler(this.Home_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Label lblGameFinder;
    }
}