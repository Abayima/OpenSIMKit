namespace SimKit.UserInterface.ContentPanels
{
    partial class ConnectionQuestionsContentPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customCheckboxContainer1 = new System.Windows.Forms.Panel();
            this.customCheckboxContainer2 = new System.Windows.Forms.Panel();
            this.imageButton1 = new SIMKIT.UserInterface.CustomControls.ImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Can we record your use of \r\nOpen SIMKit?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 60);
            this.label3.TabIndex = 6;
            this.label3.Text = "Allow SIMKIT to register that this app was turned\r\non (collecting this very basic" +
    " usage data helps us\r\nkeep SIMKIT free, please keep this in mind before \r\nunchec" +
    "king this option).";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Allow SIMKIT to collect anonymous data about\r\nthe way you use this app (not inclu" +
    "ding the \r\nmessages you write).\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(431, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Recording how often and where Open SIMKit is used is important\r\nto ensuring that " +
    "this software remains free for all to use.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imageButton1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(300, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 9;
            // 
            // customCheckboxContainer1
            // 
            this.customCheckboxContainer1.Location = new System.Drawing.Point(375, 198);
            this.customCheckboxContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.customCheckboxContainer1.Name = "customCheckboxContainer1";
            this.customCheckboxContainer1.Size = new System.Drawing.Size(100, 45);
            this.customCheckboxContainer1.TabIndex = 10;
            // 
            // customCheckboxContainer2
            // 
            this.customCheckboxContainer2.Location = new System.Drawing.Point(375, 291);
            this.customCheckboxContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.customCheckboxContainer2.Name = "customCheckboxContainer2";
            this.customCheckboxContainer2.Size = new System.Drawing.Size(100, 45);
            this.customCheckboxContainer2.TabIndex = 11;
            // 
            // imageButton1
            // 
            this.imageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton1.DownImage = null;
            this.imageButton1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageButton1.HoverImage = global::SimKit.Properties.Resources.app_button_blue_over;
            this.imageButton1.Location = new System.Drawing.Point(65, 21);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.NormalImage = global::SimKit.Properties.Resources.app_button_blue_out;
            this.imageButton1.Size = new System.Drawing.Size(110, 50);
            this.imageButton1.TabIndex = 8;
            this.imageButton1.TabStop = false;
            this.imageButton1.Text = "Continue";
            this.imageButton1.Click += new System.EventHandler(this.imageButton1_Click);
            // 
            // ConnectionQuestionsContentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.customCheckboxContainer2);
            this.Controls.Add(this.customCheckboxContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ConnectionQuestionsContentPanel";
            this.Size = new System.Drawing.Size(500, 500);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private SIMKIT.UserInterface.CustomControls.ImageButton imageButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel customCheckboxContainer1;
        private System.Windows.Forms.Panel customCheckboxContainer2;
    }
}
