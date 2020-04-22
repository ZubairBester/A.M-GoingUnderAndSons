using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A.M.GoingUnderAndSons_Pty_Ltd
{
    public partial class AMGoingUnderAndSonsLTD : Form
    {
        //variable for array item
        string[] arrItems = new string[] { "Pentium Pro", "CD of games", "Connectors", "Magazine", "Disk"};
        int intP;

        //variable for quantity items
        int[] arrQuant = new int[99];
        int intQ;
        //{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30,31,34,35,36 

        //SW and SR
        string line;

        //variable for price
        double price;       

        double dblTotal = 0;
        public AMGoingUnderAndSonsLTD()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double dblDiscount = 0.20;
            double dblTotalDiscount = 0;
            double dblTotalDisc2 = 0;
            double dblTotaldisc1 = 0;

            double dblSumDiscount = 0;

            double dbltakeDiscount = 19.00;
            double dblTotalItemPurchased = 0;


            double dblSecond = 0;


            double dblFirstDisc = 0;


            double totalAnswer = 0;
            double totalAnswer2 = 0;

            double totalAnswer3 = 0;

            double totalAnswer3_1 = 0;

            double TotalDiscAll = 0;
            switch (cmboItem.SelectedIndex)
            {
                case 0:
                    price = 3000; //pentium pro




                    break;
                case 1:
                    price = 95.00; //CD of games



                    break;
                case 2:
                    price = 30.00; //Connectors

                    break;
                case 3:

                    price = 21.00;
                    break;
                case 4:
                    price = 10.00;
                    break;

                default:
                    price = 0;
                    MessageBox.Show("Please select Item");
                    listView1.Clear();
                    listView1.Columns.Add("Items", 120, HorizontalAlignment.Center);
                    listView1.Columns.Add("Price", 120, HorizontalAlignment.Center);
                    listView1.Columns.Add("Quantity", 140, HorizontalAlignment.Center);
                    listView1.Columns.Add("Total Discount", 140, HorizontalAlignment.Center);
                    listView1.Columns.Add("Cost Including Discount", 140, HorizontalAlignment.Center);


                    try
                    {
                        listView1.Items.Add(cmboItem.SelectedItem.ToString()); // Index 0
                    }
                    catch
                    {
                        MessageBox.Show("Please select Item");
                    }
                    break;
            }

            //ListViewItem items = listView1.Items.Add(cmboPizza.SelectedItem.ToString());
            //items.SubItems.Add(string.Format("{0}", price));
            //items.SubItems.Add(cmboQuantP1.SelectedItem.ToString());
            //Items will be added after calculations
            double discountTot = 0;

            double discountTott = 0;
            try
            {
                string isNothing = cmboItem.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(isNothing))
                {
                    ListViewItem lvwItem = listView1.Items.Add(isNothing); // Index 0

                    lvwItem.SubItems.Add(string.Format(price.ToString("R"))); //index 1
                    lvwItem.SubItems.Add(cmboQuantP1.SelectedItem.ToString()); // Index 2
                    foreach (ListViewItem item in listView1.Items)
                    {
                        // Get line quantity
                        //double line_drinks = Convert.ToDouble(item.SubItems[1].Text.Replace("R", " ").Trim());

                        int line_qty = Convert.ToInt32(item.SubItems[2].Text);

                        double line_Amount = Convert.ToDouble(item.SubItems[1].Text.Replace("{0:c}", " ").Trim());


                        // Get line total
                        dblTotal = line_qty * line_Amount;
                        //dblTotalAmount += dblTotal;

                        if ((line_Amount > 20) && (line_Amount < 101) && (discountTot < 5))
                        {
                            discountTot = 5;
                            dblTotalDiscount = dblTotal / line_qty;
                            totalAnswer = dblTotalDiscount * 0.20;
                            totalAnswer2 = totalAnswer * line_qty;
                            discountTott = line_Amount - discountTot;
                            totalAnswer3 = line_Amount * line_qty - totalAnswer2;
                            //totalAnswer3 = line_Amount * line_qty - totalAnswer2;

                        }


                        if (line_Amount > 100)                        
                        {
                            double dblTotalDiscount1 = 20;
                            
                            //if (discountTot >= 20)
                            //{
                            //    discountTot = 20;
                            //}

                            totalAnswer2 = line_qty * dblTotalDiscount1;
                            totalAnswer3 = line_Amount * line_qty - totalAnswer2;


                            //dblTotalDiscount = dblTotal / line_qty;
                            //totalAnswer = dblTotalDiscount * 0.20;
                            //totalAnswer2 = totalAnswer * line_qty;
                        }

                        //dblTotalItemPurchased = dblFirstDisc + dblSecond;
                        TotalDiscAll = totalAnswer3 + totalAnswer3_1;

                        
                    }

                    lvwItem.SubItems.Add(string.Format("{0:c}", totalAnswer2));
                    lvwItem.SubItems.Add(string.Format("{0:c}", totalAnswer3));
                  

                }

            }
            catch
            {
                MessageBox.Show("Please select quantity");
            }

            try
            {
                //rchtxtbox.Text += string.Format("\n{0}", cmboPizza.SelectedItem.ToString()) + " " + string.Format("\t\t{0:c}", price) + " " +
                    //string.Format("\t\t{0}", cmboQuantP1.SelectedItem.ToString());
            }
            catch
            {
                MessageBox.Show("No items was selected");
            }
            
            //Reset combobox and radio buttons
            cmboItem.Text = "Select Item";
            cmboQuantP1.Text = "Select Quantity";

            btnCalculate.Enabled = true;

        }

        private void AMGoingUnderAndSonsLTD_Load(object sender, EventArgs e)
        {
            //for items
            for (intP = 0; intP < arrItems.Length; intP++)
            {

                cmboItem.Items.Add(arrItems[intP]);

            }
            cmboItem.Text = "Select a item";
            cmboQuantP1.Text = "Select quantity";


            cmboQuantP1.Enabled = false;

            //For quantity
            for (intQ = 0; intQ <= arrQuant.Length; intQ++)
            {
                try
                {
                    arrQuant[intQ + 1 * 1] += cmboQuantP1.Items.Add(arrQuant[intQ]);

                }
                catch (IndexOutOfRangeException)
                {


                }
            }


            //Listview Properties:
            //Listview Details 
            listView1.View = View.Details;
            //Allow user to edit labels
            listView1.LabelEdit = true;
            //Allow user to change column order
            listView1.AllowColumnReorder = false;
            //Display checkboxes
            //lstView.CheckBoxes = true;
            //Display gridlines
            listView1.GridLines = true;
            //Allows user to select entire row
            listView1.FullRowSelect = true;


            //Create columns, width of -2 indicates auto-size
            listView1.Columns.Add("Items", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Price", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Quantity", 140, HorizontalAlignment.Center);
            listView1.Columns.Add("Total Discount", 140, HorizontalAlignment.Center);
            listView1.Columns.Add("Cost Including Discount", 140, HorizontalAlignment.Center);

            //Add listview as a control
            this.Controls.Add(listView1);

            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dblDiscount = 0.20;
            double dblTotalDiscount = 0;
            double dblTotalDisc2 = 0;
            double dblTotaldisc1 = 0;

            double dblSumDiscount = 0;

            double dbltakeDiscount = 19.00;
            double dblTotalItemPurchased = 0;


            double dblSecond = 0;


            double dblFirstDisc = 0;


            double totalAnswer = 0;
            double totalAnswer2 = 0;

            double totalAnswer3 = 0;

            double totalAnswer3_1 = 0;

            double TotalDiscAll = 0;

            double discounttot = 0;

            int TotalQuantity = 0;
            double quantityTotal = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                // Get line quantity
                //double line_drinks = Convert.ToDouble(item.SubItems[1].Text.Replace("R", " ").Trim());

                int line_qty = Convert.ToInt32(item.SubItems[2].Text);

                double line_Amount = Convert.ToDouble(item.SubItems[4].Text.Replace("$", " ").Trim());

                // Get line total
                dblTotal = line_Amount;
                double discountTott = 0;
                double columnsum = 0;
                double totalDiscount = 0;

                double totalDiscounTotal = 0;
               
                try
                {
                    for (int i = 0; i < this.listView1.Items.Count; i++)
                    {

                        int line_qty2 = Convert.ToInt32(item.SubItems[2].Text);
                        columnsum += Convert.ToDouble(this.listView1.Items[i].SubItems[4].Text.Replace("$", " ").Trim());
                       // columnsum += Convert.ToDouble(this.listView1.Items[i].SubItems[4].Text);

                        quantityTotal = columnsum * line_qty2;

                        totalDiscount = Convert.ToDouble(this.listView1.Items[i].SubItems[3].Text.Replace("$", " ").Trim());

                        totalDiscounTotal += totalDiscount;
                        //dblTotalAmount += dblTotal;
                        TotalQuantity += line_qty2;
                        double discountCalc = Convert.ToDouble(item.SubItems[3].Text.Replace("$", " ").Trim());

                        discounttot += discountCalc;

                        if ((line_Amount > 20) && (line_Amount < 101) && (discounttot < 5))
                        {
                            discounttot = 5;
                            dblTotalDiscount = dblTotal / line_qty;
                            totalAnswer = dblTotalDiscount * 0.20;
                            totalAnswer2 = totalAnswer * line_qty;
                            discountTott = line_Amount - discounttot;
                            totalAnswer3 = line_Amount * line_qty - totalAnswer2;
                            //totalAnswer3 = line_Amount * line_qty - totalAnswer2;

                        }


                        if (line_Amount > 100)
                        {
                            double dblTotalDiscount1 = 20;

                            totalAnswer2 = line_qty * dblTotalDiscount1;
                            totalAnswer3_1 = line_Amount * line_qty - totalAnswer2;


                            //dblTotalDiscount = dblTotal / line_qty;
                            //totalAnswer = dblTotalDiscount * 0.20;
                           //totalAnswer2 = totalAnswer * line_qty;
                        }

                        //dblTotalItemPurchased = dblFirstDisc + dblSecond;
                        TotalDiscAll = totalAnswer3 + totalAnswer3_1;

                       

                        
                    }
                    //ListViewItem p = listView1.Items.Add("Total Cost Of Purchase");

                    

                    

                    //p.SubItems.Add(string.Format("{0:c}", dblTotal));
                    ListViewItem s = listView1.Items.Add("Total Cost Of All items");


                    s.SubItems.Add(string.Format("{0:c}", columnsum));
                    ListViewItem totaldiscount = listView1.Items.Add("Total Discount");
                    totaldiscount.SubItems.Add(string.Format("{0:c}", totalDiscounTotal));

                    //ListViewItem totaldiscount2 = listView1.Items.Add("Total Discount 2");
                    //totaldiscount2.SubItems.Add(string.Format("{0:c}", totalAnswer3_1));


                    ListViewItem totalQuantity = listView1.Items.Add("No Of Items Total");
                    totalQuantity.SubItems.Add(string.Format("{0}", TotalQuantity));
                    //ListViewItem totalItemsPurchased = listView1.Items.Add("Total Cost including Discount");
                    //totalItemsPurchased.SubItems.Add(string.Format("{0:c}", totalAnswer3));


                    //lblTot.Text = "Total:";
                    //lblDisplayTot.Text = string.Format("{0:c}", dblTotal);
                    //rchtxtbox.Text += string.Format("\n\nTotal:\t{0:c}", dblTotal);
                    btnCalculate.Enabled = false;
                }
                catch (ArgumentException ex)
                {

                }




            }
        }
        
        private void btnClearList_Click(object sender, EventArgs e) //Clear button for listbox
        {
            listView1.Clear();
            listView1.Columns.Add("Items", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Price", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Quantity", 140, HorizontalAlignment.Center);
            listView1.Columns.Add("Total Discount", 140, HorizontalAlignment.Center);
            listView1.Columns.Add("Cost Including Discount", 140, HorizontalAlignment.Center);


           
            dblTotal = 0;   //To reset the total so that it don't add when a new user select an item i.e
            price = 0;

            

        }

        private void cmboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmboQuantP1.Enabled = true;
        }

        private void btnClearList_Click_1(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.Columns.Add("Items", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Price", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Quantity", 140, HorizontalAlignment.Center);
            listView1.Columns.Add("Total Discount", 140, HorizontalAlignment.Center);
            listView1.Columns.Add("Cost Including Discount", 140, HorizontalAlignment.Center);


           
            dblTotal = 0;   //To reset the total so that it don't add when a new user select an item i.e
            price = 0;

            btnCalculate.Enabled = true;
        }
    }
}
