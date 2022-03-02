namespace PrecentacionComisiones.Formularios
{
    partial class Frm_Usuarios
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
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Txt_Password2 = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Txt_Usu = new System.Windows.Forms.TextBox();
            this.Usu_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Pasword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_Usuarios = new System.Windows.Forms.DataGridView();
            this.Usu_Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Usuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Txt_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Codigo.Enabled = false;
            this.Txt_Codigo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Txt_Codigo.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_Codigo.Location = new System.Drawing.Point(23, 41);
            this.Txt_Codigo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(299, 25);
            this.Txt_Codigo.TabIndex = 0;
            this.Txt_Codigo.Text = "CODIGO";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.Green;
            this.Btn_Guardar.Enabled = false;
            this.Btn_Guardar.FlatAppearance.BorderSize = 0;
            this.Btn_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Guardar.Location = new System.Drawing.Point(364, 132);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(257, 42);
            this.Btn_Guardar.TabIndex = 5;
            this.Btn_Guardar.Text = "GUARDAR REGISTRO";
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.Color.Green;
            this.Btn_Nuevo.FlatAppearance.BorderSize = 0;
            this.Btn_Nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_Nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nuevo.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Nuevo.Location = new System.Drawing.Point(364, 76);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(257, 42);
            this.Btn_Nuevo.TabIndex = 7;
            this.Btn_Nuevo.Text = "NUEVO REGISTRO";
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.comboBox1.Location = new System.Drawing.Point(364, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Seleccione";
            // 
            // Txt_Password2
            // 
            this.Txt_Password2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Txt_Password2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Password2.Enabled = false;
            this.Txt_Password2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Txt_Password2.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_Password2.Location = new System.Drawing.Point(23, 176);
            this.Txt_Password2.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Password2.Name = "Txt_Password2";
            this.Txt_Password2.Size = new System.Drawing.Size(299, 25);
            this.Txt_Password2.TabIndex = 3;
            this.Txt_Password2.Text = "CONFIRMAR CONTRASEÑA";
            // 
            // Txt_Password
            // 
            this.Txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Password.Enabled = false;
            this.Txt_Password.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Txt_Password.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_Password.Location = new System.Drawing.Point(23, 132);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(299, 25);
            this.Txt_Password.TabIndex = 2;
            this.Txt_Password.Text = "CONTRASEÑA";
            // 
            // Txt_Usu
            // 
            this.Txt_Usu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Txt_Usu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Usu.Enabled = false;
            this.Txt_Usu.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Txt_Usu.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_Usu.Location = new System.Drawing.Point(23, 94);
            this.Txt_Usu.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Usu.Name = "Txt_Usu";
            this.Txt_Usu.Size = new System.Drawing.Size(299, 25);
            this.Txt_Usu.TabIndex = 1;
            this.Txt_Usu.Text = "USUARIO";
            // 
            // Usu_Estado
            // 
            this.Usu_Estado.HeaderText = "ESTADO";
            this.Usu_Estado.Name = "Usu_Estado";
            // 
            // Usu_Pasword
            // 
            this.Usu_Pasword.HeaderText = "CONTRASEÑA";
            this.Usu_Pasword.Name = "Usu_Pasword";
            // 
            // Usu_Usuario
            // 
            this.Usu_Usuario.HeaderText = "USUARIOS";
            this.Usu_Usuario.Name = "Usu_Usuario";
            // 
            // Usu_Codigo
            // 
            this.Usu_Codigo.HeaderText = "#";
            this.Usu_Codigo.Name = "Usu_Codigo";
            // 
            // GV_Usuarios
            // 
            this.GV_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usu_Codigo,
            this.Usu_Usuario,
            this.Usu_Pasword,
            this.Usu_Rol,
            this.Usu_Estado});
            this.GV_Usuarios.Location = new System.Drawing.Point(4, 4);
            this.GV_Usuarios.Margin = new System.Windows.Forms.Padding(4);
            this.GV_Usuarios.Name = "GV_Usuarios";
            this.GV_Usuarios.Size = new System.Drawing.Size(640, 238);
            this.GV_Usuarios.TabIndex = 0;
            // 
            // Usu_Rol
            // 
            this.Usu_Rol.HeaderText = "ROL";
            this.Usu_Rol.Name = "Usu_Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(155, -48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Administracion de Usuarios";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GV_Usuarios);
            this.panel1.Location = new System.Drawing.Point(75, 251);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 247);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Txt_Codigo);
            this.panel2.Controls.Add(this.Btn_Guardar);
            this.panel2.Controls.Add(this.Btn_Nuevo);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.Txt_Password2);
            this.panel2.Controls.Add(this.Txt_Password);
            this.panel2.Controls.Add(this.Txt_Usu);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Location = new System.Drawing.Point(75, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 222);
            this.panel2.TabIndex = 9;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(643, 220);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape4.Enabled = false;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 17;
            this.lineShape4.X2 = 241;
            this.lineShape4.Y1 = 58;
            this.lineShape4.Y2 = 58;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 18;
            this.lineShape3.X2 = 242;
            this.lineShape3.Y1 = 165;
            this.lineShape3.Y2 = 165;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 18;
            this.lineShape2.X2 = 242;
            this.lineShape2.Y1 = 135;
            this.lineShape2.Y2 = 135;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 16;
            this.lineShape1.X2 = 240;
            this.lineShape1.Y1 = 99;
            this.lineShape1.Y2 = 99;
            // 
            // Frm_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_Usuarios";
            this.Text = "Frm_Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Usuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GV_Usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Pasword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Estado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Txt_Password2;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.TextBox Txt_Usu;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}