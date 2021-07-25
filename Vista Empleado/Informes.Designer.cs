namespace Vista_Empleado
{
    partial class Informes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sisconfiscacioncarrosDataSet = new Vista_Empleado.sisconfiscacioncarrosDataSet();
            this.informeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informeTableAdapter = new Vista_Empleado.sisconfiscacioncarrosDataSetTableAdapters.informeTableAdapter();
            this.idInformeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRazonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAgenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahoraconfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sisconfiscacioncarrosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Info. Informes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInformeDataGridViewTextBoxColumn,
            this.idVehiculoDataGridViewTextBoxColumn,
            this.idRazonDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.idAgenteDataGridViewTextBoxColumn,
            this.fechahoraconfDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.informeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(946, 268);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(39, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 109);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Vehículos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre Agente";
            // 
            // sisconfiscacioncarrosDataSet
            // 
            this.sisconfiscacioncarrosDataSet.DataSetName = "sisconfiscacioncarrosDataSet";
            this.sisconfiscacioncarrosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informeBindingSource
            // 
            this.informeBindingSource.DataMember = "informe";
            this.informeBindingSource.DataSource = this.sisconfiscacioncarrosDataSet;
            // 
            // informeTableAdapter
            // 
            this.informeTableAdapter.ClearBeforeFill = true;
            // 
            // idInformeDataGridViewTextBoxColumn
            // 
            this.idInformeDataGridViewTextBoxColumn.DataPropertyName = "idInforme";
            this.idInformeDataGridViewTextBoxColumn.HeaderText = "idInforme";
            this.idInformeDataGridViewTextBoxColumn.Name = "idInformeDataGridViewTextBoxColumn";
            // 
            // idVehiculoDataGridViewTextBoxColumn
            // 
            this.idVehiculoDataGridViewTextBoxColumn.DataPropertyName = "idVehiculo";
            this.idVehiculoDataGridViewTextBoxColumn.HeaderText = "idVehiculo";
            this.idVehiculoDataGridViewTextBoxColumn.Name = "idVehiculoDataGridViewTextBoxColumn";
            // 
            // idRazonDataGridViewTextBoxColumn
            // 
            this.idRazonDataGridViewTextBoxColumn.DataPropertyName = "idRazon";
            this.idRazonDataGridViewTextBoxColumn.HeaderText = "idRazon";
            this.idRazonDataGridViewTextBoxColumn.Name = "idRazonDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // idAgenteDataGridViewTextBoxColumn
            // 
            this.idAgenteDataGridViewTextBoxColumn.DataPropertyName = "idAgente";
            this.idAgenteDataGridViewTextBoxColumn.HeaderText = "idAgente";
            this.idAgenteDataGridViewTextBoxColumn.Name = "idAgenteDataGridViewTextBoxColumn";
            // 
            // fechahoraconfDataGridViewTextBoxColumn
            // 
            this.fechahoraconfDataGridViewTextBoxColumn.DataPropertyName = "Fecha_hora_conf";
            this.fechahoraconfDataGridViewTextBoxColumn.HeaderText = "Fecha_hora_conf";
            this.fechahoraconfDataGridViewTextBoxColumn.Name = "fechahoraconfDataGridViewTextBoxColumn";
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Informes";
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.Informes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sisconfiscacioncarrosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private sisconfiscacioncarrosDataSet sisconfiscacioncarrosDataSet;
        private System.Windows.Forms.BindingSource informeBindingSource;
        private sisconfiscacioncarrosDataSetTableAdapters.informeTableAdapter informeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInformeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRazonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAgenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahoraconfDataGridViewTextBoxColumn;
    }
}