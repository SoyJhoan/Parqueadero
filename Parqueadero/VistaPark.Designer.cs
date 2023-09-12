namespace Parqueadero
{
    partial class VistaPark
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPp = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textMo = new System.Windows.Forms.TextBox();
            this.textSus = new System.Windows.Forms.TextBox();
            this.textFren = new System.Windows.Forms.TextBox();
            this.textRue = new System.Windows.Forms.TextBox();
            this.textCol = new System.Windows.Forms.TextBox();
            this.textAu = new System.Windows.Forms.TextBox();
            this.textGar = new System.Windows.Forms.TextBox();
            this.Garantía = new System.Windows.Forms.Label();
            this.gbDatos.SuspendLayout();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(467, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Porfavor ingresa la placa del vehiculo";
            // 
            // txtPp
            // 
            this.txtPp.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPp.Location = new System.Drawing.Point(30, 16);
            this.txtPp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPp.Name = "txtPp";
            this.txtPp.Size = new System.Drawing.Size(85, 27);
            this.txtPp.TabIndex = 1;
            this.txtPp.TextChanged += new System.EventHandler(this.txtPp_TextChanged);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConsulta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnConsulta.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.Transparent;
            this.btnConsulta.Location = new System.Drawing.Point(30, 52);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(84, 25);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(34, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo";
            // 
            // txtM
            // 
            this.txtM.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM.Location = new System.Drawing.Point(119, 36);
            this.txtM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(322, 27);
            this.txtM.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(34, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cilindraje";
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(119, 136);
            this.txtC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(322, 27);
            this.txtC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(29, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Transmisión";
            // 
            // txtT
            // 
            this.txtT.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT.Location = new System.Drawing.Point(119, 88);
            this.txtT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(322, 27);
            this.txtT.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(34, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dirección";
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(119, 184);
            this.txtD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(322, 27);
            this.txtD.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(208, 387);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hora de ingreso";
            // 
            // txtHi
            // 
            this.txtHi.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHi.Location = new System.Drawing.Point(321, 384);
            this.txtHi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHi.Name = "txtHi";
            this.txtHi.Size = new System.Drawing.Size(26, 27);
            this.txtHi.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(493, 387);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hora de salida";
            // 
            // txtHs
            // 
            this.txtHs.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHs.Location = new System.Drawing.Point(603, 384);
            this.txtHs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHs.Name = "txtHs";
            this.txtHs.Size = new System.Drawing.Size(26, 27);
            this.txtHs.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(717, 384);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Minutos dentro";
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(827, 381);
            this.txtMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(26, 27);
            this.txtMin.TabIndex = 16;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // txtP
            // 
            this.txtP.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.Location = new System.Drawing.Point(689, 291);
            this.txtP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(336, 27);
            this.txtP.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(635, 294);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Placa";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpiar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Location = new System.Drawing.Point(478, 459);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalir.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalir.Location = new System.Drawing.Point(557, 459);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(71, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtPp);
            this.gbDatos.Controls.Add(this.btnConsulta);
            this.gbDatos.Location = new System.Drawing.Point(508, 31);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatos.Size = new System.Drawing.Size(150, 81);
            this.gbDatos.TabIndex = 21;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "datos";
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.Garantía);
            this.gbResultado.Controls.Add(this.textGar);
            this.gbResultado.Controls.Add(this.textAu);
            this.gbResultado.Controls.Add(this.textCol);
            this.gbResultado.Controls.Add(this.textRue);
            this.gbResultado.Controls.Add(this.textFren);
            this.gbResultado.Controls.Add(this.textSus);
            this.gbResultado.Controls.Add(this.textMo);
            this.gbResultado.Controls.Add(this.label16);
            this.gbResultado.Controls.Add(this.label15);
            this.gbResultado.Controls.Add(this.label14);
            this.gbResultado.Controls.Add(this.label13);
            this.gbResultado.Controls.Add(this.label12);
            this.gbResultado.Controls.Add(this.label11);
            this.gbResultado.Controls.Add(this.label10);
            this.gbResultado.Controls.Add(this.txtMin);
            this.gbResultado.Controls.Add(this.label2);
            this.gbResultado.Controls.Add(this.btnSalir);
            this.gbResultado.Controls.Add(this.txtM);
            this.gbResultado.Controls.Add(this.btnLimpiar);
            this.gbResultado.Controls.Add(this.label3);
            this.gbResultado.Controls.Add(this.txtP);
            this.gbResultado.Controls.Add(this.txtC);
            this.gbResultado.Controls.Add(this.label9);
            this.gbResultado.Controls.Add(this.label4);
            this.gbResultado.Controls.Add(this.txtT);
            this.gbResultado.Controls.Add(this.label8);
            this.gbResultado.Controls.Add(this.label5);
            this.gbResultado.Controls.Add(this.txtHs);
            this.gbResultado.Controls.Add(this.txtD);
            this.gbResultado.Controls.Add(this.label7);
            this.gbResultado.Controls.Add(this.label6);
            this.gbResultado.Controls.Add(this.txtHi);
            this.gbResultado.Location = new System.Drawing.Point(11, 116);
            this.gbResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbResultado.Size = new System.Drawing.Size(1073, 486);
            this.gbResultado.TabIndex = 22;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "resultado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(34, 245);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Motor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(34, 299);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "Suspensión";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(628, 39);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 19);
            this.label13.TabIndex = 24;
            this.label13.Text = "Frenos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(623, 86);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 19);
            this.label14.TabIndex = 25;
            this.label14.Text = "Ruedas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(638, 139);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 19);
            this.label15.TabIndex = 26;
            this.label15.Text = "Color";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(530, 187);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 19);
            this.label16.TabIndex = 27;
            this.label16.Text = "Audio Y Entrenimiento";
            // 
            // textMo
            // 
            this.textMo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMo.Location = new System.Drawing.Point(119, 237);
            this.textMo.Margin = new System.Windows.Forms.Padding(2);
            this.textMo.Name = "textMo";
            this.textMo.Size = new System.Drawing.Size(322, 27);
            this.textMo.TabIndex = 28;
            // 
            // textSus
            // 
            this.textSus.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSus.Location = new System.Drawing.Point(119, 291);
            this.textSus.Margin = new System.Windows.Forms.Padding(2);
            this.textSus.Name = "textSus";
            this.textSus.Size = new System.Drawing.Size(322, 27);
            this.textSus.TabIndex = 29;
            // 
            // textFren
            // 
            this.textFren.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFren.Location = new System.Drawing.Point(689, 36);
            this.textFren.Margin = new System.Windows.Forms.Padding(2);
            this.textFren.Name = "textFren";
            this.textFren.Size = new System.Drawing.Size(336, 27);
            this.textFren.TabIndex = 30;
            // 
            // textRue
            // 
            this.textRue.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRue.Location = new System.Drawing.Point(689, 83);
            this.textRue.Margin = new System.Windows.Forms.Padding(2);
            this.textRue.Name = "textRue";
            this.textRue.Size = new System.Drawing.Size(336, 27);
            this.textRue.TabIndex = 31;
            // 
            // textCol
            // 
            this.textCol.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCol.Location = new System.Drawing.Point(689, 131);
            this.textCol.Margin = new System.Windows.Forms.Padding(2);
            this.textCol.Name = "textCol";
            this.textCol.Size = new System.Drawing.Size(336, 27);
            this.textCol.TabIndex = 32;
            // 
            // textAu
            // 
            this.textAu.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAu.Location = new System.Drawing.Point(689, 179);
            this.textAu.Margin = new System.Windows.Forms.Padding(2);
            this.textAu.Name = "textAu";
            this.textAu.Size = new System.Drawing.Size(336, 27);
            this.textAu.TabIndex = 33;
            // 
            // textGar
            // 
            this.textGar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGar.Location = new System.Drawing.Point(689, 237);
            this.textGar.Margin = new System.Windows.Forms.Padding(2);
            this.textGar.Name = "textGar";
            this.textGar.Size = new System.Drawing.Size(336, 27);
            this.textGar.TabIndex = 34;
            // 
            // Garantía
            // 
            this.Garantía.AutoSize = true;
            this.Garantía.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Garantía.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Garantía.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Garantía.Location = new System.Drawing.Point(614, 240);
            this.Garantía.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Garantía.Name = "Garantía";
            this.Garantía.Size = new System.Drawing.Size(65, 19);
            this.Garantía.TabIndex = 35;
            this.Garantía.Text = "Garantía";
            // 
            // VistaPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1095, 613);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VistaPark";
            this.Text = "INFORMACIÓN VEHICULOS";
            this.Load += new System.EventHandler(this.VistaPark_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPp;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Garantía;
        private System.Windows.Forms.TextBox textGar;
        private System.Windows.Forms.TextBox textAu;
        private System.Windows.Forms.TextBox textCol;
        private System.Windows.Forms.TextBox textRue;
        private System.Windows.Forms.TextBox textFren;
        private System.Windows.Forms.TextBox textSus;
        private System.Windows.Forms.TextBox textMo;
    }
}

