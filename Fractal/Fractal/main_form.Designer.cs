namespace Fractal
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.barnsley_button = new System.Windows.Forms.Button();
            this.trisierpinski_button = new System.Windows.Forms.Button();
            this.dragon_button = new System.Windows.Forms.Button();
            this.sierpinski_button = new System.Windows.Forms.Button();
            this.cesaro_button = new System.Windows.Forms.Button();
            this.koch_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(199)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 21);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(112)))), ((int)(((byte)(206)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_exit.Location = new System.Drawing.Point(449, -2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(45, 26);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.barnsley_button);
            this.panel2.Controls.Add(this.trisierpinski_button);
            this.panel2.Controls.Add(this.dragon_button);
            this.panel2.Controls.Add(this.sierpinski_button);
            this.panel2.Controls.Add(this.cesaro_button);
            this.panel2.Controls.Add(this.koch_button);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 450);
            this.panel2.TabIndex = 1;
            // 
            // barnsley_button
            // 
            this.barnsley_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(224)))));
            this.barnsley_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.barnsley_button.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.barnsley_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.barnsley_button.Location = new System.Drawing.Point(332, 375);
            this.barnsley_button.Name = "barnsley_button";
            this.barnsley_button.Size = new System.Drawing.Size(126, 47);
            this.barnsley_button.TabIndex = 13;
            this.barnsley_button.Text = "BARNSLEY";
            this.barnsley_button.UseVisualStyleBackColor = false;
            this.barnsley_button.Click += new System.EventHandler(this.barnsley_button_Click);
            // 
            // trisierpinski_button
            // 
            this.trisierpinski_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(224)))));
            this.trisierpinski_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trisierpinski_button.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trisierpinski_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.trisierpinski_button.Location = new System.Drawing.Point(183, 375);
            this.trisierpinski_button.Name = "trisierpinski_button";
            this.trisierpinski_button.Size = new System.Drawing.Size(126, 47);
            this.trisierpinski_button.TabIndex = 12;
            this.trisierpinski_button.Text = "TRI-SIERPINSKI";
            this.trisierpinski_button.UseVisualStyleBackColor = false;
            this.trisierpinski_button.Click += new System.EventHandler(this.trisierpinski_button_Click);
            // 
            // dragon_button
            // 
            this.dragon_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(224)))));
            this.dragon_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dragon_button.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dragon_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.dragon_button.Location = new System.Drawing.Point(33, 375);
            this.dragon_button.Name = "dragon_button";
            this.dragon_button.Size = new System.Drawing.Size(126, 47);
            this.dragon_button.TabIndex = 11;
            this.dragon_button.Text = "DRAGON";
            this.dragon_button.UseVisualStyleBackColor = false;
            this.dragon_button.Click += new System.EventHandler(this.dragon_button_Click);
            // 
            // sierpinski_button
            // 
            this.sierpinski_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(224)))));
            this.sierpinski_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sierpinski_button.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sierpinski_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.sierpinski_button.Location = new System.Drawing.Point(332, 305);
            this.sierpinski_button.Name = "sierpinski_button";
            this.sierpinski_button.Size = new System.Drawing.Size(126, 47);
            this.sierpinski_button.TabIndex = 10;
            this.sierpinski_button.Text = "SIERPINSKI";
            this.sierpinski_button.UseVisualStyleBackColor = false;
            this.sierpinski_button.Click += new System.EventHandler(this.sierpinski_button_Click);
            // 
            // cesaro_button
            // 
            this.cesaro_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(224)))));
            this.cesaro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cesaro_button.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cesaro_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.cesaro_button.Location = new System.Drawing.Point(183, 305);
            this.cesaro_button.Name = "cesaro_button";
            this.cesaro_button.Size = new System.Drawing.Size(126, 47);
            this.cesaro_button.TabIndex = 9;
            this.cesaro_button.Text = "CESARO";
            this.cesaro_button.UseVisualStyleBackColor = false;
            this.cesaro_button.Click += new System.EventHandler(this.cesaro_button_Click);
            // 
            // koch_button
            // 
            this.koch_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(224)))));
            this.koch_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.koch_button.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.koch_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.koch_button.Location = new System.Drawing.Point(33, 305);
            this.koch_button.Name = "koch_button";
            this.koch_button.Size = new System.Drawing.Size(126, 47);
            this.koch_button.TabIndex = 8;
            this.koch_button.Text = "KOCH";
            this.koch_button.UseVisualStyleBackColor = false;
            this.koch_button.Click += new System.EventHandler(this.koch_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(494, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button barnsley_button;
        private System.Windows.Forms.Button trisierpinski_button;
        private System.Windows.Forms.Button dragon_button;
        private System.Windows.Forms.Button sierpinski_button;
        private System.Windows.Forms.Button cesaro_button;
        private System.Windows.Forms.Button koch_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}