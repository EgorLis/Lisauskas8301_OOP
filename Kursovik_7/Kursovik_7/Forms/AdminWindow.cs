using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovik_7
{
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
            MaximumSize = Size;
            MinimumSize = Size;
            
        }

        public void UpdateTeacherBox()
        {
            this.TeachersBox.Items.Clear();
            for (int i = 0; i < Program.AllTeachers.Count; ++i)
                this.TeachersBox.Items.Add(Program.AllTeachers[i].FullName);
            TeachersBox.Text = "";
            AppSerializer.SerializeTeach(Program.AllTeachers, "TeachSave.bin");
        }

        public void UpdateAudBox()
        {
            this.AuditoriumBox.Items.Clear();
            for (int i = 0; i < Program.AllAuditories.Count; ++i)
                this.AuditoriumBox.Items.Add(Program.AllAuditories[i].AudID);
            AuditoriumBox.Text = "";
            AppSerializer.SerializeAud(Program.AllAuditories, "AudSave.bin");
        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {
            UpdateAudBox();
            UpdateTeacherBox();
        }

        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            Form AddTeacherform = new Form();
            AddTeacherform.MaximumSize = AddTeacherform.Size;
            AddTeacherform.MinimumSize = AddTeacherform.Size;
            AddTeacherform.Show();
            AddTeacherform.Text = "Добавление преподавателя";
            Button AddButton = new Button();
            AddButton.Text = "Добавить";
            AddButton.Size = new Size(100, 40);
            AddButton.Location = new Point(100, 200);
            Label LogLabel = new Label();
            Label PassLabel = new Label();
            TextBox LogBox = new TextBox();
            TextBox PassBox = new TextBox();
            LogLabel.Text = "ФИО";
            PassLabel.Text = "Пароль";
            LogLabel.Location = new Point(30, 50);
            PassLabel.Location = new Point(30, 100);
            LogBox.Size = new Size(100, 30);
            LogBox.Location = new Point(130, 50);
            PassBox.Size = new Size(100, 30);
            PassBox.Location = new Point(130, 100);
            AddTeacherform.Controls.Add(AddButton);
            AddTeacherform.Controls.Add(LogLabel);
            AddTeacherform.Controls.Add(PassLabel);
            AddTeacherform.Controls.Add(LogBox);
            AddTeacherform.Controls.Add(PassBox);
            AddButton.Click += (Sender, args) =>
            {
                for (int i = 0; i < Program.AllTeachers.Count; i++)
                    if (LogBox.Text == Program.AllTeachers[i].FullName &&
                    PassBox.Text == Program.AllTeachers[i].Password)
                    {
                        MessageBox.Show(
                        "Пользователь с таким паролем и именем существует",
                        "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                        return;
                    }
                if (LogBox.Text.Length < 2 || PassBox.Text.Length < 6)
                {
                    MessageBox.Show(
                    "ФИО должно быть больше 1 символа, пароль больше 5 символов",
                    "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }
                else
                {
                    Program.AllTeachers.Add(new Teacher(LogBox.Text, PassBox.Text));
                    UpdateTeacherBox();
                    AddTeacherform.Close();
                }
            };
        }

        private void RedTeacherButton_Click(object sender, EventArgs e)
        {
            if (TeachersBox.SelectedIndex >= 0)
            {
                Form ChamgeTeacherform = new Form();
                ChamgeTeacherform.MaximumSize = ChamgeTeacherform.Size;
                ChamgeTeacherform.MinimumSize = ChamgeTeacherform.Size;
                ChamgeTeacherform.Show();
                ChamgeTeacherform.Text = "Редактирование преподавателя";
                Button AddButton = new Button();
                AddButton.Text = "Изменить";
                AddButton.Size = new Size(100, 40);
                AddButton.Location = new Point(100, 200);
                Label LogLabel = new Label();
                Label PassLabel = new Label();
                TextBox LogBox = new TextBox();
                TextBox PassBox = new TextBox();
                LogLabel.Text = "ФИО";
                PassLabel.Text = "Пароль";
                LogLabel.Location = new Point(30, 50);
                PassLabel.Location = new Point(30, 100);
                LogBox.Size = new Size(100, 30);
                LogBox.Location = new Point(130, 50);
                LogBox.Text = Program.AllTeachers[TeachersBox.SelectedIndex].FullName;
                PassBox.Text = Program.AllTeachers[TeachersBox.SelectedIndex].Password;
                PassBox.Size = new Size(100, 30);
                PassBox.Location = new Point(130, 100);
                ChamgeTeacherform.Controls.Add(AddButton);
                ChamgeTeacherform.Controls.Add(LogLabel);
                ChamgeTeacherform.Controls.Add(PassLabel);
                ChamgeTeacherform.Controls.Add(LogBox);
                ChamgeTeacherform.Controls.Add(PassBox);
                AddButton.Click += (Sender, args) =>
                {

                    for (int i = 0; i < Program.AllTeachers.Count; i++)
                        if (LogBox.Text == Program.AllTeachers[i].FullName &&
                        PassBox.Text == Program.AllTeachers[i].Password)
                        {
                            MessageBox.Show(
                            "Пользователь с таким паролем и именем существует",
                            "Ошибка", MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                            return;
                        }
                    if (LogBox.Text.Length < 2 || PassBox.Text.Length < 6)
                    {
                        MessageBox.Show(
                        "ФИО должно быть больше 1 символа, пароль больше 5 символов",
                        "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                        return;
                    }
                    else
                    {
                        Program.AllTeachers[TeachersBox.SelectedIndex].FullName= LogBox.Text;
                        Program.AllTeachers[TeachersBox.SelectedIndex].Password = PassBox.Text;
                        UpdateTeacherBox();
                        ChamgeTeacherform.Close();
                    }
                    
                    
                };
            }
        }
        
        private void DeleteTeacherButton_Click(object sender, EventArgs e)
        {
            if (TeachersBox.SelectedIndex >= 0)
            {
                Program.AllTeachers.RemoveAt(TeachersBox.SelectedIndex);
                MessageBox.Show(
                        "Преподаватель успешно удален",
                        "Удаление", MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                TeachersBox.Text = "";
            }
            UpdateTeacherBox();
        }

        private void AddAudButton_Click(object sender, EventArgs e)
        {
            Form AddAudform = new Form();
            AddAudform.MaximumSize = AddAudform.Size;
            AddAudform.MinimumSize = AddAudform.Size;
            AddAudform.Show();
            AddAudform.Text = "Добавление аудитории";
            Button AddButton = new Button();
            AddButton.Text = "Добавить";
            AddButton.Size = new Size(100, 40);
            AddButton.Location = new Point(100, 200);
            Label AudLabel = new Label();
            TextBox AudBox = new TextBox();
            AudLabel.Text = "Аудитория";
            AudLabel.Location = new Point(30, 50);
            AudBox.Size = new Size(100, 30);
            AudBox.Location = new Point(130, 50);
            AddAudform.Controls.Add(AddButton);
            AddAudform.Controls.Add(AudLabel);
            AddAudform.Controls.Add(AudBox);
            AddButton.Click += (Sender, args) =>
            {
                for (int i = 0; i < Program.AllAuditories.Count; i++)
                    if (AudBox.Text == Program.AllAuditories[i].AudID)
                    {
                        MessageBox.Show(
                        "Такая аудитория уже существует",
                        "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                        return;
                    }
                if (AudBox.Text.Length < 2 )
                {
                    MessageBox.Show(
                    "Название аудитории должно состоять минимум из 2 символов",
                    "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }
                else
                {
                    Program.AllAuditories.Add(new Auditorium(AudBox.Text));
                    UpdateAudBox();
                    AddAudform.Close();
                }
            };
        }

        private void BookingButton_Click(object sender, EventArgs e)
        {
            if (AuditoriumBox.SelectedIndex >= 0)
            {
                Form Bookingform = new Form();
                Bookingform.Size = new Size(650, 650);
                Bookingform.MaximumSize = Bookingform.Size;
                Bookingform.MinimumSize = Bookingform.Size;
                Bookingform.Show();
                Label CellHolder = new Label();
                DataGridView AudGrid = new DataGridView();
                AudGrid.Columns.Add("Monday", "Пн");
                AudGrid.Columns.Add("Tuesday", "Вт");
                AudGrid.Columns.Add("Wednesday", "Ср");
                AudGrid.Columns.Add("Thursday", "Чт");
                AudGrid.Columns.Add("Friday", "Пт");
                AudGrid.Columns.Add("Saturday", "Сб");
                string[] row = { "8:00", "8:00", "8:00", "8:00", "8:00", "8:00" };
                AudGrid.Rows.Add(row);
                row = new string[] { "9:40", "9:40", "9:40", "9:40", "9:40", "9:40" };
                AudGrid.Rows.Add(row);
                row = new string[] { "11:35", "11:35", "11:35", "11:35", "11:35", "11:35" };
                AudGrid.Rows.Add(row);
                row = new string[] { "13:45", "13:45", "13:45", "13:45", "13:45", "13:45" };
                AudGrid.Rows.Add(row);
                row = new string[] { "15:40", "15:40", "15:40", "15:40", "15:40", "15:40" };
                AudGrid.Rows.Add(row);
                row = new string[] { "17:20", "17:20", "17:20", "17:20", "17:20", "17:20" };
                AudGrid.Rows.Add(row);
                AudGrid.Location = new Point(150, 100);
                AudGrid.Size = new Size(362, 182 + AudGrid.ColumnHeadersHeight);
                AudGrid.ScrollBars = ScrollBars.None;
                AudGrid.AllowDrop = false;
                AudGrid.AllowUserToResizeColumns = false;
                AudGrid.AllowUserToResizeRows = false;
                AudGrid.AllowUserToAddRows = false;
                AudGrid.RowHeadersVisible = false;
                AudGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                DataGridViewCellStyle ScheduleCellStyle = new DataGridViewCellStyle();
                DataGridViewCellStyle TeacherCellStyle = new DataGridViewCellStyle();
                DataGridViewCellStyle DefaultCellStyle = new DataGridViewCellStyle();
                ScheduleCellStyle.BackColor = Color.Red;
                TeacherCellStyle.BackColor = Color.Brown;
                DefaultCellStyle.BackColor = Color.White;
                for (int i = 0; i < 6; i++)
                {
                    AudGrid.Columns[i].Width = 60;
                    AudGrid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    AudGrid.Rows[i].ReadOnly = true;
                    AudGrid.Rows[i].Height = 30;
                }
                for (int i = 0; i < 6; i++)
                    for (int j = 0; j < 6; j++)
                    {
                        if (Program.AllAuditories[AuditoriumBox.SelectedIndex][i, j] == "schedule")
                            AudGrid.Rows[i].Cells[j].Style = ScheduleCellStyle;
                        else if (Program.AllAuditories[AuditoriumBox.SelectedIndex][i, j] != "")
                            AudGrid.Rows[i].Cells[j].Style = TeacherCellStyle;
                    }
                Bookingform.Text = "Бронирование";
                CellHolder.Location = new Point(50, 400);
                Font font = new Font(CellHolder.Font.FontFamily, 10);
                CellHolder.Font = font;
                CellHolder.Text = "";
                CellHolder.Size = new Size(500, 30);
                Button BookButton = new Button();
                BookButton.Text = "Забронировать";
                BookButton.Size = new Size(200, 40);
                BookButton.Location = new Point(50, 500);
                Button UnBookButton = new Button();
                UnBookButton.Text = "Cнять бронирование";
                UnBookButton.Size = new Size(200, 40);
                UnBookButton.Location = new Point(300, 500);
                Label AudLabel = new Label();
                AudLabel.Font = font;
                AudLabel.Text = "Аудитория:";
                AudLabel.Text += Program.AllAuditories[AuditoriumBox.SelectedIndex].AudID;
                AudLabel.Location = new Point(30, 50);
                AudLabel.Size = new Size(300, 30);
                Bookingform.Controls.Add(BookButton);
                Bookingform.Controls.Add(UnBookButton);
                Bookingform.Controls.Add(AudLabel);
                Bookingform.Controls.Add(AudGrid);
                Bookingform.Controls.Add(CellHolder);
                AudGrid.ClearSelection();
                AudGrid.SelectionChanged += (Sender, args) =>
                {
                    if (AudGrid.SelectedCells.Count == 1)
                    {
                        if (Program.AllAuditories[AuditoriumBox.SelectedIndex]
                        [AudGrid.SelectedCells[0].RowIndex, AudGrid.SelectedCells[0].ColumnIndex] == "schedule")
                            CellHolder.Text = "Забронировано по расписанию";
                        else if (Program.AllAuditories[AuditoriumBox.SelectedIndex]
                        [AudGrid.SelectedCells[0].RowIndex, AudGrid.SelectedCells[0].ColumnIndex] != "")
                        {
                            CellHolder.Text = "Забронировано преподавателем: ";
                            CellHolder.Text += Program.AllTeachers.Find(x => x.GUID ==
                            Program.AllAuditories[AuditoriumBox.SelectedIndex]
                            [AudGrid.SelectedCells[0].RowIndex, AudGrid.SelectedCells[0].ColumnIndex]).FullName;
                        }
                        else
                            CellHolder.Text = "Свободно";
                    }
                    else
                    {
                        CellHolder.Text = "";
                    }
                };
                AudGrid.CellStyleChanged += (Sender, args) =>
                {
                    if (AudGrid.SelectedCells.Count == 1)
                    {
                        if (Program.AllAuditories[AuditoriumBox.SelectedIndex]
                        [AudGrid.SelectedCells[0].RowIndex, AudGrid.SelectedCells[0].ColumnIndex] == "schedule")
                            CellHolder.Text = "Забронировано по расписанию";
                        else if (Program.AllAuditories[AuditoriumBox.SelectedIndex]
                        [AudGrid.SelectedCells[0].RowIndex, AudGrid.SelectedCells[0].ColumnIndex] != "")
                        {
                            CellHolder.Text = "Забронировано преподавателем: ";
                            CellHolder.Text += Program.AllTeachers.Find(x => x.GUID ==
                            Program.AllAuditories[AuditoriumBox.SelectedIndex]
                            [AudGrid.SelectedCells[0].RowIndex, AudGrid.SelectedCells[0].ColumnIndex]).FullName;
                        }
                        else
                            CellHolder.Text = "Свободно";
                    }
                    else
                    {
                        CellHolder.Text = "";
                    }
                };

                BookButton.Click += (Sender, args) =>
                {
                    if (AudGrid.SelectedCells.Count > 0)
                    {
                        foreach (DataGridViewCell cell in AudGrid.SelectedCells)
                        {
                            if (Program.AllAuditories[AuditoriumBox.SelectedIndex][cell.RowIndex, cell.ColumnIndex] == "")
                            {
                                Program.AllAuditories[AuditoriumBox.SelectedIndex][cell.RowIndex, cell.ColumnIndex] = "schedule";
                                cell.Style = ScheduleCellStyle;
                            }
                        }
                    }
                    AppSerializer.SerializeAud(Program.AllAuditories, "AudSave.bin");
                    AudGrid.ClearSelection();
                };

                UnBookButton.Click += (Sender, args) =>
                {
                    if (AudGrid.SelectedCells.Count > 0)
                    {
                        foreach (DataGridViewCell cell in AudGrid.SelectedCells)
                        {
                            if (Program.AllAuditories[AuditoriumBox.SelectedIndex][cell.RowIndex, cell.ColumnIndex] != "")
                            {
                                Program.AllAuditories[AuditoriumBox.SelectedIndex][cell.RowIndex, cell.ColumnIndex] = "";
                                cell.Style = DefaultCellStyle;
                            }
                        }
                    }
                    AppSerializer.SerializeAud(Program.AllAuditories, "AudSave.bin");
                    AudGrid.ClearSelection();
                };
            }
            
        }

        private void DeleteAudButton_Click(object sender, EventArgs e)
        {
            if (AuditoriumBox.SelectedIndex >= 0)
            {
                Program.AllAuditories.RemoveAt(AuditoriumBox.SelectedIndex);
                MessageBox.Show(
                        "Аудитория успешно удалена",
                        "Удаление", MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                AuditoriumBox.Text = "";
            }
            UpdateAudBox();
        }

        private void ExitToAuth_Click(object sender, EventArgs e)
        {
            Program.LogOff = true;
            Close();
        }

        private void ChangeAudButton_Click(object sender, EventArgs e)
        {
            if(AuditoriumBox.SelectedIndex>=0)
            {
                Form ChangeAudform = new Form();
                ChangeAudform.MaximumSize = ChangeAudform.Size;
                ChangeAudform.MinimumSize = ChangeAudform.Size;
                ChangeAudform.Show();
                ChangeAudform.Text = "Изменение аудитории";
                Button AddButton = new Button();
                AddButton.Text = "Изменить";
                AddButton.Size = new Size(100, 40);
                AddButton.Location = new Point(100, 200);
                Label AudLabel = new Label();
                TextBox AudBox = new TextBox();
                AudBox.Text = Program.AllAuditories[AuditoriumBox.SelectedIndex].AudID;
                AudLabel.Text = "Аудитория";
                AudLabel.Location = new Point(30, 50);
                AudBox.Size = new Size(100, 30);
                AudBox.Location = new Point(130, 50);
                ChangeAudform.Controls.Add(AddButton);
                ChangeAudform.Controls.Add(AudLabel);
                ChangeAudform.Controls.Add(AudBox);
                AddButton.Click += (Sender, args) =>
                {
                    for (int i = 0; i < Program.AllAuditories.Count; i++)
                        if (AudBox.Text == Program.AllAuditories[i].AudID)
                        {
                            MessageBox.Show(
                            "Такая аудитория уже существует",
                            "Ошибка", MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                            return;
                        }
                    if (AudBox.Text.Length < 2)
                    {
                        MessageBox.Show(
                        "Название аудитории должно состоять минимум из 2 символов",
                        "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                        return;
                    }
                    else
                    {
                        Program.AllAuditories[AuditoriumBox.SelectedIndex].AudID = AudBox.Text;
                        UpdateAudBox();
                        ChangeAudform.Close();
                    }
                };
            }
            
            
        }

        
    }
}
