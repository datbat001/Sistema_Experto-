namespace expertSystem.Forms
{
    partial class habitosCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(habitosCRUD));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.txtboxHabito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.habitos_EstudioDataSet = new expertSystem.Habitos_EstudioDataSet();
            this.objetosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.objetosTableAdapter = new expertSystem.Habitos_EstudioDataSetTableAdapters.objetosTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hábitosDeEstudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarHabitosDeEstudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verHabitosDeEstudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarHabitosDeEstudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caracteristicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCaracteristicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCaracteristicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarCaracteristicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadroMofologicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitos_EstudioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetosBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtbox2);
            this.groupBox1.Controls.Add(this.txtboxHabito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(84, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(392, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 224);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(455, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cargar Imagen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(130, 88);
            this.txtbox2.Multiline = true;
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(221, 224);
            this.txtbox2.TabIndex = 3;
            // 
            // txtboxHabito
            // 
            this.txtboxHabito.Location = new System.Drawing.Point(130, 48);
            this.txtboxHabito.Name = "txtboxHabito";
            this.txtboxHabito.Size = new System.Drawing.Size(100, 20);
            this.txtboxHabito.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hábito de Estudio:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(222, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(501, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(363, 479);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // habitos_EstudioDataSet
            // 
            this.habitos_EstudioDataSet.DataSetName = "Habitos_EstudioDataSet";
            this.habitos_EstudioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // objetosBindingSource
            // 
            this.objetosBindingSource.DataMember = "objetos";
            this.objetosBindingSource.DataSource = this.habitos_EstudioDataSet;
            // 
            // objetosTableAdapter
            // 
            this.objetosTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hábitosDeEstudioToolStripMenuItem,
            this.caracteristicasToolStripMenuItem,
            this.cuadroMofologicoToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hábitosDeEstudioToolStripMenuItem
            // 
            this.hábitosDeEstudioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarHabitosDeEstudioToolStripMenuItem,
            this.verHabitosDeEstudioToolStripMenuItem,
            this.borrarHabitosDeEstudioToolStripMenuItem});
            this.hábitosDeEstudioToolStripMenuItem.Name = "hábitosDeEstudioToolStripMenuItem";
            this.hábitosDeEstudioToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.hábitosDeEstudioToolStripMenuItem.Text = "Hábitos de Estudio";
            // 
            // agregarHabitosDeEstudioToolStripMenuItem
            // 
            this.agregarHabitosDeEstudioToolStripMenuItem.Name = "agregarHabitosDeEstudioToolStripMenuItem";
            this.agregarHabitosDeEstudioToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.agregarHabitosDeEstudioToolStripMenuItem.Text = "Agregar Habitos de Estudio";
            // 
            // verHabitosDeEstudioToolStripMenuItem
            // 
            this.verHabitosDeEstudioToolStripMenuItem.Name = "verHabitosDeEstudioToolStripMenuItem";
            this.verHabitosDeEstudioToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.verHabitosDeEstudioToolStripMenuItem.Text = "Ver Habitos de Estudio";
            // 
            // borrarHabitosDeEstudioToolStripMenuItem
            // 
            this.borrarHabitosDeEstudioToolStripMenuItem.Name = "borrarHabitosDeEstudioToolStripMenuItem";
            this.borrarHabitosDeEstudioToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.borrarHabitosDeEstudioToolStripMenuItem.Text = "Borrar Habitos de Estudio";
            // 
            // caracteristicasToolStripMenuItem
            // 
            this.caracteristicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCaracteristicasToolStripMenuItem,
            this.verCaracteristicasToolStripMenuItem,
            this.borrarCaracteristicasToolStripMenuItem});
            this.caracteristicasToolStripMenuItem.Name = "caracteristicasToolStripMenuItem";
            this.caracteristicasToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.caracteristicasToolStripMenuItem.Text = "Caracteristicas";
            // 
            // agregarCaracteristicasToolStripMenuItem
            // 
            this.agregarCaracteristicasToolStripMenuItem.Name = "agregarCaracteristicasToolStripMenuItem";
            this.agregarCaracteristicasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.agregarCaracteristicasToolStripMenuItem.Text = "Agregar Caracteristicas";
            // 
            // verCaracteristicasToolStripMenuItem
            // 
            this.verCaracteristicasToolStripMenuItem.Name = "verCaracteristicasToolStripMenuItem";
            this.verCaracteristicasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.verCaracteristicasToolStripMenuItem.Text = "Ver Caracteristicas";
            // 
            // borrarCaracteristicasToolStripMenuItem
            // 
            this.borrarCaracteristicasToolStripMenuItem.Name = "borrarCaracteristicasToolStripMenuItem";
            this.borrarCaracteristicasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.borrarCaracteristicasToolStripMenuItem.Text = "Borrar Caracteristicas";
            // 
            // cuadroMofologicoToolStripMenuItem
            // 
            this.cuadroMofologicoToolStripMenuItem.Name = "cuadroMofologicoToolStripMenuItem";
            this.cuadroMofologicoToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.cuadroMofologicoToolStripMenuItem.Text = "Cuadro Mofologico";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // habitosCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::expertSystem.Properties.Resources.LR5ab1;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "habitosCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "habitosCRUD";
            this.Load += new System.EventHandler(this.habitosCRUD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitos_EstudioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetosBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.TextBox txtboxHabito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Habitos_EstudioDataSet habitos_EstudioDataSet;
        private System.Windows.Forms.BindingSource objetosBindingSource;
        private Habitos_EstudioDataSetTableAdapters.objetosTableAdapter objetosTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hábitosDeEstudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caracteristicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadroMofologicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCaracteristicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCaracteristicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarCaracteristicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarHabitosDeEstudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verHabitosDeEstudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarHabitosDeEstudioToolStripMenuItem;
    }
}