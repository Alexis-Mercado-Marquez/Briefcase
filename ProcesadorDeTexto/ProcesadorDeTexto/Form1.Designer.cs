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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
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
            this.B_CB_Replace = new System.Windows.Forms.CheckBox();
            this.B_BTN_Upload = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_upload = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_replace = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lb_desc = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rdInsertBefore = new System.Windows.Forms.RadioButton();
            this.rdInsertAfter = new System.Windows.Forms.RadioButton();
            this.rdReplace = new System.Windows.Forms.RadioButton();
            this.rdDelete = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_AditionalAction2 = new System.Windows.Forms.ComboBox();
            this.cb_AditionalAction = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.A_CB_Ultima = new System.Windows.Forms.CheckBox();
            this.A_NDD_Columna = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.A_CB_Remove = new System.Windows.Forms.CheckBox();
            this.A_CB_Mayus = new System.Windows.Forms.CheckBox();
            this.A_CB_Cadenas = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.A_TB_Cadena = new System.Windows.Forms.TextBox();
            this.tab_reemplazable = new System.Windows.Forms.TabControl();
            this.label5 = new System.Windows.Forms.Label();
            this.A_btn_clean = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_Explain = new System.Windows.Forms.ComboBox();
            this.tab_parrafo = new System.Windows.Forms.TabControl();
            this.tabPageA = new System.Windows.Forms.TabPage();
            this.A_lb_column = new System.Windows.Forms.Label();
            this.A_btn_paste = new System.Windows.Forms.Button();
            this.A_btn_B = new System.Windows.Forms.Button();
            this.A_btn_clear = new System.Windows.Forms.Button();
            this.tabPageB = new System.Windows.Forms.TabPage();
            this.B_btn_A = new System.Windows.Forms.Button();
            this.B_btn_copy = new System.Windows.Forms.Button();
            this.B_btn_clean = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.A_NDD_Rango = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.tab_reemplazo.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.B_NDD_Increm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_NDD_Inicio)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A_NDD_Columna)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tab_reemplazable.SuspendLayout();
            this.tab_parrafo.SuspendLayout();
            this.tabPageA.SuspendLayout();
            this.tabPageB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A_NDD_Rango)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pegue el texto a modificar en el panel \r\nizquierdo (o suba un archivo de texto \r\n" +
    "para trabajar sobre él)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escoja que texto se buscará en cada fila";
            // 
            // tab_reemplazo
            // 
            this.tab_reemplazo.Controls.Add(this.tabPage4);
            this.tab_reemplazo.Controls.Add(this.tabPage5);
            this.tab_reemplazo.Controls.Add(this.tabPage6);
            this.tab_reemplazo.Location = new System.Drawing.Point(6, 147);
            this.tab_reemplazo.Name = "tab_reemplazo";
            this.tab_reemplazo.SelectedIndex = 0;
            this.tab_reemplazo.Size = new System.Drawing.Size(315, 96);
            this.tab_reemplazo.TabIndex = 4;
            this.tab_reemplazo.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_reemplazo_Selected);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.B_TB_Cadena);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(307, 70);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Cadena";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cadena a insertar";
            // 
            // B_TB_Cadena
            // 
            this.B_TB_Cadena.Location = new System.Drawing.Point(9, 26);
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
            this.tabPage5.Size = new System.Drawing.Size(307, 70);
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
            100000,
            0,
            0,
            0});
            this.B_NDD_Inicio.Minimum = new decimal(new int[] {
            100000,
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
            this.tabPage6.Controls.Add(this.B_CB_Replace);
            this.tabPage6.Controls.Add(this.B_BTN_Upload);
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(307, 70);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Lista de valores";
            // 
            // B_CB_Replace
            // 
            this.B_CB_Replace.AutoSize = true;
            this.B_CB_Replace.Location = new System.Drawing.Point(107, 38);
            this.B_CB_Replace.Name = "B_CB_Replace";
            this.B_CB_Replace.Size = new System.Drawing.Size(152, 17);
            this.B_CB_Replace.TabIndex = 7;
            this.B_CB_Replace.Text = "Reemplazar una sola línea";
            this.B_CB_Replace.UseVisualStyleBackColor = true;
            // 
            // B_BTN_Upload
            // 
            this.B_BTN_Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_BTN_Upload.Location = new System.Drawing.Point(4, 34);
            this.B_BTN_Upload.Name = "B_BTN_Upload";
            this.B_BTN_Upload.Size = new System.Drawing.Size(95, 23);
            this.B_BTN_Upload.TabIndex = 6;
            this.B_BTN_Upload.Text = "Subir archivo";
            this.B_BTN_Upload.UseVisualStyleBackColor = true;
            this.B_BTN_Upload.Click += new System.EventHandler(this.B_BTN_Upload_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(263, 26);
            this.label13.TabIndex = 4;
            this.label13.Text = "Pegue la lista de valores (separados por línea) o suba \r\nun archivo de texto.";
            // 
            // btn_upload
            // 
            this.btn_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.Location = new System.Drawing.Point(215, 64);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(95, 23);
            this.btn_upload.TabIndex = 5;
            this.btn_upload.Text = "Subir archivo";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(580, 509);
            this.textBox1.TabIndex = 6;
            this.textBox1.WordWrap = false;
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(6, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(580, 509);
            this.textBox2.TabIndex = 7;
            this.textBox2.WordWrap = false;
            // 
            // btn_replace
            // 
            this.btn_replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_replace.Location = new System.Drawing.Point(6, 249);
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
            this.lb_desc.Location = new System.Drawing.Point(5, 131);
            this.lb_desc.Name = "lb_desc";
            this.lb_desc.Size = new System.Drawing.Size(126, 13);
            this.lb_desc.TabIndex = 13;
            this.lb_desc.Text = "Escoja que texto insertar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "¿Qué debe hacer al encontrarlo?";
            // 
            // rdInsertBefore
            // 
            this.rdInsertBefore.AutoSize = true;
            this.rdInsertBefore.Checked = true;
            this.rdInsertBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInsertBefore.Location = new System.Drawing.Point(8, 26);
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
            this.rdInsertAfter.Location = new System.Drawing.Point(8, 49);
            this.rdInsertAfter.Name = "rdInsertAfter";
            this.rdInsertAfter.Size = new System.Drawing.Size(137, 17);
            this.rdInsertAfter.TabIndex = 19;
            this.rdInsertAfter.Text = "Insertar txt después";
            this.rdInsertAfter.UseVisualStyleBackColor = true;
            this.rdInsertAfter.CheckedChanged += new System.EventHandler(this.rdInsertAfter_CheckedChanged);
            // 
            // rdReplace
            // 
            this.rdReplace.AutoSize = true;
            this.rdReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdReplace.Location = new System.Drawing.Point(8, 72);
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
            this.rdDelete.Location = new System.Drawing.Point(8, 95);
            this.rdDelete.Name = "rdDelete";
            this.rdDelete.Size = new System.Drawing.Size(101, 17);
            this.rdDelete.TabIndex = 21;
            this.rdDelete.Text = "Eliminar texto";
            this.rdDelete.UseVisualStyleBackColor = true;
            this.rdDelete.CheckedChanged += new System.EventHandler(this.rdDelete_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_AditionalAction2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btn_replace);
            this.panel1.Controls.Add(this.lb_desc);
            this.panel1.Controls.Add(this.rdDelete);
            this.panel1.Controls.Add(this.cb_AditionalAction);
            this.panel1.Controls.Add(this.rdInsertBefore);
            this.panel1.Controls.Add(this.rdReplace);
            this.panel1.Controls.Add(this.rdInsertAfter);
            this.panel1.Controls.Add(this.tab_reemplazo);
            this.panel1.Location = new System.Drawing.Point(8, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 282);
            this.panel1.TabIndex = 22;
            // 
            // cb_AditionalAction2
            // 
            this.cb_AditionalAction2.BackColor = System.Drawing.SystemColors.Window;
            this.cb_AditionalAction2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AditionalAction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AditionalAction2.FormattingEnabled = true;
            this.cb_AditionalAction2.Items.AddRange(new object[] {
            "Acción adicional",
            "Combinar líneas",
            "Ordenar líneas (ascendente)",
            "Ordenar líneas (descendente)"});
            this.cb_AditionalAction2.Location = new System.Drawing.Point(156, 53);
            this.cb_AditionalAction2.Name = "cb_AditionalAction2";
            this.cb_AditionalAction2.Size = new System.Drawing.Size(161, 21);
            this.cb_AditionalAction2.TabIndex = 30;
            // 
            // cb_AditionalAction
            // 
            this.cb_AditionalAction.BackColor = System.Drawing.SystemColors.Window;
            this.cb_AditionalAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AditionalAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AditionalAction.FormattingEnabled = true;
            this.cb_AditionalAction.Items.AddRange(new object[] {
            "Accion adicional",
            "Eliminar texto anterior",
            "Eliminar texto posterior"});
            this.cb_AditionalAction.Location = new System.Drawing.Point(156, 26);
            this.cb_AditionalAction.Name = "cb_AditionalAction";
            this.cb_AditionalAction.Size = new System.Drawing.Size(161, 21);
            this.cb_AditionalAction.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = ".";
            this.label3.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.A_NDD_Rango);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.A_CB_Ultima);
            this.tabPage2.Controls.Add(this.A_NDD_Columna);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(316, 129);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Columna";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "El rango indica cuantos carácteres\r\nreemplazar o eliminar desde la co-\r\nlumna enc" +
    "ontrada";
            // 
            // A_CB_Ultima
            // 
            this.A_CB_Ultima.AutoSize = true;
            this.A_CB_Ultima.Location = new System.Drawing.Point(144, 25);
            this.A_CB_Ultima.Name = "A_CB_Ultima";
            this.A_CB_Ultima.Size = new System.Drawing.Size(136, 17);
            this.A_CB_Ultima.TabIndex = 2;
            this.A_CB_Ultima.Text = "Recorrer fila en reversa";
            this.A_CB_Ultima.UseVisualStyleBackColor = true;
            // 
            // A_NDD_Columna
            // 
            this.A_NDD_Columna.Location = new System.Drawing.Point(13, 24);
            this.A_NDD_Columna.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
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
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Número de columna";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.A_CB_Remove);
            this.tabPage1.Controls.Add(this.A_CB_Mayus);
            this.tabPage1.Controls.Add(this.A_CB_Cadenas);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.A_TB_Cadena);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(316, 129);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadena exacta";
            // 
            // A_CB_Remove
            // 
            this.A_CB_Remove.AutoSize = true;
            this.A_CB_Remove.Location = new System.Drawing.Point(143, 63);
            this.A_CB_Remove.Name = "A_CB_Remove";
            this.A_CB_Remove.Size = new System.Drawing.Size(167, 17);
            this.A_CB_Remove.TabIndex = 18;
            this.A_CB_Remove.Text = "Eliminar filas sin coincidencias";
            this.A_CB_Remove.UseVisualStyleBackColor = true;
            // 
            // A_CB_Mayus
            // 
            this.A_CB_Mayus.AutoSize = true;
            this.A_CB_Mayus.Location = new System.Drawing.Point(142, 86);
            this.A_CB_Mayus.Name = "A_CB_Mayus";
            this.A_CB_Mayus.Size = new System.Drawing.Size(163, 30);
            this.A_CB_Mayus.TabIndex = 17;
            this.A_CB_Mayus.Text = "Distinguir letras mayúsculas y\r\nminúsculas\r\n";
            this.A_CB_Mayus.UseVisualStyleBackColor = true;
            // 
            // A_CB_Cadenas
            // 
            this.A_CB_Cadenas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A_CB_Cadenas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.A_CB_Cadenas.FormattingEnabled = true;
            this.A_CB_Cadenas.Items.AddRange(new object[] {
            "Todas",
            "Solo palabras completas"});
            this.A_CB_Cadenas.Location = new System.Drawing.Point(8, 80);
            this.A_CB_Cadenas.Name = "A_CB_Cadenas";
            this.A_CB_Cadenas.Size = new System.Drawing.Size(119, 21);
            this.A_CB_Cadenas.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "¿Qué cadenas tomará?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cadena a buscar";
            // 
            // A_TB_Cadena
            // 
            this.A_TB_Cadena.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A_TB_Cadena.Location = new System.Drawing.Point(6, 26);
            this.A_TB_Cadena.Name = "A_TB_Cadena";
            this.A_TB_Cadena.Size = new System.Drawing.Size(299, 20);
            this.A_TB_Cadena.TabIndex = 0;
            // 
            // tab_reemplazable
            // 
            this.tab_reemplazable.Controls.Add(this.tabPage1);
            this.tab_reemplazable.Controls.Add(this.tabPage2);
            this.tab_reemplazable.Location = new System.Drawing.Point(8, 143);
            this.tab_reemplazable.Name = "tab_reemplazable";
            this.tab_reemplazable.SelectedIndex = 0;
            this.tab_reemplazable.Size = new System.Drawing.Size(324, 155);
            this.tab_reemplazable.TabIndex = 2;
            this.tab_reemplazable.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_reemplazable_Selected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(944, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Lista de valores";
            this.label5.Visible = false;
            // 
            // A_btn_clean
            // 
            this.A_btn_clean.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A_btn_clean.Enabled = false;
            this.A_btn_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_btn_clean.Location = new System.Drawing.Point(947, 34);
            this.A_btn_clean.Multiline = true;
            this.A_btn_clean.Name = "A_btn_clean";
            this.A_btn_clean.Size = new System.Drawing.Size(208, 548);
            this.A_btn_clean.TabIndex = 24;
            this.A_btn_clean.Visible = false;
            this.A_btn_clean.WordWrap = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "EXPLICACIONES";
            // 
            // cb_Explain
            // 
            this.cb_Explain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Explain.FormattingEnabled = true;
            this.cb_Explain.Items.AddRange(new object[] {
            "Escoja lo que quiera saber...",
            "¿Qué hace este programa?",
            "Buscar texto (por cadena exacta)",
            "Buscar texto (por columna)",
            "Buscar por cadena (avanzado)",
            "Buscar por columna (avanzado)",
            "Acciones de los RadioButtons",
            "Acciones de los Selects",
            "Como insertar una cadena",
            "Insertar una iteración de números",
            "Insertar una lista de valores",
            "Subir archivos",
            "Limpiar y copiar"});
            this.cb_Explain.Location = new System.Drawing.Point(117, 29);
            this.cb_Explain.Name = "cb_Explain";
            this.cb_Explain.Size = new System.Drawing.Size(193, 21);
            this.cb_Explain.TabIndex = 26;
            this.cb_Explain.SelectedValueChanged += new System.EventHandler(this.cb_Explain_SelectedValueChanged);
            // 
            // tab_parrafo
            // 
            this.tab_parrafo.Controls.Add(this.tabPageA);
            this.tab_parrafo.Controls.Add(this.tabPageB);
            this.tab_parrafo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_parrafo.Location = new System.Drawing.Point(338, 6);
            this.tab_parrafo.Name = "tab_parrafo";
            this.tab_parrafo.SelectedIndex = 0;
            this.tab_parrafo.Size = new System.Drawing.Size(600, 580);
            this.tab_parrafo.TabIndex = 27;
            // 
            // tabPageA
            // 
            this.tabPageA.Controls.Add(this.A_lb_column);
            this.tabPageA.Controls.Add(this.A_btn_paste);
            this.tabPageA.Controls.Add(this.A_btn_B);
            this.tabPageA.Controls.Add(this.label3);
            this.tabPageA.Controls.Add(this.A_btn_clear);
            this.tabPageA.Controls.Add(this.textBox1);
            this.tabPageA.Location = new System.Drawing.Point(4, 22);
            this.tabPageA.Name = "tabPageA";
            this.tabPageA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageA.Size = new System.Drawing.Size(592, 554);
            this.tabPageA.TabIndex = 0;
            this.tabPageA.Text = "Texto original";
            this.tabPageA.UseVisualStyleBackColor = true;
            // 
            // A_lb_column
            // 
            this.A_lb_column.AutoSize = true;
            this.A_lb_column.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.A_lb_column.Location = new System.Drawing.Point(248, 530);
            this.A_lb_column.Name = "A_lb_column";
            this.A_lb_column.Size = new System.Drawing.Size(63, 13);
            this.A_lb_column.TabIndex = 31;
            this.A_lb_column.Text = "Column: 0";
            // 
            // A_btn_paste
            // 
            this.A_btn_paste.Location = new System.Drawing.Point(77, 525);
            this.A_btn_paste.Name = "A_btn_paste";
            this.A_btn_paste.Size = new System.Drawing.Size(75, 23);
            this.A_btn_paste.TabIndex = 30;
            this.A_btn_paste.Text = "Pegar";
            this.A_btn_paste.UseVisualStyleBackColor = true;
            this.A_btn_paste.Click += new System.EventHandler(this.A_btn_paste_Click);
            // 
            // A_btn_B
            // 
            this.A_btn_B.ForeColor = System.Drawing.Color.SkyBlue;
            this.A_btn_B.Location = new System.Drawing.Point(6, 525);
            this.A_btn_B.Name = "A_btn_B";
            this.A_btn_B.Size = new System.Drawing.Size(40, 23);
            this.A_btn_B.TabIndex = 29;
            this.A_btn_B.Text = "TM";
            this.A_btn_B.UseVisualStyleBackColor = true;
            this.A_btn_B.Click += new System.EventHandler(this.A_btn_B_Click);
            // 
            // A_btn_clear
            // 
            this.A_btn_clear.Location = new System.Drawing.Point(158, 525);
            this.A_btn_clear.Name = "A_btn_clear";
            this.A_btn_clear.Size = new System.Drawing.Size(75, 23);
            this.A_btn_clear.TabIndex = 7;
            this.A_btn_clear.Text = "Limpiar";
            this.A_btn_clear.UseVisualStyleBackColor = true;
            this.A_btn_clear.Click += new System.EventHandler(this.A_btn_clean_Click);
            // 
            // tabPageB
            // 
            this.tabPageB.Controls.Add(this.B_btn_A);
            this.tabPageB.Controls.Add(this.B_btn_copy);
            this.tabPageB.Controls.Add(this.B_btn_clean);
            this.tabPageB.Controls.Add(this.textBox2);
            this.tabPageB.ForeColor = System.Drawing.Color.SkyBlue;
            this.tabPageB.Location = new System.Drawing.Point(4, 22);
            this.tabPageB.Name = "tabPageB";
            this.tabPageB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageB.Size = new System.Drawing.Size(592, 554);
            this.tabPageB.TabIndex = 1;
            this.tabPageB.Text = "Texto modificado";
            this.tabPageB.UseVisualStyleBackColor = true;
            // 
            // B_btn_A
            // 
            this.B_btn_A.ForeColor = System.Drawing.Color.OrangeRed;
            this.B_btn_A.Location = new System.Drawing.Point(6, 525);
            this.B_btn_A.Name = "B_btn_A";
            this.B_btn_A.Size = new System.Drawing.Size(40, 23);
            this.B_btn_A.TabIndex = 30;
            this.B_btn_A.Text = "TO";
            this.B_btn_A.UseVisualStyleBackColor = true;
            this.B_btn_A.Click += new System.EventHandler(this.B_btn_A_Click);
            // 
            // B_btn_copy
            // 
            this.B_btn_copy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B_btn_copy.Location = new System.Drawing.Point(74, 525);
            this.B_btn_copy.Name = "B_btn_copy";
            this.B_btn_copy.Size = new System.Drawing.Size(75, 23);
            this.B_btn_copy.TabIndex = 9;
            this.B_btn_copy.Text = "Copiar";
            this.B_btn_copy.UseVisualStyleBackColor = true;
            this.B_btn_copy.Click += new System.EventHandler(this.B_btn_copy_Click);
            // 
            // B_btn_clean
            // 
            this.B_btn_clean.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B_btn_clean.Location = new System.Drawing.Point(155, 525);
            this.B_btn_clean.Name = "B_btn_clean";
            this.B_btn_clean.Size = new System.Drawing.Size(75, 23);
            this.B_btn_clean.TabIndex = 8;
            this.B_btn_clean.Text = "Limpiar";
            this.B_btn_clean.UseVisualStyleBackColor = true;
            this.B_btn_clean.Click += new System.EventHandler(this.B_btn_clean_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // A_NDD_Rango
            // 
            this.A_NDD_Rango.Location = new System.Drawing.Point(13, 72);
            this.A_NDD_Rango.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.A_NDD_Rango.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.A_NDD_Rango.Name = "A_NDD_Rango";
            this.A_NDD_Rango.Size = new System.Drawing.Size(108, 20);
            this.A_NDD_Rango.TabIndex = 4;
            this.A_NDD_Rango.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Rango de carcácteres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 596);
            this.Controls.Add(this.tab_parrafo);
            this.Controls.Add(this.cb_Explain);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.A_btn_clean);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tab_reemplazable);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Procesador de texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_reemplazo.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.B_NDD_Increm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_NDD_Inicio)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A_NDD_Columna)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tab_reemplazable.ResumeLayout(false);
            this.tab_parrafo.ResumeLayout(false);
            this.tabPageA.ResumeLayout(false);
            this.tabPageA.PerformLayout();
            this.tabPageB.ResumeLayout(false);
            this.tabPageB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A_NDD_Rango)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tab_reemplazo;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_replace;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lb_desc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox B_TB_Cadena;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdInsertBefore;
        private System.Windows.Forms.RadioButton rdInsertAfter;
        private System.Windows.Forms.RadioButton rdReplace;
        private System.Windows.Forms.RadioButton rdDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown B_NDD_Increm;
        private System.Windows.Forms.NumericUpDown B_NDD_Inicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown A_NDD_Columna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox A_CB_Mayus;
        private System.Windows.Forms.ComboBox A_CB_Cadenas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox A_TB_Cadena;
        private System.Windows.Forms.TabControl tab_reemplazable;
        private System.Windows.Forms.CheckBox B_CB_Replace;
        private System.Windows.Forms.Button B_BTN_Upload;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox A_btn_clean;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_Explain;
        private System.Windows.Forms.TabControl tab_parrafo;
        private System.Windows.Forms.TabPage tabPageA;
        private System.Windows.Forms.TabPage tabPageB;
        private System.Windows.Forms.Button A_btn_clear;
        private System.Windows.Forms.Button B_btn_copy;
        private System.Windows.Forms.Button B_btn_clean;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_AditionalAction;
        private System.Windows.Forms.CheckBox A_CB_Ultima;
        private System.Windows.Forms.ComboBox cb_AditionalAction2;
        private System.Windows.Forms.Button A_btn_B;
        private System.Windows.Forms.Button B_btn_A;
        private System.Windows.Forms.Button A_btn_paste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label A_lb_column;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox A_CB_Remove;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown A_NDD_Rango;
    }
}

