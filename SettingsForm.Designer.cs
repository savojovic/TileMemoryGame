namespace WF_Slagalica
{
    partial class SettingsForm
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
            this.gbBrojParova = new System.Windows.Forms.GroupBox();
            this.rbTen = new System.Windows.Forms.RadioButton();
            this.rbEight = new System.Windows.Forms.RadioButton();
            this.rbSix = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbBrojParova.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBrojParova
            // 
            this.gbBrojParova.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbBrojParova.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbBrojParova.Controls.Add(this.rbTen);
            this.gbBrojParova.Controls.Add(this.rbEight);
            this.gbBrojParova.Controls.Add(this.rbSix);
            this.gbBrojParova.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBrojParova.Location = new System.Drawing.Point(9, 90);
            this.gbBrojParova.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBrojParova.Name = "gbBrojParova";
            this.gbBrojParova.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBrojParova.Size = new System.Drawing.Size(238, 81);
            this.gbBrojParova.TabIndex = 1;
            this.gbBrojParova.TabStop = false;
            this.gbBrojParova.Text = "Number of pairs";
            // 
            // rbTen
            // 
            this.rbTen.AutoSize = true;
            this.rbTen.Location = new System.Drawing.Point(4, 60);
            this.rbTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTen.Name = "rbTen";
            this.rbTen.Size = new System.Drawing.Size(39, 19);
            this.rbTen.TabIndex = 2;
            this.rbTen.TabStop = true;
            this.rbTen.Text = "10";
            this.rbTen.UseVisualStyleBackColor = true;
            // 
            // rbEight
            // 
            this.rbEight.AutoSize = true;
            this.rbEight.Location = new System.Drawing.Point(5, 39);
            this.rbEight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbEight.Name = "rbEight";
            this.rbEight.Size = new System.Drawing.Size(32, 19);
            this.rbEight.TabIndex = 2;
            this.rbEight.TabStop = true;
            this.rbEight.Text = "8";
            this.rbEight.UseVisualStyleBackColor = true;
            // 
            // rbSix
            // 
            this.rbSix.AutoSize = true;
            this.rbSix.Location = new System.Drawing.Point(5, 18);
            this.rbSix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSix.Name = "rbSix";
            this.rbSix.Size = new System.Drawing.Size(32, 19);
            this.rbSix.TabIndex = 0;
            this.rbSix.TabStop = true;
            this.rbSix.Text = "6";
            this.rbSix.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(9, 27);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(240, 38);
            this.tbUsername.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(91, 228);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 305);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbBrojParova);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.gbBrojParova.ResumeLayout(false);
            this.gbBrojParova.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbBrojParova;
        private System.Windows.Forms.RadioButton rbTen;
        private System.Windows.Forms.RadioButton rbEight;
        private System.Windows.Forms.RadioButton rbSix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnSave;
    }
}