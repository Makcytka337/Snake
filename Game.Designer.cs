namespace Snake
{
    //Made by Makcytka337
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.isLose = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.keysLabel2 = new System.Windows.Forms.Label();
            this.infoBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.scetLabel = new System.Windows.Forms.Label();
            this.keysLabel1 = new System.Windows.Forms.Label();
            this.degLabel = new System.Windows.Forms.Label();
            this.gamepanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // game_timer
            // 
            this.game_timer.Interval = 20;
            // 
            // isLose
            // 
            this.isLose.Enabled = true;
            this.isLose.Interval = 20;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.volumeLabel);
            this.panel2.Controls.Add(this.speedLabel);
            this.panel2.Controls.Add(this.keysLabel2);
            this.panel2.Controls.Add(this.infoBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.scetLabel);
            this.panel2.Controls.Add(this.keysLabel1);
            this.panel2.Controls.Add(this.degLabel);
            this.panel2.Location = new System.Drawing.Point(1204, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 812);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(11, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Внимание, не дрегайте резко мышью";
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.volumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeLabel.ForeColor = System.Drawing.Color.White;
            this.volumeLabel.Location = new System.Drawing.Point(202, 371);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(125, 20);
            this.volumeLabel.TabIndex = 11;
            this.volumeLabel.Text = "Громкость: 100";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.BackColor = System.Drawing.Color.Transparent;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLabel.ForeColor = System.Drawing.Color.White;
            this.speedLabel.Location = new System.Drawing.Point(11, 423);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(98, 20);
            this.speedLabel.TabIndex = 10;
            this.speedLabel.Text = "Скорость: 5";
            // 
            // keysLabel2
            // 
            this.keysLabel2.AutoSize = true;
            this.keysLabel2.BackColor = System.Drawing.Color.Transparent;
            this.keysLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keysLabel2.ForeColor = System.Drawing.Color.White;
            this.keysLabel2.Location = new System.Drawing.Point(178, 65);
            this.keysLabel2.Name = "keysLabel2";
            this.keysLabel2.Size = new System.Drawing.Size(101, 20);
            this.keysLabel2.TabIndex = 9;
            this.keysLabel2.Text = "Управление";
            // 
            // infoBtn
            // 
            this.infoBtn.BackColor = System.Drawing.Color.Red;
            this.infoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.infoBtn.Enabled = false;
            this.infoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.infoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoBtn.Location = new System.Drawing.Point(15, 519);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(336, 41);
            this.infoBtn.TabIndex = 8;
            this.infoBtn.Text = "Пауза";
            this.infoBtn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Управление";
            // 
            // scetLabel
            // 
            this.scetLabel.AutoSize = true;
            this.scetLabel.BackColor = System.Drawing.Color.Transparent;
            this.scetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scetLabel.ForeColor = System.Drawing.Color.White;
            this.scetLabel.Location = new System.Drawing.Point(11, 475);
            this.scetLabel.Name = "scetLabel";
            this.scetLabel.Size = new System.Drawing.Size(64, 20);
            this.scetLabel.TabIndex = 2;
            this.scetLabel.Text = "Счет: 0";
            // 
            // keysLabel1
            // 
            this.keysLabel1.AutoSize = true;
            this.keysLabel1.BackColor = System.Drawing.Color.Transparent;
            this.keysLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keysLabel1.ForeColor = System.Drawing.Color.White;
            this.keysLabel1.Location = new System.Drawing.Point(11, 65);
            this.keysLabel1.Name = "keysLabel1";
            this.keysLabel1.Size = new System.Drawing.Size(101, 20);
            this.keysLabel1.TabIndex = 7;
            this.keysLabel1.Text = "Управление";
            // 
            // degLabel
            // 
            this.degLabel.AutoSize = true;
            this.degLabel.BackColor = System.Drawing.Color.Transparent;
            this.degLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degLabel.ForeColor = System.Drawing.Color.White;
            this.degLabel.Location = new System.Drawing.Point(11, 371);
            this.degLabel.Name = "degLabel";
            this.degLabel.Size = new System.Drawing.Size(138, 20);
            this.degLabel.TabIndex = 1;
            this.degLabel.Text = "Угол поворота: 0";
            // 
            // gamepanel
            // 
            this.gamepanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamepanel.BackColor = System.Drawing.Color.Black;
            this.gamepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamepanel.Location = new System.Drawing.Point(12, 9);
            this.gamepanel.Name = "gamepanel";
            this.gamepanel.Size = new System.Drawing.Size(1180, 812);
            this.gamepanel.TabIndex = 5;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1581, 833);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gamepanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Deactivate += new System.EventHandler(this.Game_Deactivate);
            this.Load += new System.EventHandler(this.Game_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer game_timer;
        private System.Windows.Forms.Label degLabel;
        private System.Windows.Forms.Label scetLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label keysLabel1;
        private System.Windows.Forms.Timer isLose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Label keysLabel2;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel gamepanel;
    }
}

