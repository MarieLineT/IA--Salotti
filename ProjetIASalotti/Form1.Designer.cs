namespace ProjetIASalotti
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.initialpositionlbl = new System.Windows.Forms.Label();
            this.finalpositionlbl = new System.Windows.Forms.Label();
            this.initialpositiontxtbx = new System.Windows.Forms.TextBox();
            this.finalpositiontxtbx = new System.Windows.Forms.TextBox();
            this.resolvebtn = new System.Windows.Forms.Button();
            this.pathlbl = new System.Windows.Forms.Label();
            this.costlbl = new System.Windows.Forms.Label();
            this.pathlstbx = new System.Windows.Forms.ListBox();
            this.costtxtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // initialpositionlbl
            // 
            this.initialpositionlbl.AutoSize = true;
            this.initialpositionlbl.Location = new System.Drawing.Point(44, 26);
            this.initialpositionlbl.Name = "initialpositionlbl";
            this.initialpositionlbl.Size = new System.Drawing.Size(76, 13);
            this.initialpositionlbl.TabIndex = 0;
            this.initialpositionlbl.Text = "Position initiale";
            // 
            // finalpositionlbl
            // 
            this.finalpositionlbl.AutoSize = true;
            this.finalpositionlbl.Location = new System.Drawing.Point(44, 84);
            this.finalpositionlbl.Name = "finalpositionlbl";
            this.finalpositionlbl.Size = new System.Drawing.Size(72, 13);
            this.finalpositionlbl.TabIndex = 1;
            this.finalpositionlbl.Text = "Position finale";
            // 
            // initialpositiontxtbx
            // 
            this.initialpositiontxtbx.Location = new System.Drawing.Point(47, 42);
            this.initialpositiontxtbx.Name = "initialpositiontxtbx";
            this.initialpositiontxtbx.Size = new System.Drawing.Size(100, 20);
            this.initialpositiontxtbx.TabIndex = 2;
            // 
            // finalpositiontxtbx
            // 
            this.finalpositiontxtbx.Location = new System.Drawing.Point(47, 100);
            this.finalpositiontxtbx.Name = "finalpositiontxtbx";
            this.finalpositiontxtbx.Size = new System.Drawing.Size(100, 20);
            this.finalpositiontxtbx.TabIndex = 3;
            // 
            // resolvebtn
            // 
            this.resolvebtn.Location = new System.Drawing.Point(312, 73);
            this.resolvebtn.Name = "resolvebtn";
            this.resolvebtn.Size = new System.Drawing.Size(75, 23);
            this.resolvebtn.TabIndex = 4;
            this.resolvebtn.Text = "Résoudre";
            this.resolvebtn.UseVisualStyleBackColor = true;
            // 
            // pathlbl
            // 
            this.pathlbl.AutoSize = true;
            this.pathlbl.Location = new System.Drawing.Point(56, 237);
            this.pathlbl.Name = "pathlbl";
            this.pathlbl.Size = new System.Drawing.Size(49, 13);
            this.pathlbl.TabIndex = 5;
            this.pathlbl.Text = "Parcours";
            // 
            // costlbl
            // 
            this.costlbl.AutoSize = true;
            this.costlbl.Location = new System.Drawing.Point(336, 236);
            this.costlbl.Name = "costlbl";
            this.costlbl.Size = new System.Drawing.Size(29, 13);
            this.costlbl.TabIndex = 6;
            this.costlbl.Text = "Coût";
            // 
            // pathlstbx
            // 
            this.pathlstbx.FormattingEnabled = true;
            this.pathlstbx.Location = new System.Drawing.Point(47, 272);
            this.pathlstbx.Name = "pathlstbx";
            this.pathlstbx.Size = new System.Drawing.Size(120, 95);
            this.pathlstbx.TabIndex = 7;
            // 
            // costtxtbx
            // 
            this.costtxtbx.Location = new System.Drawing.Point(312, 261);
            this.costtxtbx.Name = "costtxtbx";
            this.costtxtbx.Size = new System.Drawing.Size(100, 20);
            this.costtxtbx.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 449);
            this.Controls.Add(this.costtxtbx);
            this.Controls.Add(this.pathlstbx);
            this.Controls.Add(this.costlbl);
            this.Controls.Add(this.pathlbl);
            this.Controls.Add(this.resolvebtn);
            this.Controls.Add(this.finalpositiontxtbx);
            this.Controls.Add(this.initialpositiontxtbx);
            this.Controls.Add(this.finalpositionlbl);
            this.Controls.Add(this.initialpositionlbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label initialpositionlbl;
        private System.Windows.Forms.Label finalpositionlbl;
        private System.Windows.Forms.TextBox initialpositiontxtbx;
        private System.Windows.Forms.TextBox finalpositiontxtbx;
        private System.Windows.Forms.Button resolvebtn;
        private System.Windows.Forms.Label pathlbl;
        private System.Windows.Forms.Label costlbl;
        private System.Windows.Forms.ListBox pathlstbx;
        private System.Windows.Forms.TextBox costtxtbx;
    }
}

