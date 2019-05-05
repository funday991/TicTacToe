namespace TicTacToe
{
    partial class PlayerNamesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xPlayerTextBox = new System.Windows.Forms.TextBox();
            this.oPlayerTextBox = new System.Windows.Forms.TextBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.onePlayerModeCheckBox = new System.Windows.Forms.CheckBox();
            this.xRadioButton = new System.Windows.Forms.RadioButton();
            this.oRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Игрок Х:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Игрок О:";
            // 
            // xPlayerTextBox
            // 
            this.xPlayerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPlayerTextBox.Location = new System.Drawing.Point(110, 9);
            this.xPlayerTextBox.MaxLength = 10;
            this.xPlayerTextBox.Name = "xPlayerTextBox";
            this.xPlayerTextBox.Size = new System.Drawing.Size(196, 30);
            this.xPlayerTextBox.TabIndex = 2;
            this.xPlayerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlayerTextBox_KeyPress);
            // 
            // oPlayerTextBox
            // 
            this.oPlayerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oPlayerTextBox.Location = new System.Drawing.Point(110, 45);
            this.oPlayerTextBox.MaxLength = 10;
            this.oPlayerTextBox.Name = "oPlayerTextBox";
            this.oPlayerTextBox.Size = new System.Drawing.Size(196, 30);
            this.oPlayerTextBox.TabIndex = 3;
            this.oPlayerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlayerTextBox_KeyPress);
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(110, 177);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(196, 31);
            this.startGameButton.TabIndex = 4;
            this.startGameButton.Text = "Начать игру";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // onePlayerModeCheckBox
            // 
            this.onePlayerModeCheckBox.AutoSize = true;
            this.onePlayerModeCheckBox.Location = new System.Drawing.Point(18, 81);
            this.onePlayerModeCheckBox.Name = "onePlayerModeCheckBox";
            this.onePlayerModeCheckBox.Size = new System.Drawing.Size(286, 21);
            this.onePlayerModeCheckBox.TabIndex = 5;
            this.onePlayerModeCheckBox.Text = "Включить режим \"Против компьютера\"";
            this.onePlayerModeCheckBox.UseVisualStyleBackColor = true;
            this.onePlayerModeCheckBox.CheckedChanged += new System.EventHandler(this.OnePlayerModeCheckBox_CheckedChanged);
            // 
            // xRadioButton
            // 
            this.xRadioButton.AutoSize = true;
            this.xRadioButton.Checked = true;
            this.xRadioButton.Location = new System.Drawing.Point(18, 112);
            this.xRadioButton.Name = "xRadioButton";
            this.xRadioButton.Size = new System.Drawing.Size(106, 21);
            this.xRadioButton.TabIndex = 6;
            this.xRadioButton.TabStop = true;
            this.xRadioButton.Text = "Играть за X";
            this.xRadioButton.UseVisualStyleBackColor = true;
            this.xRadioButton.CheckedChanged += new System.EventHandler(this.XRadioButton_CheckedChanged);
            // 
            // oRadioButton
            // 
            this.oRadioButton.AutoSize = true;
            this.oRadioButton.Location = new System.Drawing.Point(18, 139);
            this.oRadioButton.Name = "oRadioButton";
            this.oRadioButton.Size = new System.Drawing.Size(108, 21);
            this.oRadioButton.TabIndex = 7;
            this.oRadioButton.Text = "Играть за O";
            this.oRadioButton.UseVisualStyleBackColor = true;
            // 
            // PlayerNamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 216);
            this.Controls.Add(this.oRadioButton);
            this.Controls.Add(this.xRadioButton);
            this.Controls.Add(this.onePlayerModeCheckBox);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.oPlayerTextBox);
            this.Controls.Add(this.xPlayerTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PlayerNamesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayerNamesForm_FormClosing);
            this.Load += new System.EventHandler(this.PlayerNamesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xPlayerTextBox;
        private System.Windows.Forms.TextBox oPlayerTextBox;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.CheckBox onePlayerModeCheckBox;
        private System.Windows.Forms.RadioButton xRadioButton;
        private System.Windows.Forms.RadioButton oRadioButton;
    }
}