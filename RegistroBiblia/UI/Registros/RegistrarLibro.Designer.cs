namespace RegistroBiblia.UI.Registros
{
    partial class RegistrarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarLibro));
            this.label1 = new System.Windows.Forms.Label();
            this.TipoId_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.LibroId_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Siglas_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Descripcion_textBox = new System.Windows.Forms.TextBox();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.GeneralerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TipoId_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibroId_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo ID:";
            // 
            // TipoId_numericUpDown
            // 
            this.TipoId_numericUpDown.Location = new System.Drawing.Point(105, 21);
            this.TipoId_numericUpDown.Name = "TipoId_numericUpDown";
            this.TipoId_numericUpDown.Size = new System.Drawing.Size(79, 20);
            this.TipoId_numericUpDown.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Libro ID:";
            // 
            // LibroId_numericUpDown
            // 
            this.LibroId_numericUpDown.Location = new System.Drawing.Point(105, 65);
            this.LibroId_numericUpDown.Name = "LibroId_numericUpDown";
            this.LibroId_numericUpDown.Size = new System.Drawing.Size(79, 20);
            this.LibroId_numericUpDown.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Siglas:";
            // 
            // Siglas_textBox
            // 
            this.Siglas_textBox.Location = new System.Drawing.Point(105, 106);
            this.Siglas_textBox.Name = "Siglas_textBox";
            this.Siglas_textBox.Size = new System.Drawing.Size(173, 20);
            this.Siglas_textBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descripcion:";
            // 
            // Descripcion_textBox
            // 
            this.Descripcion_textBox.Location = new System.Drawing.Point(105, 158);
            this.Descripcion_textBox.Multiline = true;
            this.Descripcion_textBox.Name = "Descripcion_textBox";
            this.Descripcion_textBox.Size = new System.Drawing.Size(173, 77);
            this.Descripcion_textBox.TabIndex = 3;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Image = global::RegistroBiblia.Properties.Resources.icons8_Delete_Document_32;
            this.Btn_Eliminar.Location = new System.Drawing.Point(390, 280);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(106, 54);
            this.Btn_Eliminar.TabIndex = 7;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Image = global::RegistroBiblia.Properties.Resources.icons8_Save_Close_32;
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Guardar.Location = new System.Drawing.Point(215, 280);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(106, 54);
            this.Btn_Guardar.TabIndex = 4;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Image = global::RegistroBiblia.Properties.Resources.icons8_New_Copy_32;
            this.Btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Nuevo.Location = new System.Drawing.Point(51, 280);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(106, 54);
            this.Btn_Nuevo.TabIndex = 5;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Image = global::RegistroBiblia.Properties.Resources.icons8_Search_16;
            this.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar.Location = new System.Drawing.Point(201, 19);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(64, 20);
            this.Btn_Buscar.TabIndex = 6;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // GeneralerrorProvider
            // 
            this.GeneralerrorProvider.ContainerControl = this;
            // 
            // RegistrarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Descripcion_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Siglas_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LibroId_numericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.TipoId_numericUpDown);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Libro";
            this.Load += new System.EventHandler(this.RegistroLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TipoId_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibroId_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TipoId_numericUpDown;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown LibroId_numericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Siglas_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Descripcion_textBox;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.ErrorProvider GeneralerrorProvider;
    }
}