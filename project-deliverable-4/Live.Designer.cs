namespace project_deliverable_4
{
    partial class Live
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Live));
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            statusStrip1 = new StatusStrip();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(271, 609);
            button1.Name = "button1";
            button1.Size = new Size(153, 29);
            button1.TabIndex = 1;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(38, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 28);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Select Camera";
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.Location = new Point(499, 26);
            button2.Name = "button2";
            button2.Size = new Size(153, 29);
            button2.TabIndex = 3;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click_1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 641);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(693, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(14, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(667, 530);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "View:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(24, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(614, 476);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Live
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 663);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Live";
            Text = "Live";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private StatusStrip statusStrip1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}