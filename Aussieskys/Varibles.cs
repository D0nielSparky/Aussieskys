﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aussieskys
{
    public class Variable
    {
        internal static string SDbConnection = "Server=219.90.188.204;Port=5433;Database=accounts;User ID=postgres;Password=mysecretpassword";
        internal static string LDbConnection = "Server = localhost; Port = 5433; Database = postgres; User Id = postgres; Password = mysecretpassword;";
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