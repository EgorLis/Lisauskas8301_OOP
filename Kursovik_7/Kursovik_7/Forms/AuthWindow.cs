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
    public partial class AuthWindow : Form
    {
        public AuthWindow()
        {
            InitializeComponent();
            MaximumSize = Size;
            MinimumSize = Size;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(LoginBox.Text == Program.admin.FullName && PassBox.Text == Program.admin.Password)
            {
                Program.ActiveUser = Program.admin;
                Close();
            }
            else
            {
                for(int i=0;i<Program.AllTeachers.Count;++i)
                {
                    if (LoginBox.Text == Program.AllTeachers[i].FullName && PassBox.Text == Program.AllTeachers[i].Password)
                    { 
                        Program.ActiveUser = Program.AllTeachers[i];
                        Close();
                        break;
                    }
                }
                if(Program.ActiveUser==null)
                {
                    MessageBox.Show("Введен неверный логин или пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AuthWindow_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
