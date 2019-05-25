namespace Traffic_Enforcement_System
{
    partial class ViolatorsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewEnforcersList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.buttonVL = new System.Windows.Forms.Button();
            this.buttonEL = new System.Windows.Forms.Button();
            this.buttonER = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnforcersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEnforcersList
            // 
            this.dataGridViewEnforcersList.AllowUserToAddRows = false;
            this.dataGridViewEnforcersList.AllowUserToDeleteRows = false;
            this.dataGridViewEnforcersList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEnforcersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEnforcersList.Location = new System.Drawing.Point(260, 130);
            this.dataGridViewEnforcersList.Name = "dataGridViewEnforcersList";
            this.dataGridViewEnforcersList.Size = new System.Drawing.Size(702, 304);
            this.dataGridViewEnforcersList.TabIndex = 107;
            this.dataGridViewEnforcersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEnforcersList_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBoxLogin.Location = new System.Drawing.Point(0, -7);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(244, 42);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 105;
            this.pictureBoxLogin.TabStop = false;
            // 
            // buttonVL
            // 
            this.buttonVL.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVL.ForeColor = System.Drawing.Color.White;
            this.buttonVL.Location = new System.Drawing.Point(0, 32);
            this.buttonVL.Name = "buttonVL";
            this.buttonVL.Size = new System.Drawing.Size(244, 46);
            this.buttonVL.TabIndex = 104;
            this.buttonVL.Text = "Violator\'s List";
            this.buttonVL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVL.UseVisualStyleBackColor = false;
            this.buttonVL.MouseEnter += new System.EventHandler(this.buttonVL_MouseEnter);
            this.buttonVL.MouseLeave += new System.EventHandler(this.buttonVL_MouseLeave);
            // 
            // buttonEL
            // 
            this.buttonEL.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEL.ForeColor = System.Drawing.Color.White;
            this.buttonEL.Location = new System.Drawing.Point(0, 78);
            this.buttonEL.Name = "buttonEL";
            this.buttonEL.Size = new System.Drawing.Size(244, 46);
            this.buttonEL.TabIndex = 103;
            this.buttonEL.Text = "Enforcer\'s List";
            this.buttonEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEL.UseVisualStyleBackColor = false;
            this.buttonEL.Click += new System.EventHandler(this.buttonEL_Click);
            this.buttonEL.MouseEnter += new System.EventHandler(this.buttonEL_MouseEnter);
            this.buttonEL.MouseLeave += new System.EventHandler(this.buttonEL_MouseLeave);
            // 
            // buttonER
            // 
            this.buttonER.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonER.ForeColor = System.Drawing.Color.White;
            this.buttonER.Location = new System.Drawing.Point(0, 119);
            this.buttonER.Name = "buttonER";
            this.buttonER.Size = new System.Drawing.Size(244, 46);
            this.buttonER.TabIndex = 102;
            this.buttonER.Text = "Enforcer\'s Registration";
            this.buttonER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonER.UseVisualStyleBackColor = false;
            this.buttonER.Click += new System.EventHandler(this.buttonER_Click);
            this.buttonER.MouseEnter += new System.EventHandler(this.buttonER_MouseEnter);
            this.buttonER.MouseLeave += new System.EventHandler(this.buttonER_MouseLeave);
            // 
            // buttonL
            // 
            this.buttonL.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonL.ForeColor = System.Drawing.Color.White;
            this.buttonL.Location = new System.Drawing.Point(0, 160);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(244, 46);
            this.buttonL.TabIndex = 100;
            this.buttonL.Text = "Logout";
            this.buttonL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonL.UseVisualStyleBackColor = false;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            this.buttonL.MouseEnter += new System.EventHandler(this.buttonL_MouseEnter);
            this.buttonL.MouseLeave += new System.EventHandler(this.buttonL_MouseLeave);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(273, 440);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(106, 37);
            this.buttonBack.TabIndex = 99;
            this.buttonBack.Text = "Update";
            this.buttonBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(687, 98);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(66, 20);
            this.labelSearch.TabIndex = 98;
            this.labelSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(759, 98);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(192, 26);
            this.textBoxSearch.TabIndex = 97;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(263, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 55);
            this.label3.TabIndex = 96;
            this.label3.Text = "Violators List";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ViolatorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 539);
            this.Controls.Add(this.dataGridViewEnforcersList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.buttonVL);
            this.Controls.Add(this.buttonEL);
            this.Controls.Add(this.buttonER);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ViolatorsList";
            this.Load += new System.EventHandler(this.ViolatorsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnforcersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEnforcersList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Button buttonVL;
        private System.Windows.Forms.Button buttonEL;
        private System.Windows.Forms.Button buttonER;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label3;
    }
}