namespace Stat_Roller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dice4 = new System.Windows.Forms.PictureBox();
            this.dice3 = new System.Windows.Forms.PictureBox();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.statLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            this.SuspendLayout();
            // 
            // dice4
            // 
            this.dice4.Image = global::Stat_Roller.Properties.Resources.Dice_1;
            this.dice4.Location = new System.Drawing.Point(340, 12);
            this.dice4.Name = "dice4";
            this.dice4.Size = new System.Drawing.Size(74, 74);
            this.dice4.TabIndex = 3;
            this.dice4.TabStop = false;
            // 
            // dice3
            // 
            this.dice3.Image = global::Stat_Roller.Properties.Resources.Dice_1;
            this.dice3.Location = new System.Drawing.Point(232, 12);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(74, 74);
            this.dice3.TabIndex = 2;
            this.dice3.TabStop = false;
            // 
            // dice2
            // 
            this.dice2.Image = global::Stat_Roller.Properties.Resources.Dice_1;
            this.dice2.Location = new System.Drawing.Point(115, 12);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(74, 75);
            this.dice2.TabIndex = 1;
            this.dice2.TabStop = false;
            this.dice2.Click += new System.EventHandler(this.dice2_Click);
            // 
            // dice1
            // 
            this.dice1.Image = global::Stat_Roller.Properties.Resources.Dice_1;
            this.dice1.Location = new System.Drawing.Point(12, 12);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(74, 75);
            this.dice1.TabIndex = 0;
            this.dice1.TabStop = false;
            // 
            // rollButton
            // 
            this.rollButton.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.Location = new System.Drawing.Point(136, 371);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(156, 70);
            this.rollButton.TabIndex = 4;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // statLabel
            // 
            this.statLabel.AutoSize = true;
            this.statLabel.Font = new System.Drawing.Font("Garamond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLabel.Location = new System.Drawing.Point(156, 192);
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(90, 72);
            this.statLabel.TabIndex = 5;
            this.statLabel.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "2020 Warren Dereu ©";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statLabel);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.dice4);
            this.Controls.Add(this.dice3);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dice1;
        private System.Windows.Forms.PictureBox dice2;
        private System.Windows.Forms.PictureBox dice3;
        private System.Windows.Forms.PictureBox dice4;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label statLabel;
        private System.Windows.Forms.Label label1;
    }
}

