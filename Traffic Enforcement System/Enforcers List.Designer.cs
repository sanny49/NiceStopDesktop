namespace Traffic_Enforcement_System
{
    partial class EnforcersList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewEnforcersList = new System.Windows.Forms.DataGridView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonEL = new System.Windows.Forms.Button();
            this.buttonER = new System.Windows.Forms.Button();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.buttonVL = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnforcersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEnforcersList
            // 
            this.dataGridViewEnforcersList.AllowUserToAddRows = false;
            this.dataGridViewEnforcersList.AllowUserToDeleteRows = false;
            this.dataGridViewEnforcersList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEnforcersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEnforcersList.Location = new System.Drawing.Point(255, 126);
            this.dataGridViewEnforcersList.Name = "dataGridViewEnforcersList";
            this.dataGridViewEnforcersList.Size = new System.Drawing.Size(698, 312);
            this.dataGridViewEnforcersList.TabIndex = 71;
            this.dataGridViewEnforcersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(679, 95);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(66, 20);
            this.labelSearch.TabIndex = 72;
            this.labelSearch.Text = "Search";
            this.labelSearch.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(751, 94);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(192, 26);
            this.textBoxSearch.TabIndex = 73;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(245, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 55);
            this.label3.TabIndex = 70;
            this.label3.Text = "Enforcers List";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(287, 444);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 37);
            this.buttonDelete.TabIndex = 75;
            this.buttonDelete.Text = "Update";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonL
            // 
            this.buttonL.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonL.ForeColor = System.Drawing.Color.White;
            this.buttonL.Location = new System.Drawing.Point(-5, 164);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(244, 44);
            this.buttonL.TabIndex = 81;
            this.buttonL.Text = "Logout";
            this.buttonL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonL.UseVisualStyleBackColor = false;
            this.buttonL.Click += new System.EventHandler(this.button1_Click);
            this.buttonL.MouseEnter += new System.EventHandler(this.buttonL_MouseEnter_1);
            this.buttonL.MouseLeave += new System.EventHandler(this.buttonL_MouseLeave);
            // 
            // buttonEL
            // 
            this.buttonEL.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEL.ForeColor = System.Drawing.Color.White;
            this.buttonEL.Location = new System.Drawing.Point(-5, 80);
            this.buttonEL.Name = "buttonEL";
            this.buttonEL.Size = new System.Drawing.Size(244, 46);
            this.buttonEL.TabIndex = 87;
            this.buttonEL.Text = "Enforcer\'s List";
            this.buttonEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEL.UseVisualStyleBackColor = false;
            this.buttonEL.Click += new System.EventHandler(this.buttonEL_Click);
            this.buttonEL.MouseEnter += new System.EventHandler(this.buttonEL_MouseEnter_1);
            this.buttonEL.MouseLeave += new System.EventHandler(this.buttonEL_MouseLeave);
            // 
            // buttonER
            // 
            this.buttonER.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonER.ForeColor = System.Drawing.Color.White;
            this.buttonER.Location = new System.Drawing.Point(-5, 122);
            this.buttonER.Name = "buttonER";
            this.buttonER.Size = new System.Drawing.Size(244, 46);
            this.buttonER.TabIndex = 86;
            this.buttonER.Text = "Enforcer\'s Registration";
            this.buttonER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonER.UseVisualStyleBackColor = false;
            this.buttonER.Click += new System.EventHandler(this.buttonER_Click);
            this.buttonER.MouseEnter += new System.EventHandler(this.buttonER_MouseEnter_1);
            this.buttonER.MouseLeave += new System.EventHandler(this.buttonER_MouseLeave);
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBoxLogin.Location = new System.Drawing.Point(-5, -1);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(244, 42);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 89;
            this.pictureBoxLogin.TabStop = false;
            // 
            // buttonVL
            // 
            this.buttonVL.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVL.ForeColor = System.Drawing.Color.White;
            this.buttonVL.Location = new System.Drawing.Point(-5, 37);
            this.buttonVL.Name = "buttonVL";
            this.buttonVL.Size = new System.Drawing.Size(244, 46);
            this.buttonVL.TabIndex = 88;
            this.buttonVL.Text = "Violator\'s List";
            this.buttonVL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVL.UseVisualStyleBackColor = false;
            this.buttonVL.Click += new System.EventHandler(this.button4_Click_1);
            this.buttonVL.MouseEnter += new System.EventHandler(this.buttonVL_MouseEnter_1);
            this.buttonVL.MouseLeave += new System.EventHandler(this.buttonVL_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // EnforcersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 539);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.buttonVL);
            this.Controls.Add(this.buttonEL);
            this.Controls.Add(this.buttonER);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.dataGridViewEnforcersList);
            this.Controls.Add(this.label3);
            this.Name = "EnforcersList";
            this.Load += new System.EventHandler(this.FormEnforcersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnforcersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewEnforcersList;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonEL;
        private System.Windows.Forms.Button buttonER;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Button buttonVL;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}