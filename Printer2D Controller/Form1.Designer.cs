namespace Printer2D_Controller
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLONA = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIMPRIMIR = new System.Windows.Forms.Button();
            this.btn_Draw_Rect = new System.Windows.Forms.Button();
            this.btn_Draw_Lineas = new System.Windows.Forms.Button();
            this.btn_Draw_Poligon = new System.Windows.Forms.Button();
            this.btn_Draw_Elip = new System.Windows.Forms.Button();
            this.btn_Draw_Arc = new System.Windows.Forms.Button();
            this.btn_ABRIR = new System.Windows.Forms.Button();
            this.btn_GUARDAR = new System.Windows.Forms.Button();
            this.btn_Draw_Line = new System.Windows.Forms.Button();
            this.btnINSERTimg = new System.Windows.Forms.Button();
            this.btn_EXPORTAR = new System.Windows.Forms.Button();
            this.btnIMITAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxCOM = new System.Windows.Forms.ComboBox();
            this.lb_Info_Pxy = new System.Windows.Forms.Label();
            this.btnAREALIMITE = new System.Windows.Forms.Button();
            this.btn_HDCOM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_VISTA_PREVIA = new System.Windows.Forms.Button();
            this.btn_Prueba_COM = new System.Windows.Forms.Button();
            this.btn_Ctrl_COM = new System.Windows.Forms.Button();
            this.btn_Curva_Bezier = new System.Windows.Forms.Button();
            this.btn_Curva = new System.Windows.Forms.Button();
            this.btn_Texto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelLONA
            // 
            this.panelLONA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLONA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.panelLONA.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panelLONA.Location = new System.Drawing.Point(0, 117);
            this.panelLONA.Name = "panelLONA";
            this.panelLONA.Size = new System.Drawing.Size(920, 302);
            this.panelLONA.TabIndex = 0;
            this.panelLONA.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLONA_Paint);
            this.panelLONA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLONA_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mutume 2D";
            // 
            // btnIMPRIMIR
            // 
            this.btnIMPRIMIR.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIMPRIMIR.FlatAppearance.BorderSize = 0;
            this.btnIMPRIMIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.btnIMPRIMIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIMPRIMIR.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIMPRIMIR.ForeColor = System.Drawing.Color.White;
            this.btnIMPRIMIR.Location = new System.Drawing.Point(628, 42);
            this.btnIMPRIMIR.Name = "btnIMPRIMIR";
            this.btnIMPRIMIR.Size = new System.Drawing.Size(65, 60);
            this.btnIMPRIMIR.TabIndex = 2;
            this.btnIMPRIMIR.Text = "IMPRIMIR";
            this.btnIMPRIMIR.UseVisualStyleBackColor = false;
            // 
            // btn_Draw_Rect
            // 
            this.btn_Draw_Rect.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Draw_Rect.FlatAppearance.BorderSize = 0;
            this.btn_Draw_Rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(122)))));
            this.btn_Draw_Rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Draw_Rect.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Draw_Rect.ForeColor = System.Drawing.Color.White;
            this.btn_Draw_Rect.Location = new System.Drawing.Point(262, 42);
            this.btn_Draw_Rect.Name = "btn_Draw_Rect";
            this.btn_Draw_Rect.Size = new System.Drawing.Size(78, 25);
            this.btn_Draw_Rect.TabIndex = 2;
            this.btn_Draw_Rect.Text = "Rectangulo";
            this.btn_Draw_Rect.UseVisualStyleBackColor = false;
            this.btn_Draw_Rect.Click += new System.EventHandler(this.btn_Draw_Rect_Click);
            // 
            // btn_Draw_Lineas
            // 
            this.btn_Draw_Lineas.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Draw_Lineas.FlatAppearance.BorderSize = 0;
            this.btn_Draw_Lineas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(122)))));
            this.btn_Draw_Lineas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Draw_Lineas.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Draw_Lineas.ForeColor = System.Drawing.Color.White;
            this.btn_Draw_Lineas.Location = new System.Drawing.Point(370, 73);
            this.btn_Draw_Lineas.Name = "btn_Draw_Lineas";
            this.btn_Draw_Lineas.Size = new System.Drawing.Size(47, 26);
            this.btn_Draw_Lineas.TabIndex = 2;
            this.btn_Draw_Lineas.Text = "Lineas";
            this.btn_Draw_Lineas.UseVisualStyleBackColor = false;
            this.btn_Draw_Lineas.Click += new System.EventHandler(this.btn_Draw_Lineas_Click);
            // 
            // btn_Draw_Poligon
            // 
            this.btn_Draw_Poligon.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Draw_Poligon.FlatAppearance.BorderSize = 0;
            this.btn_Draw_Poligon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(122)))));
            this.btn_Draw_Poligon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Draw_Poligon.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Draw_Poligon.ForeColor = System.Drawing.Color.White;
            this.btn_Draw_Poligon.Location = new System.Drawing.Point(307, 73);
            this.btn_Draw_Poligon.Name = "btn_Draw_Poligon";
            this.btn_Draw_Poligon.Size = new System.Drawing.Size(57, 26);
            this.btn_Draw_Poligon.TabIndex = 2;
            this.btn_Draw_Poligon.Text = "Poligono";
            this.btn_Draw_Poligon.UseVisualStyleBackColor = false;
            // 
            // btn_Draw_Elip
            // 
            this.btn_Draw_Elip.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Draw_Elip.FlatAppearance.BorderSize = 0;
            this.btn_Draw_Elip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(122)))));
            this.btn_Draw_Elip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Draw_Elip.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Draw_Elip.ForeColor = System.Drawing.Color.White;
            this.btn_Draw_Elip.Location = new System.Drawing.Point(346, 42);
            this.btn_Draw_Elip.Name = "btn_Draw_Elip";
            this.btn_Draw_Elip.Size = new System.Drawing.Size(50, 26);
            this.btn_Draw_Elip.TabIndex = 2;
            this.btn_Draw_Elip.Text = "Elipse";
            this.btn_Draw_Elip.UseVisualStyleBackColor = false;
            this.btn_Draw_Elip.Click += new System.EventHandler(this.btn_Draw_Elip_Click);
            // 
            // btn_Draw_Arc
            // 
            this.btn_Draw_Arc.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Draw_Arc.FlatAppearance.BorderSize = 0;
            this.btn_Draw_Arc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(122)))));
            this.btn_Draw_Arc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Draw_Arc.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Draw_Arc.ForeColor = System.Drawing.Color.White;
            this.btn_Draw_Arc.Location = new System.Drawing.Point(262, 73);
            this.btn_Draw_Arc.Name = "btn_Draw_Arc";
            this.btn_Draw_Arc.Size = new System.Drawing.Size(39, 26);
            this.btn_Draw_Arc.TabIndex = 2;
            this.btn_Draw_Arc.Text = "Arco";
            this.btn_Draw_Arc.UseVisualStyleBackColor = false;
            this.btn_Draw_Arc.Click += new System.EventHandler(this.btn_Draw_Arc_Click);
            // 
            // btn_ABRIR
            // 
            this.btn_ABRIR.FlatAppearance.BorderSize = 0;
            this.btn_ABRIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.btn_ABRIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ABRIR.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ABRIR.ForeColor = System.Drawing.Color.White;
            this.btn_ABRIR.Location = new System.Drawing.Point(18, 55);
            this.btn_ABRIR.Name = "btn_ABRIR";
            this.btn_ABRIR.Size = new System.Drawing.Size(43, 20);
            this.btn_ABRIR.TabIndex = 2;
            this.btn_ABRIR.Text = "Abrir";
            this.btn_ABRIR.UseVisualStyleBackColor = true;
            // 
            // btn_GUARDAR
            // 
            this.btn_GUARDAR.FlatAppearance.BorderSize = 0;
            this.btn_GUARDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.btn_GUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GUARDAR.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GUARDAR.ForeColor = System.Drawing.Color.White;
            this.btn_GUARDAR.Location = new System.Drawing.Point(67, 55);
            this.btn_GUARDAR.Name = "btn_GUARDAR";
            this.btn_GUARDAR.Size = new System.Drawing.Size(56, 20);
            this.btn_GUARDAR.TabIndex = 2;
            this.btn_GUARDAR.Text = "Guardar";
            this.btn_GUARDAR.UseVisualStyleBackColor = true;
            // 
            // btn_Draw_Line
            // 
            this.btn_Draw_Line.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Draw_Line.FlatAppearance.BorderSize = 0;
            this.btn_Draw_Line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(122)))));
            this.btn_Draw_Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Draw_Line.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Draw_Line.ForeColor = System.Drawing.Color.White;
            this.btn_Draw_Line.Location = new System.Drawing.Point(402, 42);
            this.btn_Draw_Line.Name = "btn_Draw_Line";
            this.btn_Draw_Line.Size = new System.Drawing.Size(50, 26);
            this.btn_Draw_Line.TabIndex = 2;
            this.btn_Draw_Line.Text = "Trazo";
            this.btn_Draw_Line.UseVisualStyleBackColor = false;
            this.btn_Draw_Line.Click += new System.EventHandler(this.btn_Draw_Line_Click);
            // 
            // btnINSERTimg
            // 
            this.btnINSERTimg.BackColor = System.Drawing.Color.Crimson;
            this.btnINSERTimg.FlatAppearance.BorderSize = 0;
            this.btnINSERTimg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnINSERTimg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnINSERTimg.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINSERTimg.ForeColor = System.Drawing.Color.White;
            this.btnINSERTimg.Location = new System.Drawing.Point(202, 42);
            this.btnINSERTimg.Name = "btnINSERTimg";
            this.btnINSERTimg.Size = new System.Drawing.Size(54, 58);
            this.btnINSERTimg.TabIndex = 2;
            this.btnINSERTimg.Text = "Insertar imagen";
            this.btnINSERTimg.UseVisualStyleBackColor = false;
            // 
            // btn_EXPORTAR
            // 
            this.btn_EXPORTAR.FlatAppearance.BorderSize = 0;
            this.btn_EXPORTAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.btn_EXPORTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EXPORTAR.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EXPORTAR.ForeColor = System.Drawing.Color.White;
            this.btn_EXPORTAR.Location = new System.Drawing.Point(129, 55);
            this.btn_EXPORTAR.Name = "btn_EXPORTAR";
            this.btn_EXPORTAR.Size = new System.Drawing.Size(56, 20);
            this.btn_EXPORTAR.TabIndex = 2;
            this.btn_EXPORTAR.Text = "Exportar";
            this.btn_EXPORTAR.UseVisualStyleBackColor = true;
            // 
            // btnIMITAR
            // 
            this.btnIMITAR.BackColor = System.Drawing.Color.CadetBlue;
            this.btnIMITAR.FlatAppearance.BorderSize = 0;
            this.btnIMITAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(161)))), ((int)(((byte)(158)))));
            this.btnIMITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIMITAR.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIMITAR.ForeColor = System.Drawing.Color.White;
            this.btnIMITAR.Location = new System.Drawing.Point(699, 42);
            this.btnIMITAR.Name = "btnIMITAR";
            this.btnIMITAR.Size = new System.Drawing.Size(47, 60);
            this.btnIMITAR.TabIndex = 2;
            this.btnIMITAR.Text = "IMITAR";
            this.btnIMITAR.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(572, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opcciones de impresión";
            // 
            // cboxCOM
            // 
            this.cboxCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxCOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.cboxCOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxCOM.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCOM.ForeColor = System.Drawing.Color.White;
            this.cboxCOM.FormattingEnabled = true;
            this.cboxCOM.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5"});
            this.cboxCOM.Location = new System.Drawing.Point(777, 81);
            this.cboxCOM.Name = "cboxCOM";
            this.cboxCOM.Size = new System.Drawing.Size(87, 21);
            this.cboxCOM.TabIndex = 3;
            this.cboxCOM.Text = "COM3";
            // 
            // lb_Info_Pxy
            // 
            this.lb_Info_Pxy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Info_Pxy.AutoSize = true;
            this.lb_Info_Pxy.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Info_Pxy.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_Info_Pxy.Location = new System.Drawing.Point(6, 424);
            this.lb_Info_Pxy.Name = "lb_Info_Pxy";
            this.lb_Info_Pxy.Size = new System.Drawing.Size(102, 13);
            this.lb_Info_Pxy.TabIndex = 1;
            this.lb_Info_Pxy.Text = "Eje[cm]  X=  0  ::  Y=  0 ";
            // 
            // btnAREALIMITE
            // 
            this.btnAREALIMITE.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAREALIMITE.FlatAppearance.BorderSize = 0;
            this.btnAREALIMITE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.btnAREALIMITE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAREALIMITE.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAREALIMITE.ForeColor = System.Drawing.Color.White;
            this.btnAREALIMITE.Location = new System.Drawing.Point(575, 42);
            this.btnAREALIMITE.Name = "btnAREALIMITE";
            this.btnAREALIMITE.Size = new System.Drawing.Size(47, 60);
            this.btnAREALIMITE.TabIndex = 2;
            this.btnAREALIMITE.Text = "AREA LIMITE";
            this.btnAREALIMITE.UseVisualStyleBackColor = false;
            // 
            // btn_HDCOM
            // 
            this.btn_HDCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_HDCOM.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_HDCOM.FlatAppearance.BorderSize = 0;
            this.btn_HDCOM.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.btn_HDCOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HDCOM.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HDCOM.ForeColor = System.Drawing.Color.White;
            this.btn_HDCOM.Location = new System.Drawing.Point(777, 41);
            this.btn_HDCOM.Name = "btn_HDCOM";
            this.btn_HDCOM.Size = new System.Drawing.Size(87, 34);
            this.btn_HDCOM.TabIndex = 2;
            this.btn_HDCOM.Text = "Desahabilitar";
            this.btn_HDCOM.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(774, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Configurar puerto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(199, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Opcciones de dibujo";
            // 
            // btn_VISTA_PREVIA
            // 
            this.btn_VISTA_PREVIA.FlatAppearance.BorderSize = 0;
            this.btn_VISTA_PREVIA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.btn_VISTA_PREVIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VISTA_PREVIA.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VISTA_PREVIA.ForeColor = System.Drawing.Color.White;
            this.btn_VISTA_PREVIA.Location = new System.Drawing.Point(18, 80);
            this.btn_VISTA_PREVIA.Name = "btn_VISTA_PREVIA";
            this.btn_VISTA_PREVIA.Size = new System.Drawing.Size(114, 20);
            this.btn_VISTA_PREVIA.TabIndex = 2;
            this.btn_VISTA_PREVIA.Text = "Generar vista previa";
            this.btn_VISTA_PREVIA.UseVisualStyleBackColor = true;
            // 
            // btn_Prueba_COM
            // 
            this.btn_Prueba_COM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Prueba_COM.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Prueba_COM.FlatAppearance.BorderSize = 0;
            this.btn_Prueba_COM.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.btn_Prueba_COM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Prueba_COM.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prueba_COM.ForeColor = System.Drawing.Color.White;
            this.btn_Prueba_COM.Location = new System.Drawing.Point(870, 41);
            this.btn_Prueba_COM.Name = "btn_Prueba_COM";
            this.btn_Prueba_COM.Size = new System.Drawing.Size(36, 34);
            this.btn_Prueba_COM.TabIndex = 2;
            this.btn_Prueba_COM.Text = "343";
            this.btn_Prueba_COM.UseVisualStyleBackColor = false;
            // 
            // btn_Ctrl_COM
            // 
            this.btn_Ctrl_COM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ctrl_COM.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Ctrl_COM.FlatAppearance.BorderSize = 0;
            this.btn_Ctrl_COM.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.btn_Ctrl_COM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ctrl_COM.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ctrl_COM.ForeColor = System.Drawing.Color.White;
            this.btn_Ctrl_COM.Location = new System.Drawing.Point(870, 80);
            this.btn_Ctrl_COM.Name = "btn_Ctrl_COM";
            this.btn_Ctrl_COM.Size = new System.Drawing.Size(36, 23);
            this.btn_Ctrl_COM.TabIndex = 2;
            this.btn_Ctrl_COM.Text = "Ctrl";
            this.btn_Ctrl_COM.UseVisualStyleBackColor = false;
            // 
            // btn_Curva_Bezier
            // 
            this.btn_Curva_Bezier.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Curva_Bezier.FlatAppearance.BorderSize = 0;
            this.btn_Curva_Bezier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(122)))));
            this.btn_Curva_Bezier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Curva_Bezier.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Curva_Bezier.ForeColor = System.Drawing.Color.White;
            this.btn_Curva_Bezier.Location = new System.Drawing.Point(458, 42);
            this.btn_Curva_Bezier.Name = "btn_Curva_Bezier";
            this.btn_Curva_Bezier.Size = new System.Drawing.Size(82, 26);
            this.btn_Curva_Bezier.TabIndex = 2;
            this.btn_Curva_Bezier.Text = "Curva Bezier";
            this.btn_Curva_Bezier.UseVisualStyleBackColor = false;
            this.btn_Curva_Bezier.Click += new System.EventHandler(this.btn_Draw_Line_Click);
            // 
            // btn_Curva
            // 
            this.btn_Curva.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Curva.FlatAppearance.BorderSize = 0;
            this.btn_Curva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(122)))));
            this.btn_Curva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Curva.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Curva.ForeColor = System.Drawing.Color.White;
            this.btn_Curva.Location = new System.Drawing.Point(423, 73);
            this.btn_Curva.Name = "btn_Curva";
            this.btn_Curva.Size = new System.Drawing.Size(42, 26);
            this.btn_Curva.TabIndex = 2;
            this.btn_Curva.Text = "Curva";
            this.btn_Curva.UseVisualStyleBackColor = false;
            this.btn_Curva.Click += new System.EventHandler(this.btn_Draw_Line_Click);
            // 
            // btn_Texto
            // 
            this.btn_Texto.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Texto.FlatAppearance.BorderSize = 0;
            this.btn_Texto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(122)))));
            this.btn_Texto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Texto.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Texto.ForeColor = System.Drawing.Color.White;
            this.btn_Texto.Location = new System.Drawing.Point(471, 73);
            this.btn_Texto.Name = "btn_Texto";
            this.btn_Texto.Size = new System.Drawing.Size(40, 26);
            this.btn_Texto.TabIndex = 2;
            this.btn_Texto.Text = "Texto";
            this.btn_Texto.UseVisualStyleBackColor = false;
            this.btn_Texto.Click += new System.EventHandler(this.btn_Draw_Line_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(920, 443);
            this.Controls.Add(this.btn_Draw_Lineas);
            this.Controls.Add(this.lb_Info_Pxy);
            this.Controls.Add(this.cboxCOM);
            this.Controls.Add(this.btn_Texto);
            this.Controls.Add(this.btn_Curva);
            this.Controls.Add(this.btn_Curva_Bezier);
            this.Controls.Add(this.btn_Draw_Line);
            this.Controls.Add(this.btn_HDCOM);
            this.Controls.Add(this.btn_Draw_Elip);
            this.Controls.Add(this.btn_Ctrl_COM);
            this.Controls.Add(this.btn_Prueba_COM);
            this.Controls.Add(this.btn_Draw_Arc);
            this.Controls.Add(this.btn_Draw_Poligon);
            this.Controls.Add(this.btnINSERTimg);
            this.Controls.Add(this.btn_Draw_Rect);
            this.Controls.Add(this.btn_EXPORTAR);
            this.Controls.Add(this.btn_GUARDAR);
            this.Controls.Add(this.btn_VISTA_PREVIA);
            this.Controls.Add(this.btn_ABRIR);
            this.Controls.Add(this.btnAREALIMITE);
            this.Controls.Add(this.btnIMITAR);
            this.Controls.Add(this.btnIMPRIMIR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLONA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mutume 2D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLONA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIMPRIMIR;
        private System.Windows.Forms.Button btn_Draw_Rect;
        private System.Windows.Forms.Button btn_Draw_Lineas;
        private System.Windows.Forms.Button btn_Draw_Poligon;
        private System.Windows.Forms.Button btn_Draw_Elip;
        private System.Windows.Forms.Button btn_Draw_Arc;
        private System.Windows.Forms.Button btn_ABRIR;
        private System.Windows.Forms.Button btn_GUARDAR;
        private System.Windows.Forms.Button btn_Draw_Line;
        private System.Windows.Forms.Button btnINSERTimg;
        private System.Windows.Forms.Button btn_EXPORTAR;
        private System.Windows.Forms.Button btnIMITAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxCOM;
        private System.Windows.Forms.Label lb_Info_Pxy;
        private System.Windows.Forms.Button btnAREALIMITE;
        private System.Windows.Forms.Button btn_HDCOM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_VISTA_PREVIA;
        private System.Windows.Forms.Button btn_Prueba_COM;
        private System.Windows.Forms.Button btn_Ctrl_COM;
        private System.Windows.Forms.Button btn_Curva_Bezier;
        private System.Windows.Forms.Button btn_Curva;
        private System.Windows.Forms.Button btn_Texto;
    }
}

