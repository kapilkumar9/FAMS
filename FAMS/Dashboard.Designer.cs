namespace FAMS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.fishes_button = new System.Windows.Forms.Button();
            this.diver_button = new System.Windows.Forms.Button();
            this.staff_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fishes_button
            // 
            this.fishes_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fishes_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fishes_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fishes_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fishes_button.ForeColor = System.Drawing.Color.DarkBlue;
            this.fishes_button.Location = new System.Drawing.Point(128, 89);
            this.fishes_button.Name = "fishes_button";
            this.fishes_button.Size = new System.Drawing.Size(150, 50);
            this.fishes_button.TabIndex = 0;
            this.fishes_button.Text = "Fishes Panel";
            this.fishes_button.UseVisualStyleBackColor = false;
            this.fishes_button.Click += new System.EventHandler(this.fishes_button_Click);
            // 
            // diver_button
            // 
            this.diver_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.diver_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diver_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.diver_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diver_button.ForeColor = System.Drawing.Color.DarkBlue;
            this.diver_button.Location = new System.Drawing.Point(128, 184);
            this.diver_button.Name = "diver_button";
            this.diver_button.Size = new System.Drawing.Size(150, 50);
            this.diver_button.TabIndex = 1;
            this.diver_button.Text = "Diver Panel";
            this.diver_button.UseVisualStyleBackColor = false;
            this.diver_button.Click += new System.EventHandler(this.diver_button_Click);
            // 
            // staff_button
            // 
            this.staff_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.staff_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staff_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.staff_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_button.ForeColor = System.Drawing.Color.DarkBlue;
            this.staff_button.Location = new System.Drawing.Point(128, 278);
            this.staff_button.Name = "staff_button";
            this.staff_button.Size = new System.Drawing.Size(150, 50);
            this.staff_button.TabIndex = 2;
            this.staff_button.Text = "Staff Panel";
            this.staff_button.UseVisualStyleBackColor = false;
            this.staff_button.Click += new System.EventHandler(this.staff_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.Firebrick;
            this.logout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.ForeColor = System.Drawing.Color.White;
            this.logout_button.Location = new System.Drawing.Point(12, 402);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(101, 36);
            this.logout_button.TabIndex = 3;
            this.logout_button.Text = "Log Out";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Firebrick;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(288, 402);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(101, 36);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.staff_button);
            this.Controls.Add(this.diver_button);
            this.Controls.Add(this.fishes_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fishes_button;
        private System.Windows.Forms.Button diver_button;
        private System.Windows.Forms.Button staff_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button exit_button;
    }
}