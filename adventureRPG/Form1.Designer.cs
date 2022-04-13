namespace adventureRPG
{
    partial class Fate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fate));
            this.titleLabel = new System.Windows.Forms.Label();
            this.title3Label = new System.Windows.Forms.Label();
            this.title2Label = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.option1 = new System.Windows.Forms.Label();
            this.option2 = new System.Windows.Forms.Label();
            this.option3 = new System.Windows.Forms.Label();
            this.dialogueHistory = new System.Windows.Forms.TextBox();
            this.debugLabel = new System.Windows.Forms.Label();
            this.debugTextboxDecidion = new System.Windows.Forms.TextBox();
            this.debgButton = new System.Windows.Forms.Button();
            this.IntegralSecretLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.LightGray;
            this.titleLabel.Location = new System.Drawing.Point(226, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(351, 42);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Your Inevitable Fate";
            // 
            // title3Label
            // 
            this.title3Label.AutoSize = true;
            this.title3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title3Label.ForeColor = System.Drawing.Color.LightGray;
            this.title3Label.Location = new System.Drawing.Point(288, 110);
            this.title3Label.Name = "title3Label";
            this.title3Label.Size = new System.Drawing.Size(231, 25);
            this.title3Label.TabIndex = 1;
            this.title3Label.Text = "Greatly inspired by Omori";
            // 
            // title2Label
            // 
            this.title2Label.AutoSize = true;
            this.title2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2Label.ForeColor = System.Drawing.Color.LightGray;
            this.title2Label.Location = new System.Drawing.Point(230, 75);
            this.title2Label.Name = "title2Label";
            this.title2Label.Size = new System.Drawing.Size(343, 29);
            this.title2Label.TabIndex = 2;
            this.title2Label.Text = "Created by Brianna Hutchinson";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightGray;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(284, 251);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(249, 75);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start Adventure";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.ForeColor = System.Drawing.Color.LightGray;
            this.option1.Location = new System.Drawing.Point(76, 297);
            this.option1.MinimumSize = new System.Drawing.Size(650, 40);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(650, 40);
            this.option1.TabIndex = 4;
            this.option1.Text = "Option One";
            this.option1.Visible = false;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.ForeColor = System.Drawing.Color.LightGray;
            this.option2.Location = new System.Drawing.Point(76, 360);
            this.option2.MinimumSize = new System.Drawing.Size(650, 40);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(650, 40);
            this.option2.TabIndex = 5;
            this.option2.Text = "Option Two";
            this.option2.Visible = false;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3.ForeColor = System.Drawing.Color.LightGray;
            this.option3.Location = new System.Drawing.Point(76, 429);
            this.option3.MinimumSize = new System.Drawing.Size(650, 40);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(650, 40);
            this.option3.TabIndex = 6;
            this.option3.Text = "Option Three";
            this.option3.Visible = false;
            this.option3.Click += new System.EventHandler(this.option3_Click);
            // 
            // dialogueHistory
            // 
            this.dialogueHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dialogueHistory.ForeColor = System.Drawing.Color.LightGray;
            this.dialogueHistory.Location = new System.Drawing.Point(80, 9);
            this.dialogueHistory.MaximumSize = new System.Drawing.Size(650, 280);
            this.dialogueHistory.MinimumSize = new System.Drawing.Size(650, 280);
            this.dialogueHistory.Multiline = true;
            this.dialogueHistory.Name = "dialogueHistory";
            this.dialogueHistory.ReadOnly = true;
            this.dialogueHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dialogueHistory.Size = new System.Drawing.Size(650, 280);
            this.dialogueHistory.TabIndex = 9;
            this.dialogueHistory.Text = ">> You wake up in a cold dark room. You can vaguely make out the shape of a metal" +
    " object and a cardboard box. There is a door at one end of the room, you wonder " +
    "if it\'s unlocked...";
            this.dialogueHistory.Visible = false;
            this.dialogueHistory.TextChanged += new System.EventHandler(this.dialogueHistory_TextChanged);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.debugLabel.Location = new System.Drawing.Point(409, 491);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(46, 16);
            this.debugLabel.TabIndex = 10;
            this.debugLabel.Text = "debug";
            this.debugLabel.Visible = false;
            // 
            // debugTextboxDecidion
            // 
            this.debugTextboxDecidion.Location = new System.Drawing.Point(496, 494);
            this.debugTextboxDecidion.Name = "debugTextboxDecidion";
            this.debugTextboxDecidion.Size = new System.Drawing.Size(100, 22);
            this.debugTextboxDecidion.TabIndex = 12;
            this.debugTextboxDecidion.Visible = false;
            // 
            // debgButton
            // 
            this.debgButton.Location = new System.Drawing.Point(608, 491);
            this.debgButton.Name = "debgButton";
            this.debgButton.Size = new System.Drawing.Size(75, 23);
            this.debgButton.TabIndex = 13;
            this.debgButton.Text = "set";
            this.debgButton.UseVisualStyleBackColor = true;
            this.debgButton.Visible = false;
            this.debgButton.Click += new System.EventHandler(this.debgButton_Click);
            // 
            // IntegralSecretLabel
            // 
            this.IntegralSecretLabel.AutoSize = true;
            this.IntegralSecretLabel.Location = new System.Drawing.Point(605, 341);
            this.IntegralSecretLabel.Name = "IntegralSecretLabel";
            this.IntegralSecretLabel.Size = new System.Drawing.Size(44, 16);
            this.IntegralSecretLabel.TabIndex = 16;
            this.IntegralSecretLabel.Text = "label1";
            this.IntegralSecretLabel.TextChanged += new System.EventHandler(this.IntegralSecretLabel_TextChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(524, 297);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(249, 163);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.LightGray;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(284, 351);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(249, 75);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "Play Again?";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Fate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dialogueHistory);
            this.Controls.Add(this.IntegralSecretLabel);
            this.Controls.Add(this.debgButton);
            this.Controls.Add(this.debugTextboxDecidion);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.title2Label);
            this.Controls.Add(this.title3Label);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fate";
            this.Text = "Your Inevitable Fate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label title3Label;
        private System.Windows.Forms.Label title2Label;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label option1;
        private System.Windows.Forms.Label option2;
        private System.Windows.Forms.Label option3;
        private System.Windows.Forms.TextBox dialogueHistory;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.TextBox debugTextboxDecidion;
        private System.Windows.Forms.Button debgButton;
        private System.Windows.Forms.Label IntegralSecretLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button resetButton;
    }
}

