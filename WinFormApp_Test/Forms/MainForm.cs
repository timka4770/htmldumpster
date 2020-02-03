using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace WinFormApp_Test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            string[] routes = Properties.Resources.Routes.Split(
                new[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None
            );

            foreach (string route in routes)
            {
                Console.WriteLine(string.Concat("- ", route));

                string[] info = route.Split(',');

                CTrainRecord TrainRecord = new CTrainRecord();
                TrainRecord.TrainStatField.SelectedIndex = int.Parse(info[0]);
                TrainRecord.TrainNumField.Text = info[1];
                TrainRecord.TrainRouteField.Text = info[2];
                TrainRecord.TrainArrivalField.Value = DateTime.Parse(info[3]);
                TrainRecord.TrainDepartField.Value = DateTime.Parse(info[4]);
                TrainRecord.TrainTrackField.Text = info[5];

                this.panel1.Controls.Add(TrainRecord);
            }

            CTrainRecordHeader TrainRecordHeader = new CTrainRecordHeader();
            this.panel1.Controls.Add(TrainRecordHeader);
        }
    }
}
