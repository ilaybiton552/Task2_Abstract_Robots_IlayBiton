using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Worker> workers; //אוסף עובדים 
        List<Mission> activeMissions;//אוסף משימות פעילות
        List<RobotSpy> activeRobots; //אוסף רובוטים פעילים

        public MainWindow()
        {
            InitializeComponent();
            workers = CreateWorkers();
            activeRobots = CreateRobots();
            activeMissions = CreateMissions();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Have a robotic day (-:","Good bye",MessageBoxButton.OK);
            this.Close();
        }


        //משימה 1
        // : כתבו פעולה המחזירה אוסף של 6 עובדים 
        //מנכ"ל אחד, 2 מנהלי תפעול ו-3 עובדי תפעול
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון

        private List<Worker> CreateWorkers()
        {
            DateTime start = new DateTime(1970, 1, 1);
            Random rnd = new Random();
            int range = (DateTime.Today - start).Days;
            List<Worker> workers = new List<Worker>
            {
                new GeneralManager("Karl", "123", start.AddDays(rnd.Next(range)), "123", 20000, 40),
                new OperationManager("Mike", "643212471", start.AddDays(rnd.Next(range)), "Mike1234", 23.5, 45, 10),
                new OperationManager("Ronald", "075312415", start.AddDays(rnd.Next(range)), "Ron1234", 25, 40, 2),
                new OperationalWorker("Mickie", "045543415", start.AddDays(rnd.Next(range)), "M1234", 20, 40),
                new OperationalWorker("Seon", "045428635", start.AddDays(rnd.Next(range)), "Se1234", 30, 20),
                new OperationalWorker("Sinus", "045212236", start.AddDays(rnd.Next(range)), "Sinus1234", 29.99, 35)
            };
            return workers;
        }

        //משימה 2
        //כתבו פעולה המחזירה אוסף של 8 רובוטים
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון

        private List<RobotSpy> CreateRobots()
        {
            List<RobotSpy> robots = new List<RobotSpy>()
            {
                new RobotFly(),
                new RobotFly(),
                new RobotFly(),
                new RobotQuad(),
                new RobotQuad(),
                new RobotQuad(),
                new RobotWheels(),
                new RobotWheels()
            };
            return robots;
        }

        //משימה 3
        //כתבו פעולה המחזירה אוסף של 5 משימות
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון       

        private List<Mission> CreateMissions()
        {
            List<Mission> missions = new List<Mission>()
            {
                new Mission(DateTime.Now, "Create robot"),
                new Mission(DateTime.Now, "Remove robot"),
                new Mission(DateTime.Now, "Upgrade robot"),
                new Mission(DateTime.Now, "Save robot"),
                new Mission(DateTime.Now, "Make icecream"),
            };
            return missions;
        }

        //משימה 4
        //login כתבו פעולה המגיבה לללחיצה על כפתור 
        //אם הפרטים לא תואמים לעובד הקיים באוסף העובדים - תוצג הודעה מתאימה
        //WndMain אם כן, יש ליצור מופע של חלון 
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            foreach (Worker worker in workers)
            {
                if (worker.GetIdNumber().Equals(tbxID.Text) && worker.GetPassword().Equals(tbxPassword.Password.ToString()))
                {
                    WndMain main = new WndMain(worker, activeMissions, activeRobots, workers);
                    Close();
                    main.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Worker Not Found", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
