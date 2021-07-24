namespace Vista_Empleado
{
    partial class Vehiculos_Conf
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
            this.dgvVehiculosConf = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtmatriculaCarro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstadoCarro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdinforme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmatriculaconf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiarConfi = new System.Windows.Forms.Button();
            this.btnEliminarConfi = new System.Windows.Forms.Button();
            this.btnActualizarEstadoV = new System.Windows.Forms.Button();
            this.btnBuscarV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosConf)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVehiculosConf
            // 
            this.dgvVehiculosConf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvVehiculosConf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculosConf.Location = new System.Drawing.Point(12, 202);
            this.dgvVehiculosConf.Name = "dgvVehiculosConf";
            this.dgvVehiculosConf.Size = new System.Drawing.Size(1010, 305);
            this.dgvVehiculosConf.TabIndex = 2;
            this.dgvVehiculosConf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculosConf_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnLimpiarConfi);
            this.groupBox2.Controls.Add(this.btnEliminarConfi);
            this.groupBox2.Controls.Add(this.txtmatriculaCarro);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbEstadoCarro);
            this.groupBox2.Controls.Add(this.btnActualizarEstadoV);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtIdinforme);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(460, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 123);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actualizar estado";
            // 
            // txtmatriculaCarro
            // 
            this.txtmatriculaCarro.Location = new System.Drawing.Point(27, 40);
            this.txtmatriculaCarro.Name = "txtmatriculaCarro";
            this.txtmatriculaCarro.ReadOnly = true;
            this.txtmatriculaCarro.Size = new System.Drawing.Size(89, 20);
            this.txtmatriculaCarro.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Matricula";
            // 
            // cmbEstadoCarro
            // 
            this.cmbEstadoCarro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCarro.FormattingEnabled = true;
            this.cmbEstadoCarro.Location = new System.Drawing.Point(208, 39);
            this.cmbEstadoCarro.Name = "cmbEstadoCarro";
            this.cmbEstadoCarro.Size = new System.Drawing.Size(113, 21);
            this.cmbEstadoCarro.TabIndex = 10;
            this.cmbEstadoCarro.Click += new System.EventHandler(this.cmbEstadoCarro_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Estado";
            // 
            // txtIdinforme
            // 
            this.txtIdinforme.Location = new System.Drawing.Point(399, 40);
            this.txtIdinforme.Name = "txtIdinforme";
            this.txtIdinforme.ReadOnly = true;
            this.txtIdinforme.Size = new System.Drawing.Size(89, 20);
            this.txtIdinforme.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "N°Informe";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txtmatriculaconf);
            this.groupBox1.Controls.Add(this.btnBuscarV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(49, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 109);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Vehículos";
            // 
            // txtmatriculaconf
            // 
            this.txtmatriculaconf.Location = new System.Drawing.Point(77, 54);
            this.txtmatriculaconf.Name = "txtmatriculaconf";
            this.txtmatriculaconf.Size = new System.Drawing.Size(155, 20);
            this.txtmatriculaconf.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matricula";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vehículos Confiscados ";
            // 
            // btnLimpiarConfi
            // 
            this.btnLimpiarConfi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiarConfi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(224)))));
            this.btnLimpiarConfi.FlatAppearance.BorderSize = 0;
            this.btnLimpiarConfi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLimpiarConfi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarConfi.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarConfi.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarConfi.Image = global::Vista_Empleado.Properties.Resources.Clean_up;
            this.btnLimpiarConfi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarConfi.Location = new System.Drawing.Point(358, 80);
            this.btnLimpiarConfi.Name = "btnLimpiarConfi";
            this.btnLimpiarConfi.Size = new System.Drawing.Size(149, 37);
            this.btnLimpiarConfi.TabIndex = 12;
            this.btnLimpiarConfi.Text = "Limpiar campos";
            this.btnLimpiarConfi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarConfi.UseVisualStyleBackColor = false;
            this.btnLimpiarConfi.Click += new System.EventHandler(this.btnLimpiarConfi_Click);
            // 
            // btnEliminarConfi
            // 
            this.btnEliminarConfi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminarConfi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(224)))));
            this.btnEliminarConfi.FlatAppearance.BorderSize = 0;
            this.btnEliminarConfi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEliminarConfi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarConfi.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarConfi.ForeColor = System.Drawing.Color.White;
            this.btnEliminarConfi.Image = global::Vista_Empleado.Properties.Resources.Dump;
            this.btnEliminarConfi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarConfi.Location = new System.Drawing.Point(208, 80);
            this.btnEliminarConfi.Name = "btnEliminarConfi";
            this.btnEliminarConfi.Size = new System.Drawing.Size(113, 37);
            this.btnEliminarConfi.TabIndex = 6;
            this.btnEliminarConfi.Text = "Eliminar";
            this.btnEliminarConfi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarConfi.UseVisualStyleBackColor = false;
            this.btnEliminarConfi.Click += new System.EventHandler(this.btnEliminarConfi_Click);
            // 
            // btnActualizarEstadoV
            // 
            this.btnActualizarEstadoV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizarEstadoV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(224)))));
            this.btnActualizarEstadoV.FlatAppearance.BorderSize = 0;
            this.btnActualizarEstadoV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnActualizarEstadoV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEstadoV.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEstadoV.ForeColor = System.Drawing.Color.White;
            this.btnActualizarEstadoV.Image = global::Vista_Empleado.Properties.Resources.Update;
            this.btnActualizarEstadoV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarEstadoV.Location = new System.Drawing.Point(27, 80);
            this.btnActualizarEstadoV.Name = "btnActualizarEstadoV";
            this.btnActualizarEstadoV.Size = new System.Drawing.Size(136, 37);
            this.btnActualizarEstadoV.TabIndex = 6;
            this.btnActualizarEstadoV.Text = "Actualizar";
            this.btnActualizarEstadoV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarEstadoV.UseVisualStyleBackColor = false;
            this.btnActualizarEstadoV.Click += new System.EventHandler(this.btnActualizarEstadoV_Click);
            // 
            // btnBuscarV
            // 
            this.btnBuscarV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(224)))));
            this.btnBuscarV.FlatAppearance.BorderSize = 0;
            this.btnBuscarV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBuscarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarV.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarV.ForeColor = System.Drawing.Color.White;
            this.btnBuscarV.Image = global::Vista_Empleado.Properties.Resources.search;
            this.btnBuscarV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarV.Location = new System.Drawing.Point(247, 43);
            this.btnBuscarV.Name = "btnBuscarV";
            this.btnBuscarV.Size = new System.Drawing.Size(123, 40);
            this.btnBuscarV.TabIndex = 6;
            this.btnBuscarV.Text = "Buscar";
            this.btnBuscarV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarV.UseVisualStyleBackColor = false;
            this.btnBuscarV.Click += new System.EventHandler(this.btnBuscarV_Click);
            // 
            // Vehiculos_Conf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVehiculosConf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vehiculos_Conf";
            this.Text = "Vehiculos_Conf";
            this.Load += new System.EventHandler(this.Vehiculos_Conf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosConf)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVehiculosConf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpiarConfi;
        private System.Windows.Forms.Button btnEliminarConfi;
        private System.Windows.Forms.TextBox txtmatriculaCarro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEstadoCarro;
        private System.Windows.Forms.Button btnActualizarEstadoV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdinforme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmatriculaconf;
        private System.Windows.Forms.Button btnBuscarV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}