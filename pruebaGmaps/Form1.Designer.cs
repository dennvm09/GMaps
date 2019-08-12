namespace pruebaGmaps
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btmostrar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbtOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbtOpcion3 = new System.Windows.Forms.RadioButton();
            this.paneOpcion1 = new System.Windows.Forms.Panel();
            this.paneOpcion2 = new System.Windows.Forms.Panel();
            this.paneOpcion3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btMostrar1 = new System.Windows.Forms.Button();
            this.rbtHombres = new System.Windows.Forms.RadioButton();
            this.rbtMujeres = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.paneOpcion1.SuspendLayout();
            this.paneOpcion2.SuspendLayout();
            this.paneOpcion3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(-1, -1);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(509, 508);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.GMapControl1_Load);
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GMapControl1_MouseDoubleClick);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(26, 426);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(206, 20);
            this.txt1.TabIndex = 1;
            this.txt1.TextChanged += new System.EventHandler(this.Txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(26, 448);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(206, 20);
            this.txt2.TabIndex = 2;
            this.txt2.TextChanged += new System.EventHandler(this.Txt2_TextChanged);
            // 
            // btmostrar
            // 
            this.btmostrar.Location = new System.Drawing.Point(82, 469);
            this.btmostrar.Name = "btmostrar";
            this.btmostrar.Size = new System.Drawing.Size(75, 23);
            this.btmostrar.TabIndex = 3;
            this.btmostrar.Text = "mostrar";
            this.btmostrar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            "San Adnrés y Providencia",
            "Santander",
            "Sucre",
            "Tolima",
            "Valle del Cauca",
            "Vaupés",
            "Vichada"});
            this.comboBox1.Location = new System.Drawing.Point(16, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(562, 455);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(185, 21);
            this.comboBox2.TabIndex = 5;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Municipios:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 20);
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
            this.paneOpcion1.Controls.Add(this.comboBox1);
            this.paneOpcion1.Controls.Add(this.label1);
            this.paneOpcion1.Location = new System.Drawing.Point(513, 164);
            this.paneOpcion1.Name = "paneOpcion1";
            this.paneOpcion1.Size = new System.Drawing.Size(286, 67);
            this.paneOpcion1.TabIndex = 13;
            this.paneOpcion1.Visible = false;
            this.paneOpcion1.Paint += new System.Windows.Forms.PaintEventHandler(this.PaneOpcion1_Paint);
            // 
            // paneOpcion2
            // 
            this.paneOpcion2.Controls.Add(this.label5);
            this.paneOpcion2.Controls.Add(this.rbtMujeres);
            this.paneOpcion2.Controls.Add(this.rbtHombres);
            this.paneOpcion2.Location = new System.Drawing.Point(513, 237);
            this.paneOpcion2.Name = "paneOpcion2";
            this.paneOpcion2.Size = new System.Drawing.Size(286, 100);
            this.paneOpcion2.TabIndex = 14;
            this.paneOpcion2.Visible = false;
            // 
            // paneOpcion3
            // 
            this.paneOpcion3.Controls.Add(this.label7);
            this.paneOpcion3.Location = new System.Drawing.Point(327, 414);
            this.paneOpcion3.Name = "paneOpcion3";
            this.paneOpcion3.Size = new System.Drawing.Size(286, 100);
            this.paneOpcion3.TabIndex = 15;
            this.paneOpcion3.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "opción 3";
            // 
            // btMostrar1
            // 
            this.btMostrar1.Location = new System.Drawing.Point(194, 30);
            this.btMostrar1.Name = "btMostrar1";
            this.btMostrar1.Size = new System.Drawing.Size(75, 23);
            this.btMostrar1.TabIndex = 7;
            this.btMostrar1.Text = "Mostrar";
            this.btMostrar1.UseVisualStyleBackColor = true;
            // 
            // rbtHombres
            // 
            this.rbtHombres.AutoSize = true;
            this.rbtHombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbtHombres.Location = new System.Drawing.Point(17, 41);
            this.rbtHombres.Name = "rbtHombres";
            this.rbtHombres.Size = new System.Drawing.Size(76, 19);
            this.rbtHombres.TabIndex = 0;
            this.rbtHombres.TabStop = true;
            this.rbtHombres.Text = "Hombres";
            this.rbtHombres.UseVisualStyleBackColor = true;
            // 
            // rbtMujeres
            // 
            this.rbtMujeres.AutoSize = true;
            this.rbtMujeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbtMujeres.Location = new System.Drawing.Point(105, 41);
            this.rbtMujeres.Name = "rbtMujeres";
            this.rbtMujeres.Size = new System.Drawing.Size(70, 19);
            this.rbtMujeres.TabIndex = 1;
            this.rbtMujeres.TabStop = true;
            this.rbtMujeres.Text = "Mujeres";
            this.rbtMujeres.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Departamentos:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.paneOpcion3);
            this.Controls.Add(this.paneOpcion2);
            this.Controls.Add(this.paneOpcion1);
            this.Controls.Add(this.rbtOpcion3);
            this.Controls.Add(this.rbtOpcion2);
            this.Controls.Add(this.rbtOpcion1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btmostrar);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.gMapControl1);
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

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btmostrar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtOpcion1;
        private System.Windows.Forms.RadioButton rbtOpcion2;
        private System.Windows.Forms.RadioButton rbtOpcion3;
        private System.Windows.Forms.Panel paneOpcion1;
        private System.Windows.Forms.Panel paneOpcion2;
        private System.Windows.Forms.Panel paneOpcion3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btMostrar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtMujeres;
        private System.Windows.Forms.RadioButton rbtHombres;
    }
}

