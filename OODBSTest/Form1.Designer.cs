namespace OODBSTest
{
    partial class Form1
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
            this.dgvPesonas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAmigos = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnAbrirDB = new System.Windows.Forms.Button();
            this.btnCerrarDB = new System.Windows.Forms.Button();
            this.btnBorarDB = new System.Windows.Forms.Button();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.btnPersonasConApellido = new System.Windows.Forms.Button();
            this.btnPersonasConEdad = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEdad1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEdad2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAmigos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesonas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmigos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPesonas
            // 
            this.dgvPesonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesonas.Location = new System.Drawing.Point(12, 34);
            this.dgvPesonas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPesonas.Name = "dgvPesonas";
            this.dgvPesonas.RowTemplate.Height = 24;
            this.dgvPesonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesonas.Size = new System.Drawing.Size(544, 389);
            this.dgvPesonas.TabIndex = 0;
            this.dgvPesonas.SelectionChanged += new System.EventHandler(this.dgvPesonas_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generar Personas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(584, 218);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(231, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Activar generacion de personas";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(584, 245);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(240, 151);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad de personas a generar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(29, 110);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(149, 30);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(581, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mensajes";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(584, 39);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(291, 148);
            this.listBox1.TabIndex = 6;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.ForeColor = System.Drawing.Color.Red;
            this.lblRows.Location = new System.Drawing.Point(25, 9);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(72, 18);
            this.lblRows.TabIndex = 7;
            this.lblRows.Text = "Personas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAmigos);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(584, 434);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(240, 112);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Amigos";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(29, 71);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Actualizar Personas";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAmigos
            // 
            this.btnAmigos.Location = new System.Drawing.Point(29, 34);
            this.btnAmigos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAmigos.Name = "btnAmigos";
            this.btnAmigos.Size = new System.Drawing.Size(149, 30);
            this.btnAmigos.TabIndex = 0;
            this.btnAmigos.Text = "Agregar Amigos";
            this.btnAmigos.UseVisualStyleBackColor = true;
            this.btnAmigos.Click += new System.EventHandler(this.btnAmigos_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(584, 407);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(217, 21);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Activar generacion de amigos";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnAbrirDB
            // 
            this.btnAbrirDB.Location = new System.Drawing.Point(613, 574);
            this.btnAbrirDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbrirDB.Name = "btnAbrirDB";
            this.btnAbrirDB.Size = new System.Drawing.Size(149, 30);
            this.btnAbrirDB.TabIndex = 10;
            this.btnAbrirDB.Text = "Abrir DB";
            this.btnAbrirDB.UseVisualStyleBackColor = true;
            this.btnAbrirDB.Click += new System.EventHandler(this.btnAbrirDB_Click);
            // 
            // btnCerrarDB
            // 
            this.btnCerrarDB.Location = new System.Drawing.Point(613, 609);
            this.btnCerrarDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarDB.Name = "btnCerrarDB";
            this.btnCerrarDB.Size = new System.Drawing.Size(149, 30);
            this.btnCerrarDB.TabIndex = 11;
            this.btnCerrarDB.Text = "Cerrar DB";
            this.btnCerrarDB.UseVisualStyleBackColor = true;
            this.btnCerrarDB.Click += new System.EventHandler(this.btnCerrarDB_Click);
            // 
            // btnBorarDB
            // 
            this.btnBorarDB.Location = new System.Drawing.Point(613, 645);
            this.btnBorarDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorarDB.Name = "btnBorarDB";
            this.btnBorarDB.Size = new System.Drawing.Size(149, 30);
            this.btnBorarDB.TabIndex = 12;
            this.btnBorarDB.Text = "Borrar DB";
            this.btnBorarDB.UseVisualStyleBackColor = true;
            this.btnBorarDB.Click += new System.EventHandler(this.btnBorarDB_Click);
            // 
            // btnPersonas
            // 
            this.btnPersonas.Location = new System.Drawing.Point(12, 591);
            this.btnPersonas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(199, 30);
            this.btnPersonas.TabIndex = 13;
            this.btnPersonas.Text = "Todas las personas en DB";
            this.btnPersonas.UseVisualStyleBackColor = true;
            this.btnPersonas.Click += new System.EventHandler(this.btnPersonas_Click);
            // 
            // btnPersonasConApellido
            // 
            this.btnPersonasConApellido.Location = new System.Drawing.Point(12, 626);
            this.btnPersonasConApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPersonasConApellido.Name = "btnPersonasConApellido";
            this.btnPersonasConApellido.Size = new System.Drawing.Size(199, 30);
            this.btnPersonasConApellido.TabIndex = 14;
            this.btnPersonasConApellido.Text = "Personas con apellido";
            this.btnPersonasConApellido.UseVisualStyleBackColor = true;
            this.btnPersonasConApellido.Click += new System.EventHandler(this.btnPersonasConApellido_Click);
            // 
            // btnPersonasConEdad
            // 
            this.btnPersonasConEdad.Location = new System.Drawing.Point(12, 663);
            this.btnPersonasConEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPersonasConEdad.Name = "btnPersonasConEdad";
            this.btnPersonasConEdad.Size = new System.Drawing.Size(199, 30);
            this.btnPersonasConEdad.TabIndex = 15;
            this.btnPersonasConEdad.Text = "Personas con edad entre";
            this.btnPersonasConEdad.UseVisualStyleBackColor = true;
            this.btnPersonasConEdad.Click += new System.EventHandler(this.btnPersonasConEdad_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(227, 631);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(208, 22);
            this.txtApellido.TabIndex = 16;
            // 
            // txtEdad1
            // 
            this.txtEdad1.Location = new System.Drawing.Point(227, 667);
            this.txtEdad1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdad1.Name = "txtEdad1";
            this.txtEdad1.Size = new System.Drawing.Size(49, 22);
            this.txtEdad1.TabIndex = 17;
            this.txtEdad1.TextChanged += new System.EventHandler(this.txtEdad1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 670);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "y";
            // 
            // txtEdad2
            // 
            this.txtEdad2.Location = new System.Drawing.Point(325, 667);
            this.txtEdad2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdad2.Name = "txtEdad2";
            this.txtEdad2.Size = new System.Drawing.Size(55, 22);
            this.txtEdad2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(25, 426);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Amigos";
            // 
            // dgvAmigos
            // 
            this.dgvAmigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmigos.Location = new System.Drawing.Point(12, 446);
            this.dgvAmigos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAmigos.Name = "dgvAmigos";
            this.dgvAmigos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAmigos.Size = new System.Drawing.Size(544, 139);
            this.dgvAmigos.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 699);
            this.Controls.Add(this.dgvAmigos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEdad2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEdad1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.btnPersonasConEdad);
            this.Controls.Add(this.btnPersonasConApellido);
            this.Controls.Add(this.btnPersonas);
            this.Controls.Add(this.btnBorarDB);
            this.Controls.Add(this.btnCerrarDB);
            this.Controls.Add(this.btnAbrirDB);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dgvPesonas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesonas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmigos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPesonas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAmigos;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnAbrirDB;
        private System.Windows.Forms.Button btnCerrarDB;
        private System.Windows.Forms.Button btnBorarDB;
        private System.Windows.Forms.Button btnPersonas;
        private System.Windows.Forms.Button btnPersonasConApellido;
        private System.Windows.Forms.Button btnPersonasConEdad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEdad1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEdad2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAmigos;
    }
}

