using SimuladorMemoriaCache.Utilidades;

namespace SimuladorMemoriaCache
{
    partial class frmPrincipal
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
            label1 = new Label();
            udTamanhoMemoriaCache = new MutiplicadorNumericUpDown();
            groupBox1 = new GroupBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)udTamanhoMemoriaCache).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 41);
            label1.Name = "label1";
            label1.Size = new Size(302, 25);
            label1.TabIndex = 1;
            label1.Text = "Tamanho desejado da memória ram:";
            // 
            // udTamanhoMemoriaCache
            // 
            udTamanhoMemoriaCache.Location = new Point(365, 41);
            udTamanhoMemoriaCache.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            udTamanhoMemoriaCache.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            udTamanhoMemoriaCache.Name = "udTamanhoMemoriaCache";
            udTamanhoMemoriaCache.ReadOnly = true;
            udTamanhoMemoriaCache.Size = new Size(163, 31);
            udTamanhoMemoriaCache.TabIndex = 2;
            udTamanhoMemoriaCache.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(udTamanhoMemoriaCache);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(546, 511);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configurações";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 114);
            label2.Name = "label2";
            label2.Size = new Size(302, 25);
            label2.TabIndex = 3;
            label2.Text = "Tamanho desejado da memória ram:";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1580, 791);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.Control;
            Name = "frmPrincipal";
            Text = "Simulador Memoria Cache";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)udTamanhoMemoriaCache).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private MutiplicadorNumericUpDown udTamanhoMemoriaCache;
        private GroupBox groupBox1;
        private Label label2;
    }
}
