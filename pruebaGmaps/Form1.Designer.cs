﻿namespace pruebaGmaps
{
    partial class Form1
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
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.cbxDeptos1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbtOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbtOpcion3 = new System.Windows.Forms.RadioButton();
            this.paneOpcion1 = new System.Windows.Forms.Panel();
            this.btMostrar1 = new System.Windows.Forms.Button();
            this.paneOpcion2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxDeptos2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btMostrar2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtMujeres = new System.Windows.Forms.RadioButton();
            this.rbtHombres = new System.Windows.Forms.RadioButton();
            this.paneOpcion3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDeptos3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btMostrar3 = new System.Windows.Forms.Button();
            this.rbtArma2 = new System.Windows.Forms.RadioButton();
            this.rbtArma1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMensajeTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.paneOpcion1.SuspendLayout();
            this.paneOpcion2.SuspendLayout();
            this.paneOpcion3.SuspendLayout();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(-1, -1);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(509, 508);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.GMapControl1_Load);
            this.map.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GMapControl1_MouseDoubleClick);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(26, 426);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(206, 20);
            this.txt1.TabIndex = 1;
            this.txt1.TextChanged += new System.EventHandler(this.Txt1_TextChanged);
            // 
            // cbxDeptos1
            // 
            this.cbxDeptos1.FormattingEnabled = true;
            this.cbxDeptos1.Items.AddRange(new object[] {
            "Amazonas",
            "Antioquia",
            "Arauca",
            "Atlántico",
            "Bogotá",
            "Bolívar",
            "Boyacá",
            "Caldas",
            "Caquetá",
            "Casanare",
            "Cauca",
            "Cesar",
            "Chocó",
            "Córdoba",
            "Cundinamarca",
            "Guainía",
            "Guaviare",
            "Huila",
            "La Guajira",
            "Magdalena",
            "Meta",
            "Nariño",
            "Norte de Santander",
            "Putumayo",
            "Quindío",
            "Risaralda",
            "San Andrés y Providencia",
            "Santander",
            "Sucre",
            "Tolima",
            "Valle del Cauca",
            "Vaupés",
            "Vichada"});
            this.cbxDeptos1.Location = new System.Drawing.Point(16, 32);
            this.cbxDeptos1.Name = "cbxDeptos1";
            this.cbxDeptos1.Size = new System.Drawing.Size(162, 21);
            this.cbxDeptos1.TabIndex = 4;
            this.cbxDeptos1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Departamentos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "HOMICIDIOS EN COLOMBIA 2018";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(538, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "¿Qué información desea conocer?...";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbtOpcion1
            // 
            this.rbtOpcion1.AutoSize = true;
            this.rbtOpcion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtOpcion1.Location = new System.Drawing.Point(533, 93);
            this.rbtOpcion1.Name = "rbtOpcion1";
            this.rbtOpcion1.Size = new System.Drawing.Size(188, 19);
            this.rbtOpcion1.TabIndex = 10;
            this.rbtOpcion1.TabStop = true;
            this.rbtOpcion1.Text = "Homicidios por departamento";
            this.rbtOpcion1.UseVisualStyleBackColor = true;
            this.rbtOpcion1.CheckedChanged += new System.EventHandler(this.RbtOpcion1_CheckedChanged);
            // 
            // rbtOpcion2
            // 
            this.rbtOpcion2.AutoSize = true;
            this.rbtOpcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtOpcion2.Location = new System.Drawing.Point(533, 116);
            this.rbtOpcion2.Name = "rbtOpcion2";
            this.rbtOpcion2.Size = new System.Drawing.Size(150, 19);
            this.rbtOpcion2.TabIndex = 11;
            this.rbtOpcion2.TabStop = true;
            this.rbtOpcion2.Text = "Homicidios por género";
            this.rbtOpcion2.UseVisualStyleBackColor = true;
            this.rbtOpcion2.CheckedChanged += new System.EventHandler(this.RbtOpcion2_CheckedChanged);
            // 
            // rbtOpcion3
            // 
            this.rbtOpcion3.AutoSize = true;
            this.rbtOpcion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtOpcion3.Location = new System.Drawing.Point(533, 139);
            this.rbtOpcion3.Name = "rbtOpcion3";
            this.rbtOpcion3.Size = new System.Drawing.Size(209, 19);
            this.rbtOpcion3.TabIndex = 12;
            this.rbtOpcion3.TabStop = true;
            this.rbtOpcion3.Text = "Homicidios según el tipo de arma";
            this.rbtOpcion3.UseVisualStyleBackColor = true;
            this.rbtOpcion3.CheckedChanged += new System.EventHandler(this.RbtOpcion3_CheckedChanged);
            // 
            // paneOpcion1
            // 
            this.paneOpcion1.Controls.Add(this.btMostrar1);
            this.paneOpcion1.Controls.Add(this.cbxDeptos1);
            this.paneOpcion1.Controls.Add(this.label1);
            this.paneOpcion1.Location = new System.Drawing.Point(513, 164);
            this.paneOpcion1.Name = "paneOpcion1";
            this.paneOpcion1.Size = new System.Drawing.Size(286, 67);
            this.paneOpcion1.TabIndex = 13;
            this.paneOpcion1.Visible = false;
            this.paneOpcion1.Paint += new System.Windows.Forms.PaintEventHandler(this.PaneOpcion1_Paint);
            // 
            // btMostrar1
            // 
            this.btMostrar1.Location = new System.Drawing.Point(194, 30);
            this.btMostrar1.Name = "btMostrar1";
            this.btMostrar1.Size = new System.Drawing.Size(75, 23);
            this.btMostrar1.TabIndex = 7;
            this.btMostrar1.Text = "Mostrar";
            this.btMostrar1.UseVisualStyleBackColor = true;
            this.btMostrar1.Click += new System.EventHandler(this.BtMostrar1_Click);
            // 
            // paneOpcion2
            // 
            this.paneOpcion2.Controls.Add(this.label8);
            this.paneOpcion2.Controls.Add(this.cbxDeptos2);
            this.paneOpcion2.Controls.Add(this.label6);
            this.paneOpcion2.Controls.Add(this.btMostrar2);
            this.paneOpcion2.Controls.Add(this.label5);
            this.paneOpcion2.Controls.Add(this.rbtMujeres);
            this.paneOpcion2.Controls.Add(this.rbtHombres);
            this.paneOpcion2.Location = new System.Drawing.Point(513, 164);
            this.paneOpcion2.Name = "paneOpcion2";
            this.paneOpcion2.Size = new System.Drawing.Size(312, 142);
            this.paneOpcion2.TabIndex = 14;
            this.paneOpcion2.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Departamentos:";
            // 
            // cbxDeptos2
            // 
            this.cbxDeptos2.FormattingEnabled = true;
            this.cbxDeptos2.Items.AddRange(new object[] {
            "Amazonas",
            "Antioquia",
            "Arauca",
            "Atlántico",
            "Bogotá",
            "Bolívar",
            "Boyacá",
            "Caldas",
            "Caquetá",
            "Casanare",
            "Cauca",
            "Cesar",
            "Chocó",
            "Córdoba",
            "Cundinamarca",
            "Guainía",
            "Guaviare",
            "Huila",
            "La Guajira",
            "Magdalena",
            "Meta",
            "Nariño",
            "Norte de Santander",
            "Putumayo",
            "Quindío",
            "Risaralda",
            "San Andrés y Providencia",
            "Santander",
            "Sucre",
            "Tolima",
            "Valle del Cauca",
            "Vaupés",
            "Vichada"});
            this.cbxDeptos2.Location = new System.Drawing.Point(15, 105);
            this.cbxDeptos2.Name = "cbxDeptos2";
            this.cbxDeptos2.Size = new System.Drawing.Size(162, 21);
            this.cbxDeptos2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Si desea conocer los homicidios según el departamento \r\ny género...";
            // 
            // btMostrar2
            // 
            this.btMostrar2.Location = new System.Drawing.Point(194, 25);
            this.btMostrar2.Name = "btMostrar2";
            this.btMostrar2.Size = new System.Drawing.Size(75, 23);
            this.btMostrar2.TabIndex = 8;
            this.btMostrar2.Text = "Mostrar";
            this.btMostrar2.UseVisualStyleBackColor = true;
            this.btMostrar2.Click += new System.EventHandler(this.BtMostrar2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Género:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // rbtMujeres
            // 
            this.rbtMujeres.AutoSize = true;
            this.rbtMujeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbtMujeres.Location = new System.Drawing.Point(105, 26);
            this.rbtMujeres.Name = "rbtMujeres";
            this.rbtMujeres.Size = new System.Drawing.Size(70, 19);
            this.rbtMujeres.TabIndex = 1;
            this.rbtMujeres.TabStop = true;
            this.rbtMujeres.Text = "Mujeres";
            this.rbtMujeres.UseVisualStyleBackColor = true;
            this.rbtMujeres.CheckedChanged += new System.EventHandler(this.RbtMujeres_CheckedChanged);
            // 
            // rbtHombres
            // 
            this.rbtHombres.AutoSize = true;
            this.rbtHombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbtHombres.Location = new System.Drawing.Point(17, 26);
            this.rbtHombres.Name = "rbtHombres";
            this.rbtHombres.Size = new System.Drawing.Size(76, 19);
            this.rbtHombres.TabIndex = 0;
            this.rbtHombres.TabStop = true;
            this.rbtHombres.Text = "Hombres";
            this.rbtHombres.UseVisualStyleBackColor = true;
            this.rbtHombres.CheckedChanged += new System.EventHandler(this.RbtHombres_CheckedChanged);
            // 
            // paneOpcion3
            // 
            this.paneOpcion3.Controls.Add(this.label2);
            this.paneOpcion3.Controls.Add(this.cbxDeptos3);
            this.paneOpcion3.Controls.Add(this.label9);
            this.paneOpcion3.Controls.Add(this.btMostrar3);
            this.paneOpcion3.Controls.Add(this.rbtArma2);
            this.paneOpcion3.Controls.Add(this.rbtArma1);
            this.paneOpcion3.Controls.Add(this.label7);
            this.paneOpcion3.Location = new System.Drawing.Point(513, 164);
            this.paneOpcion3.Name = "paneOpcion3";
            this.paneOpcion3.Size = new System.Drawing.Size(312, 147);
            this.paneOpcion3.TabIndex = 15;
            this.paneOpcion3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Departamentos:";
            // 
            // cbxDeptos3
            // 
            this.cbxDeptos3.FormattingEnabled = true;
            this.cbxDeptos3.Items.AddRange(new object[] {
            "Amazonas",
            "Antioquia",
            "Arauca",
            "Atlántico",
            "Bogotá",
            "Bolívar",
            "Boyacá",
            "Caldas",
            "Caquetá",
            "Casanare",
            "Cauca",
            "Cesar",
            "Chocó",
            "Córdoba",
            "Cundinamarca",
            "Guainía",
            "Guaviare",
            "Huila",
            "La Guajira",
            "Magdalena",
            "Meta",
            "Nariño",
            "Norte de Santander",
            "Putumayo",
            "Quindío",
            "Risaralda",
            "San Andrés y Providencia",
            "Santander",
            "Sucre",
            "Tolima",
            "Valle del Cauca",
            "Vaupés",
            "Vichada"});
            this.cbxDeptos3.Location = new System.Drawing.Point(14, 108);
            this.cbxDeptos3.Name = "cbxDeptos3";
            this.cbxDeptos3.Size = new System.Drawing.Size(162, 21);
            this.cbxDeptos3.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(272, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "Si desea conocer los homicidios según el departamento \r\ny género...";
            // 
            // btMostrar3
            // 
            this.btMostrar3.Location = new System.Drawing.Point(228, 27);
            this.btMostrar3.Name = "btMostrar3";
            this.btMostrar3.Size = new System.Drawing.Size(75, 23);
            this.btMostrar3.TabIndex = 11;
            this.btMostrar3.Text = "Mostrar";
            this.btMostrar3.UseVisualStyleBackColor = true;
            this.btMostrar3.Click += new System.EventHandler(this.BtMostrar3_Click);
            // 
            // rbtArma2
            // 
            this.rbtArma2.AutoSize = true;
            this.rbtArma2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtArma2.Location = new System.Drawing.Point(116, 27);
            this.rbtArma2.Name = "rbtArma2";
            this.rbtArma2.Size = new System.Drawing.Size(105, 19);
            this.rbtArma2.TabIndex = 17;
            this.rbtArma2.TabStop = true;
            this.rbtArma2.Text = "Arma de fuego";
            this.rbtArma2.UseVisualStyleBackColor = true;
            this.rbtArma2.CheckedChanged += new System.EventHandler(this.RbtArma2_CheckedChanged);
            // 
            // rbtArma1
            // 
            this.rbtArma1.AutoSize = true;
            this.rbtArma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtArma1.Location = new System.Drawing.Point(16, 27);
            this.rbtArma1.Name = "rbtArma1";
            this.rbtArma1.Size = new System.Drawing.Size(94, 19);
            this.rbtArma1.TabIndex = 16;
            this.rbtArma1.TabStop = true;
            this.rbtArma1.Text = "Arma blanca";
            this.rbtArma1.UseVisualStyleBackColor = true;
            this.rbtArma1.CheckedChanged += new System.EventHandler(this.RbtArma1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tipo de arma:";
            // 
            // lblMensajeTotal
            // 
            this.lblMensajeTotal.AutoSize = true;
            this.lblMensajeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeTotal.Location = new System.Drawing.Point(541, 364);
            this.lblMensajeTotal.Name = "lblMensajeTotal";
            this.lblMensajeTotal.Size = new System.Drawing.Size(0, 25);
            this.lblMensajeTotal.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(826, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMensajeTotal);
            this.Controls.Add(this.paneOpcion3);
            this.Controls.Add(this.paneOpcion2);
            this.Controls.Add(this.paneOpcion1);
            this.Controls.Add(this.rbtOpcion3);
            this.Controls.Add(this.rbtOpcion2);
            this.Controls.Add(this.rbtOpcion1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.map);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Homicidios 2018";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.paneOpcion1.ResumeLayout(false);
            this.paneOpcion1.PerformLayout();
            this.paneOpcion2.ResumeLayout(false);
            this.paneOpcion2.PerformLayout();
            this.paneOpcion3.ResumeLayout(false);
            this.paneOpcion3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.ComboBox cbxDeptos1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtOpcion1;
        private System.Windows.Forms.RadioButton rbtOpcion2;
        private System.Windows.Forms.RadioButton rbtOpcion3;
        private System.Windows.Forms.Panel paneOpcion1;
        private System.Windows.Forms.Panel paneOpcion2;
        private System.Windows.Forms.Panel paneOpcion3;
        private System.Windows.Forms.Button btMostrar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtMujeres;
        private System.Windows.Forms.RadioButton rbtHombres;
        private System.Windows.Forms.ComboBox cbxDeptos2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btMostrar2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btMostrar3;
        private System.Windows.Forms.RadioButton rbtArma2;
        private System.Windows.Forms.RadioButton rbtArma1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDeptos3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMensajeTotal;
        private System.Windows.Forms.Button button1;
    }
}

