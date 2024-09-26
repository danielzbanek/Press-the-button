namespace Press_the_button
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            button1 = new Button();
            Stage = new ProgressBar();
            StageLabel = new Label();
            label1 = new Label();
            RestartButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.FromArgb(192, 255, 255);
            Title.BorderStyle = BorderStyle.Fixed3D;
            Title.FlatStyle = FlatStyle.System;
            Title.Font = new Font("Stencil", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(1, -2);
            Title.Name = "Title";
            Title.Size = new Size(477, 226);
            Title.TabIndex = 0;
            Title.Text = "Press The Button \r\n\r\nTHE GAME\r\n";
            Title.TextAlign = ContentAlignment.BottomLeft;
            Title.Click += Title_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Location = new Point(809, 222);
            button1.Name = "button1";
            button1.Size = new Size(250, 250);
            button1.TabIndex = 1;
            button1.Text = "Button";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Stage
            // 
            Stage.Anchor = AnchorStyles.None;
            Stage.Location = new Point(579, 361);
            Stage.Name = "Stage";
            Stage.Size = new Size(214, 29);
            Stage.TabIndex = 2;
            // 
            // StageLabel
            // 
            StageLabel.Anchor = AnchorStyles.None;
            StageLabel.AutoSize = true;
            StageLabel.ForeColor = SystemColors.ActiveCaptionText;
            StageLabel.Location = new Point(579, 393);
            StageLabel.Name = "StageLabel";
            StageLabel.Size = new Size(17, 20);
            StageLabel.TabIndex = 3;
            StageLabel.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(636, 393);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 4;
            label1.Text = " ↑ Your Stage↑ \r\n";
            // 
            // RestartButton
            // 
            RestartButton.Anchor = AnchorStyles.None;
            RestartButton.Location = new Point(1028, -2);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(79, 79);
            RestartButton.TabIndex = 5;
            RestartButton.Text = "restart\r\n\r\n";
            RestartButton.UseVisualStyleBackColor = true;
            RestartButton.Click += RestartButton_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 340);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 683);
            Controls.Add(label2);
            Controls.Add(RestartButton);
            Controls.Add(label1);
            Controls.Add(StageLabel);
            Controls.Add(Stage);
            Controls.Add(button1);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Press the Button";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button button1;
        private ProgressBar Stage;
        private Label StageLabel;
        private Label label1;
        private Button RestartButton;
        private Label label2;
    }
}
