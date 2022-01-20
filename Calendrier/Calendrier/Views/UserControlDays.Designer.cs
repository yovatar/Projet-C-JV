
namespace Calendrier
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbdays = new System.Windows.Forms.Label();
            this.EventLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdays.Location = new System.Drawing.Point(17, 13);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(23, 20);
            this.lbdays.TabIndex = 0;
            this.lbdays.Text = "00";
            // 
            // EventLbl
            // 
            this.EventLbl.AutoSize = true;
            this.EventLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventLbl.Location = new System.Drawing.Point(49, 40);
            this.EventLbl.Name = "EventLbl";
            this.EventLbl.Size = new System.Drawing.Size(50, 20);
            this.EventLbl.TabIndex = 1;
            this.EventLbl.Text = "Event";
            this.EventLbl.Click += new System.EventHandler(this.EventLbl_Click);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.EventLbl);
            this.Controls.Add(this.lbdays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(148, 87);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdays;
        private System.Windows.Forms.Label EventLbl;
    }
}
