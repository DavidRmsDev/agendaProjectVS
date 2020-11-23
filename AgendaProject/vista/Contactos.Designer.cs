namespace AgendaProject.vista
{
    partial class Contactos
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
            this.label4 = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_apellidos = new System.Windows.Forms.Label();
            this.label_telefono = new System.Windows.Forms.Label();
            this.label_direccion = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_apellidos = new System.Windows.Forms.TextBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.button_insertar = new System.Windows.Forms.Button();
            this.button_modificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(118, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(416, 69);
            this.label4.TabIndex = 22;
            this.label4.Text = "CONTACTOS";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.BackColor = System.Drawing.Color.Transparent;
            this.label_nombre.Location = new System.Drawing.Point(87, 138);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(62, 17);
            this.label_nombre.TabIndex = 24;
            this.label_nombre.Text = "Nombre:";
            // 
            // label_apellidos
            // 
            this.label_apellidos.AutoSize = true;
            this.label_apellidos.BackColor = System.Drawing.Color.Transparent;
            this.label_apellidos.Location = new System.Drawing.Point(80, 170);
            this.label_apellidos.Name = "label_apellidos";
            this.label_apellidos.Size = new System.Drawing.Size(69, 17);
            this.label_apellidos.TabIndex = 25;
            this.label_apellidos.Text = "Apellidos:";
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.BackColor = System.Drawing.Color.Transparent;
            this.label_telefono.Location = new System.Drawing.Point(81, 201);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(68, 17);
            this.label_telefono.TabIndex = 26;
            this.label_telefono.Text = "Teléfono:";
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.BackColor = System.Drawing.Color.Transparent;
            this.label_direccion.Location = new System.Drawing.Point(78, 234);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(71, 17);
            this.label_direccion.TabIndex = 27;
            this.label_direccion.Text = "Dirección:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.Transparent;
            this.label_email.Location = new System.Drawing.Point(103, 266);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(46, 17);
            this.label_email.TabIndex = 28;
            this.label_email.Text = "Email:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(210, 133);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(324, 22);
            this.textBox_nombre.TabIndex = 29;
            // 
            // textBox_apellidos
            // 
            this.textBox_apellidos.Location = new System.Drawing.Point(210, 165);
            this.textBox_apellidos.Name = "textBox_apellidos";
            this.textBox_apellidos.Size = new System.Drawing.Size(324, 22);
            this.textBox_apellidos.TabIndex = 30;
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Location = new System.Drawing.Point(210, 196);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(324, 22);
            this.textBox_telefono.TabIndex = 31;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(210, 261);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(324, 22);
            this.textBox_email.TabIndex = 33;
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(210, 229);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(324, 22);
            this.textBox_direccion.TabIndex = 32;
            // 
            // button_insertar
            // 
            this.button_insertar.Location = new System.Drawing.Point(247, 314);
            this.button_insertar.Name = "button_insertar";
            this.button_insertar.Size = new System.Drawing.Size(75, 23);
            this.button_insertar.TabIndex = 34;
            this.button_insertar.Text = "Insertar";
            this.button_insertar.UseVisualStyleBackColor = true;
            this.button_insertar.Click += new System.EventHandler(this.Button_insertar_Click);
            // 
            // button_modificar
            // 
            this.button_modificar.Location = new System.Drawing.Point(414, 314);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(75, 23);
            this.button_modificar.TabIndex = 35;
            this.button_modificar.Text = "Modificar";
            this.button_modificar.UseVisualStyleBackColor = true;
            this.button_modificar.Click += new System.EventHandler(this.Button_modificar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(499, 208);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(314, 105);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_id.TabIndex = 37;
            this.textBox_id.Visible = false;
            // 
            // Contactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgendaProject.Properties.Resources.fondoPapel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 586);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button_insertar);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_direccion);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.textBox_apellidos);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.label_telefono);
            this.Controls.Add(this.label_apellidos);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Contactos";
            this.Text = "Contactos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_apellidos;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_apellidos;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.Button button_insertar;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_id;
    }
}