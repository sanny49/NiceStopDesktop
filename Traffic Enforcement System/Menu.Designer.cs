namespace NiceStop
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonVL = new System.Windows.Forms.Button();
            this.buttonEL = new System.Windows.Forms.Button();
            this.buttonER = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.violators1 = new NiceStop.Violators();
            this.enforcerRegistration1 = new NiceStop.EnforcerRegistration();
            this.enforcers1 = new NiceStop.Enforcers();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.buttonVL);
            this.panel1.Controls.Add(this.buttonEL);
            this.panel1.Controls.Add(this.buttonER);
            this.panel1.Controls.Add(this.buttonL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 543);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonVL
            // 
            this.buttonVL.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVL.ForeColor = System.Drawing.Color.White;
            this.buttonVL.Location = new System.Drawing.Point(0, 69);
            this.buttonVL.Name = "buttonVL";
            this.buttonVL.Size = new System.Drawing.Size(217, 46);
            this.buttonVL.TabIndex = 92;
            this.buttonVL.Text = "Violator\'s List";
            this.buttonVL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVL.UseVisualStyleBackColor = false;
            this.buttonVL.Click += new System.EventHandler(this.buttonVL_Click);
            this.buttonVL.MouseEnter += new System.EventHandler(this.buttonVL_MouseEnter);
            this.buttonVL.MouseLeave += new System.EventHandler(this.buttonVL_MouseLeave);
            // 
            // buttonEL
            // 
            this.buttonEL.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEL.ForeColor = System.Drawing.Color.White;
            this.buttonEL.Location = new System.Drawing.Point(0, 121);
            this.buttonEL.Name = "buttonEL";
            this.buttonEL.Size = new System.Drawing.Size(217, 46);
            this.buttonEL.TabIndex = 91;
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
            this.buttonER.Location = new System.Drawing.Point(-3, 173);
            this.buttonER.Name = "buttonER";
            this.buttonER.Size = new System.Drawing.Size(220, 46);
            this.buttonER.TabIndex = 90;
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
            this.buttonL.Location = new System.Drawing.Point(0, 225);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(217, 41);
            this.buttonL.TabIndex = 89;
            this.buttonL.Text = "Logout";
            this.buttonL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonL.UseVisualStyleBackColor = false;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            this.buttonL.MouseEnter += new System.EventHandler(this.buttonL_MouseEnter);
            this.buttonL.MouseLeave += new System.EventHandler(this.buttonL_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.violators1);
            this.panel2.Controls.Add(this.enforcerRegistration1);
            this.panel2.Controls.Add(this.enforcers1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(217, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 543);
            this.panel2.TabIndex = 93;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // violators1
            // 
            this.violators1.BackColor = System.Drawing.Color.White;
            this.violators1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.violators1.Location = new System.Drawing.Point(0, 0);
            this.violators1.Name = "violators1";
            this.violators1.Size = new System.Drawing.Size(740, 543);
            this.violators1.TabIndex = 96;
            this.violators1.Load += new System.EventHandler(this.violators1_Load);
            // 
            // enforcerRegistration1
            // 
            this.enforcerRegistration1.BackColor = System.Drawing.Color.White;
            this.enforcerRegistration1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enforcerRegistration1.Location = new System.Drawing.Point(0, 0);
            this.enforcerRegistration1.Name = "enforcerRegistration1";
            this.enforcerRegistration1.Size = new System.Drawing.Size(740, 543);
            this.enforcerRegistration1.TabIndex = 94;
            // 
            // enforcers1
            // 
            this.enforcers1.BackColor = System.Drawing.Color.White;
            this.enforcers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enforcers1.Location = new System.Drawing.Point(0, 0);
            this.enforcers1.Name = "enforcers1";
            this.enforcers1.Size = new System.Drawing.Size(740, 543);
            this.enforcers1.TabIndex = 95;
            this.enforcers1.Load += new System.EventHandler(this.enforcers1_Load_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(957, 543);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonVL;
        private System.Windows.Forms.Button buttonEL;
        private System.Windows.Forms.Button buttonER;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Panel panel2;
        private Violators violators1;
        private EnforcerRegistration enforcerRegistration1;
        private Enforcers enforcers1;
    }
}