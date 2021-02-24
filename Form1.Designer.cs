namespace nir
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
            this.tTrackBar = new System.Windows.Forms.TrackBar();
            this.t = new System.Windows.Forms.Label();
            this.Tnv = new System.Windows.Forms.Label();
            this.Pnv = new System.Windows.Forms.Label();
            this.Ngtu = new System.Windows.Forms.Label();
            this.dPin = new System.Windows.Forms.Label();
            this.dPout = new System.Windows.Forms.Label();
            this.TnvTrackBar = new System.Windows.Forms.TrackBar();
            this.PnvTrackBar = new System.Windows.Forms.TrackBar();
            this.NgtuTrackBar = new System.Windows.Forms.TrackBar();
            this.dPinTrackBar = new System.Windows.Forms.TrackBar();
            this.dPoutTrackBar = new System.Windows.Forms.TrackBar();
            this.N = new System.Windows.Forms.Label();
            this.Nu = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Label();
            this.Tout = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.NTextBox = new System.Windows.Forms.TextBox();
            this.NuTextBox = new System.Windows.Forms.TextBox();
            this.GTextBox = new System.Windows.Forms.TextBox();
            this.ToutTextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.dPinMin = new System.Windows.Forms.Label();
            this.dPinMax = new System.Windows.Forms.Label();
            this.dPinCur = new System.Windows.Forms.Label();
            this.tMin = new System.Windows.Forms.Label();
            this.tMax = new System.Windows.Forms.Label();
            this.TnvMin = new System.Windows.Forms.Label();
            this.TnvMax = new System.Windows.Forms.Label();
            this.PnvMin = new System.Windows.Forms.Label();
            this.PnvMax = new System.Windows.Forms.Label();
            this.NgtuMin = new System.Windows.Forms.Label();
            this.NgtuMax = new System.Windows.Forms.Label();
            this.dPoutMin = new System.Windows.Forms.Label();
            this.dPoutMax = new System.Windows.Forms.Label();
            this.tCur = new System.Windows.Forms.Label();
            this.TnvCur = new System.Windows.Forms.Label();
            this.PnvCur = new System.Windows.Forms.Label();
            this.NgtuCur = new System.Windows.Forms.Label();
            this.dPoutCur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TnvTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnvTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgtuTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dPinTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dPoutTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tTrackBar
            // 
            this.tTrackBar.Location = new System.Drawing.Point(230, 9);
            this.tTrackBar.Maximum = 12000;
            this.tTrackBar.Name = "tTrackBar";
            this.tTrackBar.Size = new System.Drawing.Size(199, 45);
            this.tTrackBar.TabIndex = 0;
            this.tTrackBar.TickFrequency = 1000;
            this.tTrackBar.Scroll += new System.EventHandler(this.trackBarChange);
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(12, 12);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(171, 13);
            this.t.TabIndex = 1;
            this.t.Text = "Количество часов эксплуатации";
            // 
            // Tnv
            // 
            this.Tnv.AutoSize = true;
            this.Tnv.Location = new System.Drawing.Point(12, 63);
            this.Tnv.Name = "Tnv";
            this.Tnv.Size = new System.Drawing.Size(174, 13);
            this.Tnv.TabIndex = 2;
            this.Tnv.Text = "Температура наружного воздуха";
            // 
            // Pnv
            // 
            this.Pnv.AutoSize = true;
            this.Pnv.Location = new System.Drawing.Point(12, 114);
            this.Pnv.Name = "Pnv";
            this.Pnv.Size = new System.Drawing.Size(158, 13);
            this.Pnv.TabIndex = 3;
            this.Pnv.Text = "Давление наружного воздуха";
            // 
            // Ngtu
            // 
            this.Ngtu.AutoSize = true;
            this.Ngtu.Location = new System.Drawing.Point(12, 165);
            this.Ngtu.Name = "Ngtu";
            this.Ngtu.Size = new System.Drawing.Size(79, 13);
            this.Ngtu.TabIndex = 4;
            this.Ngtu.Text = "Нагрузка ГТУ";
            // 
            // dPin
            // 
            this.dPin.AutoSize = true;
            this.dPin.Location = new System.Drawing.Point(12, 216);
            this.dPin.Name = "dPin";
            this.dPin.Size = new System.Drawing.Size(202, 13);
            this.dPin.TabIndex = 5;
            this.dPin.Text = "Потеря давления на входе из турбины";
            // 
            // dPout
            // 
            this.dPout.AutoSize = true;
            this.dPout.Location = new System.Drawing.Point(12, 267);
            this.dPout.Name = "dPout";
            this.dPout.Size = new System.Drawing.Size(210, 13);
            this.dPout.TabIndex = 6;
            this.dPout.Text = "Потеря давления на выходе из турбины";
            // 
            // TnvTrackBar
            // 
            this.TnvTrackBar.Location = new System.Drawing.Point(230, 63);
            this.TnvTrackBar.Name = "TnvTrackBar";
            this.TnvTrackBar.Size = new System.Drawing.Size(199, 45);
            this.TnvTrackBar.TabIndex = 7;
            this.TnvTrackBar.Scroll += new System.EventHandler(this.trackBarChange);
            // 
            // PnvTrackBar
            // 
            this.PnvTrackBar.Location = new System.Drawing.Point(230, 114);
            this.PnvTrackBar.Name = "PnvTrackBar";
            this.PnvTrackBar.Size = new System.Drawing.Size(199, 45);
            this.PnvTrackBar.TabIndex = 8;
            this.PnvTrackBar.Scroll += new System.EventHandler(this.trackBarChange);
            // 
            // NgtuTrackBar
            // 
            this.NgtuTrackBar.Location = new System.Drawing.Point(230, 165);
            this.NgtuTrackBar.Name = "NgtuTrackBar";
            this.NgtuTrackBar.Size = new System.Drawing.Size(199, 45);
            this.NgtuTrackBar.TabIndex = 9;
            this.NgtuTrackBar.Scroll += new System.EventHandler(this.trackBarChange);
            // 
            // dPinTrackBar
            // 
            this.dPinTrackBar.Location = new System.Drawing.Point(230, 216);
            this.dPinTrackBar.Name = "dPinTrackBar";
            this.dPinTrackBar.Size = new System.Drawing.Size(199, 45);
            this.dPinTrackBar.TabIndex = 10;
            this.dPinTrackBar.Scroll += new System.EventHandler(this.trackBarChange);
            // 
            // dPoutTrackBar
            // 
            this.dPoutTrackBar.Location = new System.Drawing.Point(230, 267);
            this.dPoutTrackBar.Name = "dPoutTrackBar";
            this.dPoutTrackBar.Size = new System.Drawing.Size(199, 45);
            this.dPoutTrackBar.TabIndex = 11;
            this.dPoutTrackBar.Scroll += new System.EventHandler(this.trackBarChange);
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Location = new System.Drawing.Point(517, 12);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(199, 13);
            this.N.TabIndex = 12;
            this.N.Text = "Электрическая мощность ГТУ брутто";
            // 
            // Nu
            // 
            this.Nu.AutoSize = true;
            this.Nu.Location = new System.Drawing.Point(517, 63);
            this.Nu.Name = "Nu";
            this.Nu.Size = new System.Drawing.Size(225, 13);
            this.Nu.TabIndex = 13;
            this.Nu.Text = "КПД по выработке электроэнергии брутто";
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.Location = new System.Drawing.Point(517, 114);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(225, 13);
            this.G.TabIndex = 14;
            this.G.Text = "Расход газов на выхлопе газовой турбины";
            // 
            // Tout
            // 
            this.Tout.AutoSize = true;
            this.Tout.Location = new System.Drawing.Point(517, 165);
            this.Tout.Name = "Tout";
            this.Tout.Size = new System.Drawing.Size(256, 13);
            this.Tout.TabIndex = 15;
            this.Tout.Text = "Температура газов на выхлопе газовой турбины";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(517, 216);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(131, 13);
            this.B.TabIndex = 16;
            this.B.Text = "Расход природного газа";
            // 
            // NTextBox
            // 
            this.NTextBox.Location = new System.Drawing.Point(779, 9);
            this.NTextBox.Name = "NTextBox";
            this.NTextBox.Size = new System.Drawing.Size(100, 20);
            this.NTextBox.TabIndex = 17;
            // 
            // NuTextBox
            // 
            this.NuTextBox.Location = new System.Drawing.Point(779, 60);
            this.NuTextBox.Name = "NuTextBox";
            this.NuTextBox.Size = new System.Drawing.Size(100, 20);
            this.NuTextBox.TabIndex = 18;
            // 
            // GTextBox
            // 
            this.GTextBox.Location = new System.Drawing.Point(779, 111);
            this.GTextBox.Name = "GTextBox";
            this.GTextBox.Size = new System.Drawing.Size(100, 20);
            this.GTextBox.TabIndex = 19;
            // 
            // ToutTextBox
            // 
            this.ToutTextBox.Location = new System.Drawing.Point(779, 162);
            this.ToutTextBox.Name = "ToutTextBox";
            this.ToutTextBox.Size = new System.Drawing.Size(100, 20);
            this.ToutTextBox.TabIndex = 20;
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(779, 213);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(100, 20);
            this.BTextBox.TabIndex = 21;
            // 
            // dPinMin
            // 
            this.dPinMin.AutoSize = true;
            this.dPinMin.Location = new System.Drawing.Point(227, 248);
            this.dPinMin.Name = "dPinMin";
            this.dPinMin.Size = new System.Drawing.Size(41, 13);
            this.dPinMin.TabIndex = 22;
            this.dPinMin.Text = "label12";
            // 
            // dPinMax
            // 
            this.dPinMax.AutoSize = true;
            this.dPinMax.Location = new System.Drawing.Point(388, 248);
            this.dPinMax.Name = "dPinMax";
            this.dPinMax.Size = new System.Drawing.Size(41, 13);
            this.dPinMax.TabIndex = 23;
            this.dPinMax.Text = "label13";
            // 
            // dPinCur
            // 
            this.dPinCur.AutoSize = true;
            this.dPinCur.Location = new System.Drawing.Point(309, 248);
            this.dPinCur.Name = "dPinCur";
            this.dPinCur.Size = new System.Drawing.Size(13, 13);
            this.dPinCur.TabIndex = 24;
            this.dPinCur.Text = "0";
            // 
            // tMin
            // 
            this.tMin.AutoSize = true;
            this.tMin.Location = new System.Drawing.Point(227, 41);
            this.tMin.Name = "tMin";
            this.tMin.Size = new System.Drawing.Size(41, 13);
            this.tMin.TabIndex = 25;
            this.tMin.Text = "label12";
            // 
            // tMax
            // 
            this.tMax.AutoSize = true;
            this.tMax.Location = new System.Drawing.Point(388, 41);
            this.tMax.Name = "tMax";
            this.tMax.Size = new System.Drawing.Size(41, 13);
            this.tMax.TabIndex = 26;
            this.tMax.Text = "label13";
            // 
            // TnvMin
            // 
            this.TnvMin.AutoSize = true;
            this.TnvMin.Location = new System.Drawing.Point(227, 95);
            this.TnvMin.Name = "TnvMin";
            this.TnvMin.Size = new System.Drawing.Size(41, 13);
            this.TnvMin.TabIndex = 27;
            this.TnvMin.Text = "label14";
            // 
            // TnvMax
            // 
            this.TnvMax.AutoSize = true;
            this.TnvMax.Location = new System.Drawing.Point(388, 95);
            this.TnvMax.Name = "TnvMax";
            this.TnvMax.Size = new System.Drawing.Size(41, 13);
            this.TnvMax.TabIndex = 28;
            this.TnvMax.Text = "label15";
            // 
            // PnvMin
            // 
            this.PnvMin.AutoSize = true;
            this.PnvMin.Location = new System.Drawing.Point(227, 146);
            this.PnvMin.Name = "PnvMin";
            this.PnvMin.Size = new System.Drawing.Size(41, 13);
            this.PnvMin.TabIndex = 29;
            this.PnvMin.Text = "label16";
            // 
            // PnvMax
            // 
            this.PnvMax.AutoSize = true;
            this.PnvMax.Location = new System.Drawing.Point(388, 146);
            this.PnvMax.Name = "PnvMax";
            this.PnvMax.Size = new System.Drawing.Size(41, 13);
            this.PnvMax.TabIndex = 30;
            this.PnvMax.Text = "label17";
            // 
            // NgtuMin
            // 
            this.NgtuMin.AutoSize = true;
            this.NgtuMin.Location = new System.Drawing.Point(227, 197);
            this.NgtuMin.Name = "NgtuMin";
            this.NgtuMin.Size = new System.Drawing.Size(41, 13);
            this.NgtuMin.TabIndex = 31;
            this.NgtuMin.Text = "label18";
            // 
            // NgtuMax
            // 
            this.NgtuMax.AutoSize = true;
            this.NgtuMax.Location = new System.Drawing.Point(388, 197);
            this.NgtuMax.Name = "NgtuMax";
            this.NgtuMax.Size = new System.Drawing.Size(41, 13);
            this.NgtuMax.TabIndex = 32;
            this.NgtuMax.Text = "label19";
            // 
            // dPoutMin
            // 
            this.dPoutMin.AutoSize = true;
            this.dPoutMin.Location = new System.Drawing.Point(227, 299);
            this.dPoutMin.Name = "dPoutMin";
            this.dPoutMin.Size = new System.Drawing.Size(41, 13);
            this.dPoutMin.TabIndex = 33;
            this.dPoutMin.Text = "label20";
            // 
            // dPoutMax
            // 
            this.dPoutMax.AutoSize = true;
            this.dPoutMax.Location = new System.Drawing.Point(388, 299);
            this.dPoutMax.Name = "dPoutMax";
            this.dPoutMax.Size = new System.Drawing.Size(41, 13);
            this.dPoutMax.TabIndex = 34;
            this.dPoutMax.Text = "label21";
            // 
            // tCur
            // 
            this.tCur.AutoSize = true;
            this.tCur.Location = new System.Drawing.Point(309, 41);
            this.tCur.Name = "tCur";
            this.tCur.Size = new System.Drawing.Size(13, 13);
            this.tCur.TabIndex = 35;
            this.tCur.Text = "0";
            // 
            // TnvCur
            // 
            this.TnvCur.AutoSize = true;
            this.TnvCur.Location = new System.Drawing.Point(309, 98);
            this.TnvCur.Name = "TnvCur";
            this.TnvCur.Size = new System.Drawing.Size(13, 13);
            this.TnvCur.TabIndex = 36;
            this.TnvCur.Text = "0";
            // 
            // PnvCur
            // 
            this.PnvCur.AutoSize = true;
            this.PnvCur.Location = new System.Drawing.Point(309, 149);
            this.PnvCur.Name = "PnvCur";
            this.PnvCur.Size = new System.Drawing.Size(13, 13);
            this.PnvCur.TabIndex = 37;
            this.PnvCur.Text = "0";
            // 
            // NgtuCur
            // 
            this.NgtuCur.AutoSize = true;
            this.NgtuCur.Location = new System.Drawing.Point(309, 197);
            this.NgtuCur.Name = "NgtuCur";
            this.NgtuCur.Size = new System.Drawing.Size(13, 13);
            this.NgtuCur.TabIndex = 38;
            this.NgtuCur.Text = "0";
            // 
            // dPoutCur
            // 
            this.dPoutCur.AutoSize = true;
            this.dPoutCur.Location = new System.Drawing.Point(309, 299);
            this.dPoutCur.Name = "dPoutCur";
            this.dPoutCur.Size = new System.Drawing.Size(13, 13);
            this.dPoutCur.TabIndex = 39;
            this.dPoutCur.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 320);
            this.Controls.Add(this.dPoutCur);
            this.Controls.Add(this.NgtuCur);
            this.Controls.Add(this.PnvCur);
            this.Controls.Add(this.TnvCur);
            this.Controls.Add(this.tCur);
            this.Controls.Add(this.dPoutMax);
            this.Controls.Add(this.dPoutMin);
            this.Controls.Add(this.NgtuMax);
            this.Controls.Add(this.NgtuMin);
            this.Controls.Add(this.PnvMax);
            this.Controls.Add(this.PnvMin);
            this.Controls.Add(this.TnvMax);
            this.Controls.Add(this.TnvMin);
            this.Controls.Add(this.tMax);
            this.Controls.Add(this.tMin);
            this.Controls.Add(this.dPinCur);
            this.Controls.Add(this.dPinMax);
            this.Controls.Add(this.dPinMin);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.ToutTextBox);
            this.Controls.Add(this.GTextBox);
            this.Controls.Add(this.NuTextBox);
            this.Controls.Add(this.NTextBox);
            this.Controls.Add(this.B);
            this.Controls.Add(this.Tout);
            this.Controls.Add(this.G);
            this.Controls.Add(this.Nu);
            this.Controls.Add(this.N);
            this.Controls.Add(this.dPoutTrackBar);
            this.Controls.Add(this.dPinTrackBar);
            this.Controls.Add(this.NgtuTrackBar);
            this.Controls.Add(this.PnvTrackBar);
            this.Controls.Add(this.TnvTrackBar);
            this.Controls.Add(this.dPout);
            this.Controls.Add(this.dPin);
            this.Controls.Add(this.Ngtu);
            this.Controls.Add(this.Pnv);
            this.Controls.Add(this.Tnv);
            this.Controls.Add(this.t);
            this.Controls.Add(this.tTrackBar);
            this.Name = "Form1";
            this.Text = "Расчет ГТУ";
            ((System.ComponentModel.ISupportInitialize)(this.tTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TnvTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnvTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgtuTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dPinTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dPoutTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tTrackBar;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label Tnv;
        private System.Windows.Forms.Label Pnv;
        private System.Windows.Forms.Label Ngtu;
        private System.Windows.Forms.Label dPin;
        private System.Windows.Forms.Label dPout;
        private System.Windows.Forms.TrackBar TnvTrackBar;
        private System.Windows.Forms.TrackBar PnvTrackBar;
        private System.Windows.Forms.TrackBar NgtuTrackBar;
        private System.Windows.Forms.TrackBar dPinTrackBar;
        private System.Windows.Forms.TrackBar dPoutTrackBar;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.Label Nu;
        private System.Windows.Forms.Label G;
        private System.Windows.Forms.Label Tout;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.TextBox NTextBox;
        private System.Windows.Forms.TextBox NuTextBox;
        private System.Windows.Forms.TextBox GTextBox;
        private System.Windows.Forms.TextBox ToutTextBox;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Label dPinMin;
        private System.Windows.Forms.Label dPinMax;
        private System.Windows.Forms.Label dPinCur;
        private System.Windows.Forms.Label tMin;
        private System.Windows.Forms.Label tMax;
        private System.Windows.Forms.Label TnvMin;
        private System.Windows.Forms.Label TnvMax;
        private System.Windows.Forms.Label PnvMin;
        private System.Windows.Forms.Label PnvMax;
        private System.Windows.Forms.Label NgtuMin;
        private System.Windows.Forms.Label NgtuMax;
        private System.Windows.Forms.Label dPoutMin;
        private System.Windows.Forms.Label dPoutMax;
        private System.Windows.Forms.Label tCur;
        private System.Windows.Forms.Label TnvCur;
        private System.Windows.Forms.Label PnvCur;
        private System.Windows.Forms.Label NgtuCur;
        private System.Windows.Forms.Label dPoutCur;
    }
}

