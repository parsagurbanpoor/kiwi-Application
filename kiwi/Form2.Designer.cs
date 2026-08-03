namespace kiwi
{
    partial class DashBoredpage
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
            this.panelsidebar = new System.Windows.Forms.Panel();
            this.panelmain = new System.Windows.Forms.Panel();
            this.btndashbored = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelsidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelsidebar
            // 
            this.panelsidebar.BackColor = System.Drawing.Color.SeaGreen;
            this.panelsidebar.Controls.Add(this.button1);
            this.panelsidebar.Controls.Add(this.btndashbored);
            this.panelsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsidebar.Location = new System.Drawing.Point(0, 0);
            this.panelsidebar.Name = "panelsidebar";
            this.panelsidebar.Size = new System.Drawing.Size(200, 553);
            this.panelsidebar.TabIndex = 0;
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.White;
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(200, 0);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(782, 553);
            this.panelmain.TabIndex = 1;
            // 
            // btndashbored
            // 
            this.btndashbored.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndashbored.FlatAppearance.BorderSize = 0;
            this.btndashbored.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashbored.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashbored.ForeColor = System.Drawing.Color.White;
            this.btndashbored.Location = new System.Drawing.Point(0, 0);
            this.btndashbored.Name = "btndashbored";
            this.btndashbored.Size = new System.Drawing.Size(200, 50);
            this.btndashbored.TabIndex = 0;
            this.btndashbored.Text = "Dashbored";
            this.btndashbored.UseVisualStyleBackColor = true;
            this.btndashbored.Click += new System.EventHandler(this.btndashbored_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Book Management";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DashBoredpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panelsidebar);
            this.Name = "DashBoredpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashbored";
            this.Load += new System.EventHandler(this.DashBoredpage_Load);
            this.panelsidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelsidebar;
        private System.Windows.Forms.Button btndashbored;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Button button1;
    }
}