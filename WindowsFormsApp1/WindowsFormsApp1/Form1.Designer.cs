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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar97 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar_RGB1 = new System.Windows.Forms.TrackBar();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.RGBUM3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.trackBar_RGB2 = new System.Windows.Forms.TrackBar();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.RGBUM2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.trackBar_RGB3 = new System.Windows.Forms.TrackBar();
            this.RGBUM1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.vChaosmUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vChaosT1UM)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar97)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RGB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBUM3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RGB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBUM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RGB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBUM1)).BeginInit();
            this.SuspendLayout();
            // 
            // cB_UMaps
            // 
            this.cB_UMaps.AutoSize = true;
            this.cB_UMaps.Location = new System.Drawing.Point(19, 19);
            this.cB_UMaps.Name = "cB_UMaps";
            this.cB_UMaps.Size = new System.Drawing.Size(94, 17);
            this.cB_UMaps.TabIndex = 0;
            this.cB_UMaps.Text = "Mapas Unicos";
            this.cB_UMaps.UseVisualStyleBackColor = true;
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(546, 519);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 1;
            this.Run.Text = "Crear Filtro";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Boton_Filtro);
            // 
            // vChaosmUM
            // 
            this.vChaosmUM.Location = new System.Drawing.Point(19, 69);
            this.vChaosmUM.Name = "vChaosmUM";
            this.vChaosmUM.Size = new System.Drawing.Size(120, 20);
            this.vChaosmUM.TabIndex = 2;
            // 
            // vChaosT1UM
            // 
            this.vChaosT1UM.Location = new System.Drawing.Point(19, 46);
            this.vChaosT1UM.Name = "vChaosT1UM";
            this.vChaosT1UM.Size = new System.Drawing.Size(120, 20);
            this.vChaosT1UM.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor minimo en Chaos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor T1 en Chaos";
            // 
            // cB_mUM
            // 
            this.cB_mUM.AutoSize = true;
            this.cB_mUM.Location = new System.Drawing.Point(19, 95);
            this.cB_mUM.Name = "cB_mUM";
            this.cB_mUM.Size = new System.Drawing.Size(232, 17);
            this.cB_mUM.TabIndex = 4;
            this.cB_mUM.Text = "Mostrar mapas por debajo del valor minimo?";
            this.cB_mUM.UseVisualStyleBackColor = true;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(713, 519);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 490);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cB_UMaps);
            this.tabPage1.Controls.Add(this.cB_mUM);
            this.tabPage1.Controls.Add(this.vChaosmUM);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.vChaosT1UM);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mapas Unicos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(19, 118);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(936, 340);
            this.tabControl2.TabIndex = 7;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.trackBar97);
            this.tabPage4.Controls.Add(this.trackBar4);
            this.tabPage4.Controls.Add(this.numericUpDown6);
            this.tabPage4.Controls.Add(this.trackBar1);
            this.tabPage4.Controls.Add(this.trackBar8);
            this.tabPage4.Controls.Add(this.numericUpDown3);
            this.tabPage4.Controls.Add(this.trackBar5);
            this.tabPage4.Controls.Add(this.trackBar_RGB1);
            this.tabPage4.Controls.Add(this.numericUpDown8);
            this.tabPage4.Controls.Add(this.trackBar2);
            this.tabPage4.Controls.Add(this.numericUpDown5);
            this.tabPage4.Controls.Add(this.RGBUM3);
            this.tabPage4.Controls.Add(this.numericUpDown2);
            this.tabPage4.Controls.Add(this.trackBar6);
            this.tabPage4.Controls.Add(this.trackBar_RGB2);
            this.tabPage4.Controls.Add(this.numericUpDown7);
            this.tabPage4.Controls.Add(this.trackBar3);
            this.tabPage4.Controls.Add(this.numericUpDown4);
            this.tabPage4.Controls.Add(this.RGBUM2);
            this.tabPage4.Controls.Add(this.numericUpDown1);
            this.tabPage4.Controls.Add(this.trackBar_RGB3);
            this.tabPage4.Controls.Add(this.RGBUM1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(928, 314);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Mapas T1";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "DROPSOUND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "BACKGROUND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "BORDERCOLOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "TEXTCOLOR";
            // 
            // trackBar97
            // 
            this.trackBar97.AllowDrop = true;
            this.trackBar97.Location = new System.Drawing.Point(530, 96);
            this.trackBar97.Maximum = 255;
            this.trackBar97.Name = "trackBar97";
            this.trackBar97.Size = new System.Drawing.Size(94, 45);
            this.trackBar97.TabIndex = 5;
            this.trackBar97.TickFrequency = 5;
            this.trackBar97.ValueChanged += new System.EventHandler(this.RgbUMaps);
            // 
            // trackBar4
            // 
            this.trackBar4.AllowDrop = true;
            this.trackBar4.Location = new System.Drawing.Point(357, 96);
            this.trackBar4.Maximum = 255;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(94, 45);
            this.trackBar4.TabIndex = 5;
            this.trackBar4.TickFrequency = 5;
            this.trackBar4.ValueChanged += new System.EventHandler(this.RgbUMaps);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(456, 209);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown6.TabIndex = 6;
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.RgbUMaps2);
            // 
            // trackBar1
            // 
            this.trackBar1.AllowDrop = true;
            this.trackBar1.Location = new System.Drawing.Point(188, 96);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(94, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.ValueChanged += new System.EventHandler(this.RgbUMaps);
            // 
            // trackBar8
            // 
            this.trackBar8.AllowDrop = true;
            this.trackBar8.Location = new System.Drawing.Point(529, 147);
            this.trackBar8.Maximum = 255;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Size = new System.Drawing.Size(94, 45);
            this.trackBar8.TabIndex = 5;
            this.trackBar8.TickFrequency = 5;
            this.trackBar8.ValueChanged += new System.EventHandler(this.RgbUMaps);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(287, 209);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown3.TabIndex = 6;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.RgbUMaps2);
            // 
            // trackBar5
            // 
            this.trackBar5.AllowDrop = true;
            this.trackBar5.Location = new System.Drawing.Point(356, 147);
            this.trackBar5.Maximum = 255;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(94, 45);
            this.trackBar5.TabIndex = 5;
            this.trackBar5.TickFrequency = 5;
            this.trackBar5.ValueChanged += new System.EventHandler(this.RgbUMaps);
            // 
            // trackBar_RGB1
            // 
            this.trackBar_RGB1.AllowDrop = true;
            this.trackBar_RGB1.Location = new System.Drawing.Point(22, 96);
            this.trackBar_RGB1.Maximum = 255;
            this.trackBar_RGB1.Name = "trackBar_RGB1";
            this.trackBar_RGB1.Size = new System.Drawing.Size(94, 45);
            this.trackBar_RGB1.TabIndex = 5;
            this.trackBar_RGB1.TickFrequency = 5;
            this.trackBar_RGB1.ValueChanged += new System.EventHandler(this.RgbUMaps);
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(629, 158);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown8.TabIndex = 6;
            this.numericUpDown8.ValueChanged += new System.EventHandler(this.RgbUMaps2);
            // 
            // trackBar2
            // 
            this.trackBar2.AllowDrop = true;
            this.trackBar2.Location = new System.Drawing.Point(187, 147);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(94, 45);
            this.trackBar2.TabIndex = 5;
            this.trackBar2.TickFrequency = 5;
            this.trackBar2.ValueChanged += new System.EventHandler(this.RgbUMaps);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(456, 158);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown5.TabIndex = 6;
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.RgbUMaps2);
            // 
            // RGBUM3
            // 
            this.RGBUM3.Location = new System.Drawing.Point(121, 209);
            this.RGBUM3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RGBUM3.Name = "RGBUM3";
            this.RGBUM3.Size = new System.Drawing.Size(48, 20);
            this.RGBUM3.TabIndex = 6;
            this.RGBUM3.ValueChanged += new System.EventHandler(this.RgbUMaps2);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(287, 158);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.RgbUMaps2);
            // 
            // trackBar6
            // 
            this.trackBar6.AllowDrop = true;
            this.trackBar6.Location = new System.Drawing.Point(356, 198);
            this.trackBar6.Maximum = 255;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(94, 45);
            this.trackBar6.TabIndex = 5;
            this.trackBar6.TickFrequency = 5;
            this.trackBar6.ValueChanged += new System.EventHandler(this.RgbUMaps);
            // 
            // trackBar_RGB2
            // 
            this.trackBar_RGB2.AllowDrop = true;
            this.trackBar_RGB2.Location = new System.Drawing.Point(21, 147);
            this.trackBar_RGB2.Maximum = 255;
            this.trackBar_RGB2.Name = "trackBar_RGB2";
            this.trackBar_RGB2.Size = new System.Drawing.Size(94, 45);
            this.trackBar_RGB2.TabIndex = 5;
            this.trackBar_RGB2.TickFrequency = 5;
            this.trackBar_RGB2.ValueChanged += new System.EventHandler(this.RgbUMaps);
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(630, 107);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown7.TabIndex = 6;
            this.numericUpDown7.ValueChanged += new System.EventHandler(this.RgbUMaps2);
            // 
            // trackBar3
            // 
            this.trackBar3.AllowDrop = true;
            this.trackBar3.Location = new System.Drawing.Point(187, 198);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(94, 45);
            this.trackBar3.TabIndex = 5;
            this.trackBar3.TickFrequency = 5;
            this.trackBar3.ValueChanged += new System.EventHandler(this.RgbUMaps);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(457, 107);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown4.TabIndex = 6;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.RgbUMaps2);
            // 
            // RGBUM2
            // 
            this.RGBUM2.Location = new System.Drawing.Point(121, 158);
            this.RGBUM2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RGBUM2.Name = "RGBUM2";
            this.RGBUM2.Size = new System.Drawing.Size(48, 20);
            this.RGBUM2.TabIndex = 6;
            this.RGBUM2.ValueChanged += new System.EventHandler(this.RgbUMaps2);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(288, 107);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.RgbUMaps2);
            // 
            // trackBar_RGB3
            // 
            this.trackBar_RGB3.AllowDrop = true;
            this.trackBar_RGB3.Location = new System.Drawing.Point(21, 198);
            this.trackBar_RGB3.Maximum = 255;
            this.trackBar_RGB3.Name = "trackBar_RGB3";
            this.trackBar_RGB3.Size = new System.Drawing.Size(94, 45);
            this.trackBar_RGB3.TabIndex = 5;
            this.trackBar_RGB3.TickFrequency = 5;
            this.trackBar_RGB3.ValueChanged += new System.EventHandler(this.RgbUMaps);
            // 
            // RGBUM1
            // 
            this.RGBUM1.Location = new System.Drawing.Point(122, 107);
            this.RGBUM1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RGBUM1.Name = "RGBUM1";
            this.RGBUM1.Size = new System.Drawing.Size(48, 20);
            this.RGBUM1.TabIndex = 6;
            this.RGBUM1.ValueChanged += new System.EventHandler(this.RgbUMaps2);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(928, 314);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mapas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(972, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Profecias";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 551);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Run);
            this.Name = "Form1";
            this.Text = "Filtro mapas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vChaosmUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vChaosT1UM)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar97)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RGB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBUM3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RGB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBUM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RGB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBUM1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TrackBar trackBar_RGB1;
        private System.Windows.Forms.NumericUpDown RGBUM1;
        private System.Windows.Forms.NumericUpDown RGBUM3;
        private System.Windows.Forms.NumericUpDown RGBUM2;
        private System.Windows.Forms.TrackBar trackBar_RGB3;
        private System.Windows.Forms.TrackBar trackBar_RGB2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar97;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

