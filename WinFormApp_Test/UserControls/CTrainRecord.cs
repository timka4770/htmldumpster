using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp_Test
{
    class CTrainRecord : TableLayoutPanel
    {
        public ComboBox TrainStatField;
        public TextBox TrainNumField;
        public TextBox TrainRouteField;
        public DateTimePicker TrainArrivalField;
        public DateTimePicker TrainDepartField;
        public TextBox TrainTrackField;
        public TextBox TrainNotesField;
        public Button TrainEditBtn;
        public Button TrainRemoveBtn;

        public CTrainRecord()
        {
            // Инициализация самой формы(!sic)
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new Padding(0);
            this.Padding = new Padding(3);
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

            // Инициализация компонентов формы
            InitializeControls();
        }

        /*
            Инициализация компонентов формы
        */
        private void InitializeControls()
        {
            this.TrainStatField = new ComboBox();
            this.TrainNumField = new TextBox();
            this.TrainRouteField = new TextBox();
            this.TrainArrivalField = new DateTimePicker();
            this.TrainDepartField = new DateTimePicker();
            this.TrainTrackField = new TextBox();
            this.TrainNotesField = new TextBox();
            this.TrainEditBtn = new Button();
            this.TrainRemoveBtn = new Button();

            // TrainStatField
            this.TrainStatField.Dock = DockStyle.Fill;
            this.TrainStatField.FormattingEnabled = true;
            this.TrainStatField.Items.AddRange(new object[] {
                    "Ожидается",
                    "Задерживается",
                    "Прибыл",
                    "Отправлен",
                    "Отменён"
                });
            this.TrainStatField.Text = "(Статус Поезда)";
            this.Controls.Add(this.TrainStatField, 0, 0);

            // TrainNumField
            this.TrainNumField.Dock = DockStyle.Fill;
            this.Controls.Add(this.TrainNumField, 1, 0);

            // TrainRouteField
            this.TrainRouteField.Dock = DockStyle.Fill;
            this.Controls.Add(this.TrainRouteField, 2, 0);

            // TrainArrivalField
            this.TrainArrivalField.Dock = DockStyle.Fill;
            this.TrainArrivalField.Format = DateTimePickerFormat.Time;
            this.TrainArrivalField.ShowUpDown = true;
            this.Controls.Add(this.TrainArrivalField, 3, 0);

            // TrainDepartField
            this.TrainDepartField.Dock = DockStyle.Fill;
            this.TrainDepartField.Format = DateTimePickerFormat.Time;
            this.TrainDepartField.ShowUpDown = true;
            this.Controls.Add(this.TrainDepartField, 4, 0);

            // TrainTrackField
            this.TrainTrackField.Dock = DockStyle.Fill;
            this.Controls.Add(this.TrainTrackField, 5, 0);

            // TrainNotesField
            this.TrainNotesField.Dock = DockStyle.Fill;
            this.Controls.Add(this.TrainNotesField, 6, 0);

            // TrainEditBtn
            this.TrainEditBtn.Dock = DockStyle.Fill;
            this.TrainEditBtn.UseVisualStyleBackColor = true;
            this.TrainEditBtn.Text = "Изменить";
            this.Controls.Add(this.TrainEditBtn, 7, 0);

            // TrainRemoveBtn
            this.TrainRemoveBtn.Dock = DockStyle.Fill;
            this.TrainRemoveBtn.UseVisualStyleBackColor = true;
            this.TrainRemoveBtn.Text = "Удалить";
            this.Controls.Add(this.TrainRemoveBtn, 8, 0);
        }
    }
}
