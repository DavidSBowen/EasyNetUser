namespace EasyNetUser
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
            this.manualUsernameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getUsernamesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputWindow = new System.Windows.Forms.TextBox();
            this.runNetUserButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.netUserWindow = new System.Windows.Forms.TextBox();
            this.clearAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // manualUsernameTextbox
            // 
            this.manualUsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualUsernameTextbox.Location = new System.Drawing.Point(24, 47);
            this.manualUsernameTextbox.Name = "manualUsernameTextbox";
            this.manualUsernameTextbox.Size = new System.Drawing.Size(170, 20);
            this.manualUsernameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter a username:";
            // 
            // getUsernamesButton
            // 
            this.getUsernamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getUsernamesButton.Location = new System.Drawing.Point(232, 17);
            this.getUsernamesButton.Name = "getUsernamesButton";
            this.getUsernamesButton.Size = new System.Drawing.Size(135, 31);
            this.getUsernamesButton.TabIndex = 5;
            this.getUsernamesButton.Text = "Get Usernames";
            this.getUsernamesButton.UseVisualStyleBackColor = true;
            this.getUsernamesButton.Click += new System.EventHandler(this.getUsernamesButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.getUsernamesButton);
            this.groupBox1.Controls.Add(this.outputWindow);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 401);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1 - Get a list of usernames if needed.";
            // 
            // outputWindow
            // 
            this.outputWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputWindow.Location = new System.Drawing.Point(6, 54);
            this.outputWindow.Multiline = true;
            this.outputWindow.Name = "outputWindow";
            this.outputWindow.Size = new System.Drawing.Size(361, 341);
            this.outputWindow.TabIndex = 8;
            // 
            // runNetUserButton
            // 
            this.runNetUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runNetUserButton.Location = new System.Drawing.Point(220, 45);
            this.runNetUserButton.Name = "runNetUserButton";
            this.runNetUserButton.Size = new System.Drawing.Size(128, 23);
            this.runNetUserButton.TabIndex = 7;
            this.runNetUserButton.Text = "Run Net User";
            this.runNetUserButton.UseVisualStyleBackColor = true;
            this.runNetUserButton.Click += new System.EventHandler(this.runNetUserButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 468);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Copy to clipboard";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(126, 468);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Save text file";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(846, 554);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.manualUsernameTextbox);
            this.groupBox2.Controls.Add(this.runNetUserButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(38, 472);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 95);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2 - Enter username on which to run Net User command.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.netUserWindow);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(454, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 497);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3 - Results of command.";
            // 
            // netUserWindow
            // 
            this.netUserWindow.Location = new System.Drawing.Point(7, 26);
            this.netUserWindow.Multiline = true;
            this.netUserWindow.Name = "netUserWindow";
            this.netUserWindow.Size = new System.Drawing.Size(454, 436);
            this.netUserWindow.TabIndex = 0;
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(742, 554);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(75, 23);
            this.clearAll.TabIndex = 14;
            this.clearAll.Text = "Clear";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 589);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox manualUsernameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getUsernamesButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button runNetUserButton;
        private System.Windows.Forms.TextBox outputWindow;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox netUserWindow;
        private System.Windows.Forms.Button clearAll;
    }
}

