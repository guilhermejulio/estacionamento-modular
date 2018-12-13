namespace WFA_EstacionamentoV2
{
    partial class SecondCustomControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondCustomControl));
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gBVeiculo = new System.Windows.Forms.GroupBox();
            this.tipoVeiculo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gBData = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimeSaida = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEntrada = new System.Windows.Forms.DateTimePicker();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.checkin = new System.Windows.Forms.Button();
            this.gBCliente = new System.Windows.Forms.GroupBox();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gBLocal = new System.Windows.Forms.GroupBox();
            this.Localizacao = new System.Windows.Forms.ComboBox();
            this.gBFormaCobranca = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.FormasCobranca = new System.Windows.Forms.ComboBox();
            this.DadosVeiculo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPlaca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.checkout = new System.Windows.Forms.Button();
            this.gBVeiculo.SuspendLayout();
            this.gBData.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gBCliente.SuspendLayout();
            this.gBLocal.SuspendLayout();
            this.gBFormaCobranca.SuspendLayout();
            this.DadosVeiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Elephant", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(16, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 49);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cadastro :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Localização :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, -2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Forma de cobrança :";
            // 
            // gBVeiculo
            // 
            this.gBVeiculo.Controls.Add(this.tipoVeiculo);
            this.gBVeiculo.Controls.Add(this.label6);
            this.gBVeiculo.Location = new System.Drawing.Point(18, 130);
            this.gBVeiculo.Margin = new System.Windows.Forms.Padding(2);
            this.gBVeiculo.Name = "gBVeiculo";
            this.gBVeiculo.Padding = new System.Windows.Forms.Padding(2);
            this.gBVeiculo.Size = new System.Drawing.Size(219, 51);
            this.gBVeiculo.TabIndex = 40;
            this.gBVeiculo.TabStop = false;
            this.gBVeiculo.Enter += new System.EventHandler(this.gBVeiculo_Enter);
            // 
            // tipoVeiculo
            // 
            this.tipoVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoVeiculo.FormattingEnabled = true;
            this.tipoVeiculo.Items.AddRange(new object[] {
            "Carro Grande",
            "Carro Pequeno",
            "Moto"});
            this.tipoVeiculo.Location = new System.Drawing.Point(6, 23);
            this.tipoVeiculo.Name = "tipoVeiculo";
            this.tipoVeiculo.Size = new System.Drawing.Size(121, 21);
            this.tipoVeiculo.TabIndex = 15;
            this.tipoVeiculo.SelectedIndexChanged += new System.EventHandler(this.tipoVeiculo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, -2);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Veiculo:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // gBData
            // 
            this.gBData.Controls.Add(this.groupBox4);
            this.gBData.Controls.Add(this.radioButton2);
            this.gBData.Controls.Add(this.radioButton1);
            this.gBData.Controls.Add(this.label10);
            this.gBData.Location = new System.Drawing.Point(319, 196);
            this.gBData.Margin = new System.Windows.Forms.Padding(2);
            this.gBData.Name = "gBData";
            this.gBData.Padding = new System.Windows.Forms.Padding(2);
            this.gBData.Size = new System.Drawing.Size(242, 112);
            this.gBData.TabIndex = 39;
            this.gBData.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.dateTimeSaida);
            this.groupBox4.Controls.Add(this.dateTimeEntrada);
            this.groupBox4.Location = new System.Drawing.Point(73, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(164, 70);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(97, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(53, 20);
            this.dateTimePicker2.TabIndex = 38;
            this.dateTimePicker2.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(53, 20);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // dateTimeSaida
            // 
            this.dateTimeSaida.CustomFormat = "dd-MM-yyyy ";
            this.dateTimeSaida.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeSaida.Location = new System.Drawing.Point(5, 31);
            this.dateTimeSaida.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeSaida.Name = "dateTimeSaida";
            this.dateTimeSaida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeSaida.Size = new System.Drawing.Size(87, 22);
            this.dateTimeSaida.TabIndex = 25;
            this.dateTimeSaida.Visible = false;
            // 
            // dateTimeEntrada
            // 
            this.dateTimeEntrada.CustomFormat = "dd-MM-yyyy ";
            this.dateTimeEntrada.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEntrada.Location = new System.Drawing.Point(5, 2);
            this.dateTimeEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeEntrada.Name = "dateTimeEntrada";
            this.dateTimeEntrada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeEntrada.Size = new System.Drawing.Size(87, 22);
            this.dateTimeEntrada.TabIndex = 21;
            this.dateTimeEntrada.ValueChanged += new System.EventHandler(this.dateTimeEntrada_ValueChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 17);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.Text = "Saída";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.Text = "Entrada";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1, 1);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Data / Horario :";
            // 
            // checkin
            // 
            this.checkin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkin.FlatAppearance.BorderSize = 0;
            this.checkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkin.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkin.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.checkin.Image = ((System.Drawing.Image)(resources.GetObject("checkin.Image")));
            this.checkin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkin.Location = new System.Drawing.Point(324, 312);
            this.checkin.Margin = new System.Windows.Forms.Padding(2);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(119, 38);
            this.checkin.TabIndex = 24;
            this.checkin.Text = "Check-in";
            this.checkin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkin.UseVisualStyleBackColor = false;
            this.checkin.Click += new System.EventHandler(this.checkin_Click);
            // 
            // gBCliente
            // 
            this.gBCliente.Controls.Add(this.txbCPF);
            this.gBCliente.Controls.Add(this.label3);
            this.gBCliente.Controls.Add(this.txbNome);
            this.gBCliente.Controls.Add(this.label8);
            this.gBCliente.Controls.Add(this.label9);
            this.gBCliente.Location = new System.Drawing.Point(14, 196);
            this.gBCliente.Margin = new System.Windows.Forms.Padding(2);
            this.gBCliente.Name = "gBCliente";
            this.gBCliente.Padding = new System.Windows.Forms.Padding(2);
            this.gBCliente.Size = new System.Drawing.Size(301, 165);
            this.gBCliente.TabIndex = 38;
            this.gBCliente.TabStop = false;
            // 
            // txbCPF
            // 
            this.txbCPF.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCPF.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCPF.Location = new System.Drawing.Point(18, 99);
            this.txbCPF.Margin = new System.Windows.Forms.Padding(2);
            this.txbCPF.MaxLength = 11;
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(127, 25);
            this.txbCPF.TabIndex = 9;
            this.txbCPF.Click += new System.EventHandler(this.checkout_Click);
            this.txbCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCPF_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF :";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(18, 49);
            this.txbNome.Margin = new System.Windows.Forms.Padding(2);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(275, 25);
            this.txbNome.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nome :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, -1);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cliente";
            // 
            // gBLocal
            // 
            this.gBLocal.Controls.Add(this.Localizacao);
            this.gBLocal.Controls.Add(this.label1);
            this.gBLocal.Location = new System.Drawing.Point(18, 50);
            this.gBLocal.Margin = new System.Windows.Forms.Padding(2);
            this.gBLocal.Name = "gBLocal";
            this.gBLocal.Padding = new System.Windows.Forms.Padding(2);
            this.gBLocal.Size = new System.Drawing.Size(220, 76);
            this.gBLocal.TabIndex = 41;
            this.gBLocal.TabStop = false;
            // 
            // Localizacao
            // 
            this.Localizacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Localizacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Localizacao.FormattingEnabled = true;
            this.Localizacao.Items.AddRange(new object[] {
            "Centro",
            "Barro Preto",
            "Venda Nova"});
            this.Localizacao.Location = new System.Drawing.Point(9, 41);
            this.Localizacao.Name = "Localizacao";
            this.Localizacao.Size = new System.Drawing.Size(121, 21);
            this.Localizacao.TabIndex = 34;
            this.Localizacao.SelectedIndexChanged += new System.EventHandler(this.Localizacao_SelectedIndexChanged);
            // 
            // gBFormaCobranca
            // 
            this.gBFormaCobranca.Controls.Add(this.FormasCobranca);
            this.gBFormaCobranca.Controls.Add(this.label2);
            this.gBFormaCobranca.Location = new System.Drawing.Point(272, 50);
            this.gBFormaCobranca.Margin = new System.Windows.Forms.Padding(2);
            this.gBFormaCobranca.Name = "gBFormaCobranca";
            this.gBFormaCobranca.Padding = new System.Windows.Forms.Padding(2);
            this.gBFormaCobranca.Size = new System.Drawing.Size(289, 76);
            this.gBFormaCobranca.TabIndex = 42;
            this.gBFormaCobranca.TabStop = false;
            this.gBFormaCobranca.Enter += new System.EventHandler(this.Localizacao_SelectedIndexChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(547, 2);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 23);
            this.btnFechar.TabIndex = 43;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormasCobranca
            // 
            this.FormasCobranca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormasCobranca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormasCobranca.FormattingEnabled = true;
            this.FormasCobranca.Items.AddRange(new object[] {
            "Horista",
            "Horista Vip",
            "Mensalista"});
            this.FormasCobranca.Location = new System.Drawing.Point(8, 32);
            this.FormasCobranca.Name = "FormasCobranca";
            this.FormasCobranca.Size = new System.Drawing.Size(121, 21);
            this.FormasCobranca.TabIndex = 35;
            this.FormasCobranca.SelectedIndexChanged += new System.EventHandler(this.FormasCobranca_SelectedIndexChanged);
            // 
            // DadosVeiculo
            // 
            this.DadosVeiculo.Controls.Add(this.label4);
            this.DadosVeiculo.Controls.Add(this.txbPlaca);
            this.DadosVeiculo.Controls.Add(this.label5);
            this.DadosVeiculo.Controls.Add(this.txbModelo);
            this.DadosVeiculo.Location = new System.Drawing.Point(272, 131);
            this.DadosVeiculo.Name = "DadosVeiculo";
            this.DadosVeiculo.Size = new System.Drawing.Size(289, 50);
            this.DadosVeiculo.TabIndex = 16;
            this.DadosVeiculo.TabStop = false;
            this.DadosVeiculo.Enter += new System.EventHandler(this.tipoVeiculo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, -3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Placa :";
            // 
            // txbPlaca
            // 
            this.txbPlaca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txbPlaca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPlaca.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPlaca.Location = new System.Drawing.Point(8, 20);
            this.txbPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.txbPlaca.MaxLength = 8;
            this.txbPlaca.Name = "txbPlaca";
            this.txbPlaca.Size = new System.Drawing.Size(112, 25);
            this.txbPlaca.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, -3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Modelo :";
            // 
            // txbModelo
            // 
            this.txbModelo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbModelo.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbModelo.Location = new System.Drawing.Point(142, 20);
            this.txbModelo.Margin = new System.Windows.Forms.Padding(2);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(119, 25);
            this.txbModelo.TabIndex = 12;
            this.txbModelo.TextChanged += new System.EventHandler(this.txbModelo_TextChanged);
            // 
            // checkout
            // 
            this.checkout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkout.FlatAppearance.BorderSize = 0;
            this.checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkout.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.checkout.Image = ((System.Drawing.Image)(resources.GetObject("checkout.Image")));
            this.checkout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkout.Location = new System.Drawing.Point(447, 312);
            this.checkout.Margin = new System.Windows.Forms.Padding(2);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(119, 38);
            this.checkout.TabIndex = 44;
            this.checkout.Text = "Check-out";
            this.checkout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkout.UseVisualStyleBackColor = false;
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            // 
            // SecondCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkout);
            this.Controls.Add(this.checkin);
            this.Controls.Add(this.DadosVeiculo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gBFormaCobranca);
            this.Controls.Add(this.gBLocal);
            this.Controls.Add(this.gBVeiculo);
            this.Controls.Add(this.gBData);
            this.Controls.Add(this.gBCliente);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SecondCustomControl";
            this.Size = new System.Drawing.Size(571, 385);
            this.gBVeiculo.ResumeLayout(false);
            this.gBVeiculo.PerformLayout();
            this.gBData.ResumeLayout(false);
            this.gBData.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.gBCliente.ResumeLayout(false);
            this.gBCliente.PerformLayout();
            this.gBLocal.ResumeLayout(false);
            this.gBLocal.PerformLayout();
            this.gBFormaCobranca.ResumeLayout(false);
            this.gBFormaCobranca.PerformLayout();
            this.DadosVeiculo.ResumeLayout(false);
            this.DadosVeiculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBVeiculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gBData;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimeSaida;
        private System.Windows.Forms.DateTimePicker dateTimeEntrada;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button checkin;
        private System.Windows.Forms.GroupBox gBCliente;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gBLocal;
        private System.Windows.Forms.GroupBox gBFormaCobranca;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox tipoVeiculo;
        private System.Windows.Forms.ComboBox Localizacao;
        private System.Windows.Forms.ComboBox FormasCobranca;
        private System.Windows.Forms.GroupBox DadosVeiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPlaca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbModelo;
        protected internal System.Windows.Forms.Button checkout;
    }
}
