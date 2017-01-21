using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace Do_nauki_kolo
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

        }

 /// <summary>
 /// Used Variables
 /// </summary>
        List<string> BlockedPagestList = new List<string>();
        bool start= false;
        bool czas = false;
        bool strony = false;
        bool przeglądarka = false;
        TimeSpan  opoznienie_TS;
        int opoznienie_int , początkowe_opoznienie ; 
        string lastTabName, procName, tabName, defaulbrowser = "przeglądarka";

       
/// <summary>
/// Declareted Events 
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>


        private void strt_btn_Click(object sender, EventArgs e)
        {
            StartSetup();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (start)
            {
                listProcessNames(przegladarka_combo.SelectedItem.ToString());
                timer2_IsEnable();
            }
        }

        private void strony_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            AddItemToList(strony_txtbox.Text);
            
        }
        
        private void ListOfPages_LV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (start == false)
            {
                usun_strone_btn.Visible = true;
                usun_wszystko_btn.Visible = true;
            }
            else
            {
                usun_strone_btn.Visible = false;
                usun_wszystko_btn.Visible = false;
            }

        }
       


        //usuwa strone z blokowanych
        private void usun_strone_btn_Click(object sender, EventArgs e)
        {

                foreach (ListViewItem item in ListOfPages_LV.SelectedItems)
                    item.Remove();

                usun_wszystko_btn.Visible = false;
                usun_strone_btn.Visible = false;

            
        }

        //usuwa wszystkie items z zablokowanej listy stron
        private void usun_wszystko_btn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListOfPages_LV.SelectedItems)
                item.Remove();

            usun_wszystko_btn.Visible = false;
            usun_strone_btn.Visible = false;

    }

        private void strony_txtbox_Click(object sender, EventArgs e)
        {
            ClearTextSpace(strony_txtbox);
        }


        //przyporzadkowanie wartości bool, potrzebne do filtrowania procesów w funkcji listview
        private void przegladarka_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(przegladarka_combo.Text == defaulbrowser)
            { przeglądarka = false; }
            else
            {przeglądarka = true; }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TimeParse(textBox1);
        }

        //odliczanie po otwarciu strony "zablokowaniej"
        private void timer2_Tick(object sender, EventArgs e)
        {
            coutdown();
        }



/// <summary>
/// Used Functions definitions 
/// </summary>


        internal void StartSetup()
        {
            //nie wybrano przegladarki
            if (!przeglądarka)
            { MessageBox.Show("Nie ustawiono przeglądarki"); return; }

            //nie wpisano żadnej strony
            if (!strony)
            { MessageBox.Show("Nie ustawiono stron"); return; }

            //jezeli nie ustawiono czasu
            if (!czas)
            { początkowe_opoznienie = 30; }

            opoznienie_int = początkowe_opoznienie;

            textBox1.Visible = false;
            stopwatch_lbl.Visible = true;
            stopwatch_text_lbl.Visible = true;
            foreach (ListViewItem i in ListOfPages_LV.Items)
            {
                BlockedPagestList.Add(i.SubItems[0].Text.ToLower());
            }

            if (!start)
            {
                start = true;
                strt_btn.Text = "Stop";
                strony_txtbox.Visible = false;
                textBox1.Visible = false;
                przegladarka_combo.Visible = false;
                stopwatch_text_lbl.Visible = false;
            }
            else
            {
                start = false;
                timer2.Enabled = false;
                strt_btn.Text = "start";
                textBox1.Visible = true;
                strony_txtbox.Visible = true;
                textBox1.Visible = true;
                przegladarka_combo.Visible = true;
                stopwatch_text_lbl.Visible = true;
                czas_odliczany_lbl.Visible = false;
                stopwatch_text_lbl.Visible = false;
                stopwatch_lbl.Text = początkowe_opoznienie.ToString();
                opoznienie_int = początkowe_opoznienie;
            }
        }

         private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.strt_btn, "Naciśnij start");
            


        }


        internal void timer2_IsEnable()
        {

            procName = listProcessNames(przegladarka_combo.SelectedItem.ToString());
            tabName = listProcessNames(procName).ToLower();


            if (start == true)
            {

                if (lastTabName != tabName)
                {
                    foreach (string p in BlockedPagestList)
                    {
                        // sprawdza czy nazwa zawiera procesu zawiera nazwe zablokowanej srony
                        if (tabName.Contains(p))
                        {
                            timer2.Enabled = true;
                            lastTabName = tabName;
                            break;

                        }
                        else
                        {
                            opoznienie_int = początkowe_opoznienie;
                            stopwatch_lbl.Text = opoznienie_int.ToString();
                            timer2.Enabled = false;
                            lastTabName = tabName;
                        }
                    }
                }
            }
            else
            //zeby za pierwszym razem sie zawsze roznil
            { lastTabName = tabName + '1'; }


        }

        private string listProcessNames(string procesname)
        {

            //zbiera tablice wszystkich procesów powiązanych z google chrome
            Process[] procs = Process.GetProcessesByName(procesname);
            string nazwa;
            //sprawdzenie czy chrome jest właczony , tablica jest 0 przy wyłączonym chromie bo nie ma zadnych processów od niego
            if (procs.Length > 0)
            {
                //kazdy proces chrome po kolei
                foreach (Process p in procs)
                {
                    //sprawdzenie czy process jest aktualnie otwartą karta , jezeli nie - jego handle = 0 
                    if (p.MainWindowHandle != IntPtr.Zero)
                    {
                        p.Refresh();

                        //tworzy item listy  { id,  tytuł procesu(tutaj tytuł aktualnie otwartej karty ,data wystapienia 
                        var x = new ListViewItem(new string[] { p.MainWindowTitle, DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() });
                        listView1.Items.Add(x);

                        if (listView1.Items.Count > 5)
                        { listView1.Items[0].Remove(); }
                    }
                    else
                    { continue; }


                }

                nazwa = listView1.Items[listView1.Items.Count - 1].SubItems[0].Text;


            }
            else
            { nazwa = "brak"; }

            return nazwa;

        }
        internal void AddItemToList(string textboxText)
        {
            ListViewItem x = new ListViewItem(textboxText);
            ListOfPages_LV.Items.Add(x);
            strony_txtbox.Text = "";
            strony = true;

        }

      
           

        internal void ClearTextSpace(TextBox T)
        {
          T.Text = "";
        }



        internal void TimeParse(TextBox T)
        {
            try
            {
                opoznienie_TS = TimeSpan.Parse(T.Text);
                // opoznienie_int = (int)opoznienie_TS.TotalSeconds;
                początkowe_opoznienie = (int)opoznienie_TS.TotalSeconds;

                stopwatch_lbl.Text = początkowe_opoznienie.ToString();

            }
            catch
            {
                MessageBox.Show("błąd", "zły format");
                return;
            }

            czas = true;
        }

        internal void coutdown()
        {
            opoznienie_int--;
            stopwatch_lbl.Text = opoznienie_int.ToString();

            if (opoznienie_int < 0)
            {
                opoznienie_int = początkowe_opoznienie;
                //MessageBox.Show(new Form { TopMost = true }, "Wracaj do nauki");
                MymessageBox_Frm frm = new MymessageBox_Frm();
                frm.Show();
            }
        }


    }//form }
   
} // namespace }

