namespace SpotTheDifference
{
    partial class Easy3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Easy3));
            label1 = new Label();
            label3 = new Label();
            pic2 = new FlowLayoutPanel();
            pic4 = new FlowLayoutPanel();
            pic1 = new FlowLayoutPanel();
            pic3 = new FlowLayoutPanel();
            labelScore = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(257, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 54);
            label1.TabIndex = 11;
            label1.Text = "Easy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(245, 88);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 38);
            label3.TabIndex = 13;
            label3.Text = "Score:";
            // 
            // pic2
            // 
            pic2.BackColor = Color.Transparent;
            pic2.BackgroundImage = (Image)resources.GetObject("pic2.BackgroundImage");
            pic2.BackgroundImageLayout = ImageLayout.Stretch;
            pic2.Location = new Point(327, 175);
            pic2.Margin = new Padding(4, 5, 4, 5);
            pic2.Name = "pic2";
            pic2.Size = new Size(197, 230);
            pic2.TabIndex = 15;
            pic2.Click += pic2_Click;
            // 
            // pic4
            // 
            pic4.BackColor = Color.Transparent;
            pic4.BackgroundImage = (Image)resources.GetObject("pic4.BackgroundImage");
            pic4.BackgroundImageLayout = ImageLayout.Stretch;
            pic4.Location = new Point(327, 435);
            pic4.Margin = new Padding(4, 5, 4, 5);
            pic4.Name = "pic4";
            pic4.Size = new Size(197, 230);
            pic4.TabIndex = 17;
            pic4.Click += pic4_Click;
            // 
            // pic1
            // 
            pic1.BackColor = Color.Transparent;
            pic1.BackgroundImage = (Image)resources.GetObject("pic1.BackgroundImage");
            pic1.BackgroundImageLayout = ImageLayout.Stretch;
            pic1.Location = new Point(91, 175);
            pic1.Margin = new Padding(4, 5, 4, 5);
            pic1.Name = "pic1";
            pic1.Size = new Size(197, 230);
            pic1.TabIndex = 16;
            pic1.Click += pic1_Click;
            // 
            // pic3
            // 
            pic3.BackColor = Color.Transparent;
            pic3.BackgroundImage = (Image)resources.GetObject("pic3.BackgroundImage");
            pic3.BackgroundImageLayout = ImageLayout.Stretch;
            pic3.Location = new Point(91, 435);
            pic3.Margin = new Padding(4, 5, 4, 5);
            pic3.Name = "pic3";
            pic3.Size = new Size(197, 230);
            pic3.TabIndex = 17;
            pic3.Click += pic3_Click;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.BackColor = Color.Transparent;
            labelScore.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.Location = new Point(330, 89);
            labelScore.Margin = new Padding(4, 0, 4, 0);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(32, 38);
            labelScore.TabIndex = 18;
            labelScore.Text = "0";
            // 
            // Easy3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(624, 708);
            Controls.Add(labelScore);
            Controls.Add(pic3);
            Controls.Add(pic1);
            Controls.Add(pic4);
            Controls.Add(pic2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Easy3";
            Text = "Easy3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private FlowLayoutPanel pic2;
        private FlowLayoutPanel pic4;
        private FlowLayoutPanel pic1;
        private FlowLayoutPanel pic3;
        private Label labelScore;
    }
}