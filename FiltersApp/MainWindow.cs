using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;

namespace FiltersApp
{

    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();


            userMatrix = new List<ReadyMatrix>();
            String[] otherFilters = { "Brightness", "Contrast", "Gamma Correction" };
            otherFiltersBox.DropDownStyle = ComboBoxStyle.DropDownList;
            otherFiltersBox.DataSource = otherFilters;

            PredefinedValues PreVal = new PredefinedValues();
            

            for (int i = 0; i < PredefinedValues.numOfPredefinedArg; i++)
            {
                userMatrix.Add( new ReadyMatrix(PredefinedValues.predefinedConvNames[i], (double[,])PreVal.AList[i]));
                AddMenuItem(PredefinedValues.predefinedConvNames[i], i);
            }




        }


    
    


       





        public static  List<ReadyMatrix> userMatrix;
        public static Bitmap MainPicture = null;
        
        string otherFilters = "";



        private void openFile_click(object sender, EventArgs e)
        {

           

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    mainPicture.Image = MainPicture = new Bitmap(dlg.FileName);
                    Controls.Add(mainPicture);

                    if (dlg.FileName == HistoryLW.currFileName)
                        return;




                    HistoryLW.ImgList.ImageSize = new Size(90, 90);


                    HistoryLW.ImgList.Images.Add(Image.FromFile(dlg.FileName));
                    historyListView.LargeImageList = HistoryLW.ImgList;
                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag = dlg.FileName;
                    lvi.ImageIndex = ++HistoryLW.index;
                    HistoryLW.currFileName = dlg.FileName;
                    historyListView.Items.Add(lvi);
                    historyListView.Refresh();

                }
            }
        }


        private void performFilterOperation(double[,] filter, int x, int variation = 0)
        {
            if (MainPicture == null)
                return;

            FilterAlgorithm Fal = new FilterAlgorithm(this, MainPicture);

            Cursor.Current = Cursors.WaitCursor;

            switch (x)
            {
                case 0:
                    mainPicture.Image =Fal.filterAlgorithm(filter);
                    break;
                case 1:
                    mainPicture.Image =  Fal.GrayScale();
                    break;
                case 2:
                    mainPicture.Image = Fal.Inversion();
                    break;
               
                default:
                    return;


            }

            Cursor.Current = Cursors.Default;

        }


        private void greyScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            performFilterOperation(null, 1);
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            performFilterOperation(null, 2);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopupForm popup = new PopupForm();
            DialogResult dialogresult = popup.ShowDialog();

            if (dialogresult == DialogResult.OK && PopupForm.wrongInput == false)
            {
               
               
                

                if (PopupForm.newFilter == "" || PopupForm.newFilter == "Name it !")
                {
                    if (MainPicture == null)
                        return;

                    FilterAlgorithm Fal = new FilterAlgorithm(this, MainPicture, PopupForm.divisor, PopupForm.offset, PopupForm.AnchorX, PopupForm.AnchorY);
                    Cursor.Current = Cursors.WaitCursor;
                    mainPicture.Image = Fal.filterAlgorithm(PopupForm.arr2d);
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    ReadyMatrix RM = new ReadyMatrix(PopupForm.newFilter, PopupForm.arr2d,PopupForm.divisor, PopupForm.offset, PopupForm.AnchorX, PopupForm.AnchorY);
                    userMatrix.Add(RM);
                    
                    AddMenuItem(PopupForm.newFilter, userMatrix.Count -1);
                    PopupForm.newFilter = "";
                }

            }
            else if (dialogresult == DialogResult.Cancel)
            {

            }
            popup.Dispose();


        }


        void AddMenuItem(string text, int counter)
        {

     
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Text = text;
            item.Click += Item_Click;
            item.Tag = counter;
            

            filtersToolStripMenuItem.DropDownItems.Insert(filtersToolStripMenuItem.DropDownItems.Count, item);
        }

        private void Item_Click(object sender, EventArgs e)
        {

          
            ToolStripMenuItem currItem = sender as ToolStripMenuItem;
            ReadyMatrix REMa = userMatrix[(int)currItem.Tag];

            if ((int)currItem.Tag < PredefinedValues.numOfPredefinedArg)
            {
                performFilterOperation(REMa.arr2d, 0);
            }
            else
            {

                if (MainPicture == null)
                    return;

                FilterAlgorithm Fal = new FilterAlgorithm(this, MainPicture, REMa.divisor, REMa.offset, REMa.anchorX, REMa.anchorY);
                Cursor.Current = Cursors.WaitCursor;
                mainPicture.Image =  Fal.filterAlgorithm(REMa.arr2d);
                Cursor.Current = Cursors.Default;
            }
        }

        private void historyListView_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in historyListView.SelectedItems)
            {
                int imgIndex = itm.ImageIndex;
                if (imgIndex >= 0 && imgIndex < HistoryLW.ImgList.Images.Count)
                {
                    mainPicture.Image =  MainPicture =  new Bitmap((String)itm.Tag);
                }
            }
        }

     

        private void otherFiltersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            otherFilters = otherFiltersBox.SelectedValue as String;

            switch (otherFilters)
            {
                case "Gamma Correction":
                    otherFiltersTrackBar.Minimum = -20;
                    otherFiltersTrackBar.Maximum = 500;
                    otherFiltersTrackBar.Value = 260;
                    
                    break;
                case "Contrast":
                    otherFiltersTrackBar.Minimum = -100;
                    otherFiltersTrackBar.Maximum = 100;
                    otherFiltersTrackBar.Value = 50;                    
                    break;                      
                 
                default:
                    otherFiltersTrackBar.Minimum = -255;
                    otherFiltersTrackBar.Maximum = 255;                  
                    break;

            }

        }

        private void otherFiltersTrackBar_Up(object sender, MouseEventArgs e)
        {
            UseAdditionalFiltersOnTrackBar();
        }
        private void otherFiltersTrackBar_KeyUp(object sender, KeyEventArgs e)
        {
            UseAdditionalFiltersOnTrackBar();
        }
        private void UseAdditionalFiltersOnTrackBar()
        {
            if (MainPicture == null)
                return;

            int var = otherFiltersTrackBar.Value;
            double doubleVar = 0.00;



            FilterAlgorithm Fal = new FilterAlgorithm(this, MainPicture);


            switch (otherFilters)
            {
                case "Brightness":

                    mainPicture.Image = Fal.Brightness(var);
                    break;
                case "Contrast":
                    mainPicture.Image = Fal.Contrast(var);
                    break;
                case "Gamma Correction":
                    doubleVar = Convert.ToDouble(var)/100;
                    mainPicture.Image = Fal.GammaCorrection(doubleVar);
                    break;
                default:
                    break;




            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MainPicture = (Bitmap)mainPicture.Image;
        }

        private void ExitApplicaton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveFile_Click(object sender, EventArgs e)
        {

            if (MainPicture == null)
                return;
             SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MainPicture.Save(dialog.FileName, ImageFormat.Jpeg);
              
            }


        }

       
    }



    public class HistoryLW
    {
       public static int index = -1;
        public static String currFileName = "";
        public static  ImageList ImgList = new ImageList();

    }

 
  


}
