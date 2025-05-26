namespace Guia_10_Grafos_Proc
{
    partial class Simulador
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
            this.Pizarra = new System.Windows.Forms.Panel();
            this.CMSCrearVertice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoVérticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbo1 = new System.Windows.Forms.GroupBox();
            this.BtnElArc = new System.Windows.Forms.Button();
            this.BtnEliminarVer = new System.Windows.Forms.Button();
            this.CBArco = new System.Windows.Forms.ComboBox();
            this.CBVertice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbo2 = new System.Windows.Forms.GroupBox();
            this.lstRecorrido = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAnch = new System.Windows.Forms.Button();
            this.BtnProf = new System.Windows.Forms.Button();
            this.CBNodoPartida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbo3 = new System.Windows.Forms.GroupBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bntRutaCorta = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CMSCrearVertice.SuspendLayout();
            this.gbo1.SuspendLayout();
            this.gbo2.SuspendLayout();
            this.gbo3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(413, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulador de Grafos";
            // 
            // Pizarra
            // 
            this.Pizarra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pizarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pizarra.Location = new System.Drawing.Point(377, 80);
            this.Pizarra.Margin = new System.Windows.Forms.Padding(4);
            this.Pizarra.Name = "Pizarra";
            this.Pizarra.Size = new System.Drawing.Size(825, 507);
            this.Pizarra.TabIndex = 1;
            this.Pizarra.Paint += new System.Windows.Forms.PaintEventHandler(this.pizarra_Paint);
            this.Pizarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pizarra_MouseDown);
            this.Pizarra.MouseLeave += new System.EventHandler(this.pizarra_MouseLeave);
            this.Pizarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pizarra_MouseMove);
            this.Pizarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pizarra_MouseUp);
            // 
            // CMSCrearVertice
            // 
            this.CMSCrearVertice.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMSCrearVertice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoVérticeToolStripMenuItem});
            this.CMSCrearVertice.Name = "CMSCrearVertice";
            this.CMSCrearVertice.Size = new System.Drawing.Size(171, 28);
            // 
            // nuevoVérticeToolStripMenuItem
            // 
            this.nuevoVérticeToolStripMenuItem.Name = "nuevoVérticeToolStripMenuItem";
            this.nuevoVérticeToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.nuevoVérticeToolStripMenuItem.Text = "Nuevo Vértice";
            this.nuevoVérticeToolStripMenuItem.Click += new System.EventHandler(this.nuevoVérticeToolStripMenuItem_Click);
            // 
            // gbo1
            // 
            this.gbo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbo1.Controls.Add(this.BtnElArc);
            this.gbo1.Controls.Add(this.BtnEliminarVer);
            this.gbo1.Controls.Add(this.CBArco);
            this.gbo1.Controls.Add(this.CBVertice);
            this.gbo1.Controls.Add(this.label2);
            this.gbo1.Controls.Add(this.label3);
            this.gbo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo1.Location = new System.Drawing.Point(28, 187);
            this.gbo1.Name = "gbo1";
            this.gbo1.Size = new System.Drawing.Size(342, 142);
            this.gbo1.TabIndex = 2;
            this.gbo1.TabStop = false;
            // 
            // BtnElArc
            // 
            this.BtnElArc.Location = new System.Drawing.Point(234, 84);
            this.BtnElArc.Name = "BtnElArc";
            this.BtnElArc.Size = new System.Drawing.Size(101, 30);
            this.BtnElArc.TabIndex = 5;
            this.BtnElArc.Text = "Eliminar";
            this.BtnElArc.UseVisualStyleBackColor = true;
            this.BtnElArc.Click += new System.EventHandler(this.BtnElArc_Click);
            // 
            // BtnEliminarVer
            // 
            this.BtnEliminarVer.Location = new System.Drawing.Point(234, 25);
            this.BtnEliminarVer.Name = "BtnEliminarVer";
            this.BtnEliminarVer.Size = new System.Drawing.Size(101, 30);
            this.BtnEliminarVer.TabIndex = 4;
            this.BtnEliminarVer.Text = "Eliminar";
            this.BtnEliminarVer.UseVisualStyleBackColor = true;
            this.BtnEliminarVer.Click += new System.EventHandler(this.BtnEliminarVer_Click);
            // 
            // CBArco
            // 
            this.CBArco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBArco.FormattingEnabled = true;
            this.CBArco.Location = new System.Drawing.Point(76, 87);
            this.CBArco.Name = "CBArco";
            this.CBArco.Size = new System.Drawing.Size(147, 26);
            this.CBArco.TabIndex = 3;
            // 
            // CBVertice
            // 
            this.CBVertice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBVertice.FormattingEnabled = true;
            this.CBVertice.Location = new System.Drawing.Point(76, 28);
            this.CBVertice.Name = "CBVertice";
            this.CBVertice.Size = new System.Drawing.Size(147, 26);
            this.CBVertice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vertice";
            // 
            // gbo2
            // 
            this.gbo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbo2.Controls.Add(this.lstRecorrido);
            this.gbo2.Controls.Add(this.label6);
            this.gbo2.Controls.Add(this.BtnAnch);
            this.gbo2.Controls.Add(this.BtnProf);
            this.gbo2.Controls.Add(this.CBNodoPartida);
            this.gbo2.Controls.Add(this.label4);
            this.gbo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo2.Location = new System.Drawing.Point(28, 343);
            this.gbo2.Name = "gbo2";
            this.gbo2.Size = new System.Drawing.Size(342, 255);
            this.gbo2.TabIndex = 4;
            this.gbo2.TabStop = false;
            this.gbo2.Text = "Recorridos";
            // 
            // lstRecorrido
            // 
            this.lstRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecorrido.FormattingEnabled = true;
            this.lstRecorrido.ItemHeight = 18;
            this.lstRecorrido.Location = new System.Drawing.Point(165, 100);
            this.lstRecorrido.Name = "lstRecorrido";
            this.lstRecorrido.Size = new System.Drawing.Size(170, 148);
            this.lstRecorrido.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nodos Visitados";
            // 
            // BtnAnch
            // 
            this.BtnAnch.Location = new System.Drawing.Point(27, 170);
            this.BtnAnch.Name = "BtnAnch";
            this.BtnAnch.Size = new System.Drawing.Size(116, 34);
            this.BtnAnch.TabIndex = 3;
            this.BtnAnch.Text = "Anchura";
            this.BtnAnch.UseVisualStyleBackColor = true;
            this.BtnAnch.Click += new System.EventHandler(this.BtnAnch_Click);
            // 
            // BtnProf
            // 
            this.BtnProf.Location = new System.Drawing.Point(27, 110);
            this.BtnProf.Name = "BtnProf";
            this.BtnProf.Size = new System.Drawing.Size(116, 38);
            this.BtnProf.TabIndex = 2;
            this.BtnProf.Text = "Profundidad";
            this.BtnProf.UseVisualStyleBackColor = true;
            this.BtnProf.Click += new System.EventHandler(this.BtnProf_Click);
            // 
            // CBNodoPartida
            // 
            this.CBNodoPartida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBNodoPartida.FormattingEnabled = true;
            this.CBNodoPartida.Location = new System.Drawing.Point(165, 33);
            this.CBNodoPartida.Name = "CBNodoPartida";
            this.CBNodoPartida.Size = new System.Drawing.Size(121, 26);
            this.CBNodoPartida.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nodo de partida";
            // 
            // gbo3
            // 
            this.gbo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbo3.Controls.Add(this.txtDestino);
            this.gbo3.Controls.Add(this.label7);
            this.gbo3.Controls.Add(this.bntRutaCorta);
            this.gbo3.Controls.Add(this.BtnBuscar);
            this.gbo3.Controls.Add(this.txtBuscar);
            this.gbo3.Controls.Add(this.label5);
            this.gbo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo3.Location = new System.Drawing.Point(12, 57);
            this.gbo3.Name = "gbo3";
            this.gbo3.Size = new System.Drawing.Size(358, 113);
            this.gbo3.TabIndex = 5;
            this.gbo3.TabStop = false;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(246, 21);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(92, 24);
            this.txtDestino.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Destino:";
            // 
            // bntRutaCorta
            // 
            this.bntRutaCorta.Location = new System.Drawing.Point(165, 67);
            this.bntRutaCorta.Name = "bntRutaCorta";
            this.bntRutaCorta.Size = new System.Drawing.Size(137, 33);
            this.bntRutaCorta.TabIndex = 10;
            this.bntRutaCorta.Text = "Ruta más corta";
            this.bntRutaCorta.UseVisualStyleBackColor = true;
            this.bntRutaCorta.Click += new System.EventHandler(this.bntRutaCorta_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(27, 67);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(101, 33);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(72, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(105, 24);
            this.txtBuscar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vertice:";
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 628);
            this.Controls.Add(this.gbo3);
            this.Controls.Add(this.gbo2);
            this.Controls.Add(this.gbo1);
            this.Controls.Add(this.Pizarra);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Simulador";
            this.Text = "Simulador de Grafos";
            this.CMSCrearVertice.ResumeLayout(false);
            this.gbo1.ResumeLayout(false);
            this.gbo1.PerformLayout();
            this.gbo2.ResumeLayout(false);
            this.gbo2.PerformLayout();
            this.gbo3.ResumeLayout(false);
            this.gbo3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pizarra;
        private System.Windows.Forms.ContextMenuStrip CMSCrearVertice;
        private System.Windows.Forms.ToolStripMenuItem nuevoVérticeToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbo1;
        private System.Windows.Forms.Button BtnElArc;
        private System.Windows.Forms.Button BtnEliminarVer;
        private System.Windows.Forms.ComboBox CBArco;
        private System.Windows.Forms.ComboBox CBVertice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbo2;
        private System.Windows.Forms.Button BtnAnch;
        private System.Windows.Forms.Button BtnProf;
        private System.Windows.Forms.ComboBox CBNodoPartida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbo3;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstRecorrido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bntRutaCorta;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label7;
    }
}

