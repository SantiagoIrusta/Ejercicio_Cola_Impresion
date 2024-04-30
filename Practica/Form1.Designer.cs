namespace Practica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.cboPrioridad = new System.Windows.Forms.ComboBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnTomar = new System.Windows.Forms.Button();
            this.lstAlta = new System.Windows.Forms.ListBox();
            this.lstMedia = new System.Windows.Forms.ListBox();
            this.lstBaja = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prioridad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Baja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Media";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alta";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(22, 49);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(100, 23);
            this.txtArchivo.TabIndex = 5;
            // 
            // cboPrioridad
            // 
            this.cboPrioridad.FormattingEnabled = true;
            this.cboPrioridad.Location = new System.Drawing.Point(22, 123);
            this.cboPrioridad.Name = "cboPrioridad";
            this.cboPrioridad.Size = new System.Drawing.Size(121, 23);
            this.cboPrioridad.TabIndex = 6;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(207, 123);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnTomar
            // 
            this.btnTomar.Location = new System.Drawing.Point(413, 235);
            this.btnTomar.Name = "btnTomar";
            this.btnTomar.Size = new System.Drawing.Size(75, 23);
            this.btnTomar.TabIndex = 8;
            this.btnTomar.Text = "Tomar";
            this.btnTomar.UseVisualStyleBackColor = true;
            this.btnTomar.Click += new System.EventHandler(this.btnTomar_Click);
            // 
            // lstAlta
            // 
            this.lstAlta.FormattingEnabled = true;
            this.lstAlta.ItemHeight = 15;
            this.lstAlta.Location = new System.Drawing.Point(22, 205);
            this.lstAlta.Name = "lstAlta";
            this.lstAlta.Size = new System.Drawing.Size(120, 94);
            this.lstAlta.TabIndex = 9;
            // 
            // lstMedia
            // 
            this.lstMedia.FormattingEnabled = true;
            this.lstMedia.ItemHeight = 15;
            this.lstMedia.Location = new System.Drawing.Point(155, 205);
            this.lstMedia.Name = "lstMedia";
            this.lstMedia.Size = new System.Drawing.Size(120, 94);
            this.lstMedia.TabIndex = 10;
            // 
            // lstBaja
            // 
            this.lstBaja.FormattingEnabled = true;
            this.lstBaja.ItemHeight = 15;
            this.lstBaja.Location = new System.Drawing.Point(287, 205);
            this.lstBaja.Name = "lstBaja";
            this.lstBaja.Size = new System.Drawing.Size(120, 94);
            this.lstBaja.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 347);
            this.Controls.Add(this.lstBaja);
            this.Controls.Add(this.lstMedia);
            this.Controls.Add(this.lstAlta);
            this.Controls.Add(this.btnTomar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.cboPrioridad);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtArchivo;
        private ComboBox cboPrioridad;
        private Button btnImprimir;
        private Button btnTomar;
        private ListBox lstAlta;
        private ListBox lstMedia;
        private ListBox lstBaja;
        private System.Windows.Forms.Timer timer1;
    }
}