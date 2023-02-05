using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numbreing
{
    public partial  class Numbring : Form
    {

        public  Numbring()
        {
            InitializeComponent();
        }


        public  string baseNum;
        public  string secNum;
        public string result;
        public string firstNum;
        public string ans;

        Stack st = new Stack();


        private void Button1_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Decimal dec = new Decimal();
            Gray G = new Gray();
            HexaDecimal hex = new HexaDecimal();
            Binary bin = new Binary();
            Octal oct = new Octal();
            
            switch(firstNum)
            {
                case "Decimal":

                    if (toBinary.Checked)
                    {
                        result = dec.decToBinary(int.Parse(baseNum));
                        resultScreen.Text = result;
                        st.push(result);
                    }
                        
                    else if (toHexa.Checked)
                    {
                        result = dec.decToHexa(int.Parse(baseNum));
                        resultScreen.Text = result;
                        st.push(result);
                    }
                        
                    else if (toOctal.Checked)
                    {
                        result = dec.decToOctal(int.Parse(baseNum));
                        resultScreen.Text = result;
                        st.push(result);
                    }
                    else if(toBcd.Checked)
                    {
                        result = hex.hexaToBinary(baseNum);
                        resultScreen.Text = result;
                        st.push(result);
                    }
                    break;
                case "Binary":
                    if(toDecimal.Checked)
                    {
                        result = bin.binaryToDec(baseNum);
                        resultScreen.Text = result;
                        st.push(result);
                    }
                    else if(toOctal.Checked)
                    {
                        result = bin.binaryToOctal(baseNum);
                        resultScreen.Text = result;
                        st.push(result);
                    }
                    else if(toHexa.Checked)
                    {
                        result = bin.binaryToHexa(baseNum);
                        resultScreen.Text = result;
                        st.push(result);
                    }
                    else if(toGrayCode.Checked)
                    {
                        result = G.binarytoGray(baseNum);
                        resultScreen.Text= result;
                        st.push(result);
                    }
                    break;
                case "Octal":
                    if(toDecimal.Checked)
                    {
                        result = oct.octalToDec(baseNum);
                        resultScreen.Text = result;
                        st.push(result);
                    }
                    else if(toBinary.Checked)
                    {
                        result = oct.octalToBinary(baseNum);
                        resultScreen.Text = result;
                        st.push(result);
                    }
                    else if(toHexa.Checked)
                    {
                        result = oct.octalToHexa(baseNum);
                        resultScreen.Text = result;
                        st.push(result);
                    }
                    break;
                case "HexaDecimal":
                    if(toBinary.Checked)
                    {
                        result = hex.hexaToBinary(baseNum);
                        resultScreen.Text = result;
                        st.push(result);
                    }
                    else if(toDecimal.Checked)
                    {
                        result = hex.hexaTodec(baseNum);
                        resultScreen.Text = result;
                        st.push(result);
                    }
                    else if(toOctal.Checked)
                    {
                        result = hex.hexaToOctal(baseNum);
                        resultScreen.Text = result;
                        st.push(result);
                    }
                    break;
                case "BCD":
                    if(toDecimal.Checked)
                    {
                        result = bin.binaryToHexa(baseNum);
                        resultScreen.Text= result;
                        st.push(result);
                    }
                    break;
                case "GrayCode":
                    if(toBinary.Checked)
                    {
                        result = G.graytoBinary(baseNum);
                        resultScreen.Text = result;
                        st.push(result);
                    }
                    break;
                        
            }
           

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if( inputScreen.Text == "" || inputScreen.Text == null)
            {
                MessageBox.Show("Inter a Number To Convert","Error");
                clear();
            }
            else
            {
                baseNum = inputScreen.Text;
                firstNum = "Binary";
            }
           
            
        }


        private void ConvetButton_Load(object sender, EventArgs e)
        {

        }

        private void fromDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (inputScreen.Text == "" || inputScreen.Text == null)
            {
                MessageBox.Show("Inter a Number To Convert", "Error");
                clear();
            }
            else
            {
                baseNum = inputScreen.Text;
                firstNum = "Decimal";
            }
            
        }

        private void fromHexa_CheckedChanged(object sender, EventArgs e)
        {
            if (inputScreen.Text == "" || inputScreen.Text == null)
            {
                MessageBox.Show("Inter a Number To Convert", "Error");
                clear();
            }
            else
            {
                baseNum = inputScreen.Text;
                firstNum = "HexaDecimal";
            }
            
        }

        private void fromOctal_CheckedChanged(object sender, EventArgs e)
        {
            if (inputScreen.Text == "" || inputScreen.Text == null)
            {
                MessageBox.Show("Inter a Number To Convert", "Error");
                clear();
            }
            else
            {
                baseNum = inputScreen.Text;
                firstNum = "Octal";
            }
            
        }

        private void fromBCD_CheckedChanged(object sender, EventArgs e)
        {
            if (inputScreen.Text == "" || inputScreen.Text == null)
            {
                MessageBox.Show("Inter a Number To Convert", "Error");
                clear();
            }
            else
            {
                baseNum = inputScreen.Text;
                firstNum = "BCD";
            }
           
        }

        private void fromGray_CheckedChanged(object sender, EventArgs e)
        {
            if (inputScreen.Text == "" || inputScreen.Text == null)
            {
                MessageBox.Show("Inter a Number To Convert", "Error");
                clear();
            }
            else
            {
                baseNum = inputScreen.Text;
                firstNum = "GrayCode";
            }
            
        }

        private void toBinary_CheckedChanged(object sender, EventArgs e)
        {
            secNum = toBinary.Text;
        }

        private void toDecimal_CheckedChanged(object sender, EventArgs e)
        {
            secNum = toDecimal.Text;
        }

        private void toHexa_CheckedChanged(object sender, EventArgs e)
        {
            secNum = toHexa.Text;
        }

        private void toOctal_CheckedChanged(object sender, EventArgs e)
        {
            secNum = toOctal.Text;
        }

        private void toBcd_CheckedChanged(object sender, EventArgs e)
        {
            secNum = toBcd.Text;
        }
        public void clear()
        {
            toBinary.Checked = false;
            toDecimal.Checked = false;
            toHexa.Checked = false;
            toOctal.Checked = false;
            toBcd.Checked = false;
            toGray.Checked = false;
            fromBinary.Checked = false;
            fromDecimal.Checked = false;
            fromHexa.Checked = false;
            fromOctal.Checked = false;
            fromBcd.Checked = false;
            fromGray.Checked = false;
            inputScreen.Text = null;
            resultScreen.Text = null;
            baseNum = null;
            secNum = null;
            result = null;
            firstNum = null;

            
            
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void group_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            clear();
            inputScreen.Text = st.peek();
            
            
        }
    }
}
