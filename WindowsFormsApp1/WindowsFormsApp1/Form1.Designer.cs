namespace WindowsFormsApp1
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
            this.cB_UMaps = new System.Windows.Forms.CheckBox();
            this.Run = new System.Windows.Forms.Button();
            this.vChaosmUM = new System.Windows.Forms.NumericUpDown();
            this.vChaosT1UM = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_mUM = new System.Windows.Forms.CheckBox();
            this.Salir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.vChaosmUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vChaosT1UM)).BeginInit();
            this.SuspendLayout();
            // 
            // cB_UMaps
            // 
            this.cB_UMaps.AutoSize = true;
            this.cB_UMaps.Location = new System.Drawing.Point(12, 79);
            this.cB_UMaps.Name = "cB_UMaps";
            this.cB_UMaps.Size = new System.Drawing.Size(94, 17);
            this.cB_UMaps.TabIndex = 0;
            this.cB_UMaps.Text = "Mapas Unicos";
            this.cB_UMaps.UseVisualStyleBackColor = true;
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(12, 235);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 1;
            this.Run.Text = "Crear Filtro";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Boton_Filtro);
            // 
            // vChaosmUM
            // 
            this.vChaosmUM.Location = new System.Drawing.Point(12, 129);
            this.vChaosmUM.Name = "vChaosmUM";
            this.vChaosmUM.Size = new System.Drawing.Size(120, 20);
            this.vChaosmUM.TabIndex = 2;
            // 
            // vChaosT1UM
            // 
            this.vChaosT1UM.Location = new System.Drawing.Point(12, 106);
            this.vChaosT1UM.Name = "vChaosT1UM";
            this.vChaosT1UM.Size = new System.Drawing.Size(120, 20);
            this.vChaosT1UM.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor minimo en Chaos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor T1 en Chaos";
            // 
            // cB_mUM
            // 
            this.cB_mUM.AutoSize = true;
            this.cB_mUM.Location = new System.Drawing.Point(12, 155);
            this.cB_mUM.Name = "cB_mUM";
            this.cB_mUM.Size = new System.Drawing.Size(232, 17);
            this.cB_mUM.TabIndex = 4;
            this.cB_mUM.Text = "Mostrar mapas por debajo del valor minimo?";
            this.cB_mUM.UseVisualStyleBackColor = true;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(179, 235);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Boton_Salir);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 270);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.cB_mUM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vChaosT1UM);
            this.Controls.Add(this.vChaosmUM);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.cB_UMaps);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vChaosmUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vChaosT1UM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cB_UMaps;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.NumericUpDown vChaosmUM;
        private System.Windows.Forms.NumericUpDown vChaosT1UM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cB_mUM;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

