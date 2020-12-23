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
    public partial class TeacherWindow : Form
    {
        public TeacherWindow()
        {
            InitializeComponent();
            MaximumSize = Size;
            MinimumSize = Size;
        }

        public void UpdateAudBox()
        {
            this.AuditoriumBox.Items.Clear();
            for (int i = 0; i < Program.AllAuditories.Count; ++i)
                this.AuditoriumBox.Items.Add(Program.AllAuditories[i].AudID);
            AuditoriumBox.Text = "";
            AppSerializer.SerializeAud(Program.AllAuditories, "AudSave.bin");
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
                        [AudGrid.SelectedCells[0].RowIndex, AudGrid.SelectedCells[0].ColumnIndex] == Program.ActiveUser.GUID)
                            CellHolder.Text = "Забронировано вами";
                        else
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
                        [AudGrid.SelectedCells[0].RowIndex, AudGrid.SelectedCells[0].ColumnIndex] == Program.ActiveUser.GUID)
                            CellHolder.Text = "Забронировано вами";
                        else
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
                                Program.AllAuditories[AuditoriumBox.SelectedIndex][cell.RowIndex, cell.ColumnIndex] = Program.ActiveUser.GUID;
                                cell.Style = TeacherCellStyle;
                            }
                        }
                    }
                    AudGrid.ClearSelection();
                    AppSerializer.SerializeAud(Program.AllAuditories, "AudSave.bin");
                };

                UnBookButton.Click += (Sender, args) =>
                {
                    if (AudGrid.SelectedCells.Count > 0)
                    {
                        foreach (DataGridViewCell cell in AudGrid.SelectedCells)
                        {
                            if (Program.AllAuditories[AuditoriumBox.SelectedIndex][cell.RowIndex, cell.ColumnIndex] == Program.ActiveUser.GUID)
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

        private void TeacherWindow_Load(object sender, EventArgs e)
        {
            UpdateAudBox();
            Label UserLabel = new Label();
            Font font = new Font(UserLabel.Font.FontFamily, 10);
            UserLabel.Font = font;
            UserLabel.Text = "Пользователь: ";
            UserLabel.Text += Program.ActiveUser.FullName;
            UserLabel.Size = new Size(300, 30);
            UserLabel.Location = new Point(50, 280);
            Controls.Add(UserLabel);
        }

        private void ExitToAuth_Click(object sender, EventArgs e)
        {
            Program.LogOff = true;
            Close();
        }

        private void OneDayButton_Click(object sender, EventArgs e)
        {
            if(OneDayBox.SelectedIndex >=0)
            {
                DataGridViewCellStyle ScheduleCellStyle = new DataGridViewCellStyle();
                DataGridViewCellStyle TeacherCellStyle = new DataGridViewCellStyle();
                DataGridViewCellStyle DefaultCellStyle = new DataGridViewCellStyle();
                ScheduleCellStyle.BackColor = Color.Red;
                TeacherCellStyle.BackColor = Color.Brown;
                DefaultCellStyle.BackColor = Color.White;
                Controls.RemoveByKey("AudGrid");
                DataGridView AudGrid = new DataGridView();
                AudGrid.Name = "AudGrid";
                AudGrid.Columns.Add("day", OneDayBox.SelectedItem.ToString());
                string row;
                for (int i=0;i<Program.AllAuditories.Count;i++)
                {
                    row = Program.AllAuditories[i].AudID ;
                    AudGrid.Rows.Add(row);
                    row =  "8:00";
                    AudGrid.Rows.Add(row);
                    row ="9:40";
                    AudGrid.Rows.Add(row);
                    row = "11:35";
                    AudGrid.Rows.Add(row);
                    row = "13:45";
                    AudGrid.Rows.Add(row);
                    row = "15:40" ;
                    AudGrid.Rows.Add(row);
                    row = "17:20" ;
                    AudGrid.Rows.Add(row);
                    AudGrid.Rows[AudGrid.Rows.Count - 8].Cells[0].Style.ForeColor = Color.BlueViolet;
                    Font font = new Font(Font.FontFamily, 10);
                    AudGrid.Rows[AudGrid.Rows.Count - 8].Cells[0].Style.Font = font;
                    AudGrid.Rows[AudGrid.Rows.Count - 8].ReadOnly = true;
                    for (int j=0;j<6;j++)
                    {
                        AudGrid.Rows[AudGrid.Rows.Count - 7 + j].ReadOnly = true;
                        if (Program.AllAuditories[i][j, OneDayBox.SelectedIndex] == "schedule")
                            AudGrid.Rows[AudGrid.Rows.Count - 7 + j].Cells[0].Style = ScheduleCellStyle;
                        else if (Program.AllAuditories[i][j, OneDayBox.SelectedIndex] != "")
                            AudGrid.Rows[AudGrid.Rows.Count - 7 + j].Cells[0].Style = TeacherCellStyle;
                    }
                }
                AudGrid.Location = new Point(400, 70);
                AudGrid.Size = new Size(132, 182 + AudGrid.ColumnHeadersHeight);
                AudGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                AudGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                AudGrid.ScrollBars = ScrollBars.Vertical;
                AudGrid.AllowDrop = false;
                AudGrid.AllowUserToResizeColumns = false;
                AudGrid.AllowUserToResizeRows = false;
                AudGrid.AllowUserToAddRows = false;
                AudGrid.RowHeadersVisible = false;
                AudGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                AudGrid.Columns[0].Width = 120;
                AudGrid.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                AudGrid.Rows[0].ReadOnly = true;
                AudGrid.Rows[0].Height = 30;
                AudGrid.SelectionChanged += (Sender, args) =>
                {
                    AudGrid.ClearSelection();
                };
                Controls.Add(AudGrid);
            }
            
        }
    }
}
