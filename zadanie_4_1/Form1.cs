using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace zadanie_5
{
    public partial class Form1 : Form
    {

        public enum DateTimeFormat { ShowClock, ShowDate };
        DateTimeFormat Format = DateTimeFormat.ShowClock;
        ToolTip Tip;
        Color ShapeColor;
        Dictionary<string, string> Day_Week;
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Visible = false;
            Tip = new ToolTip();
            Tip.IsBalloon = true;
            Tip.ToolTipIcon = ToolTipIcon.Info;
            Tip.SetToolTip(rTrackBar, "значение красного");
            Tip.SetToolTip(gTrackBar, "значение зеленого");
            Tip.SetToolTip(bTrackBar, "значение синего");
            DayOfWeek();
            C.Text = Day_Week[DateTime.Now.DayOfWeek.ToString()];
            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString();
        }

        private void DayOfWeek()
        {
            Day_Week = new Dictionary<string, string>();
            Day_Week["Monday"] = "Понедельник";
            Day_Week["Tuesday"] = "Вторник";
            Day_Week["Wednesday"] = "Среда";
            Day_Week["Thursday"] = "Четверг";
            Day_Week["Friday"] = "Пятница";
            Day_Week["Saturday"] = "Суббота";
            Day_Week["Sunday"] = "Воскресенье";
        }

        private void ЦветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorPanel.Visible = true;
            ShapeColor = BackColor;
            rTrackBar.Value = ShapeColor.R;
            gTrackBar.Value = ShapeColor.G;
            bTrackBar.Value = ShapeColor.B;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Format == DateTimeFormat.ShowClock)
            {
                toolStripStatusLabel1.Text =
                    DateTime.Now.ToShortTimeString();
                Format = DateTimeFormat.ShowDate;
            }
            else
            {
                toolStripStatusLabel1.Text =
                    DateTime.Now.ToShortDateString();
                Format = DateTimeFormat.ShowClock;
            }
        }

        private void РусскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            русскийToolStripMenuItem.Enabled = false;
            англискийToolStripMenuItem.Enabled = true;
            toolStripDropDownButton1.Text = "Меню";
            C.Text = Day_Week[DateTime.Now.DayOfWeek.ToString()];
            показатьToolStripMenuItem.Text = "Показать";
            выходToolStripMenuItem.Text = "Выход";
            notifyIcon1.Text = "Задание 1";
            Text = "Задание 1";
            цветФонаToolStripMenuItem.Text = "Цвет Фона";
            языкToolStripMenuItem.Text = "Язык";
            русскийToolStripMenuItem.Text = "Русский";
            англискийToolStripMenuItem.Text = "Английский";
            okButton.Text = "Принять";
            button_close.Text = "Закрыть";
            label2.Text = "Изменения цвета формы";
            Tip.SetToolTip(rTrackBar, "значение красного");
            Tip.SetToolTip(gTrackBar, "значение зеленого");
            Tip.SetToolTip(bTrackBar, "значение синего");
            выходToolStripMenuItem1.Text = "Выход";
        }

        private void АнглискийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            англискийToolStripMenuItem.Enabled = false;
            русскийToolStripMenuItem.Enabled = true;
            Text = "Task 1";
            toolStripDropDownButton1.Text = "Menu";
            C.Text = DateTime.Now.DayOfWeek.ToString();
            показатьToolStripMenuItem.Text = "Show";
            выходToolStripMenuItem.Text = "Exit";
            notifyIcon1.Text = "Task 1";
            цветФонаToolStripMenuItem.Text = "Background Color";
            языкToolStripMenuItem.Text = "Language";
            русскийToolStripMenuItem.Text = "Russian";
            англискийToolStripMenuItem.Text = "English";
            okButton.Text = "To accept";
            button_close.Text = "To Close";
            label2.Text = "Shape Color Changes";
            Tip.SetToolTip(rTrackBar, "red value");
            Tip.SetToolTip(gTrackBar, "green value");
            Tip.SetToolTip(bTrackBar, "blue value");
            выходToolStripMenuItem1.Text = "Exit";
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ПоказатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            colorPanel.Visible = false;
        }

        private void AllTrackBar_ValueChanged(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
            ToolTip1_ValueChanged();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BackColor = ShapeColor;
            colorPanel.Visible = false;
        }

        private void ToolTip1_ValueChanged()
        {
            toolTip1.SetToolTip(rTrackBar, $"{rTrackBar.Value}");
            toolTip1.SetToolTip(gTrackBar, $"{gTrackBar.Value}");
            toolTip1.SetToolTip(bTrackBar, $"{bTrackBar.Value}");
        }
    }
}
