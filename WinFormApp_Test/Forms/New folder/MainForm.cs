using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp_Test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            CTrainRecord TrainRecord = new CTrainRecord();
            this.Controls.Add(TrainRecord);

            CTrainRecord TrainRecord2 = new CTrainRecord();
            this.Controls.Add(TrainRecord2);

            CTrainRecordHeader TrainRecordHeader = new CTrainRecordHeader();
            this.Controls.Add(TrainRecordHeader);
        }
    }
}
