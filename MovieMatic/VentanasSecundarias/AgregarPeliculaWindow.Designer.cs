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
            anioEstrenoLabel.Location = new System.Drawing.Point(12, 44);
            anioEstrenoLabel.Name = "anioEstrenoLabel";
            anioEstrenoLabel.Size = new System.Drawing.Size(82, 13);
            anioEstrenoLabel.TabIndex = 1;
            anioEstrenoLabel.Text = "Año de estreno:";
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new System.Drawing.Point(45, 100);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(47, 13);
            directorLabel.TabIndex = 3;
            directorLabel.Text = "Director:";
            // 
            // generoLabel
            // 
            generoLabel.AutoSize = true;
            generoLabel.Location = new System.Drawing.Point(47, 126);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(45, 13);
            generoLabel.TabIndex = 5;
            generoLabel.Text = "Genero:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(45, 15);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "Nombre:";
            // 
            // sinopsisLabel
            // 
            sinopsisLabel.AutoSize = true;
            sinopsisLabel.Location = new System.Drawing.Point(43, 152);
            sinopsisLabel.Name = "sinopsisLabel";
            sinopsisLabel.Size = new System.Drawing.Size(49, 13);
            sinopsisLabel.TabIndex = 9;
            sinopsisLabel.Text = "Sinopsis:";
            // 
            // nombreApellidoLabel
            // 
            nombreApellidoLabel.AutoSize = true;
            nombreApellidoLabel.Location = new System.Drawing.Point(45, 71);
            nombreApellidoLabel.Name = "nombreApellidoLabel";
            nombreApellidoLabel.Size = new System.Drawing.Size(46, 13);
            nombreApellidoLabel.TabIndex = 10;
            nombreApellidoLabel.Text = "Actores:";
            // 
            // peliculaBindingSource
            // 
            this.peliculaBindingSource.DataSource = typeof(Entidades.Pelicula);
            // 
            // anioEstrenoTextBox
            // 
            this.anioEstrenoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculaBindingSource, "AnioEstreno", true));
            this.anioEstrenoTextBox.Location = new System.Drawing.Point(98, 41);
            this.anioEstrenoTextBox.Name = "anioEstrenoTextBox";
            this.anioEstrenoTextBox.Size = new System.Drawing.Size(50, 20);
            this.anioEstrenoTextBox.TabIndex = 2;
            // 
            // directorTextBox
            // 
            this.directorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculaBindingSource, "Director", true));
            this.directorTextBox.Location = new System.Drawing.Point(98, 97);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(143, 20);
            this.directorTextBox.TabIndex = 4;
            // 
            // generoTextBox
            // 
            this.generoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculaBindingSource, "Genero", true));
            this.generoTextBox.Location = new System.Drawing.Point(98, 123);
            this.generoTextBox.Name = "generoTextBox";
            this.generoTextBox.Size = new System.Drawing.Size(95, 20);
            this.generoTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculaBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(98, 12);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(246, 20);
            this.nombreTextBox.TabIndex = 8;
            // 
            // sinopsisRichTextBox
            // 
            this.sinopsisRichTextBox.Location = new System.Drawing.Point(98, 149);
            this.sinopsisRichTextBox.Name = "sinopsisRichTextBox";
            this.sinopsisRichTextBox.Size = new System.Drawing.Size(396, 131);
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
            this.nombreApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actoresBindingSource, "NombreApellido", true));
            this.nombreApellidoTextBox.Location = new System.Drawing.Point(98, 68);
            this.nombreApellidoTextBox.Name = "nombreApellidoTextBox";
            this.nombreApellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreApellidoTextBox.TabIndex = 11;
            // 
            // AgregarActorButton
            // 
            this.AgregarActorButton.Location = new System.Drawing.Point(214, 67);
            this.AgregarActorButton.Name = "AgregarActorButton";
            this.AgregarActorButton.Size = new System.Drawing.Size(82, 21);
            this.AgregarActorButton.TabIndex = 12;
            this.AgregarActorButton.Text = "Agregar actor";
            this.AgregarActorButton.UseVisualStyleBackColor = true;
            this.AgregarActorButton.Click += new System.EventHandler(this.AgregarActorButton_Click);
            // 
            // actoresNuevosComboBox
            // 
            this.actoresNuevosComboBox.FormattingEnabled = true;
            this.actoresNuevosComboBox.Location = new System.Drawing.Point(314, 67);
            this.actoresNuevosComboBox.Name = "actoresNuevosComboBox";
            this.actoresNuevosComboBox.Size = new System.Drawing.Size(121, 21);
            this.actoresNuevosComboBox.TabIndex = 13;
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(314, 315);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(75, 23);
            this.agregarButton.TabIndex = 14;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // AgregarPeliculaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 350);
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
            this.Name = "AgregarPeliculaWindow";
            this.Text = "AgregarPeliculaWindow";
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