namespace expertSystem
{
    partial class ExpertSystem
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tecno = new System.Windows.Forms.Label();
            this.tecnm = new System.Windows.Forms.PictureBox();
            this.itz = new System.Windows.Forms.PictureBox();
            this.About = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tecnm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itz)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(139, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "sistema experto para la \r\nidentificación de hábitos de estudio ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tecno
            // 
            this.tecno.AutoSize = true;
            this.tecno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tecno.Location = new System.Drawing.Point(88, 186);
            this.tecno.Name = "tecno";
            this.tecno.Size = new System.Drawing.Size(585, 31);
            this.tecno.TabIndex = 1;
            this.tecno.Text = "INSTITUTO TECNOLOGICO DE ZACATEPEC";
            this.tecno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tecnm
            // 
            this.tecnm.Image = global::expertSystem.Properties.Resources.tecnm;
            this.tecnm.Location = new System.Drawing.Point(58, 56);
            this.tecnm.Name = "tecnm";
            this.tecnm.Size = new System.Drawing.Size(100, 57);
            this.tecnm.TabIndex = 2;
            this.tecnm.TabStop = false;
            // 
            // itz
            // 
            this.itz.Image = global::expertSystem.Properties.Resources.LOGO_DEL_ITZACATEPEC;
            this.itz.Location = new System.Drawing.Point(636, 30);
            this.itz.Name = "itz";
            this.itz.Size = new System.Drawing.Size(80, 83);
            this.itz.TabIndex = 3;
            this.itz.TabStop = false;
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.About.Location = new System.Drawing.Point(145, 393);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(126, 52);
            this.About.TabIndex = 4;
            this.About.Text = "Acerca de";
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            this.About.MouseClick += new System.Windows.Forms.MouseEventHandler(this.About_MouseClick);
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Enter.Location = new System.Drawing.Point(508, 393);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(126, 52);
            this.Enter.TabIndex = 5;
            this.Enter.Text = "Entrar";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 26);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoresToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.autoresToolStripMenuItem.Text = "Autores";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem1,
            this.autoresToolStripMenuItem1,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.acercaDeToolStripMenuItem1.Text = "Acerca De";
            this.acercaDeToolStripMenuItem1.Click += new System.EventHandler(this.acercaDeToolStripMenuItem1_Click);
            // 
            // autoresToolStripMenuItem1
            // 
            this.autoresToolStripMenuItem1.Name = "autoresToolStripMenuItem1";
            this.autoresToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.autoresToolStripMenuItem1.Text = "Autores";
            this.autoresToolStripMenuItem1.Click += new System.EventHandler(this.autoresToolStripMenuItem1_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.Location = new System.Drawing.Point(329, 393);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 52);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ExpertSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::expertSystem.Properties.Resources.LR5ab1;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.About);
            this.Controls.Add(this.itz);
            this.Controls.Add(this.tecnm);
            this.Controls.Add(this.tecno);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ExpertSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sistema experto ";
            this.Load += new System.EventHandler(this.ExpertSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tecnm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itz)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tecno;
        private System.Windows.Forms.PictureBox tecnm;
        private System.Windows.Forms.PictureBox itz;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
    }
}

