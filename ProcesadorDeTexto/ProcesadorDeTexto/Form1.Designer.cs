namespace ProcesadorDeTexto
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
            this.label1 = new System.Windows.Forms.Label();
            this.tab_reemplazable = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.A_CB_Mayus = new System.Windows.Forms.CheckBox();
            this.A_CB_Cadenas = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.A_TB_Cadena = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.A_NDD_Columna = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_reemplazo = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.B_TB_Cadena = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.B_NDD_Increm = new System.Windows.Forms.NumericUpDown();
            this.B_NDD_Inicio = new System.Windows.Forms.NumericUpDown();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btn_upload = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_replace = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lb_desc = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rdInsertBefore = new System.Windows.Forms.RadioButton();
            this.rdInsertAfter = new System.Windows.Forms.RadioButton();
            this.rdReplace = new System.Windows.Forms.RadioButton();
            this.rdDelete = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tab_reemplazable.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A_NDD_Columna)).BeginInit();
            this.tab_reemplazo.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.B_NDD_Increm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_NDD_Inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pegue el texto a modificar en el panel izquierdo (o suba un ar-\r\nchivo para traba" +
    "jar sobre él)";
            // 
            // tab_reemplazable
            // 
            this.tab_reemplazable.Controls.Add(this.tabPage1);
            this.tab_reemplazable.Controls.Add(this.tabPage2);
            this.tab_reemplazable.Controls.Add(this.tabPage3);
            this.tab_reemplazable.Location = new System.Drawing.Point(8, 105);
            this.tab_reemplazable.Name = "tab_reemplazable";
            this.tab_reemplazable.SelectedIndex = 0;
            this.tab_reemplazable.Size = new System.Drawing.Size(324, 169);
            this.tab_reemplazable.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.A_CB_Mayus);
            this.tabPage1.Controls.Add(this.A_CB_Cadenas);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.A_TB_Cadena);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(316, 143);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadena exacta";
            // 
            // A_CB_Mayus
            // 
            this.A_CB_Mayus.AutoSize = true;
            this.A_CB_Mayus.Location = new System.Drawing.Point(175, 68);
            this.A_CB_Mayus.Name = "A_CB_Mayus";
            this.A_CB_Mayus.Size = new System.Drawing.Size(127, 30);
            this.A_CB_Mayus.TabIndex = 17;
            this.A_CB_Mayus.Text = "Distinguir mayúsculas\r\ny minúsculas";
            this.A_CB_Mayus.UseVisualStyleBackColor = true;
            this.A_CB_Mayus.CheckedChanged += new System.EventHandler(this.A_CB_Mayus_CheckedChanged);
            // 
            // A_CB_Cadenas
            // 
            this.A_CB_Cadenas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A_CB_Cadenas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.A_CB_Cadenas.FormattingEnabled = true;
            this.A_CB_Cadenas.Items.AddRange(new object[] {
            "Todas",
            "Solo palabras completas"});
            this.A_CB_Cadenas.Location = new System.Drawing.Point(9, 73);
            this.A_CB_Cadenas.Name = "A_CB_Cadenas";
            this.A_CB_Cadenas.Size = new System.Drawing.Size(150, 21);
            this.A_CB_Cadenas.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "¿Qué cadenas tomará?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cadena a buscar";
            // 
            // A_TB_Cadena
            // 
            this.A_TB_Cadena.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A_TB_Cadena.Location = new System.Drawing.Point(7, 30);
            this.A_TB_Cadena.Name = "A_TB_Cadena";
            this.A_TB_Cadena.Size = new System.Drawing.Size(294, 20);
            this.A_TB_Cadena.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.A_NDD_Columna);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(316, 143);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Columnas x filas";
            // 
            // A_NDD_Columna
            // 
            this.A_NDD_Columna.Location = new System.Drawing.Point(13, 24);
            this.A_NDD_Columna.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.A_NDD_Columna.Name = "A_NDD_Columna";
            this.A_NDD_Columna.Size = new System.Drawing.Size(110, 20);
            this.A_NDD_Columna.TabIndex = 1;
            this.A_NDD_Columna.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Número de la columna";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(316, 143);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Grupo de valores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escoja que texto se debe buscar";
            // 
            // tab_reemplazo
            // 
            this.tab_reemplazo.Controls.Add(this.tabPage4);
            this.tab_reemplazo.Controls.Add(this.tabPage5);
            this.tab_reemplazo.Controls.Add(this.tabPage6);
            this.tab_reemplazo.Location = new System.Drawing.Point(5, 112);
            this.tab_reemplazo.Name = "tab_reemplazo";
            this.tab_reemplazo.SelectedIndex = 0;
            this.tab_reemplazo.Size = new System.Drawing.Size(315, 87);
            this.tab_reemplazo.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.B_TB_Cadena);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(307, 61);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Cadena";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cadena a insertar";
            // 
            // B_TB_Cadena
            // 
            this.B_TB_Cadena.Location = new System.Drawing.Point(6, 35);
            this.B_TB_Cadena.Name = "B_TB_Cadena";
            this.B_TB_Cadena.Size = new System.Drawing.Size(290, 20);
            this.B_TB_Cadena.TabIndex = 15;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.B_NDD_Increm);
            this.tabPage5.Controls.Add(this.B_NDD_Inicio);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(307, 61);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Iteración de números";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(122, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Incrementar en:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Empezar en:";
            // 
            // B_NDD_Increm
            // 
            this.B_NDD_Increm.Location = new System.Drawing.Point(125, 29);
            this.B_NDD_Increm.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.B_NDD_Increm.Name = "B_NDD_Increm";
            this.B_NDD_Increm.Size = new System.Drawing.Size(87, 20);
            this.B_NDD_Increm.TabIndex = 1;
            // 
            // B_NDD_Inicio
            // 
            this.B_NDD_Inicio.Location = new System.Drawing.Point(11, 29);
            this.B_NDD_Inicio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.B_NDD_Inicio.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.B_NDD_Inicio.Name = "B_NDD_Inicio";
            this.B_NDD_Inicio.Size = new System.Drawing.Size(92, 20);
            this.B_NDD_Inicio.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(307, 61);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Grupo de valores";
            // 
            // btn_upload
            // 
            this.btn_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.Location = new System.Drawing.Point(12, 51);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(95, 23);
            this.btn_upload.TabIndex = 5;
            this.btn_upload.Text = "Subir archivo";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(351, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 487);
            this.textBox1.TabIndex = 6;
            this.textBox1.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Location = new System.Drawing.Point(631, 29);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 487);
            this.textBox2.TabIndex = 7;
            this.textBox2.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Texto a modificar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(628, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Texto modificado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(909, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hoja de Excel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(912, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(296, 487);
            this.dataGridView1.TabIndex = 11;
            // 
            // btn_replace
            // 
            this.btn_replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_replace.Location = new System.Drawing.Point(5, 205);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(91, 23);
            this.btn_replace.TabIndex = 12;
            this.btn_replace.Text = "Insertar";
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lb_desc
            // 
            this.lb_desc.AutoSize = true;
            this.lb_desc.Location = new System.Drawing.Point(5, 81);
            this.lb_desc.Name = "lb_desc";
            this.lb_desc.Size = new System.Drawing.Size(126, 13);
            this.lb_desc.TabIndex = 13;
            this.lb_desc.Text = "Escoja que texto insertar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Escoja una acción";
            // 
            // rdInsertBefore
            // 
            this.rdInsertBefore.AutoSize = true;
            this.rdInsertBefore.Checked = true;
            this.rdInsertBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInsertBefore.Location = new System.Drawing.Point(8, 27);
            this.rdInsertBefore.Name = "rdInsertBefore";
            this.rdInsertBefore.Size = new System.Drawing.Size(135, 17);
            this.rdInsertBefore.TabIndex = 18;
            this.rdInsertBefore.TabStop = true;
            this.rdInsertBefore.Text = "Insertar texto antes";
            this.rdInsertBefore.UseVisualStyleBackColor = true;
            this.rdInsertBefore.CheckedChanged += new System.EventHandler(this.rdInsertBefore_CheckedChanged);
            // 
            // rdInsertAfter
            // 
            this.rdInsertAfter.AutoSize = true;
            this.rdInsertAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInsertAfter.Location = new System.Drawing.Point(8, 50);
            this.rdInsertAfter.Name = "rdInsertAfter";
            this.rdInsertAfter.Size = new System.Drawing.Size(151, 17);
            this.rdInsertAfter.TabIndex = 19;
            this.rdInsertAfter.Text = "Insertar texto después";
            this.rdInsertAfter.UseVisualStyleBackColor = true;
            this.rdInsertAfter.CheckedChanged += new System.EventHandler(this.rdInsertAfter_CheckedChanged);
            // 
            // rdReplace
            // 
            this.rdReplace.AutoSize = true;
            this.rdReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdReplace.Location = new System.Drawing.Point(179, 27);
            this.rdReplace.Name = "rdReplace";
            this.rdReplace.Size = new System.Drawing.Size(123, 17);
            this.rdReplace.TabIndex = 20;
            this.rdReplace.Text = "Reemplazar texto";
            this.rdReplace.UseVisualStyleBackColor = true;
            this.rdReplace.CheckedChanged += new System.EventHandler(this.rdReplace_CheckedChanged);
            // 
            // rdDelete
            // 
            this.rdDelete.AutoSize = true;
            this.rdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDelete.Location = new System.Drawing.Point(179, 50);
            this.rdDelete.Name = "rdDelete";
            this.rdDelete.Size = new System.Drawing.Size(101, 17);
            this.rdDelete.TabIndex = 21;
            this.rdDelete.Text = "Eliminar texto";
            this.rdDelete.UseVisualStyleBackColor = true;
            this.rdDelete.CheckedChanged += new System.EventHandler(this.rdDelete_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btn_replace);
            this.panel1.Controls.Add(this.lb_desc);
            this.panel1.Controls.Add(this.rdDelete);
            this.panel1.Controls.Add(this.rdInsertBefore);
            this.panel1.Controls.Add(this.rdReplace);
            this.panel1.Controls.Add(this.rdInsertAfter);
            this.panel1.Controls.Add(this.tab_reemplazo);
            this.panel1.Location = new System.Drawing.Point(8, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 231);
            this.panel1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tab_reemplazable);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Procesador de texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_reemplazable.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A_NDD_Columna)).EndInit();
            this.tab_reemplazo.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.B_NDD_Increm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_NDD_Inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab_reemplazable;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tab_reemplazo;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_replace;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lb_desc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox A_TB_Cadena;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox B_TB_Cadena;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdInsertBefore;
        private System.Windows.Forms.RadioButton rdInsertAfter;
        private System.Windows.Forms.RadioButton rdReplace;
        private System.Windows.Forms.RadioButton rdDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown A_NDD_Columna;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown B_NDD_Increm;
        private System.Windows.Forms.NumericUpDown B_NDD_Inicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox A_CB_Cadenas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox A_CB_Mayus;
    }
}

