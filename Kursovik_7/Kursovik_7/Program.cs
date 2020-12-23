using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovik_7
{
    static class Program
    {
        public static User ActiveUser;

        public static List<Teacher> AllTeachers;
        public static List<Auditorium> AllAuditories;
        public static bool LogOff = true;
        public static Admin admin;
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            admin = new Admin();
            AllAuditories = new List<Auditorium>();
            AllTeachers = new List<Teacher>();
            AllAuditories = AppSerializer.DeserializeAud("AudSave.bin");
            AllTeachers = AppSerializer.DeserializeTeach("TeachSave.bin");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while(LogOff == true)
            {
                LogOff = false;
                Application.Run(new AuthWindow());
                if (ActiveUser.GetType() == typeof(Admin))
                    Application.Run(new AdminWindow());
                else if (ActiveUser.GetType() == typeof(Teacher))
                    Application.Run(new TeacherWindow());
            }
        }
    }
}
