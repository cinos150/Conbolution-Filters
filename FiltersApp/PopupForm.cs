using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltersApp
{
    public partial class PopupForm : Form
    {
        public static  double[,] arr2d;
        public static int divisor = 1;
        public static int offset = 0;
        public static int AnchorX = -1;
        public static int AnchorY = -1;
        public static String newFilter = "";
        public static bool wrongInput = false;

        private int? RowNum = 3;
        private int? ColNum = 3;
        private List<List<TextBox>> matrix = new List<List<TextBox>>();
        private List<ReadyMatrix> GivenMatrix;


        public PopupForm()
        {
            InitializeComponent();

            int[] num = {1, 3, 5, 7, 9 };
            int[] num2 = {1, 3, 5, 7, 9 };
            XBox.DataSource = num;
            YBox.DataSource = num2;
            wrongInput = false;

            List<String> tempConvName = new List<string>();
            GivenMatrix = MainWindow.userMatrix;
            tempConvName.Add("");
            for (int i = 0; i <GivenMatrix.Count; i++)
            {
                tempConvName.Add(GivenMatrix[i].convultionName);
            }

            predefinedFiltersComboBox.DataSource = tempConvName;



            TextBoxGrid.EditingControlShowing += TextBoxGrid_EditingControlShowing;
            TextBoxGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void TextBoxGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(CheckKey);
        }

        private void CheckKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsNumber(e.KeyChar)
                && e.KeyChar != '.'
                && e.KeyChar != '-'

                )
            {
                e.Handled = true;
            }
        }


        private void XBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RowNum = XBox.SelectedValue as int?;
            int[] tempArr = new int[(int)RowNum];

            TextBoxGrid.ColumnCount = (int)ColNum;

            TextBoxGrid.RowCount = (int)RowNum;


            for (int i = 0; i < RowNum; i++)
            {
                tempArr[i] = i;
            }

            anchorXComboBox.DataSource = tempArr;
         



        }

        private void TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void YBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            ColNum = YBox.SelectedValue as int?;

            int[] tempArr = new int[(int)ColNum];

            TextBoxGrid.ColumnCount = (int)ColNum;

            TextBoxGrid.RowCount = (int)RowNum;


            for (int i = 0; i < ColNum; i++)
            {
                tempArr[i] = i;
            }

            anchorYComboBox.DataSource = tempArr;





        }


        private void getDataFromMatrix()
        {
            arr2d = new double[TextBoxGrid.Rows.Count, TextBoxGrid.Columns.Count];

            double value;

            offset = Convert.ToInt32(offsetNumeric.Value);
            divisor = Convert.ToInt32(dividerNumeric.Value);
            String defaultValue = Convert.ToString(defaultValueNumeric.Value);
            int? tempAnchorX = anchorXComboBox.SelectedValue as int?;
            AnchorX = (int)tempAnchorX;

            int? tempAnchorY = anchorYComboBox.SelectedValue as int?;
            AnchorY = (int)tempAnchorY;




            for (int x = 0; x < arr2d.GetLength(0); x++)
            {
                for (int i = 0; i < arr2d.GetLength(1); i++)
                {

                    if (TextBoxGrid.Rows[x].Cells[i].Value == null)
                        TextBoxGrid.Rows[x].Cells[i].Value = defaultValue;
                    try
                    {
                        value = Convert.ToDouble(TextBoxGrid.Rows[x].Cells[i].Value);
                        arr2d[x, i] = value;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Wrong input");
                        Console.WriteLine(ex.StackTrace);
                        wrongInput = true;
                        return;
                    }

                }
            }

        }
        private void acceptButton_click(object sender, EventArgs e)
        {

            getDataFromMatrix();

        }

        private void saveButton_click(object sender, EventArgs e)
        {
            if (saveTextBox.Text == "" || saveTextBox.Text == "Name it !")
            {
                saveTextBox.Text = "Name it !";
                saveTextBox.Focus();
            }
            else
            {
                newFilter = saveTextBox.Text;
               
            }
        }

        private void LoadPredefinedFilterToMatrix(object sender, EventArgs e)
        {
            String otherFilters = predefinedFiltersComboBox.SelectedValue as String;

            if (otherFilters == "")
                return;

           ReadyMatrix Rm = GivenMatrix.Find(x => x.convultionName == otherFilters);

            TextBoxGrid.ColumnCount = Rm.arr2d.GetLength(1);

            TextBoxGrid.RowCount = Rm.arr2d.GetLength(0);

   
            XBox.SelectedIndex =(Rm.arr2d.GetLength(0))/2;
            YBox.SelectedIndex = (Rm.arr2d.GetLength(1))/2;
          
           


            offsetNumeric.Value = Rm.offset;
            dividerNumeric.Value = Rm.divisor==0? ++Rm.divisor: Rm.divisor;
            anchorXComboBox.SelectedIndex = (Rm.anchorX);
            anchorYComboBox.SelectedIndex = (Rm.anchorY);

            for (int x = 0; x < Rm.arr2d.GetLength(0); x++)
            {
                for (int i = 0; i < Rm.arr2d.GetLength(1); i++)
                {

                    TextBoxGrid.Rows[x].Cells[i].Value = Rm.arr2d[x, i];
                }
            }



        }
    }
}
