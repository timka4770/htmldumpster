namespace WinFormApp_Test.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TrainRecord = new System.Windows.Forms.TableLayoutPanel();
            this.TrainDepartField = new System.Windows.Forms.DateTimePicker();
            this.TrainStatField = new System.Windows.Forms.ComboBox();
            this.TrainNumField = new System.Windows.Forms.TextBox();
            this.TrainRouteField = new System.Windows.Forms.TextBox();
            this.TrainArrivalField = new System.Windows.Forms.DateTimePicker();
            this.TrainTrackField = new System.Windows.Forms.TextBox();
            this.TrainNotesField = new System.Windows.Forms.TextBox();
            this.TrainEditBtn = new System.Windows.Forms.Button();
            this.TrainRemoveBtn = new System.Windows.Forms.Button();
            this.TrainRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrainRecord
            // 
            this.TrainRecord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TrainRecord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TrainRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.TrainRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.TrainRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TrainRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TrainRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TrainRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TrainRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.TrainRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.TrainRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.TrainRecord.Controls.Add(this.TrainDepartField, 4, 0);
            this.TrainRecord.Controls.Add(this.TrainStatField, 0, 0);
            this.TrainRecord.Controls.Add(this.TrainNumField, 1, 0);
            this.TrainRecord.Controls.Add(this.TrainRouteField, 2, 0);
            this.TrainRecord.Controls.Add(this.TrainArrivalField, 3, 0);
            this.TrainRecord.Controls.Add(this.TrainTrackField, 5, 0);
            this.TrainRecord.Controls.Add(this.TrainNotesField, 6, 0);
            this.TrainRecord.Controls.Add(this.TrainEditBtn, 7, 0);
            this.TrainRecord.Controls.Add(this.TrainRemoveBtn, 8, 0);
            this.TrainRecord.Location = new System.Drawing.Point(8, 8);
            this.TrainRecord.Margin = new System.Windows.Forms.Padding(0);
            this.TrainRecord.Name = "TrainRecord";
            this.TrainRecord.Padding = new System.Windows.Forms.Padding(3);
            this.TrainRecord.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TrainRecord.Size = new System.Drawing.Size(938, 35);
            this.TrainRecord.TabIndex = 2;
            // 
            // TrainDepartField
            // 
            this.TrainDepartField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrainDepartField.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TrainDepartField.Location = new System.Drawing.Point(458, 6);
            this.TrainDepartField.Name = "TrainDepartField";
            this.TrainDepartField.ShowUpDown = true;
            this.TrainDepartField.Size = new System.Drawing.Size(90, 20);
            this.TrainDepartField.TabIndex = 4;
            // 
            // TrainStatField
            // 
            this.TrainStatField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrainStatField.FormattingEnabled = true;
            this.TrainStatField.Items.AddRange(new object[] {
            "Ожидается",
            "Задерживается",
            "Прибыл",
            "Отправлен",
            "Отменён"});
            this.TrainStatField.Location = new System.Drawing.Point(6, 6);
            this.TrainStatField.Name = "TrainStatField";
            this.TrainStatField.Size = new System.Drawing.Size(122, 21);
            this.TrainStatField.TabIndex = 0;
            this.TrainStatField.Text = "(Статус Поезда)";
            // 
            // TrainNumField
            // 
            this.TrainNumField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrainNumField.Location = new System.Drawing.Point(134, 6);
            this.TrainNumField.Name = "TrainNumField";
            this.TrainNumField.Size = new System.Drawing.Size(58, 20);
            this.TrainNumField.TabIndex = 1;
            // 
            // TrainRouteField
            // 
            this.TrainRouteField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrainRouteField.Location = new System.Drawing.Point(198, 6);
            this.TrainRouteField.Name = "TrainRouteField";
            this.TrainRouteField.Size = new System.Drawing.Size(158, 20);
            this.TrainRouteField.TabIndex = 2;
            // 
            // TrainArrivalField
            // 
            this.TrainArrivalField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrainArrivalField.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TrainArrivalField.Location = new System.Drawing.Point(362, 6);
            this.TrainArrivalField.Name = "TrainArrivalField";
            this.TrainArrivalField.ShowUpDown = true;
            this.TrainArrivalField.Size = new System.Drawing.Size(90, 20);
            this.TrainArrivalField.TabIndex = 3;
            // 
            // TrainTrackField
            // 
            this.TrainTrackField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrainTrackField.Location = new System.Drawing.Point(554, 6);
            this.TrainTrackField.Name = "TrainTrackField";
            this.TrainTrackField.Size = new System.Drawing.Size(42, 20);
            this.TrainTrackField.TabIndex = 5;
            // 
            // TrainNotesField
            // 
            this.TrainNotesField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrainNotesField.Location = new System.Drawing.Point(602, 6);
            this.TrainNotesField.Name = "TrainNotesField";
            this.TrainNotesField.Size = new System.Drawing.Size(138, 20);
            this.TrainNotesField.TabIndex = 6;
            // 
            // TrainEditBtn
            // 
            this.TrainEditBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrainEditBtn.Location = new System.Drawing.Point(746, 6);
            this.TrainEditBtn.Name = "TrainEditBtn";
            this.TrainEditBtn.Size = new System.Drawing.Size(90, 23);
            this.TrainEditBtn.TabIndex = 7;
            this.TrainEditBtn.Text = "Изменить";
            this.TrainEditBtn.UseVisualStyleBackColor = true;
            // 
            // TrainRemoveBtn
            // 
            this.TrainRemoveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrainRemoveBtn.Location = new System.Drawing.Point(842, 6);
            this.TrainRemoveBtn.Name = "TrainRemoveBtn";
            this.TrainRemoveBtn.Size = new System.Drawing.Size(90, 23);
            this.TrainRemoveBtn.TabIndex = 8;
            this.TrainRemoveBtn.Text = "Удалить";
            this.TrainRemoveBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.TrainRecord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TrainRecord.ResumeLayout(false);
            this.TrainRecord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TrainRecord;
        private System.Windows.Forms.DateTimePicker TrainDepartField;
        private System.Windows.Forms.ComboBox TrainStatField;
        private System.Windows.Forms.TextBox TrainNumField;
        private System.Windows.Forms.TextBox TrainRouteField;
        private System.Windows.Forms.DateTimePicker TrainArrivalField;
        private System.Windows.Forms.TextBox TrainTrackField;
        private System.Windows.Forms.TextBox TrainNotesField;
        private System.Windows.Forms.Button TrainEditBtn;
        private System.Windows.Forms.Button TrainRemoveBtn;
    }
}