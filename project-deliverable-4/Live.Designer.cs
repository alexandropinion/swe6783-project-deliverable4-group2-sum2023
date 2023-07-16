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
            pictureBox2 = new PictureBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            vScrollBar1 = new VScrollBar();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(38, 609);
            button1.Name = "button1";
            button1.Size = new Size(614, 43);
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
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(756, 611);
            button2.Name = "button2";
            button2.Size = new Size(728, 39);
            button2.TabIndex = 3;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click_1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 655);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1559, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user_icon1;
            pictureBox2.Location = new Point(118, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 126);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(vScrollBar1);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(732, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(788, 530);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Members:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(494, 304);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 14;
            label4.Text = "Member 4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(140, 304);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 13;
            label3.Text = "Member 3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(494, 45);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 12;
            label2.Text = "Member 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(140, 45);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 11;
            label1.Text = "Member 1";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.user_icon1;
            pictureBox5.Location = new Point(469, 359);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(127, 125);
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.user_icon1;
            pictureBox4.Location = new Point(118, 357);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(130, 127);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user_icon1;
            pictureBox3.Location = new Point(469, 97);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(133, 130);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(756, 17);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 510);
            vScrollBar1.TabIndex = 7;
            // 
            // Live
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1559, 677);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Live";
            Text = "Live";
            FormClosed += Live_Closed;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox2;
        private GroupBox groupBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private VScrollBar vScrollBar1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}