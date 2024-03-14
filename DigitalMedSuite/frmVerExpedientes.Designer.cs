namespace DigitalMedSuite
{
    partial class frmVerExpedientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerExpedientes));
            this.cob_Archivos = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btn_Atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // cob_Archivos
            // 
            this.cob_Archivos.FormattingEnabled = true;
            this.cob_Archivos.Location = new System.Drawing.Point(21, 40);
            this.cob_Archivos.Name = "cob_Archivos";
            this.cob_Archivos.Size = new System.Drawing.Size(754, 24);
            this.cob_Archivos.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "*.txt*";
            this.fileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.FileName;
            this.fileSystemWatcher1.Path = "C:\\Users\\roker\\source\\repos\\DigitalMedSuite_Diseños\\DigitalMedSuite\\bin\\Debug\\Exp" +
    "edientes";
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(423, 205);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(75, 23);
            this.btn_Atras.TabIndex = 1;
            this.btn_Atras.Text = "Atras";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // frmVerExpedientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.cob_Archivos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerExpedientes";
            this.Text = "frmVerExpedientes";
            this.Load += new System.EventHandler(this.frmVerExpedientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cob_Archivos;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btn_Atras;
    }
}