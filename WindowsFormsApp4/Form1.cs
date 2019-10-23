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
using sdc3;
using sdc4;
using sdc5;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var date = from.Date; date.Date <= thru.Date; date = date.AddDays(1))
                yield return date;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(tbxHA.Text); //Hämtar spelschema i form av JSON-fil som har fåtts genom konvertering.
            var allsvenskan = AllsvenskanDezClass.FromJson(text); //använder en enkel klass för att göra om JSON till ett objekt
            text = System.IO.File.ReadAllText(tbxSHL.Text); // -||-
            var shl = ShlDezClass.FromJson(text); // -||-
            text = System.IO.File.ReadAllText(tbxLiga3.Text); // -||-
            var sdhl = SdhlDezClass.FromJson(text); // -||-
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = docPath + @"\WriteLines.txt";
            File.Delete(path);
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                }
            }
            int i = 0;
            int month;
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt"), true))
            {
                outputFile.WriteLine("###### Glöm inte att du måste [klicka på denna länken och skicka](http://www.reddit.com/message/compose/?to=AutoModerator&subject=Ishockey&message=schedule) för att uppdatera post-schemat!");
                outputFile.WriteLine("---");
            }
            string monthstring = "";
            DateTime StartDate = new DateTime(2019, 10, 21);
            DateTime EndDate = new DateTime(2020, 4, 12);
            foreach (DateTime date in EachDay(StartDate, EndDate))
            {
                month = date.Month;
                monthstring = "";
                switch (month)
                {
                    case 1:
                        monthstring = "January";
                        break;
                    case 2:
                        monthstring = "February";
                        break;
                    case 3:
                        monthstring = "March";
                        break;
                    case 4:
                        monthstring = "April";
                        break;
                    case 5:
                        monthstring = "May";
                        break;
                    case 6:
                        monthstring = "June";
                        break;
                    case 7:
                        monthstring = "July";
                        break;
                    case 8:
                        monthstring = "August";
                        break;
                    case 9:
                        monthstring = "September";
                        break;
                    case 10:
                        monthstring = "October";
                        break;
                    case 11:
                        monthstring = "November";
                        break;
                    case 12:
                        monthstring = "December";
                        break;
                    default:
                        break;
                }
                string shl1 = null;
                string shl1tid = null;
                string shl2 = null;
                string shl2tid = null;
                string shl3 = null;
                string shl3tid = null;
                string shl4 = null;
                string shl4tid = null;
                string shl5 = null;
                string shl5tid = null;
                string shl6 = null;
                string shl6tid = null;
                string shl7 = null;
                string shl7tid = null;
                int nr = 1;
                for (i = 0; i < shl.Length; i++)
                {
                    string år = shl[i].Tid.Substring(0, 4);

                    string månad = shl[i].Tid.Substring(4, 2);
                    string dag = shl[i].Tid.Substring(6, 2);
                    string tid = shl[i].Tid.Substring(9, 2) + ":" + shl[i].Tid.Substring(11, 2);
                    if (date.Month == int.Parse(månad) && date.Day == int.Parse(dag))
                    {
                        if (nr == 1)
                        {
                            shl1 = shl[i].Lag;
                            shl1tid = shl[i].Tid;

                        }
                        else if (nr == 2)
                        {
                            shl2 = shl[i].Lag;
                            shl2tid = shl[i].Tid;

                        }
                        else if (nr == 3)
                        {
                            shl3 = shl[i].Lag;
                            shl3tid = shl[i].Tid;

                        }

                        else if (nr == 4)
                        {
                            shl4 = shl[i].Lag;
                            shl4tid = shl[i].Tid;

                        }
                        else if (nr == 5)
                        {
                            shl5 = shl[i].Lag;
                            shl5tid = shl[i].Tid;

                        }
                        else if (nr == 6)
                        {
                            shl6 = shl[i].Lag;
                            shl6tid = shl[i].Tid;

                        }
                        else if (nr == 7)
                        {
                            shl7 = shl[i].Lag;
                            shl7tid = shl[i].Tid;

                        }
                        nr++;
                    }
                }
                string date1 = monthstring + " " + date.Day + ", " + date.Year + " 11:40";
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt"), true))
                {
                    outputFile.WriteLine("    ");
                    outputFile.WriteLine("    first: \"" + date1 + "\"" + "");
                    outputFile.WriteLine("    sticky: false");
                    outputFile.WriteLine("    title: \"Matchtråd " + date.Year + "-" + date.Month + "-" + date.Day + "\"");
                    outputFile.WriteLine("    text: |");
                    outputFile.WriteLine("        ##Dagens matcher");
                    outputFile.WriteLine("        **SHL:**");
                    if (shl1 == null)
                    {
                        outputFile.WriteLine("        Inga matcher idag!");
                        outputFile.WriteLine("        ");
                        outputFile.WriteLine("        ___");
                    }
                    else
                    {

                        outputFile.WriteLine("        ");
                        outputFile.WriteLine("        | Lag | Tid");
                        outputFile.WriteLine("        |:-----------|------------:|");
                        int tidfix1 = 0;
                        int tidfix2 = 0;
                        int tidfix3 = 0;
                        int tidfix4 = 0;
                        int tidfix5 = 0;
                        int tidfix6 = 0;
                        int tidfix7 = 0;
                        string tidfixmin1 = null;
                        string tidfixmin2 = null;
                        string tidfixmin3 = null;
                        string tidfixmin4 = null;
                        string tidfixmin5 = null;
                        string tidfixmin6 = null;
                        string tidfixmin7 = null;
                        if (shl1tid != null)
                        {
                            tidfix1 = Convert.ToInt32(shl1tid.Substring(9, 2));
                            tidfix1 = tidfix1 + 1;
                            tidfixmin1 = shl1tid.Substring(11, 2);
                        }
                        if (shl2tid != null)
                        {
                            tidfix2 = Convert.ToInt32(shl2tid.Substring(9, 2));
                            tidfix2++;
                            tidfixmin2 = shl2tid.Substring(11, 2);
                        }
                        if (shl3tid != null)
                        {
                            tidfix3 = Convert.ToInt32(shl3tid.Substring(9, 2));
                            tidfix3++;
                            tidfixmin3 = shl3tid.Substring(11, 2);
                        }
                        if (shl4tid != null)
                        {
                            tidfix4 = Convert.ToInt32(shl4tid.Substring(9, 2));
                            tidfix4++;
                            tidfixmin4 = shl4tid.Substring(11, 2);
                        }
                        if (shl5tid != null)
                        {
                            tidfix5 = Convert.ToInt32(shl5tid.Substring(9, 2));
                            tidfix5++;
                            tidfixmin5 = shl5tid.Substring(11, 2);
                        }
                        if (shl6tid != null)
                        {
                            tidfix6 = Convert.ToInt32(shl6tid.Substring(9, 2));
                            tidfix6++;
                            tidfixmin6 = shl6tid.Substring(11, 2);
                        }
                        if (shl7tid != null)
                        {
                            tidfix7 = Convert.ToInt32(shl7tid.Substring(9, 2));
                            tidfix7++;
                            tidfixmin7 = shl7tid.Substring(11, 2);
                        }
                        outputFile.WriteLine("        |" + shl1 + "|" + (tidfix1 + 1).ToString() + ":" + tidfixmin1 + " |");
                        if (shl2 != null) outputFile.WriteLine("        |" + shl2 + "|" + (tidfix2 + 1).ToString() + ":" + tidfixmin2 + "|");
                        if (shl3 != null) outputFile.WriteLine("        |" + shl3 + "|" + (tidfix3 + 1).ToString() + ":" + tidfixmin3 + "|");
                        if (shl4 != null) outputFile.WriteLine("        |" + shl4 + "|" + (tidfix4 + 1).ToString() + ":" + tidfixmin4 + "|");
                        if (shl5 != null) outputFile.WriteLine("        |" + shl5 + "|" + (tidfix5 + 1).ToString() + ":" + tidfixmin5 + "|");
                        if (shl6 != null) outputFile.WriteLine("        |" + shl6 + "|" + (tidfix6 + 1).ToString() + ":" + tidfixmin6 + "|");
                        if (shl7 != null) outputFile.WriteLine("        |" + shl7 + "|" + (tidfix7 + 1).ToString() + ":" + tidfixmin7 + "|");
                        outputFile.WriteLine("        ");
                        outputFile.WriteLine("        ___");




                    }

                }
                string allsvenskan1 = null;
                string allsvenskan1tid = null;
                string allsvenskan2 = null;
                string allsvenskan2tid = null;
                string allsvenskan3 = null;
                string allsvenskan3tid = null;
                string allsvenskan4 = null;
                string allsvenskan4tid = null;
                string allsvenskan5 = null;
                string allsvenskan5tid = null;
                string allsvenskan6 = null;
                string allsvenskan6tid = null;
                string allsvenskan7 = null;
                string allsvenskan7tid = null;
                nr = 1;
                for (i = 0; i < allsvenskan.Length; i++)
                {
                    string år = allsvenskan[i].Tid.Substring(0, 4);

                    string månad = allsvenskan[i].Tid.Substring(4, 2);
                    string dag = allsvenskan[i].Tid.Substring(6, 2);
                    string tid = allsvenskan[i].Tid.Substring(9, 2) + ":" + allsvenskan[i].Tid.Substring(11, 2);
                    if (date.Month == int.Parse(månad) && date.Day == int.Parse(dag))
                    {
                        if (nr == 1)
                        {
                            allsvenskan1 = allsvenskan[i].Lag;
                            allsvenskan1tid = allsvenskan[i].Tid;

                        }
                        else if (nr == 2)
                        {
                            allsvenskan2 = allsvenskan[i].Lag;
                            allsvenskan2tid = allsvenskan[i].Tid;

                        }
                        else if (nr == 3)
                        {
                            allsvenskan3 = allsvenskan[i].Lag;
                            allsvenskan3tid = allsvenskan[i].Tid;

                        }

                        else if (nr == 4)
                        {
                            allsvenskan4 = allsvenskan[i].Lag;
                            allsvenskan4tid = allsvenskan[i].Tid;

                        }
                        else if (nr == 5)
                        {
                            allsvenskan5 = allsvenskan[i].Lag;
                            allsvenskan5tid = allsvenskan[i].Tid;

                        }
                        else if (nr == 6)
                        {
                            allsvenskan6 = allsvenskan[i].Lag;
                            allsvenskan6tid = allsvenskan[i].Tid;

                        }
                        else if (nr == 7)
                        {
                            allsvenskan7 = allsvenskan[i].Lag;
                            allsvenskan7tid = allsvenskan[i].Tid;

                        }
                        nr++;
                    }
                }
                date1 = monthstring + " " + date.Day + ", " + date.Year + " 11:00";
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt"), true))
                {
                    outputFile.WriteLine("        ");
                    outputFile.WriteLine("        **Hockeyallsvenskan:**");

                    if (allsvenskan1 == null)
                    {
                        outputFile.WriteLine("        Inga matcher idag!");
                        outputFile.WriteLine("        ");
                        outputFile.WriteLine("        ___");
                    }
                    else
                    {

                        outputFile.WriteLine("        ");
                        outputFile.WriteLine("        | Lag | Tid");
                        outputFile.WriteLine("        |:-----------|------------:|");
                        int tidfix1 = 0;
                        int tidfix2 = 0;
                        int tidfix3 = 0;
                        int tidfix4 = 0;
                        int tidfix5 = 0;
                        int tidfix6 = 0;
                        int tidfix7 = 0;
                        string tidfixmin1 = null;
                        string tidfixmin3 = null;
                        string tidfixmin2 = null;
                        string tidfixmin4 = null;
                        string tidfixmin5 = null;
                        string tidfixmin6 = null;
                        string tidfixmin7 = null;
                        if (allsvenskan1tid != null)
                        {
                            tidfix1 = Convert.ToInt32(allsvenskan1tid.Substring(9, 2));
                            tidfix1 = tidfix1 + 1;
                            tidfixmin1 = allsvenskan1tid.Substring(11, 2);
                        }
                        if (allsvenskan2tid != null)
                        {
                            tidfix2 = Convert.ToInt32(allsvenskan2tid.Substring(9, 2));
                            tidfix2++;
                            tidfixmin2 = allsvenskan2tid.Substring(11, 2);
                        }
                        if (allsvenskan3tid != null)
                        {
                            tidfix3 = Convert.ToInt32(allsvenskan3tid.Substring(9, 2));
                            tidfix3++;
                            tidfixmin3 = allsvenskan3tid.Substring(11, 2);
                        }
                        if (allsvenskan4tid != null)
                        {
                            tidfix4 = Convert.ToInt32(allsvenskan4tid.Substring(9, 2));
                            tidfix4++;
                            tidfixmin4 = allsvenskan4tid.Substring(11, 2);
                        }
                        if (allsvenskan5tid != null)
                        {
                            tidfix5 = Convert.ToInt32(allsvenskan5tid.Substring(9, 2));
                            tidfix5++;
                            tidfixmin5 = allsvenskan5tid.Substring(11, 2);
                        }
                        if (allsvenskan6tid != null)
                        {
                            tidfix6 = Convert.ToInt32(allsvenskan6tid.Substring(9, 2));
                            tidfix6++;
                            tidfixmin6 = allsvenskan6tid.Substring(11, 2);
                        }
                        if (allsvenskan7tid != null)
                        {
                            tidfix7 = Convert.ToInt32(allsvenskan7tid.Substring(9, 2));
                            tidfix7++;
                            tidfixmin7 = allsvenskan7tid.Substring(11, 2);
                        }
                        outputFile.WriteLine("        |" + allsvenskan1 + "|" + (tidfix1 + 1).ToString() + ":" + tidfixmin1 + " |");
                        if (allsvenskan2 != null) outputFile.WriteLine("        |" + allsvenskan2 + "|" + (tidfix2 + 1).ToString() + ":" + tidfixmin2 + "|");
                        if (allsvenskan3 != null) outputFile.WriteLine("        |" + allsvenskan3 + "|" + (tidfix3 + 1).ToString() + ":" + tidfixmin3 + "|");
                        if (allsvenskan4 != null) outputFile.WriteLine("        |" + allsvenskan4 + "|" + (tidfix4 + 1).ToString() + ":" + tidfixmin4 + "|");
                        if (allsvenskan5 != null) outputFile.WriteLine("        |" + allsvenskan5 + "|" + (tidfix5 + 1).ToString() + ":" + tidfixmin5 + "|");
                        if (allsvenskan6 != null) outputFile.WriteLine("        |" + allsvenskan6 + "|" + (tidfix6 + 1).ToString() + ":" + tidfixmin6 + "|");
                        if (allsvenskan7 != null) outputFile.WriteLine("        |" + allsvenskan7 + "|" + (tidfix7 + 1).ToString() + ":" + tidfixmin7 + "|");
                        outputFile.WriteLine("        ");
                        outputFile.WriteLine("        ___");
                        outputFile.WriteLine("        ");
                        outputFile.WriteLine("        ");


                    }
                    /*outputFile.WriteLine("        ");
                    outputFile.WriteLine("        ");
                    outputFile.WriteLine("---");
                    */
                }
                string sdhl1 = null;
                string sdhl1tid = null;
                string sdhl2 = null;
                string sdhl2tid = null;
                string sdhl3 = null;
                string sdhl3tid = null;
                string sdhl4 = null;
                string sdhl4tid = null;
                string sdhl5 = null;
                string sdhl5tid = null;
                string sdhl6 = null;
                string sdhl6tid = null;
                string sdhl7 = null;
                string sdhl7tid = null;
                nr = 1;
                for (i = 0; i < sdhl.Length; i++)
                {
                    string år = sdhl[i].Tid.Substring(0, 4);

                    string månad = sdhl[i].Tid.Substring(4, 2);
                    string dag = sdhl[i].Tid.Substring(6, 2);
                    string tid = sdhl[i].Tid.Substring(9, 2) + ":" + sdhl[i].Tid.Substring(11, 2);
                    if (date.Month == int.Parse(månad) && date.Day == int.Parse(dag))
                    {
                        if (nr == 1)
                        {
                            sdhl1 = sdhl[i].Lag;
                            sdhl1tid = sdhl[i].Tid;

                        }
                        else if (nr == 2)
                        {
                            sdhl2 = sdhl[i].Lag;
                            sdhl2tid = sdhl[i].Tid;

                        }
                        else if (nr == 3)
                        {
                            sdhl3 = sdhl[i].Lag;
                            sdhl3tid = sdhl[i].Tid;

                        }

                        else if (nr == 4)
                        {
                            sdhl4 = sdhl[i].Lag;
                            sdhl4tid = sdhl[i].Tid;

                        }
                        else if (nr == 5)
                        {
                            sdhl5 = sdhl[i].Lag;
                            sdhl5tid = sdhl[i].Tid;

                        }
                        else if (nr == 6)
                        {
                            sdhl6 = sdhl[i].Lag;
                            sdhl6tid = sdhl[i].Tid;

                        }
                        else if (nr == 7)
                        {
                            sdhl7 = sdhl[i].Lag;
                            sdhl7tid = sdhl[i].Tid;

                        }
                        nr++;
                    }
                }
                date1 = monthstring + " " + date.Day + ", " + date.Year + " 11:00";
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt"), true))
                {
                    outputFile.WriteLine("        ");
                    outputFile.WriteLine("        **SDHL:**");

                    if (sdhl1 == null)
                    {
                        outputFile.WriteLine("        Inga matcher idag!");
                        outputFile.WriteLine("        ");
                        outputFile.WriteLine("        ___");
                    }
                    else
                    {

                        outputFile.WriteLine("        ");
                        outputFile.WriteLine("        | Lag | Tid");
                        outputFile.WriteLine("        |:-----------|------------:|");
                        int tidfix1 = 0;
                        int tidfix2 = 0;
                        int tidfix3 = 0;
                        int tidfix4 = 0;
                        int tidfix5 = 0;
                        int tidfix6 = 0;
                        int tidfix7 = 0;
                        string tidfixmin1 = null;
                        string tidfixmin3 = null;
                        string tidfixmin2 = null;
                        string tidfixmin4 = null;
                        string tidfixmin5 = null;
                        string tidfixmin6 = null;
                        string tidfixmin7 = null;
                        if (sdhl1tid != null)
                        {
                            tidfix1 = Convert.ToInt32(sdhl1tid.Substring(9, 2));
                            tidfix1 = tidfix1 + 1;
                            tidfixmin1 = sdhl1tid.Substring(11, 2);
                        }
                        if (sdhl2tid != null)
                        {
                            tidfix2 = Convert.ToInt32(sdhl2tid.Substring(9, 2));
                            tidfix2++;
                            tidfixmin2 = sdhl2tid.Substring(11, 2);
                        }
                        if (sdhl3tid != null)
                        {
                            tidfix3 = Convert.ToInt32(sdhl3tid.Substring(9, 2));
                            tidfix3++;
                            tidfixmin3 = sdhl3tid.Substring(11, 2);
                        }
                        if (sdhl4tid != null)
                        {
                            tidfix4 = Convert.ToInt32(sdhl4tid.Substring(9, 2));
                            tidfix4++;
                            tidfixmin4 = sdhl4tid.Substring(11, 2);
                        }
                        if (sdhl5tid != null)
                        {
                            tidfix5 = Convert.ToInt32(sdhl5tid.Substring(9, 2));
                            tidfix5++;
                            tidfixmin5 = sdhl5tid.Substring(11, 2);
                        }
                        if (sdhl6tid != null)
                        {
                            tidfix6 = Convert.ToInt32(sdhl6tid.Substring(9, 2));
                            tidfix6++;
                            tidfixmin6 = sdhl6tid.Substring(11, 2);
                        }
                        if (sdhl7tid != null)
                        {
                            tidfix7 = Convert.ToInt32(sdhl7tid.Substring(9, 2));
                            tidfix7++;
                            tidfixmin7 = sdhl7tid.Substring(11, 2);
                        }
                        outputFile.WriteLine("        |" + sdhl1 + "|" + (tidfix1 + 1).ToString() + ":" + tidfixmin1 + " |");
                        if (sdhl2 != null) outputFile.WriteLine("        |" + sdhl2 + "|" + (tidfix2 + 1).ToString() + ":" + tidfixmin2 + "|");
                        if (sdhl3 != null) outputFile.WriteLine("        |" + sdhl3 + "|" + (tidfix3 + 1).ToString() + ":" + tidfixmin3 + "|");
                        if (sdhl4 != null) outputFile.WriteLine("        |" + sdhl4 + "|" + (tidfix4 + 1).ToString() + ":" + tidfixmin4 + "|");
                        if (sdhl5 != null) outputFile.WriteLine("        |" + sdhl5 + "|" + (tidfix5 + 1).ToString() + ":" + tidfixmin5 + "|");
                        if (sdhl6 != null) outputFile.WriteLine("        |" + sdhl6 + "|" + (tidfix6 + 1).ToString() + ":" + tidfixmin6 + "|");
                        if (sdhl7 != null) outputFile.WriteLine("        |" + sdhl7 + "|" + (tidfix7 + 1).ToString() + ":" + tidfixmin7 + "|");
                        outputFile.WriteLine("        ");
                        outputFile.WriteLine("        ___");
                        outputFile.WriteLine("        ");
                        outputFile.WriteLine("        ");


                    }
                    outputFile.WriteLine("        ");
                    outputFile.WriteLine("        ");
                    outputFile.WriteLine("        *För tillfället vet jag bara när det är match i SHL, SDHL och HA - men jag uppdateras varje dag, och snart finns alla relevanta ligor här att se!*");
                    outputFile.WriteLine("---");

                }
                tbxSchema.Text = File.ReadAllText(Path.Combine(docPath, "WriteLines.txt"));
            }

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BtnSHL_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Välj JSON i textformat",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxSHL.Text = openFileDialog1.FileName;
            }
        }

        private void BtnHA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Välj JSON i textformat",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                tbxHA.Text = openFileDialog2.FileName;
            }
        }

        private void BtnLiga3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Välj JSON i textformat",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxLiga3.Text = openFileDialog1.FileName;
            }
        }

        private void BtnLiga4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Denna funktion är för tillfället inte komplett! Forsätt med försiktighet!", "Varning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation ,MessageBoxDefaultButton.Button2);
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Välj JSON i textformat",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxLiga4.Text = openFileDialog1.FileName;
            }
        }
    }
}