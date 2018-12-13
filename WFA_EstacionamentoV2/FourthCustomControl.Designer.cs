namespace WFA_EstacionamentoV2
{
    partial class FourthCustomControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FourthCustomControl));
            this.rBTodos = new System.Windows.Forms.RadioButton();
            this.rBBarroPreto = new System.Windows.Forms.RadioButton();
            this.rBCentro = new System.Windows.Forms.RadioButton();
            this.gBLocal = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rBVendaNova = new System.Windows.Forms.RadioButton();
            this.btnMostrarExtrato = new System.Windows.Forms.Button();
            this.rBFaturamento = new System.Windows.Forms.RadioButton();
            this.rBExtratoCliente = new System.Windows.Forms.RadioButton();
            this.gBTipo = new System.Windows.Forms.GroupBox();
            this.dateFimCliente = new System.Windows.Forms.DateTimePicker();
            this.dateInicioCliente = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCPFExtrato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gBCliente = new System.Windows.Forms.GroupBox();
            this.dateTimeFimFaturamento = new System.Windows.Forms.DateTimePicker();
            this.dateTimeIncioFaturamento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gBFaturamento = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.gBLocal.SuspendLayout();
            this.gBTipo.SuspendLayout();
            this.gBCliente.SuspendLayout();
            this.gBFaturamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // rBTodos
            // 
            this.rBTodos.AutoSize = true;
            this.rBTodos.Location = new System.Drawing.Point(7, 128);
            this.rBTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBTodos.Name = "rBTodos";
            this.rBTodos.Size = new System.Drawing.Size(55, 17);
            this.rBTodos.TabIndex = 5;
            this.rBTodos.TabStop = true;
            this.rBTodos.Text = "Todos";
            this.rBTodos.UseVisualStyleBackColor = true;
            this.rBTodos.CheckedChanged += new System.EventHandler(this.rBTodos_CheckedChanged);
            // 
            // rBBarroPreto
            // 
            this.rBBarroPreto.AutoSize = true;
            this.rBBarroPreto.Location = new System.Drawing.Point(7, 103);
            this.rBBarroPreto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBBarroPreto.Name = "rBBarroPreto";
            this.rBBarroPreto.Size = new System.Drawing.Size(78, 17);
            this.rBBarroPreto.TabIndex = 4;
            this.rBBarroPreto.TabStop = true;
            this.rBBarroPreto.Text = "Barro Preto";
            this.rBBarroPreto.UseVisualStyleBackColor = true;
            this.rBBarroPreto.CheckedChanged += new System.EventHandler(this.rBBarroPreto_CheckedChanged);
            // 
            // rBCentro
            // 
            this.rBCentro.AutoSize = true;
            this.rBCentro.Location = new System.Drawing.Point(7, 53);
            this.rBCentro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBCentro.Name = "rBCentro";
            this.rBCentro.Size = new System.Drawing.Size(56, 17);
            this.rBCentro.TabIndex = 2;
            this.rBCentro.TabStop = true;
            this.rBCentro.Text = "Centro";
            this.rBCentro.UseVisualStyleBackColor = true;
            this.rBCentro.CheckedChanged += new System.EventHandler(this.rBCentro_CheckedChanged);
            // 
            // gBLocal
            // 
            this.gBLocal.Controls.Add(this.label10);
            this.gBLocal.Controls.Add(this.rBTodos);
            this.gBLocal.Controls.Add(this.rBBarroPreto);
            this.gBLocal.Controls.Add(this.rBVendaNova);
            this.gBLocal.Controls.Add(this.rBCentro);
            this.gBLocal.Location = new System.Drawing.Point(35, 72);
            this.gBLocal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBLocal.Name = "gBLocal";
            this.gBLocal.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBLocal.Size = new System.Drawing.Size(208, 154);
            this.gBLocal.TabIndex = 82;
            this.gBLocal.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 29);
            this.label10.TabIndex = 81;
            this.label10.Text = "Estacionamento  :";
            // 
            // rBVendaNova
            // 
            this.rBVendaNova.AutoSize = true;
            this.rBVendaNova.Location = new System.Drawing.Point(7, 78);
            this.rBVendaNova.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBVendaNova.Name = "rBVendaNova";
            this.rBVendaNova.Size = new System.Drawing.Size(85, 17);
            this.rBVendaNova.TabIndex = 3;
            this.rBVendaNova.TabStop = true;
            this.rBVendaNova.Text = "Venda Nova";
            this.rBVendaNova.UseVisualStyleBackColor = true;
            this.rBVendaNova.CheckedChanged += new System.EventHandler(this.rBVendaNova_CheckedChanged);
            // 
            // btnMostrarExtrato
            // 
            this.btnMostrarExtrato.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMostrarExtrato.FlatAppearance.BorderSize = 0;
            this.btnMostrarExtrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarExtrato.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarExtrato.ForeColor = System.Drawing.Color.White;
            this.btnMostrarExtrato.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarExtrato.Image")));
            this.btnMostrarExtrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarExtrato.Location = new System.Drawing.Point(455, 442);
            this.btnMostrarExtrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarExtrato.Name = "btnMostrarExtrato";
            this.btnMostrarExtrato.Size = new System.Drawing.Size(92, 39);
            this.btnMostrarExtrato.TabIndex = 83;
            this.btnMostrarExtrato.Text = "Extrato";
            this.btnMostrarExtrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarExtrato.UseVisualStyleBackColor = false;
            // 
            // rBFaturamento
            // 
            this.rBFaturamento.AutoSize = true;
            this.rBFaturamento.Location = new System.Drawing.Point(7, 37);
            this.rBFaturamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBFaturamento.Name = "rBFaturamento";
            this.rBFaturamento.Size = new System.Drawing.Size(84, 17);
            this.rBFaturamento.TabIndex = 3;
            this.rBFaturamento.TabStop = true;
            this.rBFaturamento.Text = "Faturamento";
            this.rBFaturamento.UseVisualStyleBackColor = true;
            this.rBFaturamento.CheckedChanged += new System.EventHandler(this.rBFaturamento_CheckedChanged);
            // 
            // rBExtratoCliente
            // 
            this.rBExtratoCliente.AutoSize = true;
            this.rBExtratoCliente.Location = new System.Drawing.Point(7, 14);
            this.rBExtratoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBExtratoCliente.Name = "rBExtratoCliente";
            this.rBExtratoCliente.Size = new System.Drawing.Size(93, 17);
            this.rBExtratoCliente.TabIndex = 2;
            this.rBExtratoCliente.TabStop = true;
            this.rBExtratoCliente.Text = "Extrato Cliente";
            this.rBExtratoCliente.UseVisualStyleBackColor = true;
            this.rBExtratoCliente.CheckedChanged += new System.EventHandler(this.rBExtratoCliente_CheckedChanged);
            // 
            // gBTipo
            // 
            this.gBTipo.Controls.Add(this.rBFaturamento);
            this.gBTipo.Controls.Add(this.rBExtratoCliente);
            this.gBTipo.Location = new System.Drawing.Point(353, 109);
            this.gBTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBTipo.Name = "gBTipo";
            this.gBTipo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBTipo.Size = new System.Drawing.Size(131, 58);
            this.gBTipo.TabIndex = 81;
            this.gBTipo.TabStop = false;
            // 
            // dateFimCliente
            // 
            this.dateFimCliente.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFimCliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFimCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateFimCliente.Location = new System.Drawing.Point(143, 88);
            this.dateFimCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateFimCliente.Name = "dateFimCliente";
            this.dateFimCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateFimCliente.Size = new System.Drawing.Size(81, 20);
            this.dateFimCliente.TabIndex = 67;
            // 
            // dateInicioCliente
            // 
            this.dateInicioCliente.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInicioCliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicioCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateInicioCliente.Location = new System.Drawing.Point(143, 63);
            this.dateInicioCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateInicioCliente.Name = "dateInicioCliente";
            this.dateInicioCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateInicioCliente.Size = new System.Drawing.Size(81, 20);
            this.dateInicioCliente.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 64;
            this.label2.Text = "Inicio : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 63;
            this.label1.Text = "Periodo:  ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(2, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 29);
            this.label7.TabIndex = 62;
            this.label7.Text = "Cliente : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 61;
            this.label4.Text = "CPF :";
            // 
            // txbCPFExtrato
            // 
            this.txbCPFExtrato.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCPFExtrato.Location = new System.Drawing.Point(176, 11);
            this.txbCPFExtrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbCPFExtrato.MaxLength = 11;
            this.txbCPFExtrato.Name = "txbCPFExtrato";
            this.txbCPFExtrato.Size = new System.Drawing.Size(113, 29);
            this.txbCPFExtrato.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 65;
            this.label3.Text = "Fim :";
            // 
            // gBCliente
            // 
            this.gBCliente.Controls.Add(this.dateFimCliente);
            this.gBCliente.Controls.Add(this.dateInicioCliente);
            this.gBCliente.Controls.Add(this.label2);
            this.gBCliente.Controls.Add(this.label1);
            this.gBCliente.Controls.Add(this.label7);
            this.gBCliente.Controls.Add(this.label4);
            this.gBCliente.Controls.Add(this.txbCPFExtrato);
            this.gBCliente.Controls.Add(this.label3);
            this.gBCliente.Location = new System.Drawing.Point(34, 237);
            this.gBCliente.Name = "gBCliente";
            this.gBCliente.Size = new System.Drawing.Size(308, 124);
            this.gBCliente.TabIndex = 84;
            this.gBCliente.TabStop = false;
            // 
            // dateTimeFimFaturamento
            // 
            this.dateTimeFimFaturamento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFimFaturamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFimFaturamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimeFimFaturamento.Location = new System.Drawing.Point(142, 83);
            this.dateTimeFimFaturamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeFimFaturamento.Name = "dateTimeFimFaturamento";
            this.dateTimeFimFaturamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeFimFaturamento.Size = new System.Drawing.Size(81, 20);
            this.dateTimeFimFaturamento.TabIndex = 73;
            // 
            // dateTimeIncioFaturamento
            // 
            this.dateTimeIncioFaturamento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeIncioFaturamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeIncioFaturamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimeIncioFaturamento.Location = new System.Drawing.Point(142, 58);
            this.dateTimeIncioFaturamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeIncioFaturamento.Name = "dateTimeIncioFaturamento";
            this.dateTimeIncioFaturamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeIncioFaturamento.Size = new System.Drawing.Size(81, 20);
            this.dateTimeIncioFaturamento.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 71;
            this.label6.Text = "Fim :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(86, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 70;
            this.label8.Text = "Inicio : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 21);
            this.label9.TabIndex = 69;
            this.label9.Text = "Periodo:  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 29);
            this.label5.TabIndex = 68;
            this.label5.Text = "Faturamento: ";
            // 
            // gBFaturamento
            // 
            this.gBFaturamento.Controls.Add(this.dateTimeFimFaturamento);
            this.gBFaturamento.Controls.Add(this.dateTimeIncioFaturamento);
            this.gBFaturamento.Controls.Add(this.label6);
            this.gBFaturamento.Controls.Add(this.label8);
            this.gBFaturamento.Controls.Add(this.label9);
            this.gBFaturamento.Controls.Add(this.label5);
            this.gBFaturamento.Location = new System.Drawing.Point(35, 370);
            this.gBFaturamento.Name = "gBFaturamento";
            this.gBFaturamento.Size = new System.Drawing.Size(307, 111);
            this.gBFaturamento.TabIndex = 85;
            this.gBFaturamento.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(548, 2);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 23);
            this.btnFechar.TabIndex = 68;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Elephant", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Goldenrod;
            this.label12.Location = new System.Drawing.Point(32, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 49);
            this.label12.TabIndex = 86;
            this.label12.Text = "Extrato :";
            // 
            // FourthCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gBLocal);
            this.Controls.Add(this.btnMostrarExtrato);
            this.Controls.Add(this.gBTipo);
            this.Controls.Add(this.gBCliente);
            this.Controls.Add(this.gBFaturamento);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FourthCustomControl";
            this.Size = new System.Drawing.Size(575, 516);
            this.gBLocal.ResumeLayout(false);
            this.gBLocal.PerformLayout();
            this.gBTipo.ResumeLayout(false);
            this.gBTipo.PerformLayout();
            this.gBCliente.ResumeLayout(false);
            this.gBCliente.PerformLayout();
            this.gBFaturamento.ResumeLayout(false);
            this.gBFaturamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rBTodos;
        private System.Windows.Forms.RadioButton rBBarroPreto;
        private System.Windows.Forms.RadioButton rBCentro;
        private System.Windows.Forms.GroupBox gBLocal;
        private System.Windows.Forms.RadioButton rBVendaNova;
        private System.Windows.Forms.Button btnMostrarExtrato;
        private System.Windows.Forms.RadioButton rBFaturamento;
        private System.Windows.Forms.RadioButton rBExtratoCliente;
        private System.Windows.Forms.GroupBox gBTipo;
        private System.Windows.Forms.DateTimePicker dateFimCliente;
        private System.Windows.Forms.DateTimePicker dateInicioCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCPFExtrato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gBCliente;
        private System.Windows.Forms.DateTimePicker dateTimeFimFaturamento;
        private System.Windows.Forms.DateTimePicker dateTimeIncioFaturamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gBFaturamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label12;
    }
}
