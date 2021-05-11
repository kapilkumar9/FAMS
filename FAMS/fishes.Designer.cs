namespace FAMS
{
    partial class fishes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fishes));
            this.id_textBox1 = new System.Windows.Forms.TextBox();
            this.species_textBox2 = new System.Windows.Forms.TextBox();
            this.age_textBox4 = new System.Windows.Forms.TextBox();
            this.zone_textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addnew_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.quan_textBox1 = new System.Windows.Forms.TextBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id_textBox1
            // 
            this.id_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_textBox1.Location = new System.Drawing.Point(143, 49);
            this.id_textBox1.Name = "id_textBox1";
            this.id_textBox1.Size = new System.Drawing.Size(338, 26);
            this.id_textBox1.TabIndex = 0;
            this.id_textBox1.TextChanged += new System.EventHandler(this.id_textBox1_TextChanged);
            // 
            // species_textBox2
            // 
            this.species_textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.species_textBox2.Location = new System.Drawing.Point(143, 101);
            this.species_textBox2.Name = "species_textBox2";
            this.species_textBox2.Size = new System.Drawing.Size(385, 26);
            this.species_textBox2.TabIndex = 1;
            this.species_textBox2.TextChanged += new System.EventHandler(this.species_textBox2_TextChanged);
            // 
            // age_textBox4
            // 
            this.age_textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_textBox4.Location = new System.Drawing.Point(143, 211);
            this.age_textBox4.Name = "age_textBox4";
            this.age_textBox4.Size = new System.Drawing.Size(385, 26);
            this.age_textBox4.TabIndex = 3;
            this.age_textBox4.TextChanged += new System.EventHandler(this.age_textBox4_TextChanged);
            // 
            // zone_textBox5
            // 
            this.zone_textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone_textBox5.Location = new System.Drawing.Point(143, 268);
            this.zone_textBox5.Name = "zone_textBox5";
            this.zone_textBox5.Size = new System.Drawing.Size(385, 26);
            this.zone_textBox5.TabIndex = 4;
            this.zone_textBox5.TextChanged += new System.EventHandler(this.zone_textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(109, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(77, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Species";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(79, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(97, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(91, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Zone";
            // 
            // addnew_button
            // 
            this.addnew_button.BackColor = System.Drawing.Color.Green;
            this.addnew_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnew_button.ForeColor = System.Drawing.Color.White;
            this.addnew_button.Location = new System.Drawing.Point(40, 346);
            this.addnew_button.Name = "addnew_button";
            this.addnew_button.Size = new System.Drawing.Size(146, 43);
            this.addnew_button.TabIndex = 11;
            this.addnew_button.Text = "Add New";
            this.addnew_button.UseVisualStyleBackColor = false;
            this.addnew_button.Click += new System.EventHandler(this.addnew_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Firebrick;
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.Color.White;
            this.delete_button.Location = new System.Drawing.Point(440, 346);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(146, 43);
            this.delete_button.TabIndex = 12;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.DarkGreen;
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.ForeColor = System.Drawing.Color.White;
            this.save_button.Location = new System.Drawing.Point(241, 395);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(146, 43);
            this.save_button.TabIndex = 13;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.Teal;
            this.edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.Color.White;
            this.edit_button.Location = new System.Drawing.Point(241, 346);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(146, 43);
            this.edit_button.TabIndex = 14;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.Maroon;
            this.logout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.ForeColor = System.Drawing.Color.White;
            this.logout_button.Location = new System.Drawing.Point(12, 491);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(146, 31);
            this.logout_button.TabIndex = 15;
            this.logout_button.Text = "Back";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // quan_textBox1
            // 
            this.quan_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quan_textBox1.Location = new System.Drawing.Point(143, 155);
            this.quan_textBox1.Name = "quan_textBox1";
            this.quan_textBox1.Size = new System.Drawing.Size(385, 26);
            this.quan_textBox1.TabIndex = 17;
            this.quan_textBox1.TextChanged += new System.EventHandler(this.quan_textBox1_TextChanged);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Maroon;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(462, 491);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(146, 31);
            this.exit_button.TabIndex = 18;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.MediumBlue;
            this.search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_button.BackgroundImage")));
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.search_button.Location = new System.Drawing.Point(482, 45);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(41, 36);
            this.search_button.TabIndex = 19;
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // fishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 536);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.quan_textBox1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.addnew_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zone_textBox5);
            this.Controls.Add(this.age_textBox4);
            this.Controls.Add(this.species_textBox2);
            this.Controls.Add(this.id_textBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fishes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fishes";
            this.Load += new System.EventHandler(this.fishes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_textBox1;
        private System.Windows.Forms.TextBox species_textBox2;
        private System.Windows.Forms.TextBox age_textBox4;
        private System.Windows.Forms.TextBox zone_textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addnew_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.TextBox quan_textBox1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button search_button;
    }
}