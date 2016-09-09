namespace MovieMatic.VentanasSecundarias
{
    partial class ResultadosBusquedaWindow
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
            this.resultadosTituloLabel = new System.Windows.Forms.Label();
            this.peliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultadosTituloLabel
            // 
            this.resultadosTituloLabel.AutoSize = true;
            this.resultadosTituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadosTituloLabel.Location = new System.Drawing.Point(81, 25);
            this.resultadosTituloLabel.Name = "resultadosTituloLabel";
            this.resultadosTituloLabel.Size = new System.Drawing.Size(369, 25);
            this.resultadosTituloLabel.TabIndex = 0;
            this.resultadosTituloLabel.Text = "RESULTADOS DE LA BUSQUEDA";
            // 
            // peliculaBindingSource
            // 
            this.peliculaBindingSource.DataSource = typeof(Entidades.Pelicula);
            // 
            // peliculaDataGridView
            // 
            this.peliculaDataGridView.AutoGenerateColumns = false;
            this.peliculaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peliculaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.peliculaDataGridView.DataSource = this.peliculaBindingSource;
            this.peliculaDataGridView.Location = new System.Drawing.Point(12, 53);
            this.peliculaDataGridView.Name = "peliculaDataGridView";
            this.peliculaDataGridView.Size = new System.Drawing.Size(523, 217);
            this.peliculaDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AnioEstreno";
            this.dataGridViewTextBoxColumn2.HeaderText = "Año";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Genero";
            this.dataGridViewTextBoxColumn3.HeaderText = "Género";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Director";
            this.dataGridViewTextBoxColumn4.HeaderText = "Director";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // ResultadosBusquedaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 321);
            this.Controls.Add(this.peliculaDataGridView);
            this.Controls.Add(this.resultadosTituloLabel);
            this.Name = "ResultadosBusquedaWindow";
            this.Text = "ResultadosBusquedaWindow";
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultadosTituloLabel;
        private System.Windows.Forms.BindingSource peliculaBindingSource;
        private System.Windows.Forms.DataGridView peliculaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}