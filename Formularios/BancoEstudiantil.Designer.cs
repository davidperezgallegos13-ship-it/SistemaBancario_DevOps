namespace SistemaBancario.Formularios
{
    partial class BancoEstudiantil
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulta1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulta2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulta3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulta4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulta5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulta6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulta7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulacion de Banco";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(59, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 97);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apertura Cuenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(238, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 97);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dep / Ret";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(417, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 97);
            this.button3.TabIndex = 3;
            this.button3.Text = "Mejor Cliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button4.Location = new System.Drawing.Point(596, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 97);
            this.button4.TabIndex = 4;
            this.button4.Text = "Pago Intereses";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulta1ToolStripMenuItem,
            this.consulta2ToolStripMenuItem,
            this.consulta3ToolStripMenuItem,
            this.consulta4ToolStripMenuItem,
            this.consulta5ToolStripMenuItem,
            this.consulta6ToolStripMenuItem,
            this.consulta7ToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.consultasToolStripMenuItem.Text = "Consultas Linq to Object";
            // 
            // consulta1ToolStripMenuItem
            // 
            this.consulta1ToolStripMenuItem.Name = "consulta1ToolStripMenuItem";
            this.consulta1ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.consulta1ToolStripMenuItem.Text = "Consulta 1";
            this.consulta1ToolStripMenuItem.Click += new System.EventHandler(this.consulta1ToolStripMenuItem_Click);
            // 
            // consulta2ToolStripMenuItem
            // 
            this.consulta2ToolStripMenuItem.Name = "consulta2ToolStripMenuItem";
            this.consulta2ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.consulta2ToolStripMenuItem.Text = "Consulta 2";
            this.consulta2ToolStripMenuItem.Click += new System.EventHandler(this.consulta2ToolStripMenuItem_Click);
            // 
            // consulta3ToolStripMenuItem
            // 
            this.consulta3ToolStripMenuItem.Name = "consulta3ToolStripMenuItem";
            this.consulta3ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.consulta3ToolStripMenuItem.Text = "Consulta 3";
            this.consulta3ToolStripMenuItem.Click += new System.EventHandler(this.consulta3ToolStripMenuItem_Click);
            // 
            // consulta4ToolStripMenuItem
            // 
            this.consulta4ToolStripMenuItem.Name = "consulta4ToolStripMenuItem";
            this.consulta4ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.consulta4ToolStripMenuItem.Text = "Consulta 4";
            this.consulta4ToolStripMenuItem.Click += new System.EventHandler(this.consulta4ToolStripMenuItem_Click);
            // 
            // consulta5ToolStripMenuItem
            // 
            this.consulta5ToolStripMenuItem.Name = "consulta5ToolStripMenuItem";
            this.consulta5ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.consulta5ToolStripMenuItem.Text = "Consulta 5";
            this.consulta5ToolStripMenuItem.Click += new System.EventHandler(this.consulta5ToolStripMenuItem_Click);
            // 
            // consulta6ToolStripMenuItem
            // 
            this.consulta6ToolStripMenuItem.Name = "consulta6ToolStripMenuItem";
            this.consulta6ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.consulta6ToolStripMenuItem.Text = "Consulta 6";
            this.consulta6ToolStripMenuItem.Click += new System.EventHandler(this.consulta6ToolStripMenuItem_Click);
            // 
            // consulta7ToolStripMenuItem
            // 
            this.consulta7ToolStripMenuItem.Name = "consulta7ToolStripMenuItem";
            this.consulta7ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.consulta7ToolStripMenuItem.Text = "Consulta 7";
            this.consulta7ToolStripMenuItem.Click += new System.EventHandler(this.consulta7ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(130, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(556, 314);
            this.dataGridView1.TabIndex = 6;
            // 
            // BancoEstudiantil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(801, 615);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BancoEstudiantil";
            this.Text = "BancoEstudiantil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem consulta1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulta2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulta3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulta4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulta5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulta6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulta7ToolStripMenuItem;
    }
}