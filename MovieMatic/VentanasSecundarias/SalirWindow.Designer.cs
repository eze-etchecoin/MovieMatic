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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalirWindow));
            this.SiSalirButton = new System.Windows.Forms.Button();
            this.NoSalirButton = new System.Windows.Forms.Button();
            this.CancelarSalirButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SiSalirButton
            // 
            this.SiSalirButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SiSalirButton.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiSalirButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SiSalirButton.Location = new System.Drawing.Point(46, 94);
            this.SiSalirButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SiSalirButton.Name = "SiSalirButton";
            this.SiSalirButton.Size = new System.Drawing.Size(112, 35);
            this.SiSalirButton.TabIndex = 1;
            this.SiSalirButton.Text = "SI";
            this.SiSalirButton.UseVisualStyleBackColor = false;
            this.SiSalirButton.Click += new System.EventHandler(this.SiSalirButton_Click);
            // 
            // NoSalirButton
            // 
            this.NoSalirButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NoSalirButton.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoSalirButton.ForeColor = System.Drawing.Color.Red;
            this.NoSalirButton.Location = new System.Drawing.Point(200, 94);
            this.NoSalirButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NoSalirButton.Name = "NoSalirButton";
            this.NoSalirButton.Size = new System.Drawing.Size(112, 35);
            this.NoSalirButton.TabIndex = 2;
            this.NoSalirButton.Text = "NO";
            this.NoSalirButton.UseVisualStyleBackColor = false;
            this.NoSalirButton.Click += new System.EventHandler(this.NoSalirButton_Click);
            // 
            // CancelarSalirButton
            // 
            this.CancelarSalirButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelarSalirButton.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarSalirButton.ForeColor = System.Drawing.Color.Coral;
            this.CancelarSalirButton.Location = new System.Drawing.Point(354, 94);
            this.CancelarSalirButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarSalirButton.Name = "CancelarSalirButton";
            this.CancelarSalirButton.Size = new System.Drawing.Size(112, 35);
            this.CancelarSalirButton.TabIndex = 3;
            this.CancelarSalirButton.Text = "Cancelar";
            this.CancelarSalirButton.UseVisualStyleBackColor = false;
            this.CancelarSalirButton.Click += new System.EventHandler(this.CancelarSalirButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "¿Desea guardar los cambios?";
            // 
            // SalirWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(537, 158);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelarSalirButton);
            this.Controls.Add(this.NoSalirButton);
            this.Controls.Add(this.SiSalirButton);
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SalirWindow";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SiSalirButton;
        private System.Windows.Forms.Button NoSalirButton;
        private System.Windows.Forms.Button CancelarSalirButton;
        private System.Windows.Forms.Label label1;
    }
}