namespace Guia_10_Grafos_Proc
{
    partial class NuevosControles
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
            this.gbo1 = new System.Windows.Forms.GroupBox();
            this.BtnElArc = new System.Windows.Forms.Button();
            this.BtnEliminarVer = new System.Windows.Forms.Button();
            this.CBArco = new System.Windows.Forms.ComboBox();
            this.CBVertice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbo3 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbo2 = new System.Windows.Forms.GroupBox();
            this.lstRecorrido = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAnch = new System.Windows.Forms.Button();
            this.BtnProf = new System.Windows.Forms.Button();
            this.CBNodoPartida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbo1.SuspendLayout();
            this.gbo3.SuspendLayout();
            this.gbo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbo1
            // 
            this.gbo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbo1.Controls.Add(this.BtnElArc);
            this.gbo1.Controls.Add(this.BtnEliminarVer);
            this.gbo1.Controls.Add(this.CBArco);
            this.gbo1.Controls.Add(this.CBVertice);
            this.gbo1.Controls.Add(this.label2);
            this.gbo1.Controls.Add(this.label1);
            this.gbo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo1.Location = new System.Drawing.Point(51, 32);
            this.gbo1.Name = "gbo1";
            this.gbo1.Size = new System.Drawing.Size(342, 142);
            this.gbo1.TabIndex = 0;
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
            // 
            // BtnEliminarVer
            // 
            this.BtnEliminarVer.Location = new System.Drawing.Point(234, 25);
            this.BtnEliminarVer.Name = "BtnEliminarVer";
            this.BtnEliminarVer.Size = new System.Drawing.Size(101, 30);
            this.BtnEliminarVer.TabIndex = 4;
            this.BtnEliminarVer.Text = "Eliminar";
            this.BtnEliminarVer.UseVisualStyleBackColor = true;
            // 
            // CBArco
            // 
            this.CBArco.FormattingEnabled = true;
            this.CBArco.Location = new System.Drawing.Point(75, 87);
            this.CBArco.Name = "CBArco";
            this.CBArco.Size = new System.Drawing.Size(153, 26);
            this.CBArco.TabIndex = 3;
            // 
            // CBVertice
            // 
            this.CBVertice.FormattingEnabled = true;
            this.CBVertice.Location = new System.Drawing.Point(75, 28);
            this.CBVertice.Name = "CBVertice";
            this.CBVertice.Size = new System.Drawing.Size(153, 26);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vertice";
            // 
            // gbo3
            // 
            this.gbo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbo3.Controls.Add(this.BtnBuscar);
            this.gbo3.Controls.Add(this.txtBuscar);
            this.gbo3.Controls.Add(this.label3);
            this.gbo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo3.Location = new System.Drawing.Point(426, 107);
            this.gbo3.Name = "gbo3";
            this.gbo3.Size = new System.Drawing.Size(342, 90);
            this.gbo3.TabIndex = 1;
            this.gbo3.TabStop = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(224, 26);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(101, 33);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(100, 35);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(105, 24);
            this.txtBuscar.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vertice:";
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
            this.gbo2.Location = new System.Drawing.Point(51, 199);
            this.gbo2.Name = "gbo2";
            this.gbo2.Size = new System.Drawing.Size(342, 226);
            this.gbo2.TabIndex = 3;
            this.gbo2.TabStop = false;
            this.gbo2.Text = "Recorridos";
            // 
            // lstRecorrido
            // 
            this.lstRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecorrido.FormattingEnabled = true;
            this.lstRecorrido.ItemHeight = 18;
            this.lstRecorrido.Location = new System.Drawing.Point(187, 115);
            this.lstRecorrido.Name = "lstRecorrido";
            this.lstRecorrido.Size = new System.Drawing.Size(120, 94);
            this.lstRecorrido.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nodos Visitados";
            // 
            // BtnAnch
            // 
            this.BtnAnch.Location = new System.Drawing.Point(29, 141);
            this.BtnAnch.Name = "BtnAnch";
            this.BtnAnch.Size = new System.Drawing.Size(116, 38);
            this.BtnAnch.TabIndex = 3;
            this.BtnAnch.Text = "Anchura";
            this.BtnAnch.UseVisualStyleBackColor = true;
            // 
            // BtnProf
            // 
            this.BtnProf.Location = new System.Drawing.Point(29, 84);
            this.BtnProf.Name = "BtnProf";
            this.BtnProf.Size = new System.Drawing.Size(116, 38);
            this.BtnProf.TabIndex = 2;
            this.BtnProf.Text = "Profundidad";
            this.BtnProf.UseVisualStyleBackColor = true;
            // 
            // CBNodoPartida
            // 
            this.CBNodoPartida.FormattingEnabled = true;
            this.CBNodoPartida.Location = new System.Drawing.Point(166, 38);
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
            // NuevosControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.gbo2);
            this.Controls.Add(this.gbo3);
            this.Controls.Add(this.gbo1);
            this.Name = "NuevosControles";
            this.Text = "NuevosControles";
            this.gbo1.ResumeLayout(false);
            this.gbo1.PerformLayout();
            this.gbo3.ResumeLayout(false);
            this.gbo3.PerformLayout();
            this.gbo2.ResumeLayout(false);
            this.gbo2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbo1;
        private System.Windows.Forms.Button BtnEliminarVer;
        private System.Windows.Forms.ComboBox CBArco;
        private System.Windows.Forms.ComboBox CBVertice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnElArc;
        private System.Windows.Forms.GroupBox gbo3;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbo2;
        private System.Windows.Forms.Button BtnAnch;
        private System.Windows.Forms.Button BtnProf;
        private System.Windows.Forms.ComboBox CBNodoPartida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstRecorrido;
        private System.Windows.Forms.Label label6;
    }
}