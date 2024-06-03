using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class Converter : Form
    {
        double num, cm, mm, m, km, inches, foot, yard, mile, gm, pound, kg,ounce, mg, l, ml, cf, ci, cubicm;



        void ClearField()
        {
            TxtNum.Clear();
            TxtValue3.Clear();
            TxtValue4.Clear();
            TxtValue5.Clear();
            TxtValue6.Clear();
            TxtValue7.Clear();
            TxtValue8.Clear();
            ComboUnit.SelectedIndex = -1;
            ComboUnitType.SelectedIndex = -1;
        }

        public Converter()
        {
            InitializeComponent();
        }

        void CalculateLength()
        {
            if (ComboUnit.SelectedItem == "CM")
            {
                
                mm = num * 10;
                m = num / 100;
                km = num / 100000;
                inches = num / 2.54;
                foot = num / 30.48;
                yard = num / 91.44;
                mile = num / 160900;
                TxtValue3.Text = mm.ToString();
                TxtValue4.Text = km.ToString();
                TxtValue5.Text = inches.ToString();
                TxtValue6.Text = foot.ToString();
                TxtValue7.Text = yard.ToString();
                TxtValue8.Text = mile.ToString();
            }
            else if (ComboUnit.SelectedItem == "MM")
            {
                cm = num / 10;
                m = num / 1000;
                km = num / 1000000;
                inches = num / 25.4;
                foot = num / 304.8;
                yard = num / 914.4;
                mile = num / 1609000;
                TxtValue3.Text = cm.ToString();
                TxtValue4.Text = km.ToString();
                TxtValue5.Text = inches.ToString();
                TxtValue6.Text = foot.ToString();
                TxtValue7.Text = yard.ToString();
                TxtValue8.Text = mile.ToString();
            }
            else if (ComboUnit.SelectedItem == "KM")
            {
                mm = num * 1000000;
                cm = num * 100000;
                m = num * 1000;
                inches = num * 39370;
                foot = num * 3281;
                yard = num * 1094;
                mile = num / 1.609;
                TxtValue3.Text = cm.ToString();
                TxtValue4.Text = km.ToString();
                TxtValue5.Text = inches.ToString();
                TxtValue6.Text = foot.ToString();
                TxtValue7.Text = yard.ToString();
                TxtValue8.Text = mile.ToString();
            }
            else if (ComboUnit.SelectedItem == "Inch")
            {
                mm = num * 25.4;
                cm = num * 2.54;
                m = num / 39.37;
                km = num / 39370;
                foot = num / 12;
                yard = num / 36;
                mile = num / 63360;
                TxtValue3.Text = cm.ToString();
                TxtValue4.Text = km.ToString();
                TxtValue5.Text = inches.ToString();
                TxtValue6.Text = foot.ToString();
                TxtValue7.Text = yard.ToString();
                TxtValue8.Text = mile.ToString();
            }
            else if (ComboUnit.SelectedItem == "Foot")
            {
                mm = num * 304.8;
                cm = num * 30.48;
                m = num / 3.281;
                km = num / 3281;
                inches = num / 12;
                yard = num / 3;
                mile = num / 5280;
                TxtValue3.Text = cm.ToString();
                TxtValue4.Text = km.ToString();
                TxtValue5.Text = inches.ToString();
                TxtValue6.Text = foot.ToString();
                TxtValue7.Text = yard.ToString();
                TxtValue8.Text = mile.ToString();
            }
            else if (ComboUnit.SelectedItem == "Yard")
            {
                mm = num * 914.4;
                cm = num * 91.44;
                m = num / 1.094;
                km = num / 1094;
                inches = num * 36;
                foot = num * 3;
                mile = num / 1760;
                TxtValue3.Text = cm.ToString();
                TxtValue4.Text = km.ToString();
                TxtValue5.Text = inches.ToString();
                TxtValue6.Text = foot.ToString();
                TxtValue7.Text = yard.ToString();
                TxtValue8.Text = mile.ToString();
            }
            else if (ComboUnit.SelectedItem == "Mile")
            {
                mm = num * 1.609000;
                cm = num * 160900;
                m = num * 1609;
                km = num * 1.609;
                inches = num * 63360;
                foot = num * 5280;
                yard = num * 1760;
                TxtValue3.Text = cm.ToString();
                TxtValue4.Text = mm.ToString();
                TxtValue5.Text = km.ToString();
                TxtValue6.Text = inches.ToString();
                TxtValue7.Text = foot.ToString();
                TxtValue8.Text = yard.ToString();
            }

        }

        void CalculateWeight()
        {

            if (ComboUnit.SelectedItem == "Gm")
            {
                pound = num / 453.6;
                kg = num / 1000;
                ounce = num / 28.35;
                mg = num * 1000;
                
                TxtValue3.Text = pound.ToString();
                TxtValue4.Text = kg.ToString();
                TxtValue5.Text = ounce.ToString();
                TxtValue6.Text = mg.ToString();
            }
            else if (ComboUnit.SelectedItem == "Pound")
            {
                gm = num * 453.6;
                kg = num / 2.205;
                ounce = num * 16;
                mg = num * 453600;
                TxtValue3.Text = gm.ToString();
                TxtValue4.Text = kg.ToString();
                TxtValue5.Text = ounce.ToString();
                TxtValue6.Text = mg.ToString();
            }
            else if (ComboUnit.SelectedItem == "Kg")
            {
                gm = num * 1000;
                pound = num * 2.205;
                ounce = num * 35.274;
                mg = num * 1000000;
                TxtValue3.Text = gm.ToString();
                TxtValue4.Text = pound.ToString();
                TxtValue5.Text = ounce.ToString();
                TxtValue6.Text = mg.ToString();
            }
            else if (ComboUnit.SelectedItem == "Ounce")
            {
                gm = num * 28.35;
                pound = num / 16;
                kg = num / 35.274;
                mg = num * 28350;
                //mm = num * 25.4;
                //cm = num * 2.54;
                //m = num / 39.37;
                //km = num / 39370;
                //foot = num / 12;
                //yard = num / 36;
                //mile = num / 63360;
                TxtValue3.Text = gm.ToString();
                TxtValue4.Text = pound.ToString();
                TxtValue5.Text = kg.ToString();
                TxtValue6.Text = mg.ToString();
            }
            else if (ComboUnit.SelectedItem == "Mg")
            {
                gm = num / 1000;
                pound = num / 453600;
                kg = num / 1000000;
                ounce = num / 28350;
                TxtValue3.Text = gm.ToString();
                TxtValue4.Text = pound.ToString();
                TxtValue5.Text = kg.ToString();
                TxtValue6.Text = ounce.ToString();
            }
        }

        void CalculateVolume()
        {
            MessageBox.Show("Volume Conversion");


        }


        private void ComboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
                
            if (ComboUnit.SelectedItem == "CM")
            {
                LblUnit3.Text = "MM";
                LblUnit4.Text = "KM";
                LblUnit5.Text = "Inch";
                LblUnit6.Text = "Foot";
                LblUnit7.Text = "Yard";
                LblUnit8.Text = "Mile";
                LblUnit7.Show();
                LblUnit8.Show();
                TxtValue7.Show();
                TxtValue8.Show();

            }
            else if (ComboUnit.SelectedItem == "MM")
            {
                LblUnit3.Text = "CM";
                LblUnit4.Text = "KM";
                LblUnit5.Text = "Inch";
                LblUnit6.Text = "Foot";
                LblUnit7.Text = "Yard";
                LblUnit8.Text = "Mile";
                LblUnit7.Show();
                LblUnit8.Show();
                TxtValue7.Show();
                TxtValue8.Show();
            }
            else if (ComboUnit.SelectedItem == "KM")
            {
                LblUnit3.Text = "CM";
                LblUnit4.Text = "MM";
                LblUnit5.Text = "Inch";
                LblUnit6.Text = "Foot";
                LblUnit7.Text = "Yard";
                LblUnit8.Text = "Mile";
                LblUnit7.Show();
                LblUnit8.Show();
                TxtValue7.Show();
                TxtValue8.Show();
            }
            else if (ComboUnit.SelectedItem == "Inch")
            {
                LblUnit3.Text = "CM";
                LblUnit4.Text = "MM";
                LblUnit5.Text = "KM";
                LblUnit6.Text = "Foot";
                LblUnit7.Text = "Yard";
                LblUnit8.Text = "Mile";
                LblUnit7.Show();
                LblUnit8.Show();
                TxtValue7.Show();
                TxtValue8.Show();
            }
            else if (ComboUnit.SelectedItem == "Foot")
            {
                LblUnit3.Text = "CM";
                LblUnit4.Text = "MM";
                LblUnit5.Text = "KM";
                LblUnit6.Text = "Inch";
                LblUnit7.Text = "Yard";
                LblUnit8.Text = "Mile";
                LblUnit7.Show();
                LblUnit8.Show();
                TxtValue7.Show();
                TxtValue8.Show();
            }
            else if (ComboUnit.SelectedItem == "Yard")
            {
                LblUnit3.Text = "CM";
                LblUnit4.Text = "MM";
                LblUnit5.Text = "KM";
                LblUnit6.Text = "Inch";
                LblUnit7.Text = "Foot";
                LblUnit8.Text = "Mile";
                LblUnit7.Show();
                LblUnit8.Show();
                TxtValue7.Show();
                TxtValue8.Show();
            }
            else if (ComboUnit.SelectedItem == "Mile")
            {
                LblUnit3.Text = "CM";
                LblUnit4.Text = "MM";
                LblUnit5.Text = "KM";
                LblUnit6.Text = "Inch";
                LblUnit7.Text = "Foot";
                LblUnit8.Text = "Yard";
                LblUnit7.Show();
                LblUnit8.Show();
                TxtValue7.Show();
                TxtValue8.Show();
            }
            else if (ComboUnit.SelectedItem == "Gm")
            {
                LblUnit3.Text = "Pound";
                LblUnit4.Text = "Kg";
                LblUnit5.Text = "Ounce";
                LblUnit6.Text = "Mg";
                LblUnit7.Hide();
                LblUnit8.Hide();
                TxtValue7.Hide();
                TxtValue8.Hide();
            }
            else if (ComboUnit.SelectedItem == "Pound")
            {
                LblUnit3.Text = "Gm";
                LblUnit4.Text = "Kg";
                LblUnit5.Text = "Ounce";
                LblUnit6.Text = "Mg";
                LblUnit7.Hide();
                LblUnit8.Hide();
                TxtValue7.Hide();
                TxtValue8.Hide();
            }
            else if (ComboUnit.SelectedItem == "Kg")
            {
                LblUnit3.Text = "Gm";
                LblUnit4.Text = "Pound";
                LblUnit5.Text = "Ounce";
                LblUnit6.Text = "Mg";
                LblUnit7.Hide();
                LblUnit8.Hide();
                TxtValue7.Hide();
                TxtValue8.Hide();
            }
            else if (ComboUnit.SelectedItem == "Ounce")
            {
                LblUnit3.Text = "Gm";
                LblUnit4.Text = "Pound";
                LblUnit5.Text = "Kg";
                LblUnit6.Text = "Mg";
                LblUnit7.Hide();
                LblUnit8.Hide();
                TxtValue7.Hide();
                TxtValue8.Hide();
            }
            else if (ComboUnit.SelectedItem == "Mg")
            {
                LblUnit3.Text = "Gm";
                LblUnit4.Text = "Pound";
                LblUnit5.Text = "Kg";
                LblUnit6.Text = "Ounce";
                LblUnit7.Hide();
                LblUnit8.Hide();
                TxtValue7.Hide();
                TxtValue8.Hide();
            }
            else if (ComboUnit.SelectedItem == "Liter")
            {
                LblUnit3.Text = "Milliliter";
                LblUnit4.Text = "Cubic Foot";
                LblUnit5.Text = "Cubic Inch";
                LblUnit6.Text = "Cubic Meter";
                LblUnit7.Hide();
                TxtValue7.Hide();
                LblUnit8.Hide();
                TxtValue8.Hide();
            }
            else if (ComboUnit.SelectedItem == "Milliliter")
            {
                LblUnit3.Text = "Liter";
                LblUnit4.Text = "Cubic Foot";
                LblUnit5.Text = "Cubic Inch";
                LblUnit6.Text = "Cubic Meter";
                LblUnit7.Hide();
                TxtValue7.Hide();
                LblUnit8.Hide();
                TxtValue8.Hide();
            }
            else if (ComboUnit.SelectedItem == "Cubic Foot")
            {
                LblUnit3.Text = "Liter";
                LblUnit4.Text = "Milliliter";
                LblUnit5.Text = "Cubic Inch";
                LblUnit6.Text = "Cubic Meter";
                LblUnit7.Hide();
                TxtValue7.Hide();
                LblUnit8.Hide();
                TxtValue8.Hide();
            }
            else if (ComboUnit.SelectedItem == "Cubic Inch")
            {
                LblUnit3.Text = "Liter";
                LblUnit4.Text = "Milliliter";
                LblUnit5.Text = "Cubic Foot";
                LblUnit6.Text = "Cubic Meter";
                LblUnit7.Hide();
                TxtValue7.Hide();
                LblUnit8.Hide();
                TxtValue8.Hide();
            }
            else if (ComboUnit.SelectedItem == "Cubic Meter")
            {
                LblUnit3.Text = "Liter";
                LblUnit4.Text = "Milliliter";
                LblUnit5.Text = "Cubic Foot";
                LblUnit6.Text = "Cubic Inch";
                LblUnit7.Hide();
                TxtValue7.Hide();
                LblUnit8.Hide();
                TxtValue8.Hide();
            }
        }

        private void ComboUnitType_SelectedIndexChanged(object sender, EventArgs e) {

            if (ComboUnitType.SelectedIndex != -1 && ComboUnitType.SelectedItem.ToString() == "Length")
            {
                ComboUnit.Items.Clear();
                ComboUnit.SelectedIndex = -1;
                ComboUnit.Items.Add("CM");
                ComboUnit.Items.Add("MM");
                ComboUnit.Items.Add("KM");
                ComboUnit.Items.Add("Inch");
                ComboUnit.Items.Add("Foot");
                ComboUnit.Items.Add("Yard");
                ComboUnit.Items.Add("Mile");
            }
            else if (ComboUnitType.SelectedIndex != -1 && ComboUnitType.SelectedItem.ToString() == "Weight")
            {
                ComboUnit.Items.Clear();
                ComboUnit.SelectedIndex = -1;
                ComboUnit.Items.Add("Gm");
                ComboUnit.Items.Add("Pound");
                ComboUnit.Items.Add("Kg");
                ComboUnit.Items.Add("Ounce");
                ComboUnit.Items.Add("Mg");
            }
            else if (ComboUnitType.SelectedIndex != -1 && ComboUnitType.SelectedItem.ToString() == "Volume")
            {
                ComboUnit.Items.Clear();
                ComboUnit.SelectedIndex = -1;
                ComboUnit.Items.Add("Liter");
                ComboUnit.Items.Add("Milliliter");
                ComboUnit.Items.Add("Cubic Foot");
                ComboUnit.Items.Add("Cubic Inch");
                ComboUnit.Items.Add("Cubic Meter");
            }

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(TxtNum.Text.ToString());

            if (ComboUnitType.SelectedItem == "Length")
            {
                CalculateLength();
            }
            else if (ComboUnitType.SelectedItem == "Weight")
            {
                CalculateWeight();
            }
            else if (ComboUnitType.SelectedItem == "Volume")
            {
                CalculateVolume();
            }


        }
    }
}
