using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assign3_database_application
{
    

    static class Forms
    {
        public static menuForm menuSwitchTo = new menuForm();

        public static CityGymMembershipForm memberSwitchTo = new CityGymMembershipForm();

        public static searchForm searchSwitchTo = new searchForm();

        public static fitnessForm2 fitnessSwitchTo = new fitnessForm2();

        public static helpForm helpSwitchTo = new helpForm();
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new menuForm()); // Set Main Menu as entry point for the application
        }
    }
}
