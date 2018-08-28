using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEasy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int filas = 0;
        public string[] listaimg = new string[1500];
        List<string> getAllNotePadFiles;
        Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
        Worksheet ws;
        private void btnopen_Click(object sender, EventArgs e)
        {
            //abrir();
            abierto();
        }

        void abrir()
        {
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();

            if (xlapp == null)
            {
                Console.WriteLine("No puede ser abierto");
                return;
            }
            xlapp.Visible = true;

            Workbook wb = xlapp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            if (ws == null)
            {
                Console.WriteLine("Worksheet no puede ser creado.");
            }

            Range range = ws.Range["C1", "C7"];
            var n = ws.Range["C1"].Value2;

            if (range == null)
            {
                Console.WriteLine("Rango no puede ser obtenido");
            }
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                "All files (*.*)|*.*";

            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Select photos";

            DialogResult dr = openFileDialog1.ShowDialog();

            ws.Shapes.AddPicture(openFileDialog1.FileName, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, 50, 50);
            Console.WriteLine(n);

            /*
            Object[] args = new Object[1];
            args[0] = 6;
            range.GetType().InvokeMember("Value", System.Reflection.BindingFlags.SetProperty, null, range, args);
            range.Value2 = 8;*/

        }

        private void btntxt_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtfilas.Text = openFileDialog1.FileName;
            }

        }

        private void btnimg_Click(object sender, EventArgs e)
        {

        }

        public bool ThumbnailCallBack()
        {
            return false;
        }

        public string[] Imagenes()
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                "All files (*.*)|*.*";

            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Select photos";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    try
                    {
                        PictureBox image = new PictureBox();
                        image.Height = 100;
                        image.Width = 100;

                        Image.GetThumbnailImageAbort myCallback =
                            new Image.GetThumbnailImageAbort(ThumbnailCallBack);
                        Bitmap bitmap = new Bitmap(file);
                        Image myThumbnail = bitmap.GetThumbnailImage(96, 96, myCallback, IntPtr.Zero);
                        image.Image = myThumbnail;

                        Console.WriteLine(System.IO.Path.GetFileNameWithoutExtension(file));
                        //PhotoGallary.Controls.Add(image);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error: " + ex.Message);
                        string[] vacio = new string[100];
                        return vacio;
                    }
                }
            }
            return openFileDialog1.FileNames;
        }
        void abierto()
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string local = openFileDialog1.FileName;
                String filename = DialogResult.ToString();

                xlapp.Visible = true;
                xlapp.Workbooks.Open(local);
                ws = (Worksheet)xlapp.Worksheets[1];

                Range range = ws.Range["C1", $"C50"];
                var n = ws.Range["C1"].Value2;

                if (range == null)
                {
                    Console.WriteLine("Rango no puede ser obtenido");
                }
            }

        }

        private void btnfilas_Click(object sender, EventArgs e)
        {
            filas = Convert.ToInt16(txtfilas.Text);
        }

        private void btnselect_Click(object sender, EventArgs e)
        {

            if (filas > 0)
            {
                openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                    "All files (*.*)|*.*";

                openFileDialog1.Multiselect = true;
                openFileDialog1.Title = "Select photos";

                DialogResult dr = openFileDialog1.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    listaimg = openFileDialog1.FileNames;
                    Range[] lista = new Range[filas];
                    Range range2 = ws.Range["E1", $"E{filas}"];
                    Range[] lista2 = new Range[filas];
                    for (int i = 0; i <= listaimg.Length; i++)
                    {
                        for (int j = 1; j <= filas; j++)
                        {
                            try
                            {
                                if (System.IO.Path.GetFileNameWithoutExtension(listaimg[i]) == ws.Range[$"C{j}"].Text)
                                {
                                    Console.WriteLine("uno");
                                    Microsoft.Office.Interop.Excel.Range oRange = (Microsoft.Office.Interop.Excel.Range)ws.Cells[j, 5];
                                    float Left = (float)((double)oRange.Left);
                                    float Top = (float)((double)oRange.Top);
                                    const float ImageSize = 32;
                                    ws.Shapes.AddPicture(listaimg[i], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, 70, 90);
                                }
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Error: " + ex.Message);
                                break;
                            }

                        }
                    }
                }

            }
            else
            {
                //mm
            }
        }

        private void btnfully_Click(object sender, EventArgs e)
        {

            if (filas > 0)
            {
                Range[] lista = new Range[filas];
                Range range2 = ws.Range["E1", $"E{filas}"];
                Range[] lista2 = new Range[filas];
                //for (int i = 0; i <= listaimg.Length; i++)
                //{
                for (int j = 1; j <= filas; j++)
                {

                    //var test = from getAllNotePadFiles 
                    //         Contains(ws.Range[$"C{j}"].Text+".jpg");

                    var n = getAllNotePadFiles.Where(file => file.Contains(ws.Range[$"C{j}"].Text)).ToList();


                    try
                    {
                        if (n.Count > 0)
                        {
                            Console.WriteLine(n[0]);
                            Console.WriteLine("uno");
                            Microsoft.Office.Interop.Excel.Range oRange = (Microsoft.Office.Interop.Excel.Range)ws.Cells[j, 5];
                            float Left = (float)((double)oRange.Left);
                            float Top = (float)((double)oRange.Top);
                            const float ImageSize = 32;
                            ws.Shapes.AddPicture(n[0], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, 70, 90);
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error: " + ex.Message);
                        break;
                    }

                }
                //Microsoft.Office.Interop.Excel.Range oRange = (Microsoft.Office.Interop.Excel.Range)ws.Cells[3, 5];
                //float Left = (float)((double)oRange.Left);
                //float Top = (float)((double)oRange.Top);
                // const float ImageSize = 32;
                // ws.Shapes.AddPicture(@"C:\Users\Raul Sanchez\Desktop\2ca3e241-1407-433c-ae9b-96a1c03245d0.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, 70, 90);
                //Console.WriteLine(lista[48].Text);
                //Console.WriteLine(lista2[48].Text);
            }
            else
            {
                //mm
            }
        }

        private void btnfolder_Click(object sender, EventArgs e)
        {
            if (filas > 0)
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        string[] files = Directory.GetFiles(fbd.SelectedPath);
                        DirectoryInfo dir = new DirectoryInfo(fbd.SelectedPath);
                        int h = 0;
                        foreach (var item in dir.GetFiles())
                        {
                            listaimg[h] = item.FullName;
                            Console.WriteLine(item.FullName);
                            string popo = System.IO.Path.GetFileNameWithoutExtension(item.FullName);
                            Console.WriteLine(popo);
                            h += 1;
                        }

                        getAllNotePadFiles = dir.GetFiles("*.jpg", SearchOption.AllDirectories)
                                            .Where(file => file.Name.Contains(".jpg"))
                                            .Select(file => file.FullName).ToList();

                        Range[] lista = new Range[filas];
                        Range range2 = ws.Range["E1", $"E{filas}"];
                        Range[] lista2 = new Range[filas];
                        //for (int i = 0; i <= listaimg.Length; i++)
                        //{
                        for (int j = 1; j <= filas; j++)
                        {

                            //var test = from getAllNotePadFiles 
                            //         Contains(ws.Range[$"C{j}"].Text+".jpg");

                            var n = getAllNotePadFiles.Where(file => file.Contains(ws.Range[$"C{j}"].Text)).ToList();


                            try
                            {
                                if (n.Count > 0)
                                {
                                    Console.WriteLine(n[0]);
                                    Console.WriteLine("uno");
                                    Microsoft.Office.Interop.Excel.Range oRange = (Microsoft.Office.Interop.Excel.Range)ws.Cells[j, 5];
                                    float Left = (float)((double)oRange.Left);
                                    float Top = (float)((double)oRange.Top);
                                    const float ImageSize = 32;
                                    ws.Shapes.AddPicture(n[0], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, 70, 90);
                                }
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Error: " + ex.Message);
                                break;
                            }

                        }
                        //}
                        //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                    }
                }
            }
        }
    }
}
