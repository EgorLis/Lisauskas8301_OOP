namespace Kursovik_7
{
    partial class TeacherWindow
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
            this.BookingButton = new System.Windows.Forms.Button();
            this.AuditoriumBox = new System.Windows.Forms.ComboBox();
            this.ExitToAuth = new System.Windows.Forms.Button();
            this.OneDayBox = new System.Windows.Forms.ComboBox();
            this.OneDayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookingButton
            // 
            this.BookingButton.Location = new System.Drawing.Point(325, 41);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(120, 40);
            this.BookingButton.TabIndex = 1;
            this.BookingButton.Text = "Бронь";
            this.BookingButton.UseVisualStyleBackColor = true;
            this.BookingButton.Click += new System.EventHandler(this.BookingButton_Click);
            // 
            // AuditoriumBox
            // 
            this.AuditoriumBox.FormattingEnabled = true;
            this.AuditoriumBox.Location = new System.Drawing.Point(166, 50);
            this.AuditoriumBox.Name = "AuditoriumBox";
            this.AuditoriumBox.Size = new System.Drawing.Size(121, 24);
            this.AuditoriumBox.TabIndex = 2;
            // 
            // ExitToAuth
            // 
            this.ExitToAuth.Location = new System.Drawing.Point(568, 350);
            this.ExitToAuth.Name = "ExitToAuth";
            this.ExitToAuth.Size = new System.Drawing.Size(200, 30);
            this.ExitToAuth.TabIndex = 3;
            this.ExitToAuth.Text = "Выйти из профиля";
            this.ExitToAuth.UseVisualStyleBackColor = true;
            this.ExitToAuth.Click += new System.EventHandler(this.ExitToAuth_Click);
            // 
            // OneDayBox
            // 
            this.OneDayBox.FormattingEnabled = true;
            this.OneDayBox.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота"});
            this.OneDayBox.Location = new System.Drawing.Point(166, 103);
            this.OneDayBox.Name = "OneDayBox";
            this.OneDayBox.Size = new System.Drawing.Size(121, 24);
            this.OneDayBox.TabIndex = 4;
            // 
            // OneDayButton
            // 
            this.OneDayButton.Location = new System.Drawing.Point(325, 94);
            this.OneDayButton.Name = "OneDayButton";
            this.OneDayButton.Size = new System.Drawing.Size(120, 40);
            this.OneDayButton.TabIndex = 5;
            this.OneDayButton.Text = "Просмотреть";
            this.OneDayButton.UseVisualStyleBackColor = true;
            this.OneDayButton.Click += new System.EventHandler(this.OneDayButton_Click);
            // 
            // TeacherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OneDayButton);
            this.Controls.Add(this.OneDayBox);
            this.Controls.Add(this.ExitToAuth);
            this.Controls.Add(this.AuditoriumBox);
            this.Controls.Add(this.BookingButton);
            this.Name = "TeacherWindow";
            this.Text = "Окно преподавателя";
            this.Load += new System.EventHandler(this.TeacherWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BookingButton;
        private System.Windows.Forms.ComboBox AuditoriumBox;
        private System.Windows.Forms.Button ExitToAuth;
        private System.Windows.Forms.ComboBox OneDayBox;
        private System.Windows.Forms.Button OneDayButton;
    }
}