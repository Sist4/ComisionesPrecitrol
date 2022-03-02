namespace PrecentacionComisiones.Formularios
{
    partial class Frm_Comision
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.GV_DetalleFacturas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Det_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V_Neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Observacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Cbx_TipoComision = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Porcentaje = new System.Windows.Forms.TextBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Cbx_Empleado = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Txt_ItemSeleccionado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Fecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Categoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_RazonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_NFactura = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Gv_Comision = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GV_DetalleFacturas)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Comision)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 7);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(186, 530);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // GV_DetalleFacturas
            // 
            this.GV_DetalleFacturas.AllowUserToAddRows = false;
            this.GV_DetalleFacturas.AllowUserToDeleteRows = false;
            this.GV_DetalleFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_DetalleFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Det_Codigo,
            this.Descripcion,
            this.V_Neto,
            this.Comentario});
            this.GV_DetalleFacturas.Location = new System.Drawing.Point(374, 186);
            this.GV_DetalleFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.GV_DetalleFacturas.Name = "GV_DetalleFacturas";
            this.GV_DetalleFacturas.Size = new System.Drawing.Size(1031, 220);
            this.GV_DetalleFacturas.TabIndex = 0;
            this.GV_DetalleFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_DetalleFacturas_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Det_Codigo
            // 
            this.Det_Codigo.HeaderText = "#";
            this.Det_Codigo.Name = "Det_Codigo";
            this.Det_Codigo.Width = 30;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 200F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 230;
            // 
            // V_Neto
            // 
            this.V_Neto.HeaderText = "V_Neto";
            this.V_Neto.Name = "V_Neto";
            this.V_Neto.Width = 60;
            // 
            // Comentario
            // 
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.Name = "Comentario";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.Txt_Observacion);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.Cbx_TipoComision);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.Txt_Porcentaje);
            this.panel5.Controls.Add(this.Btn_Aceptar);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.Cbx_Empleado);
            this.panel5.Location = new System.Drawing.Point(381, 414);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1031, 124);
            this.panel5.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(403, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "OBSERVACION";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Txt_Observacion
            // 
            this.Txt_Observacion.BackColor = System.Drawing.Color.White;
            this.Txt_Observacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Observacion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Txt_Observacion.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_Observacion.Location = new System.Drawing.Point(406, 31);
            this.Txt_Observacion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Observacion.Multiline = true;
            this.Txt_Observacion.Name = "Txt_Observacion";
            this.Txt_Observacion.Size = new System.Drawing.Size(436, 75);
            this.Txt_Observacion.TabIndex = 3;
            this.Txt_Observacion.TextChanged += new System.EventHandler(this.Txt_Observacion_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "TIPO COMISION";
            // 
            // Cbx_TipoComision
            // 
            this.Cbx_TipoComision.FormattingEnabled = true;
            this.Cbx_TipoComision.Items.AddRange(new object[] {
            "C. Mano de Obra",
            "C. Repuestos Stock",
            "C. Software y Diseño",
            "C. Metrología",
            "MANO DE OBRA CONTRATADA",
            "PROYECTOS SERVICIOS",
            "SOPORTE DE VENTAS",
            "MOVILIZACION TECNICOS PRECITROL"});
            this.Cbx_TipoComision.Location = new System.Drawing.Point(7, 82);
            this.Cbx_TipoComision.Margin = new System.Windows.Forms.Padding(4);
            this.Cbx_TipoComision.Name = "Cbx_TipoComision";
            this.Cbx_TipoComision.Size = new System.Drawing.Size(388, 24);
            this.Cbx_TipoComision.TabIndex = 1;
            this.Cbx_TipoComision.Text = "Seleccione ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "EMPLEADO";
            // 
            // Txt_Porcentaje
            // 
            this.Txt_Porcentaje.BackColor = System.Drawing.Color.White;
            this.Txt_Porcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Porcentaje.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Txt_Porcentaje.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_Porcentaje.Location = new System.Drawing.Point(850, 26);
            this.Txt_Porcentaje.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Porcentaje.Name = "Txt_Porcentaje";
            this.Txt_Porcentaje.Size = new System.Drawing.Size(164, 25);
            this.Txt_Porcentaje.TabIndex = 2;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Aceptar.Image = global::PrecentacionComisiones.Properties.Resources.comprobado;
            this.Btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Aceptar.Location = new System.Drawing.Point(852, 59);
            this.Btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(163, 49);
            this.Btn_Aceptar.TabIndex = 4;
            this.Btn_Aceptar.Text = "Asignar";
            this.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(847, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "% DE PARTICIPACION";
            // 
            // Cbx_Empleado
            // 
            this.Cbx_Empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cbx_Empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cbx_Empleado.FormattingEnabled = true;
            this.Cbx_Empleado.Location = new System.Drawing.Point(4, 27);
            this.Cbx_Empleado.Margin = new System.Windows.Forms.Padding(4);
            this.Cbx_Empleado.Name = "Cbx_Empleado";
            this.Cbx_Empleado.Size = new System.Drawing.Size(391, 24);
            this.Cbx_Empleado.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Txt_ItemSeleccionado);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.Txt_Fecha);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.Txt_Valor);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.Txt_Categoria);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.Txt_RazonSocial);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.Txt_NFactura);
            this.panel4.Location = new System.Drawing.Point(13, 102);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1392, 76);
            this.panel4.TabIndex = 7;
            // 
            // Txt_ItemSeleccionado
            // 
            this.Txt_ItemSeleccionado.Location = new System.Drawing.Point(652, 100);
            this.Txt_ItemSeleccionado.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_ItemSeleccionado.Name = "Txt_ItemSeleccionado";
            this.Txt_ItemSeleccionado.Size = new System.Drawing.Size(59, 22);
            this.Txt_ItemSeleccionado.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(444, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "F. EMISION:";
            // 
            // Txt_Fecha
            // 
            this.Txt_Fecha.BackColor = System.Drawing.Color.White;
            this.Txt_Fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Fecha.Enabled = false;
            this.Txt_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Txt_Fecha.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_Fecha.Location = new System.Drawing.Point(519, 48);
            this.Txt_Fecha.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Fecha.Name = "Txt_Fecha";
            this.Txt_Fecha.Size = new System.Drawing.Size(253, 15);
            this.Txt_Fecha.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(1153, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "VALOR:";
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.BackColor = System.Drawing.Color.White;
            this.Txt_Valor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Valor.Enabled = false;
            this.Txt_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Txt_Valor.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_Valor.Location = new System.Drawing.Point(1220, 50);
            this.Txt_Valor.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(152, 15);
            this.Txt_Valor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(782, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "CATEGORIA:";
            // 
            // Txt_Categoria
            // 
            this.Txt_Categoria.BackColor = System.Drawing.Color.White;
            this.Txt_Categoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Txt_Categoria.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_Categoria.Location = new System.Drawing.Point(887, 48);
            this.Txt_Categoria.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Categoria.Name = "Txt_Categoria";
            this.Txt_Categoria.Size = new System.Drawing.Size(246, 15);
            this.Txt_Categoria.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "RAZON SOCIAL:";
            // 
            // Txt_RazonSocial
            // 
            this.Txt_RazonSocial.BackColor = System.Drawing.Color.White;
            this.Txt_RazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_RazonSocial.Enabled = false;
            this.Txt_RazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Txt_RazonSocial.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_RazonSocial.Location = new System.Drawing.Point(147, 14);
            this.Txt_RazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_RazonSocial.Name = "Txt_RazonSocial";
            this.Txt_RazonSocial.Size = new System.Drawing.Size(1223, 15);
            this.Txt_RazonSocial.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "N° DE FACTURA:";
            // 
            // Txt_NFactura
            // 
            this.Txt_NFactura.BackColor = System.Drawing.Color.White;
            this.Txt_NFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_NFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Txt_NFactura.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_NFactura.Location = new System.Drawing.Point(147, 48);
            this.Txt_NFactura.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_NFactura.Name = "Txt_NFactura";
            this.Txt_NFactura.Size = new System.Drawing.Size(289, 15);
            this.Txt_NFactura.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 201);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 574);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(346, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Facturacion Precitrol";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "RESUMEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(203, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Cargar Facturas:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(206, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 125);
            this.panel1.TabIndex = 1;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(4, 91);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(97, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Fac. MTA";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(5, 33);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(97, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Fac. GYE";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(4, 62);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Fac. UIO";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(4, 4);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "TODOS";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.treeView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(346, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comisiones Asignadas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(205, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Cargar Facturas:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.radioButton7);
            this.panel6.Controls.Add(this.radioButton8);
            this.panel6.Controls.Add(this.radioButton9);
            this.panel6.Controls.Add(this.radioButton10);
            this.panel6.Location = new System.Drawing.Point(208, 27);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(130, 129);
            this.panel6.TabIndex = 3;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(5, 89);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(97, 21);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.Text = "Fac. MTA";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(5, 33);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(97, 21);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.Text = "Fac. GYE";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton9.Location = new System.Drawing.Point(5, 61);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(92, 21);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.Text = "Fac. UIO";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Checked = true;
            this.radioButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton10.Location = new System.Drawing.Point(4, 4);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(84, 21);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "TODOS";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(8, 8);
            this.treeView2.Margin = new System.Windows.Forms.Padding(4);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(197, 514);
            this.treeView2.TabIndex = 1;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItem1.Text = "Eliminar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Gv_Comision
            // 
            this.Gv_Comision.AllowUserToAddRows = false;
            this.Gv_Comision.AllowUserToDeleteRows = false;
            this.Gv_Comision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_Comision.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gv_Comision.Location = new System.Drawing.Point(374, 546);
            this.Gv_Comision.Margin = new System.Windows.Forms.Padding(4);
            this.Gv_Comision.Name = "Gv_Comision";
            this.Gv_Comision.Size = new System.Drawing.Size(1038, 229);
            this.Gv_Comision.TabIndex = 9;
            this.Gv_Comision.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Gv_Comision_CellMouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1425, 82);
            this.panel2.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrecentacionComisiones.Properties.Resources.recepcion;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(93, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 48);
            this.label11.TabIndex = 0;
            this.label11.Text = "COMISIONES";
            // 
            // Frm_Comision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1425, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Gv_Comision);
            this.Controls.Add(this.GV_DetalleFacturas);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Comision";
            this.Text = "Comision de Empleados";
            this.Load += new System.EventHandler(this.Frm_Comision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_DetalleFacturas)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Comision)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView GV_DetalleFacturas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_RazonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_NFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Categoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox Txt_Porcentaje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Cbx_Empleado;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.ComboBox Cbx_TipoComision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_ItemSeleccionado;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Observacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Det_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn V_Neto;
        private System.Windows.Forms.DataGridView Gv_Comision;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
    }
}