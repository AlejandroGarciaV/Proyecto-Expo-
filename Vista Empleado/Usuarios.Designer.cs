namespace Vista_Empleado
{
    partial class Usuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAdministracionUser = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoUser = new System.Windows.Forms.ComboBox();
            this.cmbestadoUser = new System.Windows.Forms.ComboBox();
            this.btnAgregarUser = new System.Windows.Forms.Button();
            this.btnEliminarUser = new System.Windows.Forms.Button();
            this.btnActualizaUser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdempleadoUser = new System.Windows.Forms.TextBox();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClaveUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministracionUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administración de Usuarios";
            // 
            // dgvAdministracionUser
            // 
            this.dgvAdministracionUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdministracionUser.Location = new System.Drawing.Point(53, 240);
            this.dgvAdministracionUser.Name = "dgvAdministracionUser";
            this.dgvAdministracionUser.Size = new System.Drawing.Size(909, 235);
            this.dgvAdministracionUser.TabIndex = 2;
            this.dgvAdministracionUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdministracionUser_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTipoUser);
            this.groupBox1.Controls.Add(this.cmbestadoUser);
            this.groupBox1.Controls.Add(this.btnAgregarUser);
            this.groupBox1.Controls.Add(this.btnEliminarUser);
            this.groupBox1.Controls.Add(this.btnActualizaUser);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIdempleadoUser);
            this.groupBox1.Controls.Add(this.txtIdUser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtClaveUser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombreUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBuscarUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(53, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 137);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // cmbTipoUser
            // 
            this.cmbTipoUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUser.FormattingEnabled = true;
            this.cmbTipoUser.Location = new System.Drawing.Point(451, 106);
            this.cmbTipoUser.Name = "cmbTipoUser";
            this.cmbTipoUser.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoUser.TabIndex = 60;
            this.cmbTipoUser.Click += new System.EventHandler(this.cmbTipoUser_Click);
            // 
            // cmbestadoUser
            // 
            this.cmbestadoUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestadoUser.FormattingEnabled = true;
            this.cmbestadoUser.Location = new System.Drawing.Point(451, 39);
            this.cmbestadoUser.Name = "cmbestadoUser";
            this.cmbestadoUser.Size = new System.Drawing.Size(121, 21);
            this.cmbestadoUser.TabIndex = 59;
            this.cmbestadoUser.Click += new System.EventHandler(this.cmbestadoUser_Click);
            // 
            // btnAgregarUser
            // 
            this.btnAgregarUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(224)))));
            this.btnAgregarUser.FlatAppearance.BorderSize = 0;
            this.btnAgregarUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAgregarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUser.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUser.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUser.Image = global::Vista_Empleado.Properties.Resources.Add;
            this.btnAgregarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUser.Location = new System.Drawing.Point(606, 28);
            this.btnAgregarUser.Name = "btnAgregarUser";
            this.btnAgregarUser.Size = new System.Drawing.Size(123, 40);
            this.btnAgregarUser.TabIndex = 58;
            this.btnAgregarUser.Text = "Agregar";
            this.btnAgregarUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarUser.UseVisualStyleBackColor = false;
            this.btnAgregarUser.Click += new System.EventHandler(this.btnAgregarUser_Click);
            // 
            // btnEliminarUser
            // 
            this.btnEliminarUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(224)))));
            this.btnEliminarUser.FlatAppearance.BorderSize = 0;
            this.btnEliminarUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEliminarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUser.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUser.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUser.Image = global::Vista_Empleado.Properties.Resources.Dump;
            this.btnEliminarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarUser.Location = new System.Drawing.Point(770, 91);
            this.btnEliminarUser.Name = "btnEliminarUser";
            this.btnEliminarUser.Size = new System.Drawing.Size(123, 40);
            this.btnEliminarUser.TabIndex = 57;
            this.btnEliminarUser.Text = "Eliminar";
            this.btnEliminarUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarUser.UseVisualStyleBackColor = false;
            this.btnEliminarUser.Click += new System.EventHandler(this.btnEliminarUser_Click);
            // 
            // btnActualizaUser
            // 
            this.btnActualizaUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizaUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(224)))));
            this.btnActualizaUser.FlatAppearance.BorderSize = 0;
            this.btnActualizaUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnActualizaUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizaUser.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizaUser.ForeColor = System.Drawing.Color.White;
            this.btnActualizaUser.Image = global::Vista_Empleado.Properties.Resources.Update;
            this.btnActualizaUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizaUser.Location = new System.Drawing.Point(606, 95);
            this.btnActualizaUser.Name = "btnActualizaUser";
            this.btnActualizaUser.Size = new System.Drawing.Size(123, 40);
            this.btnActualizaUser.TabIndex = 56;
            this.btnActualizaUser.Text = "Actualizar";
            this.btnActualizaUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizaUser.UseVisualStyleBackColor = false;
            this.btnActualizaUser.Click += new System.EventHandler(this.btnActualizaUser_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Tipo de Usuario";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Estado de Usuario";
            // 
            // txtIdempleadoUser
            // 
            this.txtIdempleadoUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdempleadoUser.Location = new System.Drawing.Point(12, 108);
            this.txtIdempleadoUser.Name = "txtIdempleadoUser";
            this.txtIdempleadoUser.Size = new System.Drawing.Size(97, 20);
            this.txtIdempleadoUser.TabIndex = 53;
            // 
            // txtIdUser
            // 
            this.txtIdUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdUser.Location = new System.Drawing.Point(241, 111);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.Size = new System.Drawing.Size(97, 20);
            this.txtIdUser.TabIndex = 52;
            this.txtIdUser.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "IdEmpleado";
            // 
            // txtClaveUser
            // 
            this.txtClaveUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClaveUser.Location = new System.Drawing.Point(241, 48);
            this.txtClaveUser.Name = "txtClaveUser";
            this.txtClaveUser.Size = new System.Drawing.Size(163, 20);
            this.txtClaveUser.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Clave";
            // 
            // txtNombreUser
            // 
            this.txtNombreUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombreUser.Location = new System.Drawing.Point(12, 48);
            this.txtNombreUser.Name = "txtNombreUser";
            this.txtNombreUser.Size = new System.Drawing.Size(165, 20);
            this.txtNombreUser.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Nombre del Usuario";
            // 
            // btnBuscarUser
            // 
            this.btnBuscarUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(224)))));
            this.btnBuscarUser.FlatAppearance.BorderSize = 0;
            this.btnBuscarUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBuscarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUser.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUser.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUser.Image = global::Vista_Empleado.Properties.Resources.Clean_up;
            this.btnBuscarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarUser.Location = new System.Drawing.Point(751, 28);
            this.btnBuscarUser.Name = "btnBuscarUser";
            this.btnBuscarUser.Size = new System.Drawing.Size(152, 40);
            this.btnBuscarUser.TabIndex = 46;
            this.btnBuscarUser.Text = "Limpiar Campos";
            this.btnBuscarUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarUser.UseVisualStyleBackColor = false;
            this.btnBuscarUser.Click += new System.EventHandler(this.btnBuscarUser_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "IdUsuario";
            this.label2.Visible = false;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAdministracionUser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministracionUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAdministracionUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipoUser;
        private System.Windows.Forms.ComboBox cmbestadoUser;
        private System.Windows.Forms.Button btnAgregarUser;
        private System.Windows.Forms.Button btnEliminarUser;
        private System.Windows.Forms.Button btnActualizaUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdempleadoUser;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClaveUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarUser;
        private System.Windows.Forms.Label label2;
    }
}