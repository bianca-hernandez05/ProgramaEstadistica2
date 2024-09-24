namespace Programa_de_estadistica
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            btnGuardarCambios = new Button();
            button2 = new Button();
            lblSumX = new Label();
            lblSumy2 = new Label();
            lblSumx2 = new Label();
            lblSumY = new Label();
            lblSumxy = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label5 = new Label();
            lblMedia = new Label();
            btnSiguientesCalculos = new Button();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            plotView2 = new OxyPlot.WindowsForms.PlotView();
            label10 = new Label();
            lblB1 = new Label();
            label11 = new Label();
            lblB0 = new Label();
            lblX = new Label();
            lblY = new Label();
            label15 = new Label();
            label16 = new Label();
            lblRcuadrado = new Label();
            lblR = new Label();
            txtx = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txty = new TextBox();
            label2 = new Label();
            label12 = new Label();
            groupBox1 = new GroupBox();
            lblMcr = new Label();
            lblGLE = new Label();
            lblGLR = new Label();
            lblRVR = new Label();
            lblSCE = new Label();
            lblMCE = new Label();
            lblSCR = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label14 = new Label();
            label13 = new Label();
            lblCorrelacion = new Label();
            groupBox2 = new GroupBox();
            lblTstudent = new Label();
            lblSumden = new Label();
            label22 = new Label();
            label21 = new Label();
            groupBox3 = new GroupBox();
            lblIntervaloPredicion = new Label();
            lblValorCritico = new Label();
            groupBox4 = new GroupBox();
            lblIntervaloConfianzaxp = new Label();
            lblResultadoHipotesis = new Label();
            groupBox5 = new GroupBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(409, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(771, 233);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Y";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Xi^2";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Yi^2";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "XY";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(207, 143);
            button1.Name = "button1";
            button1.Size = new Size(181, 31);
            button1.TabIndex = 1;
            button1.Text = "agregar los valores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCambios.Location = new Point(35, 143);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(156, 39);
            btnGuardarCambios.TabIndex = 8;
            btnGuardarCambios.Text = "guardar cambios ";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += GuardarCambios_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(145, 229);
            button2.Name = "button2";
            button2.Size = new Size(98, 29);
            button2.TabIndex = 9;
            button2.Text = "calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblSumX
            // 
            lblSumX.AutoSize = true;
            lblSumX.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Bold);
            lblSumX.Location = new Point(496, 297);
            lblSumX.Name = "lblSumX";
            lblSumX.Size = new Size(55, 19);
            lblSumX.TabIndex = 10;
            lblSumX.Text = "label4";
            // 
            // lblSumy2
            // 
            lblSumy2.AutoSize = true;
            lblSumy2.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Bold);
            lblSumy2.Location = new Point(929, 297);
            lblSumy2.Name = "lblSumy2";
            lblSumy2.Size = new Size(55, 19);
            lblSumy2.TabIndex = 11;
            lblSumy2.Text = "label5";
            // 
            // lblSumx2
            // 
            lblSumx2.AutoSize = true;
            lblSumx2.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Bold);
            lblSumx2.Location = new Point(777, 297);
            lblSumx2.Name = "lblSumx2";
            lblSumx2.Size = new Size(55, 19);
            lblSumx2.TabIndex = 12;
            lblSumx2.Text = "label6";
            // 
            // lblSumY
            // 
            lblSumY.AutoSize = true;
            lblSumY.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Bold);
            lblSumY.Location = new Point(649, 297);
            lblSumY.Name = "lblSumY";
            lblSumY.Size = new Size(55, 19);
            lblSumY.TabIndex = 13;
            lblSumY.Text = "label7";
            // 
            // lblSumxy
            // 
            lblSumxy.AutoSize = true;
            lblSumxy.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Bold);
            lblSumxy.Location = new Point(1065, 297);
            lblSumxy.Name = "lblSumxy";
            lblSumxy.Size = new Size(55, 19);
            lblSumxy.TabIndex = 14;
            lblSumxy.Text = "label8";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label4.Location = new Point(496, 259);
            label4.Name = "label4";
            label4.Size = new Size(53, 19);
            label4.TabIndex = 15;
            label4.Text = "SumX";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label6.Location = new Point(1065, 259);
            label6.Name = "label6";
            label6.Size = new Size(64, 19);
            label6.TabIndex = 17;
            label6.Text = "SumXY";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label7.Location = new Point(929, 259);
            label7.Name = "label7";
            label7.Size = new Size(71, 19);
            label7.TabIndex = 18;
            label7.Text = "SumY^2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label8.Location = new Point(777, 259);
            label8.Name = "label8";
            label8.Size = new Size(72, 19);
            label8.TabIndex = 19;
            label8.Text = "SumX^2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label9.Location = new Point(649, 259);
            label9.Name = "label9";
            label9.Size = new Size(52, 19);
            label9.TabIndex = 20;
            label9.Text = "SumY";
            label9.Click += label9_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label5.Location = new Point(406, 352);
            label5.Name = "label5";
            label5.Size = new Size(96, 19);
            label5.TabIndex = 21;
            label5.Text = "La media es";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Bold);
            lblMedia.Location = new Point(406, 396);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(22, 19);
            lblMedia.TabIndex = 22;
            lblMedia.Text = "la";
            // 
            // btnSiguientesCalculos
            // 
            btnSiguientesCalculos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguientesCalculos.Location = new Point(207, 185);
            btnSiguientesCalculos.Name = "btnSiguientesCalculos";
            btnSiguientesCalculos.Size = new Size(181, 33);
            btnSiguientesCalculos.TabIndex = 23;
            btnSiguientesCalculos.Text = "Grafica de dispersion";
            btnSiguientesCalculos.UseVisualStyleBackColor = true;
            btnSiguientesCalculos.Click += btnSiguientesCalculos_Click;
            // 
            // plotView1
            // 
            plotView1.Location = new Point(0, 0);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(0, 0);
            plotView1.TabIndex = 0;
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView2
            // 
            plotView2.Location = new Point(245, 599);
            plotView2.Name = "plotView2";
            plotView2.PanCursor = Cursors.Hand;
            plotView2.Size = new Size(94, 29);
            plotView2.TabIndex = 24;
            plotView2.Text = "plotView2";
            plotView2.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView2.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label10.Location = new Point(553, 352);
            label10.Name = "label10";
            label10.Size = new Size(27, 19);
            label10.TabIndex = 25;
            label10.Text = "b1";
            // 
            // lblB1
            // 
            lblB1.AutoSize = true;
            lblB1.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Bold);
            lblB1.Location = new Point(522, 396);
            lblB1.Name = "lblB1";
            lblB1.Size = new Size(22, 19);
            lblB1.TabIndex = 26;
            lblB1.Text = "la";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label11.Location = new Point(653, 352);
            label11.Name = "label11";
            label11.Size = new Size(30, 19);
            label11.TabIndex = 27;
            label11.Text = "B0";
            // 
            // lblB0
            // 
            lblB0.AutoSize = true;
            lblB0.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Bold);
            lblB0.Location = new Point(649, 396);
            lblB0.Name = "lblB0";
            lblB0.Size = new Size(22, 19);
            lblB0.TabIndex = 28;
            lblB0.Text = "la";
            lblB0.Visible = false;
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblX.ForeColor = Color.FromArgb(64, 0, 64);
            lblX.Location = new Point(1307, 229);
            lblX.Name = "lblX";
            lblX.Size = new Size(65, 19);
            lblX.TabIndex = 29;
            lblX.Text = "corte bo";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblY.ForeColor = Color.FromArgb(64, 0, 64);
            lblY.Location = new Point(1307, 323);
            lblY.Name = "lblY";
            lblY.Size = new Size(64, 19);
            lblY.TabIndex = 30;
            lblY.Text = "corte b1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(0, 0, 64);
            label15.Location = new Point(1334, 17);
            label15.Name = "label15";
            label15.Size = new Size(93, 19);
            label15.TabIndex = 34;
            label15.Text = "R cuadrado";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label16.ForeColor = Color.FromArgb(0, 0, 64);
            label16.Location = new Point(1360, 100);
            label16.Name = "label16";
            label16.Size = new Size(21, 19);
            label16.TabIndex = 35;
            label16.Text = "R";
            // 
            // lblRcuadrado
            // 
            lblRcuadrado.AutoSize = true;
            lblRcuadrado.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRcuadrado.ForeColor = Color.FromArgb(0, 0, 64);
            lblRcuadrado.Location = new Point(1303, 55);
            lblRcuadrado.Name = "lblRcuadrado";
            lblRcuadrado.Size = new Size(22, 19);
            lblRcuadrado.TabIndex = 36;
            lblRcuadrado.Text = "la";
            lblRcuadrado.Visible = false;
            // 
            // lblR
            // 
            lblR.AutoSize = true;
            lblR.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR.ForeColor = Color.FromArgb(0, 0, 64);
            lblR.Location = new Point(1309, 137);
            lblR.Name = "lblR";
            lblR.Size = new Size(22, 19);
            lblR.TabIndex = 37;
            lblR.Text = "la";
            lblR.Visible = false;
            // 
            // txtx
            // 
            txtx.Location = new Point(46, 91);
            txtx.Name = "txtx";
            txtx.Size = new Size(125, 27);
            txtx.TabIndex = 3;
            txtx.KeyPress += txtx_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(229, 35);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 7;
            label3.Text = "Ingrese los valores de y";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(35, 35);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 5;
            label1.Text = "Ingrese los valores de x";
            label1.Click += label1_Click;
            // 
            // txty
            // 
            txty.Location = new Point(245, 91);
            txty.Name = "txty";
            txty.Size = new Size(125, 27);
            txty.TabIndex = 4;
            txty.TextChanged += textBox2_TextChanged;
            txty.KeyPress += txty_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 0, 64);
            label2.Location = new Point(1333, 184);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 38;
            label2.Text = "Corte en  Bo";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(64, 0, 64);
            label12.Location = new Point(1335, 277);
            label12.Name = "label12";
            label12.Size = new Size(98, 19);
            label12.TabIndex = 39;
            label12.Text = "Corte en B1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMcr);
            groupBox1.Controls.Add(lblGLE);
            groupBox1.Controls.Add(lblGLR);
            groupBox1.Controls.Add(lblRVR);
            groupBox1.Controls.Add(lblSCE);
            groupBox1.Controls.Add(lblMCE);
            groupBox1.Controls.Add(lblSCR);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(370, 443);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(680, 139);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "ANOVA";
            // 
            // lblMcr
            // 
            lblMcr.AutoSize = true;
            lblMcr.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Bold);
            lblMcr.Location = new Point(395, 52);
            lblMcr.Name = "lblMcr";
            lblMcr.Size = new Size(22, 19);
            lblMcr.TabIndex = 47;
            lblMcr.Text = "la";
            lblMcr.Visible = false;
            // 
            // lblGLE
            // 
            lblGLE.AutoSize = true;
            lblGLE.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            lblGLE.Location = new Point(275, 97);
            lblGLE.Name = "lblGLE";
            lblGLE.Size = new Size(24, 38);
            lblGLE.TabIndex = 35;
            lblGLE.Text = "ln\r\n\r\n";
            // 
            // lblGLR
            // 
            lblGLR.AutoSize = true;
            lblGLR.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            lblGLR.Location = new Point(275, 52);
            lblGLR.Name = "lblGLR";
            lblGLR.Size = new Size(24, 38);
            lblGLR.TabIndex = 34;
            lblGLR.Text = "ln\r\n\r\n";
            // 
            // lblRVR
            // 
            lblRVR.AutoSize = true;
            lblRVR.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            lblRVR.Location = new Point(544, 57);
            lblRVR.Name = "lblRVR";
            lblRVR.Size = new Size(24, 19);
            lblRVR.TabIndex = 33;
            lblRVR.Text = "ln";
            // 
            // lblSCE
            // 
            lblSCE.AutoSize = true;
            lblSCE.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            lblSCE.Location = new Point(97, 97);
            lblSCE.Name = "lblSCE";
            lblSCE.Size = new Size(24, 19);
            lblSCE.TabIndex = 31;
            lblSCE.Text = "ln";
            // 
            // lblMCE
            // 
            lblMCE.AutoSize = true;
            lblMCE.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            lblMCE.Location = new Point(395, 97);
            lblMCE.Name = "lblMCE";
            lblMCE.Size = new Size(24, 38);
            lblMCE.TabIndex = 29;
            lblMCE.Text = "ln\r\n\r\n";
            // 
            // lblSCR
            // 
            lblSCR.AutoSize = true;
            lblSCR.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            lblSCR.Location = new Point(97, 57);
            lblSCR.Name = "lblSCR";
            lblSCR.Size = new Size(24, 38);
            lblSCR.TabIndex = 28;
            lblSCR.Text = "ln\r\n\r\n";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label20.ForeColor = Color.FromArgb(64, 64, 64);
            label20.Location = new Point(608, 12);
            label20.Name = "label20";
            label20.Size = new Size(31, 38);
            label20.TabIndex = 27;
            label20.Text = "RV\r\n\r\n";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label19.ForeColor = Color.FromArgb(64, 64, 64);
            label19.Location = new Point(395, 12);
            label19.Name = "label19";
            label19.Size = new Size(37, 38);
            label19.TabIndex = 26;
            label19.Text = "MC\r\n\r\n";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label18.ForeColor = Color.FromArgb(64, 64, 64);
            label18.Location = new Point(274, 12);
            label18.Name = "label18";
            label18.Size = new Size(34, 38);
            label18.TabIndex = 25;
            label18.Text = "GL\r\n\r\n";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label17.ForeColor = Color.FromArgb(64, 64, 64);
            label17.Location = new Point(97, 12);
            label17.Name = "label17";
            label17.Size = new Size(30, 19);
            label17.TabIndex = 24;
            label17.Text = "SC";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label14.Location = new Point(7, 97);
            label14.Name = "label14";
            label14.Size = new Size(53, 38);
            label14.TabIndex = 23;
            label14.Text = "Error\r\n\r\n";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label13.Location = new Point(7, 57);
            label13.Name = "label13";
            label13.Size = new Size(85, 38);
            label13.TabIndex = 22;
            label13.Text = "Regresion\r\n\r\n";
            // 
            // lblCorrelacion
            // 
            lblCorrelacion.AutoSize = true;
            lblCorrelacion.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            lblCorrelacion.Location = new Point(1065, 599);
            lblCorrelacion.Name = "lblCorrelacion";
            lblCorrelacion.Size = new Size(24, 19);
            lblCorrelacion.TabIndex = 30;
            lblCorrelacion.Text = "ln\n";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTstudent);
            groupBox2.Controls.Add(lblSumden);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(label21);
            groupBox2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(1291, 665);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(261, 165);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "calcular T";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblTstudent
            // 
            lblTstudent.AutoSize = true;
            lblTstudent.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Bold);
            lblTstudent.Location = new Point(109, 105);
            lblTstudent.Name = "lblTstudent";
            lblTstudent.Size = new Size(22, 19);
            lblTstudent.TabIndex = 43;
            lblTstudent.Text = "la";
            // 
            // lblSumden
            // 
            lblSumden.AutoSize = true;
            lblSumden.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Bold);
            lblSumden.Location = new Point(109, 47);
            lblSumden.Name = "lblSumden";
            lblSumden.Size = new Size(22, 19);
            lblSumden.TabIndex = 42;
            lblSumden.Text = "la";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label22.Location = new Point(7, 105);
            label22.Name = "label22";
            label22.Size = new Size(15, 38);
            label22.TabIndex = 37;
            label22.Text = "t\r\n\r\n";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label21.Location = new Point(0, 40);
            label21.Name = "label21";
            label21.Size = new Size(82, 38);
            label21.TabIndex = 36;
            label21.Text = "sum (xj-x)\r\n\r\n";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblIntervaloPredicion);
            groupBox3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(370, 831);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(581, 77);
            groupBox3.TabIndex = 42;
            groupBox3.TabStop = false;
            groupBox3.Text = "intervalo de prediccion";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // lblIntervaloPredicion
            // 
            lblIntervaloPredicion.AutoSize = true;
            lblIntervaloPredicion.Font = new Font("Baskerville Old Face", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIntervaloPredicion.Location = new Point(7, 40);
            lblIntervaloPredicion.Name = "lblIntervaloPredicion";
            lblIntervaloPredicion.Size = new Size(19, 16);
            lblIntervaloPredicion.TabIndex = 44;
            lblIntervaloPredicion.Text = "ln\r\n";
            // 
            // lblValorCritico
            // 
            lblValorCritico.AutoSize = true;
            lblValorCritico.Font = new Font("Baskerville Old Face", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorCritico.Location = new Point(7, 36);
            lblValorCritico.Name = "lblValorCritico";
            lblValorCritico.Size = new Size(18, 16);
            lblValorCritico.TabIndex = 44;
            lblValorCritico.Text = "la";
            lblValorCritico.Click += lblValorCritico_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblIntervaloConfianzaxp);
            groupBox4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(971, 839);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(581, 77);
            groupBox4.TabIndex = 45;
            groupBox4.TabStop = false;
            groupBox4.Text = "Intervalo de Confianza segun Prediccion";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // lblIntervaloConfianzaxp
            // 
            lblIntervaloConfianzaxp.AutoSize = true;
            lblIntervaloConfianzaxp.Font = new Font("Baskerville Old Face", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIntervaloConfianzaxp.Location = new Point(7, 40);
            lblIntervaloConfianzaxp.Name = "lblIntervaloConfianzaxp";
            lblIntervaloConfianzaxp.Size = new Size(19, 16);
            lblIntervaloConfianzaxp.TabIndex = 45;
            lblIntervaloConfianzaxp.Text = "ln\r\n";
            // 
            // lblResultadoHipotesis
            // 
            lblResultadoHipotesis.AutoSize = true;
            lblResultadoHipotesis.Font = new Font("Baskerville Old Face", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultadoHipotesis.Location = new Point(7, 75);
            lblResultadoHipotesis.Name = "lblResultadoHipotesis";
            lblResultadoHipotesis.Size = new Size(18, 16);
            lblResultadoHipotesis.TabIndex = 44;
            lblResultadoHipotesis.Text = "la";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblValorCritico);
            groupBox5.Controls.Add(lblResultadoHipotesis);
            groupBox5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(363, 653);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(906, 157);
            groupBox5.TabIndex = 46;
            groupBox5.TabStop = false;
            groupBox5.Text = "Verificacion de Hipotesis y intervalo de Confianza";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(93, 189);
            button3.Name = "button3";
            button3.Size = new Size(98, 29);
            button3.TabIndex = 47;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1566, 999);
            Controls.Add(button3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(lblCorrelacion);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label12);
            Controls.Add(label2);
            Controls.Add(lblR);
            Controls.Add(lblRcuadrado);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(lblY);
            Controls.Add(lblX);
            Controls.Add(lblB0);
            Controls.Add(label11);
            Controls.Add(lblB1);
            Controls.Add(label10);
            Controls.Add(plotView2);
            Controls.Add(plotView1);
            Controls.Add(btnSiguientesCalculos);
            Controls.Add(lblMedia);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(lblSumxy);
            Controls.Add(lblSumY);
            Controls.Add(lblSumx2);
            Controls.Add(lblSumy2);
            Controls.Add(lblSumX);
            Controls.Add(button2);
            Controls.Add(btnGuardarCambios);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txty);
            Controls.Add(txtx);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button btnGuardarCambios;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label lblSumX;
        private Label lblSumy2;
        private Label lblSumx2;
        private Label lblSumY;
        private Label lblSumxy;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label5;
        private Label lblMedia;
        private Button btnSiguientesCalculos;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private Label label10;
        private Label lblB1;
        private Label label11;
        private Label lblB0;
        private Label lblX;
        private Label lblY;
        private Label label15;
        private Label label16;
        private Label lblRcuadrado;
        private Label lblR;
        private TextBox txtx;
        private Label label3;
        private Label label1;
        private TextBox txty;
        private Label label2;
        private Label label12;
        private GroupBox groupBox1;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label14;
        private Label label13;
        private Label lblGLE;
        private Label lblGLR;
        private Label lblRVR;
        private Label lblSCE;
        private Label lblCorrelacion;
        private Label lblMCE;
        private Label lblSCR;
        private GroupBox groupBox2;
        private Label label21;
        private Label lblTstudent;
        private Label lblSumden;
        private Label label22;
        private GroupBox groupBox3;
        private Label lblValorCritico;
        private Label lblIntervaloPredicion;
        private GroupBox groupBox4;
        private Label lblIntervaloConfianzaxp;
        private Label lblResultadoHipotesis;
        private GroupBox groupBox5;
        private Label lblMcr;
        private Button button3;
    }
}