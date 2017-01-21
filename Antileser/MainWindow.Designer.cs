namespace Do_nauki_kolo
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.strony_txtbox = new System.Windows.Forms.TextBox();
            this.strt_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nazwStrony = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ListOfPages_LV = new System.Windows.Forms.ListView();
            this.zablokowane_strony = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usun_strone_btn = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.stopwatch_lbl = new System.Windows.Forms.Label();
            this.stopwatch_text_lbl = new System.Windows.Forms.Label();
            this.przegladarka_combo = new System.Windows.Forms.ComboBox();
            this.usun_wszystko_btn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.czas_odliczany_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // strony_txtbox
            // 
            this.strony_txtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.strony_txtbox.Location = new System.Drawing.Point(262, 25);
            this.strony_txtbox.Name = "strony_txtbox";
            this.strony_txtbox.Size = new System.Drawing.Size(121, 20);
            this.strony_txtbox.TabIndex = 0;
            this.strony_txtbox.Text = "wpisz strony";
            this.toolTip1.SetToolTip(this.strony_txtbox, "Podaj nazwe strony do zablokowania np. Facebook, Youtube...");
            this.strony_txtbox.Click += new System.EventHandler(this.strony_txtbox_Click);
            this.strony_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.strony_txtbox_KeyPress);
            // 
            // strt_btn
            // 
            this.strt_btn.Location = new System.Drawing.Point(12, 51);
            this.strt_btn.Name = "strt_btn";
            this.strt_btn.Size = new System.Drawing.Size(70, 20);
            this.strt_btn.TabIndex = 1;
            this.strt_btn.Text = "start";
            this.strt_btn.UseVisualStyleBackColor = true;
            this.strt_btn.Click += new System.EventHandler(this.strt_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nazwStrony
            // 
            this.nazwStrony.Text = "aktualnie otwarta strona";
            this.nazwStrony.Width = 337;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nazwStrony,
            this.time});
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(15, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(241, 148);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // time
            // 
            this.time.Text = "czas";
            this.time.Width = 210;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "00:00:00";
            this.toolTip1.SetToolTip(this.textBox1, "Podaj czas po którym zostanie wyświetlony komunikat");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ListOfPages_LV
            // 
            this.ListOfPages_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.zablokowane_strony});
            this.ListOfPages_LV.Location = new System.Drawing.Point(262, 80);
            this.ListOfPages_LV.Name = "ListOfPages_LV";
            this.ListOfPages_LV.Size = new System.Drawing.Size(178, 148);
            this.ListOfPages_LV.TabIndex = 12;
            this.toolTip1.SetToolTip(this.ListOfPages_LV, "Kliknij tutaj jeśli chcesz usunąć strone");
            this.ListOfPages_LV.UseCompatibleStateImageBehavior = false;
            this.ListOfPages_LV.View = System.Windows.Forms.View.Details;
            this.ListOfPages_LV.SelectedIndexChanged += new System.EventHandler(this.ListOfPages_LV_SelectedIndexChanged);
            // 
            // zablokowane_strony
            // 
            this.zablokowane_strony.Text = "zapisane strony";
            this.zablokowane_strony.Width = 268;
            // 
            // usun_strone_btn
            // 
            this.usun_strone_btn.Location = new System.Drawing.Point(262, 51);
            this.usun_strone_btn.Name = "usun_strone_btn";
            this.usun_strone_btn.Size = new System.Drawing.Size(87, 23);
            this.usun_strone_btn.TabIndex = 13;
            this.usun_strone_btn.Text = "usuń";
            this.usun_strone_btn.UseVisualStyleBackColor = true;
            this.usun_strone_btn.Visible = false;
            this.usun_strone_btn.Click += new System.EventHandler(this.usun_strone_btn_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // stopwatch_lbl
            // 
            this.stopwatch_lbl.AutoSize = true;
            this.stopwatch_lbl.Location = new System.Drawing.Point(116, 56);
            this.stopwatch_lbl.Name = "stopwatch_lbl";
            this.stopwatch_lbl.Size = new System.Drawing.Size(13, 13);
            this.stopwatch_lbl.TabIndex = 14;
            this.stopwatch_lbl.Text = "0";
            // 
            // stopwatch_text_lbl
            // 
            this.stopwatch_text_lbl.AutoSize = true;
            this.stopwatch_text_lbl.Location = new System.Drawing.Point(12, 9);
            this.stopwatch_text_lbl.Name = "stopwatch_text_lbl";
            this.stopwatch_text_lbl.Size = new System.Drawing.Size(32, 13);
            this.stopwatch_text_lbl.TabIndex = 15;
            this.stopwatch_text_lbl.Text = "czas ";
            this.stopwatch_text_lbl.Visible = false;
            // 
            // przegladarka_combo
            // 
            this.przegladarka_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.przegladarka_combo.FormattingEnabled = true;
            this.przegladarka_combo.Items.AddRange(new object[] {
            "Chrome",
            "Firefox",
            "Opera"});
            this.przegladarka_combo.Location = new System.Drawing.Point(119, 24);
            this.przegladarka_combo.Name = "przegladarka_combo";
            this.przegladarka_combo.Size = new System.Drawing.Size(121, 21);
            this.przegladarka_combo.TabIndex = 16;
            this.przegladarka_combo.Text = "przeglądarka";
            this.toolTip1.SetToolTip(this.przegladarka_combo, "Wybierz przeglądarkę z listy");
            this.przegladarka_combo.SelectedIndexChanged += new System.EventHandler(this.przegladarka_combo_SelectedIndexChanged);
            // 
            // usun_wszystko_btn
            // 
            this.usun_wszystko_btn.Location = new System.Drawing.Point(355, 51);
            this.usun_wszystko_btn.Name = "usun_wszystko_btn";
            this.usun_wszystko_btn.Size = new System.Drawing.Size(84, 23);
            this.usun_wszystko_btn.TabIndex = 17;
            this.usun_wszystko_btn.Text = "usun wszystko";
            this.usun_wszystko_btn.UseVisualStyleBackColor = true;
            this.usun_wszystko_btn.Visible = false;
            this.usun_wszystko_btn.Click += new System.EventHandler(this.usun_wszystko_btn_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // czas_odliczany_lbl
            // 
            this.czas_odliczany_lbl.AutoSize = true;
            this.czas_odliczany_lbl.Location = new System.Drawing.Point(136, 56);
            this.czas_odliczany_lbl.Name = "czas_odliczany_lbl";
            this.czas_odliczany_lbl.Size = new System.Drawing.Size(29, 13);
            this.czas_odliczany_lbl.TabIndex = 18;
            this.czas_odliczany_lbl.Text = "czas";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 242);
            this.Controls.Add(this.czas_odliczany_lbl);
            this.Controls.Add(this.usun_wszystko_btn);
            this.Controls.Add(this.przegladarka_combo);
            this.Controls.Add(this.stopwatch_text_lbl);
            this.Controls.Add(this.stopwatch_lbl);
            this.Controls.Add(this.usun_strone_btn);
            this.Controls.Add(this.ListOfPages_LV);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.strt_btn);
            this.Controls.Add(this.strony_txtbox);
            this.Name = "MainWindow";
            this.Text = "AntyLeser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox strony_txtbox;
        private System.Windows.Forms.Button strt_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader nazwStrony;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView ListOfPages_LV;
        private System.Windows.Forms.ColumnHeader zablokowane_strony;
        private System.Windows.Forms.Button usun_strone_btn;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label stopwatch_lbl;
        private System.Windows.Forms.Label stopwatch_text_lbl;
        private System.Windows.Forms.ComboBox przegladarka_combo;
        private System.Windows.Forms.Button usun_wszystko_btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label czas_odliczany_lbl;
    }
}

