namespace GSO
{
    partial class proveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewE = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.telProveedor = new MetroFramework.Controls.MetroTextBox();
            this.direProveedor = new MetroFramework.Controls.MetroTextBox();
            this.nomProveedor = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mailProveedor = new MetroFramework.Controls.MetroTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewE)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewE
            // 
            this.dataGridViewE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridViewE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewE.ColumnHeadersHeight = 30;
            this.dataGridViewE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewE.EnableHeadersVisualStyles = false;
            this.dataGridViewE.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewE.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewE.Name = "dataGridViewE";
            this.dataGridViewE.ReadOnly = true;
            this.dataGridViewE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewE.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewE.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewE.Size = new System.Drawing.Size(512, 368);
            this.dataGridViewE.TabIndex = 16;
            this.dataGridViewE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewE_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button3.Location = new System.Drawing.Point(167, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 43);
            this.button3.TabIndex = 15;
            this.button3.Text = "Baja";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(13, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 43);
            this.button2.TabIndex = 14;
            this.button2.Text = "Modificacion";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // telProveedor
            // 
            // 
            // 
            // 
            this.telProveedor.CustomButton.Image = null;
            this.telProveedor.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.telProveedor.CustomButton.Name = "";
            this.telProveedor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.telProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.telProveedor.CustomButton.TabIndex = 1;
            this.telProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.telProveedor.CustomButton.UseSelectable = true;
            this.telProveedor.CustomButton.Visible = false;
            this.telProveedor.Lines = new string[] {
        "Telefono"};
            this.telProveedor.Location = new System.Drawing.Point(553, 121);
            this.telProveedor.MaxLength = 32767;
            this.telProveedor.Name = "telProveedor";
            this.telProveedor.PasswordChar = '\0';
            this.telProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.telProveedor.SelectedText = "";
            this.telProveedor.SelectionLength = 0;
            this.telProveedor.SelectionStart = 0;
            this.telProveedor.ShortcutsEnabled = true;
            this.telProveedor.Size = new System.Drawing.Size(200, 23);
            this.telProveedor.TabIndex = 20;
            this.telProveedor.Text = "Telefono";
            this.telProveedor.UseSelectable = true;
            this.telProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.telProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.telProveedor.Enter += new System.EventHandler(this.telProveedor_Enter);
            this.telProveedor.Leave += new System.EventHandler(this.telProveedor_Leave);
            // 
            // direProveedor
            // 
            // 
            // 
            // 
            this.direProveedor.CustomButton.Image = null;
            this.direProveedor.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.direProveedor.CustomButton.Name = "";
            this.direProveedor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.direProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.direProveedor.CustomButton.TabIndex = 1;
            this.direProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.direProveedor.CustomButton.UseSelectable = true;
            this.direProveedor.CustomButton.Visible = false;
            this.direProveedor.Lines = new string[] {
        "Direccion"};
            this.direProveedor.Location = new System.Drawing.Point(553, 71);
            this.direProveedor.MaxLength = 32767;
            this.direProveedor.Name = "direProveedor";
            this.direProveedor.PasswordChar = '\0';
            this.direProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.direProveedor.SelectedText = "";
            this.direProveedor.SelectionLength = 0;
            this.direProveedor.SelectionStart = 0;
            this.direProveedor.ShortcutsEnabled = true;
            this.direProveedor.Size = new System.Drawing.Size(200, 23);
            this.direProveedor.TabIndex = 19;
            this.direProveedor.Text = "Direccion";
            this.direProveedor.UseSelectable = true;
            this.direProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.direProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.direProveedor.Enter += new System.EventHandler(this.direProveedor_Enter);
            this.direProveedor.Leave += new System.EventHandler(this.direProveedor_Leave);
            // 
            // nomProveedor
            // 
            // 
            // 
            // 
            this.nomProveedor.CustomButton.Image = null;
            this.nomProveedor.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.nomProveedor.CustomButton.Name = "";
            this.nomProveedor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nomProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nomProveedor.CustomButton.TabIndex = 1;
            this.nomProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nomProveedor.CustomButton.UseSelectable = true;
            this.nomProveedor.CustomButton.Visible = false;
            this.nomProveedor.Lines = new string[] {
        "Nombre"};
            this.nomProveedor.Location = new System.Drawing.Point(553, 24);
            this.nomProveedor.MaxLength = 32767;
            this.nomProveedor.Name = "nomProveedor";
            this.nomProveedor.PasswordChar = '\0';
            this.nomProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nomProveedor.SelectedText = "";
            this.nomProveedor.SelectionLength = 0;
            this.nomProveedor.SelectionStart = 0;
            this.nomProveedor.ShortcutsEnabled = true;
            this.nomProveedor.Size = new System.Drawing.Size(200, 23);
            this.nomProveedor.TabIndex = 18;
            this.nomProveedor.Text = "Nombre";
            this.nomProveedor.UseSelectable = true;
            this.nomProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nomProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nomProveedor.Enter += new System.EventHandler(this.nomProveedor_Enter);
            this.nomProveedor.Leave += new System.EventHandler(this.nomProveedor_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(553, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Alta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mailProveedor
            // 
            // 
            // 
            // 
            this.mailProveedor.CustomButton.Image = null;
            this.mailProveedor.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.mailProveedor.CustomButton.Name = "";
            this.mailProveedor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mailProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mailProveedor.CustomButton.TabIndex = 1;
            this.mailProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mailProveedor.CustomButton.UseSelectable = true;
            this.mailProveedor.CustomButton.Visible = false;
            this.mailProveedor.Lines = new string[] {
        "Email"};
            this.mailProveedor.Location = new System.Drawing.Point(553, 166);
            this.mailProveedor.MaxLength = 32767;
            this.mailProveedor.Name = "mailProveedor";
            this.mailProveedor.PasswordChar = '\0';
            this.mailProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mailProveedor.SelectedText = "";
            this.mailProveedor.SelectionLength = 0;
            this.mailProveedor.SelectionStart = 0;
            this.mailProveedor.ShortcutsEnabled = true;
            this.mailProveedor.Size = new System.Drawing.Size(200, 23);
            this.mailProveedor.TabIndex = 21;
            this.mailProveedor.Text = "Email";
            this.mailProveedor.UseSelectable = true;
            this.mailProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mailProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mailProveedor.Enter += new System.EventHandler(this.mailProveedor_Enter);
            this.mailProveedor.Leave += new System.EventHandler(this.mailProveedor_Leave);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(553, 211);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(230, 95);
            this.listBox1.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button4.Location = new System.Drawing.Point(13, 492);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(294, 43);
            this.button4.TabIndex = 27;
            this.button4.Text = "BUSQUEDA";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(11)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(826, 594);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.mailProveedor);
            this.Controls.Add(this.telProveedor);
            this.Controls.Add(this.direProveedor);
            this.Controls.Add(this.nomProveedor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewE);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "proveedores";
            this.Text = "proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroTextBox telProveedor;
        private MetroFramework.Controls.MetroTextBox direProveedor;
        private MetroFramework.Controls.MetroTextBox nomProveedor;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox mailProveedor;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
    }
}