namespace MoveTo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnSelectDestino = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMover = new System.Windows.Forms.Button();
            this.btnSelectOrigen = new System.Windows.Forms.Button();
            this.fBDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acuerdoDeLicenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToContextMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearSoftLinkEnElOrigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(65, 35);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(539, 20);
            this.txtOrigen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Origen:";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(66, 90);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(538, 20);
            this.txtDestino.TabIndex = 2;
            this.txtDestino.Leave += new System.EventHandler(this.txtDestino_Leave);
            // 
            // btnSelectDestino
            // 
            this.btnSelectDestino.Location = new System.Drawing.Point(610, 87);
            this.btnSelectDestino.Name = "btnSelectDestino";
            this.btnSelectDestino.Size = new System.Drawing.Size(26, 23);
            this.btnSelectDestino.TabIndex = 3;
            this.btnSelectDestino.Text = "...";
            this.btnSelectDestino.UseVisualStyleBackColor = true;
            this.btnSelectDestino.Click += new System.EventHandler(this.btnSelectDestino_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destino:";
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(245, 141);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(165, 28);
            this.btnMover.TabIndex = 5;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnSelectOrigen
            // 
            this.btnSelectOrigen.Location = new System.Drawing.Point(610, 32);
            this.btnSelectOrigen.Name = "btnSelectOrigen";
            this.btnSelectOrigen.Size = new System.Drawing.Size(26, 23);
            this.btnSelectOrigen.TabIndex = 7;
            this.btnSelectOrigen.Text = "...";
            this.btnSelectOrigen.UseVisualStyleBackColor = true;
            this.btnSelectOrigen.Click += new System.EventHandler(this.btnSelectOrigen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.archivoToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 9;
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAyudaToolStripMenuItem,
            this.toolStripSeparator1,
            this.acercaDeToolStripMenuItem,
            this.acuerdoDeLicenciaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // verAyudaToolStripMenuItem
            // 
            this.verAyudaToolStripMenuItem.Image = global::MoveTo.Properties.Resources.icons8_signo_de_interrogación_48;
            this.verAyudaToolStripMenuItem.Name = "verAyudaToolStripMenuItem";
            this.verAyudaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.verAyudaToolStripMenuItem.Text = "Ver la Ayuda";
            this.verAyudaToolStripMenuItem.Click += new System.EventHandler(this.verAyudaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Image = global::MoveTo.Properties.Resources.icons8_acerca_de_48;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // acuerdoDeLicenciaToolStripMenuItem
            // 
            this.acuerdoDeLicenciaToolStripMenuItem.Name = "acuerdoDeLicenciaToolStripMenuItem";
            this.acuerdoDeLicenciaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.acuerdoDeLicenciaToolStripMenuItem.Text = "Acuerdo de licencia";
            this.acuerdoDeLicenciaToolStripMenuItem.Click += new System.EventHandler(this.acuerdoDeLicenciaToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::MoveTo.Properties.Resources.icons8_salida_48;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToContextMenuToolStripMenuItem,
            this.addFolderToolStripMenuItem,
            this.crearSoftLinkEnElOrigenToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // addToContextMenuToolStripMenuItem
            // 
            this.addToContextMenuToolStripMenuItem.Checked = true;
            this.addToContextMenuToolStripMenuItem.CheckOnClick = true;
            this.addToContextMenuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addToContextMenuToolStripMenuItem.Name = "addToContextMenuToolStripMenuItem";
            this.addToContextMenuToolStripMenuItem.Size = new System.Drawing.Size(321, 22);
            this.addToContextMenuToolStripMenuItem.Text = "Añadir opción \"Move To...\" al menú contextual";
            this.addToContextMenuToolStripMenuItem.Click += new System.EventHandler(this.addToContextMenuToolStripMenuItem_Click);
            // 
            // addFolderToolStripMenuItem
            // 
            this.addFolderToolStripMenuItem.Checked = true;
            this.addFolderToolStripMenuItem.CheckOnClick = true;
            this.addFolderToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(321, 22);
            this.addFolderToolStripMenuItem.Text = "Añadir nombre de carpeta en destino";
            this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
            // 
            // crearSoftLinkEnElOrigenToolStripMenuItem
            // 
            this.crearSoftLinkEnElOrigenToolStripMenuItem.Checked = true;
            this.crearSoftLinkEnElOrigenToolStripMenuItem.CheckOnClick = true;
            this.crearSoftLinkEnElOrigenToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.crearSoftLinkEnElOrigenToolStripMenuItem.Name = "crearSoftLinkEnElOrigenToolStripMenuItem";
            this.crearSoftLinkEnElOrigenToolStripMenuItem.Size = new System.Drawing.Size(321, 22);
            this.crearSoftLinkEnElOrigenToolStripMenuItem.Text = "Crear SoftLink en el origen";
            this.crearSoftLinkEnElOrigenToolStripMenuItem.Click += new System.EventHandler(this.crearSoftLinkEnElOrigenToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 181);
            this.Controls.Add(this.btnSelectOrigen);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectDestino);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Move To...";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnSelectDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnSelectOrigen;
        private System.Windows.Forms.FolderBrowserDialog fBDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToContextMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearSoftLinkEnElOrigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acuerdoDeLicenciaToolStripMenuItem;
    }
}

