namespace TicTacToe
{
    partial class TicTacToeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCountersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.xPlayerLabel = new System.Windows.Forms.Label();
            this.oPlayerLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xWinCountLabel = new System.Windows.Forms.Label();
            this.drawCountLabel = new System.Windows.Forms.Label();
            this.oWinCountLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(336, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetCountersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.файлToolStripMenuItem.Text = "Меню";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.newGameToolStripMenuItem.Text = "Новая игра";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // resetCountersToolStripMenuItem
            // 
            this.resetCountersToolStripMenuItem.Name = "resetCountersToolStripMenuItem";
            this.resetCountersToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.resetCountersToolStripMenuItem.Text = "Обнулить счет";
            this.resetCountersToolStripMenuItem.Click += new System.EventHandler(this.ResetCountersToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AccessibleName = "";
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.exitToolStripMenuItem.Text = "Выйти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(12, 31);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 100);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.TicTacToeButton_Click);
            this.A1.MouseEnter += new System.EventHandler(this.TicTacToeButton_MouseEnter);
            this.A1.MouseLeave += new System.EventHandler(this.TicTacToeButton_MouseLeave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(118, 31);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(100, 100);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.TicTacToeButton_Click);
            this.A2.MouseEnter += new System.EventHandler(this.TicTacToeButton_MouseEnter);
            this.A2.MouseLeave += new System.EventHandler(this.TicTacToeButton_MouseLeave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(224, 31);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(100, 100);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.TicTacToeButton_Click);
            this.A3.MouseEnter += new System.EventHandler(this.TicTacToeButton_MouseEnter);
            this.A3.MouseLeave += new System.EventHandler(this.TicTacToeButton_MouseLeave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(118, 137);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(100, 100);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.TicTacToeButton_Click);
            this.B2.MouseEnter += new System.EventHandler(this.TicTacToeButton_MouseEnter);
            this.B2.MouseLeave += new System.EventHandler(this.TicTacToeButton_MouseLeave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(224, 137);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(100, 100);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.TicTacToeButton_Click);
            this.B3.MouseEnter += new System.EventHandler(this.TicTacToeButton_MouseEnter);
            this.B3.MouseLeave += new System.EventHandler(this.TicTacToeButton_MouseLeave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(12, 137);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(100, 100);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.TicTacToeButton_Click);
            this.B1.MouseEnter += new System.EventHandler(this.TicTacToeButton_MouseEnter);
            this.B1.MouseLeave += new System.EventHandler(this.TicTacToeButton_MouseLeave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(12, 243);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(100, 100);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.TicTacToeButton_Click);
            this.C1.MouseEnter += new System.EventHandler(this.TicTacToeButton_MouseEnter);
            this.C1.MouseLeave += new System.EventHandler(this.TicTacToeButton_MouseLeave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(118, 243);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(100, 100);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.TicTacToeButton_Click);
            this.C2.MouseEnter += new System.EventHandler(this.TicTacToeButton_MouseEnter);
            this.C2.MouseLeave += new System.EventHandler(this.TicTacToeButton_MouseLeave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(224, 243);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(100, 100);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.TicTacToeButton_Click);
            this.C3.MouseEnter += new System.EventHandler(this.TicTacToeButton_MouseEnter);
            this.C3.MouseLeave += new System.EventHandler(this.TicTacToeButton_MouseLeave);
            // 
            // xPlayerLabel
            // 
            this.xPlayerLabel.AutoSize = true;
            this.xPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPlayerLabel.Location = new System.Drawing.Point(16, 363);
            this.xPlayerLabel.MaximumSize = new System.Drawing.Size(96, 17);
            this.xPlayerLabel.MinimumSize = new System.Drawing.Size(96, 17);
            this.xPlayerLabel.Name = "xPlayerLabel";
            this.xPlayerLabel.Size = new System.Drawing.Size(96, 17);
            this.xPlayerLabel.TabIndex = 10;
            this.xPlayerLabel.Text = "Игрок Х";
            this.xPlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oPlayerLabel
            // 
            this.oPlayerLabel.AutoSize = true;
            this.oPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oPlayerLabel.Location = new System.Drawing.Point(228, 363);
            this.oPlayerLabel.MaximumSize = new System.Drawing.Size(96, 17);
            this.oPlayerLabel.MinimumSize = new System.Drawing.Size(96, 17);
            this.oPlayerLabel.Name = "oPlayerLabel";
            this.oPlayerLabel.Size = new System.Drawing.Size(96, 17);
            this.oPlayerLabel.TabIndex = 11;
            this.oPlayerLabel.Text = "Игрок О";
            this.oPlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ничья";
            // 
            // xWinCountLabel
            // 
            this.xWinCountLabel.AutoSize = true;
            this.xWinCountLabel.Location = new System.Drawing.Point(56, 389);
            this.xWinCountLabel.Name = "xWinCountLabel";
            this.xWinCountLabel.Size = new System.Drawing.Size(16, 17);
            this.xWinCountLabel.TabIndex = 13;
            this.xWinCountLabel.Text = "0";
            // 
            // drawCountLabel
            // 
            this.drawCountLabel.AutoSize = true;
            this.drawCountLabel.Location = new System.Drawing.Point(161, 389);
            this.drawCountLabel.Name = "drawCountLabel";
            this.drawCountLabel.Size = new System.Drawing.Size(16, 17);
            this.drawCountLabel.TabIndex = 14;
            this.drawCountLabel.Text = "0";
            // 
            // oWinCountLabel
            // 
            this.oWinCountLabel.AutoSize = true;
            this.oWinCountLabel.Location = new System.Drawing.Point(268, 389);
            this.oWinCountLabel.Name = "oWinCountLabel";
            this.oWinCountLabel.Size = new System.Drawing.Size(16, 17);
            this.oWinCountLabel.TabIndex = 15;
            this.oWinCountLabel.Text = "0";
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 427);
            this.Controls.Add(this.oWinCountLabel);
            this.Controls.Add(this.drawCountLabel);
            this.Controls.Add(this.xWinCountLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oPlayerLabel);
            this.Controls.Add(this.xPlayerLabel);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TicTacToeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Крестики-нолики";
            this.Load += new System.EventHandler(this.TicTacToeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label xPlayerLabel;
        private System.Windows.Forms.Label oPlayerLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label xWinCountLabel;
        private System.Windows.Forms.Label drawCountLabel;
        private System.Windows.Forms.Label oWinCountLabel;
        private System.Windows.Forms.ToolStripMenuItem resetCountersToolStripMenuItem;
    }
}

