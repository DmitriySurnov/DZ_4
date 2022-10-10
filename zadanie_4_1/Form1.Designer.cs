namespace zadanie_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bTrackBar = new System.Windows.Forms.TrackBar();
            this.gTrackBar = new System.Windows.Forms.TrackBar();
            this.rTrackBar = new System.Windows.Forms.TrackBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.C = new System.Windows.Forms.ToolStripMenuItem();
            this.цветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.языкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.англискийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.показатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.bLabel = new System.Windows.Forms.Label();
            this.gLabel = new System.Windows.Forms.Label();
            this.rLabel = new System.Windows.Forms.Label();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTrackBar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.colorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bTrackBar
            // 
            this.bTrackBar.Location = new System.Drawing.Point(33, 168);
            this.bTrackBar.Maximum = 255;
            this.bTrackBar.Name = "bTrackBar";
            this.bTrackBar.Size = new System.Drawing.Size(203, 45);
            this.bTrackBar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.bTrackBar, "0");
            this.bTrackBar.ValueChanged += new System.EventHandler(this.AllTrackBar_ValueChanged);
            // 
            // gTrackBar
            // 
            this.gTrackBar.Location = new System.Drawing.Point(33, 117);
            this.gTrackBar.Maximum = 255;
            this.gTrackBar.Name = "gTrackBar";
            this.gTrackBar.Size = new System.Drawing.Size(203, 45);
            this.gTrackBar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.gTrackBar, "0");
            this.gTrackBar.ValueChanged += new System.EventHandler(this.AllTrackBar_ValueChanged);
            // 
            // rTrackBar
            // 
            this.rTrackBar.Location = new System.Drawing.Point(33, 66);
            this.rTrackBar.Maximum = 255;
            this.rTrackBar.Name = "rTrackBar";
            this.rTrackBar.Size = new System.Drawing.Size(203, 45);
            this.rTrackBar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.rTrackBar, "0");
            this.rTrackBar.ValueChanged += new System.EventHandler(this.AllTrackBar_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.statusStrip1.Size = new System.Drawing.Size(550, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.C,
            this.цветФонаToolStripMenuItem,
            this.языкToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(54, 20);
            this.toolStripDropDownButton1.Text = "Меню";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // C
            // 
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(180, 22);
            this.C.Text = "День недели";
            // 
            // цветФонаToolStripMenuItem
            // 
            this.цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            this.цветФонаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.цветФонаToolStripMenuItem.Text = "Цвет Фона";
            this.цветФонаToolStripMenuItem.Click += new System.EventHandler(this.ЦветФонаToolStripMenuItem_Click);
            // 
            // языкToolStripMenuItem
            // 
            this.языкToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.русскийToolStripMenuItem,
            this.англискийToolStripMenuItem});
            this.языкToolStripMenuItem.Name = "языкToolStripMenuItem";
            this.языкToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.языкToolStripMenuItem.Text = "Язык";
            // 
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.Enabled = false;
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.русскийToolStripMenuItem.Text = "Русский";
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.РусскийToolStripMenuItem_Click);
            // 
            // англискийToolStripMenuItem
            // 
            this.англискийToolStripMenuItem.Name = "англискийToolStripMenuItem";
            this.англискийToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.англискийToolStripMenuItem.Text = "Английский";
            this.англискийToolStripMenuItem.Click += new System.EventHandler(this.АнглискийToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Задание 4_1";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // показатьToolStripMenuItem
            // 
            this.показатьToolStripMenuItem.Name = "показатьToolStripMenuItem";
            this.показатьToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.показатьToolStripMenuItem.Text = "Показать";
            this.показатьToolStripMenuItem.Click += new System.EventHandler(this.ПоказатьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorPanel.Controls.Add(this.button_close);
            this.colorPanel.Controls.Add(this.label2);
            this.colorPanel.Controls.Add(this.okButton);
            this.colorPanel.Controls.Add(this.bLabel);
            this.colorPanel.Controls.Add(this.gLabel);
            this.colorPanel.Controls.Add(this.rLabel);
            this.colorPanel.Controls.Add(this.bTrackBar);
            this.colorPanel.Controls.Add(this.gTrackBar);
            this.colorPanel.Controls.Add(this.rTrackBar);
            this.colorPanel.Location = new System.Drawing.Point(121, 64);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(251, 256);
            this.colorPanel.TabIndex = 17;
            this.colorPanel.Visible = false;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(133, 219);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(103, 23);
            this.button_close.TabIndex = 8;
            this.button_close.Text = "Закрыть";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Изменения цвета формы";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(7, 219);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(103, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Принять";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(12, 172);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(14, 13);
            this.bLabel.TabIndex = 5;
            this.bLabel.Text = "B";
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Location = new System.Drawing.Point(12, 122);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(15, 13);
            this.gLabel.TabIndex = 4;
            this.gLabel.Text = "G";
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Location = new System.Drawing.Point(12, 69);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(15, 13);
            this.rLabel.TabIndex = 3;
            this.rLabel.Text = "R";
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 385);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Задание 1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.bTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTrackBar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.colorPanel.ResumeLayout(false);
            this.colorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem C;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem языкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem англискийToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem показатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.TrackBar bTrackBar;
        private System.Windows.Forms.TrackBar gTrackBar;
        private System.Windows.Forms.TrackBar rTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
    }
}

