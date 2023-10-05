using App_assignment;
using aussiesky;
using aussiesky.Properties;
using System.IO;
using System.Reflection;

namespace aussiesky
{
    public class Variables
    {
        public static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        internal static string SDbConnection = "Server=219.90.188.204;Port=5433;Database=accounts;User ID=postgres;Password=mysecretpassword";
        internal static string LConnect = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={directory}\\DbTimetable.mdf;Integrated Security=True;Connect Timeout=30";
        internal static string LAccountConnect = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={directory}\\Accounts.mdf;Integrated Security=True;Connect Timeout=30";
        public static bool maxscreen = false;
        public static bool Ssign = false;
        public static bool Lsign = false;
        public static bool tt_loaded = false;

        public static string Loadingchoice;
        public static bool debugging = false;
        public static string daypick;
        public static string title;

        public static int FTimetable;
        public static int FCalendar;
        public static int FCalculator;
        public static int FGame;

        public static string username = "guest";
        public static string password = "Null";
        public static string email = "Null";
        public static string phone = "Null";
        public static string gender = "Null";
        public static string dob = "10/13/2023";

        public static string nerror = "Null";
        public static string ntimetable = "Null";
        public static string ncalendar = "Null";

        public static string fastatus = "Off";
        public static string faemail = "Null";
        public static string secquestion = "Null";
        public static string secanswer = "Null";


    }
}
