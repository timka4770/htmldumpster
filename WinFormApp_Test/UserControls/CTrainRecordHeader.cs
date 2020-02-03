using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp_Test
{
    class CTrainRecordHeader : TableLayoutPanel
    {
        private Label TrainStatLbl;
        private Label TrainNumLbl;
        private Label TrainRouteLbl;
        private Label TrainArrivalLbl;
        private Label TrainDepartLbl;
        private Label TrainTrackLbl;
        private Label TrainNotesLbl;
        private Label TrainActionsLbl;

        public CTrainRecordHeader()
        {
            // Инициализация самой формы(!sic)
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new Padding(0);
            this.Padding = new Padding(3, 6, 3, 6);
            this.Dock = DockStyle.Top;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,  60F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,  40F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            // Надо указать количество столбцов, иначе всё съебётся в сторону
            this.ColumnCount = 9;

            // Инициализация компонентов формы
            InitializeControls();
        }

        /*
            Инициализация компонентов формы
        */
        private void InitializeControls()
        {
            this.TrainStatLbl = new Label();
            this.TrainNumLbl = new Label();
            this.TrainRouteLbl = new Label();
            this.TrainArrivalLbl = new Label();
            this.TrainDepartLbl = new Label();
            this.TrainTrackLbl = new Label();
            this.TrainNotesLbl = new Label();
            this.TrainActionsLbl = new Label();

            // TrainStatLbl
            this.TrainStatLbl.Dock = DockStyle.Fill;
            this.TrainStatLbl.AutoSize = true;
            this.TrainStatLbl.Text = "Статус";
            this.Controls.Add(this.TrainStatLbl, 0, 0);

            // TrainNumLbl
            this.TrainNumLbl.Dock = DockStyle.Fill;
            this.TrainNumLbl.AutoSize = true;
            this.TrainNumLbl.Text = "№ Поезда";
            this.Controls.Add(this.TrainNumLbl, 1, 0);

            // TrainRouteLbl
            this.TrainRouteLbl.Dock = DockStyle.Fill;
            this.TrainRouteLbl.AutoSize = true;
            this.TrainRouteLbl.Text = "Маршрут";
            this.Controls.Add(this.TrainRouteLbl, 2, 0);

            // TrainArrivalLbl
            this.TrainArrivalLbl.Dock = DockStyle.Fill;
            this.TrainArrivalLbl.AutoSize = true;
            this.TrainArrivalLbl.Text = "Прибытие";
            this.Controls.Add(this.TrainArrivalLbl, 3, 0);

            // TrainDepartLbl
            this.TrainDepartLbl.Dock = DockStyle.Fill;
            this.TrainDepartLbl.AutoSize = true;
            this.TrainDepartLbl.Text = "Отправление";
            this.Controls.Add(this.TrainDepartLbl, 4, 0);

            // TrainTrackLbl
            this.TrainTrackLbl.Dock = DockStyle.Fill;
            this.TrainTrackLbl.AutoSize = true;
            this.TrainTrackLbl.Text = "Путь";
            this.Controls.Add(this.TrainTrackLbl, 5, 0);

            // TrainNotesLbl
            this.TrainNotesLbl.Dock = DockStyle.Fill;
            this.TrainNotesLbl.AutoSize = true;
            this.TrainNotesLbl.Text = "Примечания";
            this.Controls.Add(this.TrainNotesLbl, 6, 0);

            // TrainActionsLbl
            this.TrainActionsLbl.Dock = DockStyle.Fill;
            this.TrainActionsLbl.AutoSize = true;
            this.TrainActionsLbl.Text = "Действия";
            this.Controls.Add(this.TrainActionsLbl, 7, 0);
        }
    }
}
