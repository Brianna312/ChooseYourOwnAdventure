namespace adventureRPG
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.title3Label = new System.Windows.Forms.Label();
            this.title2Label = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.option1 = new System.Windows.Forms.Label();
            this.option2 = new System.Windows.Forms.Label();
            this.option3 = new System.Windows.Forms.Label();
            this.dialogueHistory = new System.Windows.Forms.TextBox();
            this.debugLabel = new System.Windows.Forms.Label();
            this.debugTextboxEncounter = new System.Windows.Forms.TextBox();
            this.debugTextboxDecidion = new System.Windows.Forms.TextBox();
            this.debgButton = new System.Windows.Forms.Button();
            this.debugTextboxLabel = new System.Windows.Forms.Label();
            this.debugTextboxGun = new System.Windows.Forms.TextBox();
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
            this.titleLabel.Size = new System.Drawing.Size(347, 42);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "The Text Adventure";
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
            this.debugLabel.Location = new System.Drawing.Point(602, 481);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(46, 16);
            this.debugLabel.TabIndex = 10;
            this.debugLabel.Text = "debug";
            // 
            // debugTextboxEncounter
            // 
            this.debugTextboxEncounter.Location = new System.Drawing.Point(605, 398);
            this.debugTextboxEncounter.Name = "debugTextboxEncounter";
            this.debugTextboxEncounter.Size = new System.Drawing.Size(100, 22);
            this.debugTextboxEncounter.TabIndex = 11;
            // 
            // debugTextboxDecidion
            // 
            this.debugTextboxDecidion.Location = new System.Drawing.Point(605, 370);
            this.debugTextboxDecidion.Name = "debugTextboxDecidion";
            this.debugTextboxDecidion.Size = new System.Drawing.Size(100, 22);
            this.debugTextboxDecidion.TabIndex = 12;
            // 
            // debgButton
            // 
            this.debgButton.Location = new System.Drawing.Point(711, 397);
            this.debgButton.Name = "debgButton";
            this.debgButton.Size = new System.Drawing.Size(75, 23);
            this.debgButton.TabIndex = 13;
            this.debgButton.Text = "set";
            this.debgButton.UseVisualStyleBackColor = true;
            this.debgButton.Click += new System.EventHandler(this.debgButton_Click);
            // 
            // debugTextboxLabel
            // 
            this.debugTextboxLabel.AutoSize = true;
            this.debugTextboxLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.debugTextboxLabel.Location = new System.Drawing.Point(533, 370);
            this.debugTextboxLabel.Name = "debugTextboxLabel";
            this.debugTextboxLabel.Size = new System.Drawing.Size(66, 80);
            this.debugTextboxLabel.TabIndex = 14;
            this.debugTextboxLabel.Text = "decision\r\n\r\nencounter\r\n\r\nGun\r\n";
            // 
            // debugTextboxGun
            // 
            this.debugTextboxGun.Location = new System.Drawing.Point(605, 430);
            this.debugTextboxGun.Name = "debugTextboxGun";
            this.debugTextboxGun.Size = new System.Drawing.Size(100, 22);
            this.debugTextboxGun.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.debugTextboxGun);
            this.Controls.Add(this.debugTextboxLabel);
            this.Controls.Add(this.debgButton);
            this.Controls.Add(this.debugTextboxDecidion);
            this.Controls.Add(this.debugTextboxEncounter);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.dialogueHistory);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.title2Label);
            this.Controls.Add(this.title3Label);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox debugTextboxEncounter;
        private System.Windows.Forms.TextBox debugTextboxDecidion;
        private System.Windows.Forms.Button debgButton;
        private System.Windows.Forms.Label debugTextboxLabel;
        private System.Windows.Forms.TextBox debugTextboxGun;
    }
}

