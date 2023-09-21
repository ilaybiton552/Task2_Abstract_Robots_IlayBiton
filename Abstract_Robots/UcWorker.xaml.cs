using System;
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
    /// Interaction logic for UcWorker.xaml
    /// </summary>
    public partial class UcWorker : UserControl
    {
        public UcWorker(Worker worker)
        {
            InitializeComponent();
            this.DataContext = worker;

            if (worker is GeneralManager)
            {
                border.Background = Brushes.LightGreen;
                lbRole.Content = "CEO";
            }
            else if (worker is OperationManager)
            {
                border.Background = Brushes.LightSkyBlue;
                lbRole.Content = "Manager";
            }
            else
            {
                lbRole.Content = "Worker";
            }

            if (worker.BirthDate.Month.Equals(DateTime.Now.Month) &&
                worker.BirthDate.Day.Equals(DateTime.Now.Day)) 
            {
                lbBday.Content = "🎂";
            }
        }
    }
}
