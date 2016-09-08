namespace MovieMatic.VentanasSecundarias
{
    partial class AgregarPeliculaWindow
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
            System.Windows.Forms.Label anioEstrenoLabel;
            System.Windows.Forms.Label directorLabel;
            System.Windows.Forms.Label generoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label sinopsisLabel;
            System.Windows.Forms.Label nombreApellidoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPeliculaWindow));
            this.peliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anioEstrenoTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.generoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.sinopsisRichTextBox = new System.Windows.Forms.RichTextBox();
            this.actoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreApellidoTextBox = new System.Windows.Forms.TextBox();
            this.AgregarActorButton = new System.Windows.Forms.Button();
            this.actoresNuevosComboBox = new System.Windows.Forms.ComboBox();
            this.agregarButton = new System.Windows.Forms.Button();
            anioEstrenoLabel = new System.Windows.Forms.Label();
            directorLabel = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            sinopsisLabel = new System.Windows.Forms.Label();
            nombreApellidoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // anioEstrenoLabel
            // 
            anioEstrenoLabel.AutoSize = true;
            anioEstrenoLabel.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anioEstrenoLabel.ForeColor = System.Drawing.Color.Coral;
            anioEstrenoLabel.Location = new System.Drawing.Point(13, 69);
            anioEstrenoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            anioEstrenoLabel.Name = "anioEstrenoLabel";
            anioEstrenoLabel.Size = new System.Drawing.Size(149, 24);
            anioEstrenoLabel.TabIndex = 1;
            anioEstrenoLabel.Text = "Año de estreno:";
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            directorLabel.Location = new System.Drawing.Point(66, 154);
            directorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(94, 24);
            directorLabel.TabIndex = 3;
            directorLabel.Text = "Director:";
            // 
            // generoLabel
            // 
            generoLabel.AutoSize = true;
            generoLabel.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            generoLabel.Location = new System.Drawing.Point(76, 194);
            generoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(83, 24);
            generoLabel.TabIndex = 5;
            generoLabel.Text = "Genero:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Black;
            nombreLabel.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.ForeColor = System.Drawing.Color.Coral;
            nombreLabel.Location = new System.Drawing.Point(66, 25);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(96, 24);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "Nombre:";
            // 
            // sinopsisLabel
            // 
            sinopsisLabel.AutoSize = true;
            sinopsisLabel.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sinopsisLabel.Location = new System.Drawing.Point(68, 234);
            sinopsisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sinopsisLabel.Name = "sinopsisLabel";
            sinopsisLabel.Size = new System.Drawing.Size(92, 24);
            sinopsisLabel.TabIndex = 9;
            sinopsisLabel.Text = "Sinopsis:";
            // 
            // nombreApellidoLabel
            // 
            nombreApellidoLabel.AutoSize = true;
            nombreApellidoLabel.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreApellidoLabel.ForeColor = System.Drawing.Color.Coral;
            nombreApellidoLabel.Location = new System.Drawing.Point(76, 109);
            nombreApellidoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreApellidoLabel.Name = "nombreApellidoLabel";
            nombreApellidoLabel.Size = new System.Drawing.Size(84, 24);
            nombreApellidoLabel.TabIndex = 10;
            nombreApellidoLabel.Text = "Actores:";
            // 
            // peliculaBindingSource
            // 
            this.peliculaBindingSource.DataSource = typeof(Entidades.Pelicula);
            // 
            // anioEstrenoTextBox
            // 
            this.anioEstrenoTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.anioEstrenoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculaBindingSource, "AnioEstreno", true));
            this.anioEstrenoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.anioEstrenoTextBox.Location = new System.Drawing.Point(184, 68);
            this.anioEstrenoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anioEstrenoTextBox.Name = "anioEstrenoTextBox";
            this.anioEstrenoTextBox.Size = new System.Drawing.Size(73, 26);
            this.anioEstrenoTextBox.TabIndex = 2;
            // 
            // directorTextBox
            // 
            this.directorTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.directorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculaBindingSource, "Director", true));
            this.directorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.directorTextBox.Location = new System.Drawing.Point(184, 154);
            this.directorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(212, 26);
            this.directorTextBox.TabIndex = 4;
            // 
            // generoTextBox
            // 
            this.generoTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.generoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculaBindingSource, "Genero", true));
            this.generoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.generoTextBox.Location = new System.Drawing.Point(184, 194);
            this.generoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generoTextBox.Name = "generoTextBox";
            this.generoTextBox.Size = new System.Drawing.Size(140, 26);
            this.generoTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculaBindingSource, "Nombre", true));
            this.nombreTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nombreTextBox.Location = new System.Drawing.Point(184, 23);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(367, 26);
            this.nombreTextBox.TabIndex = 8;
            // 
            // sinopsisRichTextBox
            // 
            this.sinopsisRichTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.sinopsisRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.sinopsisRichTextBox.Location = new System.Drawing.Point(184, 234);
            this.sinopsisRichTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sinopsisRichTextBox.Name = "sinopsisRichTextBox";
            this.sinopsisRichTextBox.Size = new System.Drawing.Size(592, 199);
            this.sinopsisRichTextBox.TabIndex = 10;
            this.sinopsisRichTextBox.Text = "";
            // 
            // actoresBindingSource
            // 
            this.actoresBindingSource.DataMember = "Actores";
            this.actoresBindingSource.DataSource = this.peliculaBindingSource;
            // 
            // nombreApellidoTextBox
            // 
            this.nombreApellidoTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nombreApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actoresBindingSource, "NombreApellido", true));
            this.nombreApellidoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nombreApellidoTextBox.Location = new System.Drawing.Point(184, 110);
            this.nombreApellidoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombreApellidoTextBox.Name = "nombreApellidoTextBox";
            this.nombreApellidoTextBox.Size = new System.Drawing.Size(148, 26);
            this.nombreApellidoTextBox.TabIndex = 11;
            // 
            // AgregarActorButton
            // 
            this.AgregarActorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AgregarActorButton.BackgroundImage")));
            this.AgregarActorButton.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarActorButton.ForeColor = System.Drawing.Color.Coral;
            this.AgregarActorButton.Location = new System.Drawing.Point(376, 81);
            this.AgregarActorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgregarActorButton.Name = "AgregarActorButton";
            this.AgregarActorButton.Size = new System.Drawing.Size(116, 63);
            this.AgregarActorButton.TabIndex = 12;
            this.AgregarActorButton.Text = "Agregar actor";
            this.AgregarActorButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarActorButton.UseVisualStyleBackColor = true;
            this.AgregarActorButton.Click += new System.EventHandler(this.AgregarActorButton_Click);
            // 
            // actoresNuevosComboBox
            // 
            this.actoresNuevosComboBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.actoresNuevosComboBox.FormattingEnabled = true;
            this.actoresNuevosComboBox.Location = new System.Drawing.Point(549, 108);
            this.actoresNuevosComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actoresNuevosComboBox.Name = "actoresNuevosComboBox";
            this.actoresNuevosComboBox.Size = new System.Drawing.Size(180, 28);
            this.actoresNuevosComboBox.TabIndex = 13;
            // 
            // agregarButton
            // 
            this.agregarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("agregarButton.BackgroundImage")));
            this.agregarButton.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarButton.Location = new System.Drawing.Point(565, 469);
            this.agregarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(123, 65);
            this.agregarButton.TabIndex = 14;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // AgregarPeliculaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 550);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.actoresNuevosComboBox);
            this.Controls.Add(this.AgregarActorButton);
            this.Controls.Add(nombreApellidoLabel);
            this.Controls.Add(this.nombreApellidoTextBox);
            this.Controls.Add(this.sinopsisRichTextBox);
            this.Controls.Add(anioEstrenoLabel);
            this.Controls.Add(this.anioEstrenoTextBox);
            this.Controls.Add(directorLabel);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(generoLabel);
            this.Controls.Add(this.generoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(sinopsisLabel);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AgregarPeliculaWindow";
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource peliculaBindingSource;
        private System.Windows.Forms.TextBox anioEstrenoTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.TextBox generoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.RichTextBox sinopsisRichTextBox;
        private System.Windows.Forms.BindingSource actoresBindingSource;
        private System.Windows.Forms.TextBox nombreApellidoTextBox;
        private System.Windows.Forms.Button AgregarActorButton;
        private System.Windows.Forms.ComboBox actoresNuevosComboBox;
        private System.Windows.Forms.Button agregarButton;
    }
}