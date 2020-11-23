namespace AgendaProject.vista
{
    partial class Notas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_insertar = new System.Windows.Forms.Button();
            this.textBox_fecha = new System.Windows.Forms.TextBox();
            this.textBox_titulo = new System.Windows.Forms.TextBox();
            this.label_nota = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.label_titulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_nota = new System.Windows.Forms.RichTextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(499, 208);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            // 
            // button_modificar
            // 
            this.button_modificar.Location = new System.Drawing.Point(414, 314);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(75, 23);
            this.button_modificar.TabIndex = 49;
            this.button_modificar.Text = "Modificar";
            this.button_modificar.UseVisualStyleBackColor = true;
            this.button_modificar.Click += new System.EventHandler(this.Button_modificar_Click);
            // 
            // button_insertar
            // 
            this.button_insertar.Location = new System.Drawing.Point(247, 314);
            this.button_insertar.Name = "button_insertar";
            this.button_insertar.Size = new System.Drawing.Size(75, 23);
            this.button_insertar.TabIndex = 48;
            this.button_insertar.Text = "Insertar";
            this.button_insertar.UseVisualStyleBackColor = true;
            this.button_insertar.Click += new System.EventHandler(this.Button_insertar_Click);
            // 
            // textBox_fecha
            // 
            this.textBox_fecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_fecha.Location = new System.Drawing.Point(210, 165);
            this.textBox_fecha.Name = "textBox_fecha";
            this.textBox_fecha.ReadOnly = true;
            this.textBox_fecha.Size = new System.Drawing.Size(324, 22);
            this.textBox_fecha.TabIndex = 44;
            // 
            // textBox_titulo
            // 
            this.textBox_titulo.Location = new System.Drawing.Point(210, 133);
            this.textBox_titulo.Name = "textBox_titulo";
            this.textBox_titulo.Size = new System.Drawing.Size(324, 22);
            this.textBox_titulo.TabIndex = 43;
            // 
            // label_nota
            // 
            this.label_nota.AutoSize = true;
            this.label_nota.BackColor = System.Drawing.Color.Transparent;
            this.label_nota.Location = new System.Drawing.Point(92, 201);
            this.label_nota.Name = "label_nota";
            this.label_nota.Size = new System.Drawing.Size(42, 17);
            this.label_nota.TabIndex = 40;
            this.label_nota.Text = "Nota:";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.BackColor = System.Drawing.Color.Transparent;
            this.label_fecha.Location = new System.Drawing.Point(83, 170);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(51, 17);
            this.label_fecha.TabIndex = 39;
            this.label_fecha.Text = "Fecha:";
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.BackColor = System.Drawing.Color.Transparent;
            this.label_titulo.Location = new System.Drawing.Point(87, 138);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(47, 17);
            this.label_titulo.TabIndex = 38;
            this.label_titulo.Text = "Título:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(193, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 69);
            this.label4.TabIndex = 37;
            this.label4.Text = "NOTAS";
            // 
            // richTextBox_nota
            // 
            this.richTextBox_nota.Location = new System.Drawing.Point(210, 201);
            this.richTextBox_nota.Name = "richTextBox_nota";
            this.richTextBox_nota.Size = new System.Drawing.Size(324, 107);
            this.richTextBox_nota.TabIndex = 51;
            this.richTextBox_nota.Text = "";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(535, 315);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_id.TabIndex = 52;
            this.textBox_id.Visible = false;
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgendaProject.Properties.Resources.fondoPapel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 586);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.richTextBox_nota);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button_insertar);
            this.Controls.Add(this.textBox_fecha);
            this.Controls.Add(this.textBox_titulo);
            this.Controls.Add(this.label_nota);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Notas";
            this.Text = "Notas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_insertar;
        private System.Windows.Forms.TextBox textBox_fecha;
        private System.Windows.Forms.TextBox textBox_titulo;
        private System.Windows.Forms.Label label_nota;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox_nota;
        private System.Windows.Forms.TextBox textBox_id;
    }
}