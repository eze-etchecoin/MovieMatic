namespace MovieMatic.VentanasSecundarias
{
    partial class SalirWindow
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
            this.RespaldarSalirLabel = new System.Windows.Forms.Label();
            this.SiSalirButton = new System.Windows.Forms.Button();
            this.NoSalirButton = new System.Windows.Forms.Button();
            this.CancelarSalirButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RespaldarSalirLabel
            // 
            this.RespaldarSalirLabel.AutoSize = true;
            this.RespaldarSalirLabel.Location = new System.Drawing.Point(93, 26);
            this.RespaldarSalirLabel.Name = "RespaldarSalirLabel";
            this.RespaldarSalirLabel.Size = new System.Drawing.Size(142, 13);
            this.RespaldarSalirLabel.TabIndex = 0;
            this.RespaldarSalirLabel.Text = "¿Desea respaldar películas?";
            this.RespaldarSalirLabel.Click += new System.EventHandler(this.RespaldarSalirLabel_Click);
            // 
            // SiSalirButton
            // 
            this.SiSalirButton.Location = new System.Drawing.Point(31, 61);
            this.SiSalirButton.Name = "SiSalirButton";
            this.SiSalirButton.Size = new System.Drawing.Size(75, 23);
            this.SiSalirButton.TabIndex = 1;
            this.SiSalirButton.Text = "SI";
            this.SiSalirButton.UseVisualStyleBackColor = true;
            this.SiSalirButton.Click += new System.EventHandler(this.SiSalirButton_Click);
            // 
            // NoSalirButton
            // 
            this.NoSalirButton.Location = new System.Drawing.Point(133, 61);
            this.NoSalirButton.Name = "NoSalirButton";
            this.NoSalirButton.Size = new System.Drawing.Size(75, 23);
            this.NoSalirButton.TabIndex = 2;
            this.NoSalirButton.Text = "NO";
            this.NoSalirButton.UseVisualStyleBackColor = true;
            this.NoSalirButton.Click += new System.EventHandler(this.NoSalirButton_Click);
            // 
            // CancelarSalirButton
            // 
            this.CancelarSalirButton.Location = new System.Drawing.Point(236, 61);
            this.CancelarSalirButton.Name = "CancelarSalirButton";
            this.CancelarSalirButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarSalirButton.TabIndex = 3;
            this.CancelarSalirButton.Text = "Cancelar";
            this.CancelarSalirButton.UseVisualStyleBackColor = true;
            this.CancelarSalirButton.Click += new System.EventHandler(this.CancelarSalirButton_Click);
            // 
            // SalirWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 103);
            this.Controls.Add(this.CancelarSalirButton);
            this.Controls.Add(this.NoSalirButton);
            this.Controls.Add(this.SiSalirButton);
            this.Controls.Add(this.RespaldarSalirLabel);
            this.Name = "SalirWindow";
            this.Text = "SalirWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RespaldarSalirLabel;
        private System.Windows.Forms.Button SiSalirButton;
        private System.Windows.Forms.Button NoSalirButton;
        private System.Windows.Forms.Button CancelarSalirButton;
    }
}