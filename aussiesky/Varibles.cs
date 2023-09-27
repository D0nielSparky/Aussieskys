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
        public static bool maxscreen = false;
        public static bool sign = false;
        public static string username = "guest";
        public static bool tt_loaded = false;

        public static string Loadingchoice;
        public static bool debugging = true;
        public static string daypick;
        public static string title;

        public static int FTimetable;
        public static int FCalendar;
        public static int FCalculator;
        public static int FGame;

    }
}
