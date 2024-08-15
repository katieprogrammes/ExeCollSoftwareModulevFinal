namespace SpotTheDifference
{
    partial class Medium3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medium3));
            label1 = new Label();
            label2 = new Label();
            pic1 = new FlowLayoutPanel();
            pic2 = new FlowLayoutPanel();
            pic3 = new FlowLayoutPanel();
            pic4 = new FlowLayoutPanel();
            pic5 = new FlowLayoutPanel();
            pic6 = new FlowLayoutPanel();
            labelScore = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(323, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 54);
            label1.TabIndex = 3;
            label1.Text = "Medium";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(346, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 38);
            label2.TabIndex = 4;
            label2.Text = "Score:";
            // 
            // pic1
            // 
            pic1.BackColor = Color.Transparent;
            pic1.BackgroundImage = (Image)resources.GetObject("pic1.BackgroundImage");
            pic1.BackgroundImageLayout = ImageLayout.Stretch;
            pic1.Cursor = Cursors.Hand;
            pic1.Location = new Point(74, 253);
            pic1.Margin = new Padding(4, 5, 4, 5);
            pic1.Name = "pic1";
            pic1.Size = new Size(197, 230);
            pic1.TabIndex = 21;
            pic1.Click += pic1_Click;
            // 
            // pic2
            // 
            pic2.BackColor = Color.Transparent;
            pic2.BackgroundImage = (Image)resources.GetObject("pic2.BackgroundImage");
            pic2.BackgroundImageLayout = ImageLayout.Stretch;
            pic2.Cursor = Cursors.Hand;
            pic2.Location = new Point(324, 253);
            pic2.Margin = new Padding(4, 5, 4, 5);
            pic2.Name = "pic2";
            pic2.Size = new Size(197, 230);
            pic2.TabIndex = 22;
            pic2.Click += pic2_Click;
            // 
            // pic3
            // 
            pic3.BackColor = Color.Transparent;
            pic3.BackgroundImage = (Image)resources.GetObject("pic3.BackgroundImage");
            pic3.BackgroundImageLayout = ImageLayout.Stretch;
            pic3.Cursor = Cursors.Hand;
            pic3.Location = new Point(565, 253);
            pic3.Margin = new Padding(4, 5, 4, 5);
            pic3.Name = "pic3";
            pic3.Size = new Size(197, 230);
            pic3.TabIndex = 23;
            pic3.Click += pic3_Click;
            // 
            // pic4
            // 
            pic4.BackColor = Color.Transparent;
            pic4.BackgroundImage = (Image)resources.GetObject("pic4.BackgroundImage");
            pic4.BackgroundImageLayout = ImageLayout.Stretch;
            pic4.Cursor = Cursors.Hand;
            pic4.Location = new Point(74, 538);
            pic4.Margin = new Padding(4, 5, 4, 5);
            pic4.Name = "pic4";
            pic4.Size = new Size(197, 230);
            pic4.TabIndex = 24;
            pic4.Click += pic4_Click;
            // 
            // pic5
            // 
            pic5.BackColor = Color.Transparent;
            pic5.BackgroundImage = (Image)resources.GetObject("pic5.BackgroundImage");
            pic5.BackgroundImageLayout = ImageLayout.Stretch;
            pic5.Cursor = Cursors.Hand;
            pic5.Location = new Point(323, 538);
            pic5.Margin = new Padding(4, 5, 4, 5);
            pic5.Name = "pic5";
            pic5.Size = new Size(197, 230);
            pic5.TabIndex = 25;
            pic5.Click += pic5_Click;
            // 
            // pic6
            // 
            pic6.BackColor = Color.Transparent;
            pic6.BackgroundImage = (Image)resources.GetObject("pic6.BackgroundImage");
            pic6.BackgroundImageLayout = ImageLayout.Stretch;
            pic6.Cursor = Cursors.Hand;
            pic6.Location = new Point(565, 538);
            pic6.Margin = new Padding(4, 5, 4, 5);
            pic6.Name = "pic6";
            pic6.Size = new Size(197, 230);
            pic6.TabIndex = 26;
            pic6.Click += pic6_Click;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.BackColor = Color.Transparent;
            labelScore.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.Location = new Point(435, 155);
            labelScore.Margin = new Padding(4, 0, 4, 0);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(32, 38);
            labelScore.TabIndex = 28;
            labelScore.Text = "0";
            // 
            // Medium3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(833, 841);
            Controls.Add(labelScore);
            Controls.Add(pic6);
            Controls.Add(pic5);
            Controls.Add(pic4);
            Controls.Add(pic3);
            Controls.Add(pic2);
            Controls.Add(pic1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Medium3";
            Text = "Medium3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private FlowLayoutPanel pic1;
        private FlowLayoutPanel pic2;
        private FlowLayoutPanel pic3;
        private FlowLayoutPanel pic4;
        private FlowLayoutPanel pic5;
        private FlowLayoutPanel pic6;
        private Label labelScore;
    }
}