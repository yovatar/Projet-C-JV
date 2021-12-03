
namespace Calendrier.Views
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lstGameList = new System.Windows.Forms.ListBox();
            this.lblGameList = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblEditor = new System.Windows.Forms.Label();
            this.lblDevices = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(22, 29);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lstGameList
            // 
            this.lstGameList.FormattingEnabled = true;
            this.lstGameList.Location = new System.Drawing.Point(12, 47);
            this.lstGameList.Name = "lstGameList";
            this.lstGameList.Size = new System.Drawing.Size(323, 589);
            this.lstGameList.TabIndex = 1;
            // 
            // lblGameList
            // 
            this.lblGameList.AutoSize = true;
            this.lblGameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameList.Location = new System.Drawing.Point(527, 12);
            this.lblGameList.Name = "lblGameList";
            this.lblGameList.Size = new System.Drawing.Size(172, 37);
            this.lblGameList.TabIndex = 3;
            this.lblGameList.Text = "Game List";
            this.lblGameList.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(539, 111);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseDate.Location = new System.Drawing.Point(539, 248);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(159, 29);
            this.lblReleaseDate.TabIndex = 5;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // lblEditor
            // 
            this.lblEditor.AutoSize = true;
            this.lblEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditor.Location = new System.Drawing.Point(540, 391);
            this.lblEditor.Name = "lblEditor";
            this.lblEditor.Size = new System.Drawing.Size(77, 29);
            this.lblEditor.TabIndex = 6;
            this.lblEditor.Text = "Editor";
            // 
            // lblDevices
            // 
            this.lblDevices.AutoSize = true;
            this.lblDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevices.Location = new System.Drawing.Point(540, 552);
            this.lblDevices.Name = "lblDevices";
            this.lblDevices.Size = new System.Drawing.Size(99, 29);
            this.lblDevices.TabIndex = 7;
            this.lblDevices.Text = "Devices";
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(341, 47);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(42, 50);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "⬆";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(341, 586);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(42, 50);
            this.btnDown.TabIndex = 9;
            this.btnDown.Text = "⬇";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // GameList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 762);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblDevices);
            this.Controls.Add(this.lblEditor);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGameList);
            this.Controls.Add(this.lstGameList);
            this.Controls.Add(this.btnBack);
            this.Name = "GameList";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstGameList;
        private System.Windows.Forms.Label lblGameList;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblEditor;
        private System.Windows.Forms.Label lblDevices;
        private System.Windows.Forms.Button btnUp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDown;
    }
}