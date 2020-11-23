namespace AgendaProject.vista
{
    partial class Recordatorios
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
            this.richTextBox_descripcion = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_insertar = new System.Windows.Forms.Button();
            this.textBox_titulo = new System.Windows.Forms.TextBox();
            this.label_descripcion = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.label_titulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_hora = new System.Windows.Forms.Label();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_hora = new System.Windows.Forms.DateTimePicker();
            this.textBox_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_descripcion
            // 
            this.richTextBox_descripcion.Location = new System.Drawing.Point(210, 234);
            this.richTextBox_descripcion.Name = "richTextBox_descripcion";
            this.richTextBox_descripcion.Size = new System.Drawing.Size(324, 107);
            this.richTextBox_descripcion.TabIndex = 61;
            this.richTextBox_descripcion.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 388);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(499, 186);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            // 
            // button_modificar
            // 
            this.button_modificar.Location = new System.Drawing.Point(414, 347);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(75, 23);
            this.button_modificar.TabIndex = 59;
            this.button_modificar.Text = "Modificar";
            this.button_modificar.UseVisualStyleBackColor = true;
            this.button_modificar.Click += new System.EventHandler(this.Button_modificar_Click);
            // 
            // button_insertar
            // 
            this.button_insertar.Location = new System.Drawing.Point(247, 347);
            this.button_insertar.Name = "button_insertar";
            this.button_insertar.Size = new System.Drawing.Size(75, 23);
            this.button_insertar.TabIndex = 58;
            this.button_insertar.Text = "Insertar";
            this.button_insertar.UseVisualStyleBackColor = true;
            this.button_insertar.Click += new System.EventHandler(this.Button_insertar_Click);
            // 
            // textBox_titulo
            // 
            this.textBox_titulo.Location = new System.Drawing.Point(210, 133);
            this.textBox_titulo.Name = "textBox_titulo";
            this.textBox_titulo.Size = new System.Drawing.Size(324, 22);
            this.textBox_titulo.TabIndex = 56;
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.label_descripcion.Location = new System.Drawing.Point(48, 234);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(86, 17);
            this.label_descripcion.TabIndex = 55;
            this.label_descripcion.Text = "Descripción:";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.BackColor = System.Drawing.Color.Transparent;
            this.label_fecha.Location = new System.Drawing.Point(83, 168);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(51, 17);
            this.label_fecha.TabIndex = 54;
            this.label_fecha.Text = "Fecha:";
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.BackColor = System.Drawing.Color.Transparent;
            this.label_titulo.Location = new System.Drawing.Point(87, 138);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(47, 17);
            this.label_titulo.TabIndex = 53;
            this.label_titulo.Text = "Título:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(37, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(573, 69);
            this.label4.TabIndex = 52;
            this.label4.Text = "RECORDATORIOS";
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.BackColor = System.Drawing.Color.Transparent;
            this.label_hora.Location = new System.Drawing.Point(91, 203);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(43, 17);
            this.label_hora.TabIndex = 62;
            this.label_hora.Text = "Hora:";
            // 
            // dateTimePicker_fecha
            // 
            this.dateTimePicker_fecha.Location = new System.Drawing.Point(210, 165);
            this.dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            this.dateTimePicker_fecha.Size = new System.Drawing.Size(324, 22);
            this.dateTimePicker_fecha.TabIndex = 64;
            // 
            // dateTimePicker_hora
            // 
            this.dateTimePicker_hora.CustomFormat = "HH:mm";
            this.dateTimePicker_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_hora.Location = new System.Drawing.Point(210, 198);
            this.dateTimePicker_hora.Name = "dateTimePicker_hora";
            this.dateTimePicker_hora.ShowUpDown = true;
            this.dateTimePicker_hora.Size = new System.Drawing.Size(324, 22);
            this.dateTimePicker_hora.TabIndex = 65;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(510, 347);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_id.TabIndex = 66;
            this.textBox_id.Visible = false;
            // 
            // Recordatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgendaProject.Properties.Resources.fondoPapel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 586);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.dateTimePicker_hora);
            this.Controls.Add(this.dateTimePicker_fecha);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.richTextBox_descripcion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button_insertar);
            this.Controls.Add(this.textBox_titulo);
            this.Controls.Add(this.label_descripcion);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Recordatorios";
            this.Text = "Recordatorios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_descripcion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_insertar;
        private System.Windows.Forms.TextBox textBox_titulo;
        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_hora;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker_hora;
        private System.Windows.Forms.TextBox textBox_id;
    }
}