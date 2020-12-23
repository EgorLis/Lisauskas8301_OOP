namespace Kursovik_7
{
    partial class AdminWindow
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
            this.DeleteAudButton = new System.Windows.Forms.Button();
            this.DeleteTeacherButton = new System.Windows.Forms.Button();
            this.AuditoriumBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TeachersBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddAudButton = new System.Windows.Forms.Button();
            this.AddTeacherButton = new System.Windows.Forms.Button();
            this.RedTeacherButton = new System.Windows.Forms.Button();
            this.BookingButton = new System.Windows.Forms.Button();
            this.ActiveUserLabel = new System.Windows.Forms.Label();
            this.ExitToAuth = new System.Windows.Forms.Button();
            this.ChangeAudButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteAudButton
            // 
            this.DeleteAudButton.Location = new System.Drawing.Point(281, 251);
            this.DeleteAudButton.Name = "DeleteAudButton";
            this.DeleteAudButton.Size = new System.Drawing.Size(100, 40);
            this.DeleteAudButton.TabIndex = 0;
            this.DeleteAudButton.Text = "Удалить";
            this.DeleteAudButton.UseVisualStyleBackColor = true;
            this.DeleteAudButton.Click += new System.EventHandler(this.DeleteAudButton_Click);
            // 
            // DeleteTeacherButton
            // 
            this.DeleteTeacherButton.Location = new System.Drawing.Point(578, 196);
            this.DeleteTeacherButton.Name = "DeleteTeacherButton";
            this.DeleteTeacherButton.Size = new System.Drawing.Size(100, 40);
            this.DeleteTeacherButton.TabIndex = 1;
            this.DeleteTeacherButton.Text = "Удалить";
            this.DeleteTeacherButton.UseVisualStyleBackColor = true;
            this.DeleteTeacherButton.Click += new System.EventHandler(this.DeleteTeacherButton_Click);
            // 
            // AuditoriumBox
            // 
            this.AuditoriumBox.FormattingEnabled = true;
            this.AuditoriumBox.Location = new System.Drawing.Point(129, 101);
            this.AuditoriumBox.Name = "AuditoriumBox";
            this.AuditoriumBox.Size = new System.Drawing.Size(121, 24);
            this.AuditoriumBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(141, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Аудитории";
            // 
            // TeachersBox
            // 
            this.TeachersBox.FormattingEnabled = true;
            this.TeachersBox.Location = new System.Drawing.Point(413, 101);
            this.TeachersBox.Name = "TeachersBox";
            this.TeachersBox.Size = new System.Drawing.Size(150, 24);
            this.TeachersBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(410, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Преподователи";
            // 
            // AddAudButton
            // 
            this.AddAudButton.Location = new System.Drawing.Point(281, 92);
            this.AddAudButton.Name = "AddAudButton";
            this.AddAudButton.Size = new System.Drawing.Size(100, 40);
            this.AddAudButton.TabIndex = 7;
            this.AddAudButton.Text = "Добавить";
            this.AddAudButton.UseVisualStyleBackColor = true;
            this.AddAudButton.Click += new System.EventHandler(this.AddAudButton_Click);
            // 
            // AddTeacherButton
            // 
            this.AddTeacherButton.Location = new System.Drawing.Point(578, 92);
            this.AddTeacherButton.Name = "AddTeacherButton";
            this.AddTeacherButton.Size = new System.Drawing.Size(100, 40);
            this.AddTeacherButton.TabIndex = 8;
            this.AddTeacherButton.Text = "Добавить";
            this.AddTeacherButton.UseVisualStyleBackColor = true;
            this.AddTeacherButton.Click += new System.EventHandler(this.AddTeacherButton_Click);
            // 
            // RedTeacherButton
            // 
            this.RedTeacherButton.Location = new System.Drawing.Point(578, 144);
            this.RedTeacherButton.Name = "RedTeacherButton";
            this.RedTeacherButton.Size = new System.Drawing.Size(100, 40);
            this.RedTeacherButton.TabIndex = 9;
            this.RedTeacherButton.Text = "Изменить";
            this.RedTeacherButton.UseVisualStyleBackColor = true;
            this.RedTeacherButton.Click += new System.EventHandler(this.RedTeacherButton_Click);
            // 
            // BookingButton
            // 
            this.BookingButton.Location = new System.Drawing.Point(281, 144);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(100, 40);
            this.BookingButton.TabIndex = 10;
            this.BookingButton.Text = "Бронь";
            this.BookingButton.UseVisualStyleBackColor = true;
            this.BookingButton.Click += new System.EventHandler(this.BookingButton_Click);
            // 
            // ActiveUserLabel
            // 
            this.ActiveUserLabel.AutoSize = true;
            this.ActiveUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActiveUserLabel.Location = new System.Drawing.Point(190, 368);
            this.ActiveUserLabel.Name = "ActiveUserLabel";
            this.ActiveUserLabel.Size = new System.Drawing.Size(0, 24);
            this.ActiveUserLabel.TabIndex = 12;
            // 
            // ExitToAuth
            // 
            this.ExitToAuth.Location = new System.Drawing.Point(578, 368);
            this.ExitToAuth.Name = "ExitToAuth";
            this.ExitToAuth.Size = new System.Drawing.Size(200, 30);
            this.ExitToAuth.TabIndex = 13;
            this.ExitToAuth.Text = "Выйти из профиля";
            this.ExitToAuth.UseVisualStyleBackColor = true;
            this.ExitToAuth.Click += new System.EventHandler(this.ExitToAuth_Click);
            // 
            // ChangeAudButton
            // 
            this.ChangeAudButton.Location = new System.Drawing.Point(281, 196);
            this.ChangeAudButton.Name = "ChangeAudButton";
            this.ChangeAudButton.Size = new System.Drawing.Size(100, 40);
            this.ChangeAudButton.TabIndex = 14;
            this.ChangeAudButton.Text = "Изменить";
            this.ChangeAudButton.UseVisualStyleBackColor = true;
            this.ChangeAudButton.Click += new System.EventHandler(this.ChangeAudButton_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangeAudButton);
            this.Controls.Add(this.ExitToAuth);
            this.Controls.Add(this.ActiveUserLabel);
            this.Controls.Add(this.BookingButton);
            this.Controls.Add(this.RedTeacherButton);
            this.Controls.Add(this.AddTeacherButton);
            this.Controls.Add(this.AddAudButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TeachersBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuditoriumBox);
            this.Controls.Add(this.DeleteTeacherButton);
            this.Controls.Add(this.DeleteAudButton);
            this.Name = "AdminWindow";
            this.Text = "Админское окно";
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteAudButton;
        private System.Windows.Forms.Button DeleteTeacherButton;
        private System.Windows.Forms.ComboBox AuditoriumBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TeachersBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddAudButton;
        private System.Windows.Forms.Button AddTeacherButton;
        private System.Windows.Forms.Button RedTeacherButton;
        private System.Windows.Forms.Button BookingButton;
        private System.Windows.Forms.Label ActiveUserLabel;
        private System.Windows.Forms.Button ExitToAuth;
        private System.Windows.Forms.Button ChangeAudButton;
    }
}