
namespace TimerWinForms
{
    partial class MainForm
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
            this.startBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.hourUpDown = new System.Windows.Forms.NumericUpDown();
            this.minuteUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondUpDown = new System.Windows.Forms.NumericUpDown();
            this.hourLabel = new System.Windows.Forms.Label();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.secondTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Chartreuse;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Location = new System.Drawing.Point(12, 133);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(112, 37);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Старт";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.OnStartPauseNextClick);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Crimson;
            this.cancelBtn.Enabled = false;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(196, 133);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 37);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // hourUpDown
            // 
            this.hourUpDown.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourUpDown.Location = new System.Drawing.Point(12, 35);
            this.hourUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hourUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.hourUpDown.Name = "hourUpDown";
            this.hourUpDown.Size = new System.Drawing.Size(92, 71);
            this.hourUpDown.TabIndex = 2;
            // 
            // minuteUpDown
            // 
            this.minuteUpDown.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minuteUpDown.Location = new System.Drawing.Point(112, 35);
            this.minuteUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minuteUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minuteUpDown.Name = "minuteUpDown";
            this.minuteUpDown.Size = new System.Drawing.Size(94, 71);
            this.minuteUpDown.TabIndex = 3;
            this.minuteUpDown.ValueChanged += new System.EventHandler(this.OnMinuteChange);
            // 
            // secondUpDown
            // 
            this.secondUpDown.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondUpDown.Location = new System.Drawing.Point(214, 35);
            this.secondUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secondUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.secondUpDown.Name = "secondUpDown";
            this.secondUpDown.Size = new System.Drawing.Size(94, 71);
            this.secondUpDown.TabIndex = 4;
            this.secondUpDown.ValueChanged += new System.EventHandler(this.OnSecondChange);
            // 
            // hourLabel
            // 
            this.hourLabel.Location = new System.Drawing.Point(12, 9);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(92, 21);
            this.hourLabel.TabIndex = 5;
            this.hourLabel.Text = "Часы";
            this.hourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minuteLabel
            // 
            this.minuteLabel.Location = new System.Drawing.Point(112, 9);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(94, 21);
            this.minuteLabel.TabIndex = 6;
            this.minuteLabel.Text = "Минуты";
            this.minuteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondLabel
            // 
            this.secondLabel.Location = new System.Drawing.Point(214, 9);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(94, 21);
            this.secondLabel.TabIndex = 7;
            this.secondLabel.Text = "Секунды";
            this.secondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondTimer
            // 
            this.secondTimer.Interval = 1000;
            this.secondTimer.Tick += new System.EventHandler(this.OnSecondPass);
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(12, 17);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(303, 89);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "00:00:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 186);
            this.Controls.Add(this.minuteUpDown);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.minuteLabel);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.secondUpDown);
            this.Controls.Add(this.hourUpDown);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.timeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(343, 225);
            this.MinimumSize = new System.Drawing.Size(343, 225);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запуск таймера";
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.NumericUpDown hourUpDown;
        private System.Windows.Forms.NumericUpDown minuteUpDown;
        private System.Windows.Forms.NumericUpDown secondUpDown;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Timer secondTimer;
        private System.Windows.Forms.Label timeLabel;
    }
}

