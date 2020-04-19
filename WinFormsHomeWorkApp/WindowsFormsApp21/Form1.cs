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

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        double OverallSumma = 0;
        public Form1()
        {
            InitializeComponent();
            StartPosMenu();
        }

        private void StartPosMenu()
        {
            Slot1Label.Text = "Фирменная";
            PriceLabel1.Text = "130 грн.";

            Slot2Label.Text = "Гавайская";
            PriceLabel2.Text = "140 грн.";

            Slot3Label.Text = "Баварская";
            Price3Label.Text = "150 грн";

            Slot4Label.Text = "4 Сыра";
            Price4Label.Text = "160 грн";
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void BurgButton_Click(object sender, EventArgs e)
        {
            if(BurgButton.Checked == true)
            {
                Slot1Label.Text = "Дабл-Чиз";
                PriceLabel1.Text = "70 грн.";

                Slot2Label.Text = "Чикен-Бургер";
                PriceLabel2.Text = "80 грн.";

                Slot3Label.Text = "Макс-Бургер";
                Price3Label.Text = "100 грн";

                Slot4Label.Text = "Хэви-Бургер";
                Price4Label.Text = "120 грн";
            }

        }

        private void PizzaButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (PizzaButton.Checked == true)
            {
                Slot1Label.Text = "Фирменная";
                PriceLabel1.Text = "130 грн.";

                Slot2Label.Text = "Гавайская";
                PriceLabel2.Text = "140 грн.";

                Slot3Label.Text = "Баварская";
                Price3Label.Text = "150 грн";

                Slot4Label.Text = "Сырная";
                Price4Label.Text = "160 грн";
            }
        }

        private void SaladButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (SaladButton.Checked == true)
            {
                Slot1Label.Text = "Овощной";
                PriceLabel1.Text = "50 грн.";

                Slot2Label.Text = "Греческий";
                PriceLabel2.Text = "75 грн.";

                Slot3Label.Text = "Цезарь";
                Price3Label.Text = "100 грн";

                Slot4Label.Text = "Фирменный";
                Price4Label.Text = "120 грн";
            }
        }

        private void DeserButton_MouseClick(object sender, MouseEventArgs e)
        {
            if(DeserButton.Checked == true)
            {
                Slot1Label.Text = "Мороженное";
                PriceLabel1.Text = "25 грн.";

                Slot2Label.Text = "Брауни";
                PriceLabel2.Text = "40 грн.";

                Slot3Label.Text = "Чизкейк";
                Price3Label.Text = "50 грн";

                Slot4Label.Text = "Наполеон";
                Price4Label.Text = "55 грн";
            }
        }

        private void DrinkButton_MouseClick(object sender, MouseEventArgs e)
        {
            if(DrinkButton.Checked == true)
            {
                Slot1Label.Text = "Вода(газированная)";
                PriceLabel1.Text = "20 грн.";

                Slot2Label.Text = "Coca-Cola";
                PriceLabel2.Text = "25 грн.";

                Slot3Label.Text = "Сок";
                Price3Label.Text = "30 грн";

                Slot4Label.Text = "Фрэш";
                Price4Label.Text = "40 грн.";
            }
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
           
            if(numericUpDown1.Value>1)
            {
                for(int i = 0; i < numericUpDown1.Value; i++)
                {
                    Summa.Text = "";
                    string temp = Slot1Label.Text + " " + PriceLabel1.Text;
                    listBox1.Items.Add(temp);

                    string TempString = PriceLabel1.Text;
                    string str1;
                    string[] TestString = TempString.Split(' ');
                    str1 = TestString[0];

                    double TempSumma = double.Parse(str1);

                    OverallSumma += TempSumma;

                    Summa.Text += Convert.ToString(OverallSumma);
                }
            }
            else
            {
                Summa.Text = "";
                string temp = Slot1Label.Text + " " + PriceLabel1.Text;
                listBox1.Items.Add(temp);

                string TempString = PriceLabel1.Text;
                string str1;
                string[] TestString = TempString.Split(' ');
                str1 = TestString[0];

                double TempSumma = double.Parse(str1);

                OverallSumma += TempSumma * (double)numericUpDown1.Value;

                Summa.Text += Convert.ToString(OverallSumma);
            }
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e) 
        {
            if (listBox1.Items.Count > 0)
            {
                if (listBox1.SelectedIndex != -1)
                {
                    Summa.Text = "";
                    string TempString = listBox1.SelectedItem.ToString();
                    string str1;
                    string[] TestString = TempString.Split(' ');
                    str1 = TestString[1];
                    double TempSumma = double.Parse(str1);
                    OverallSumma -= TempSumma;
                    Summa.Text = Convert.ToString(OverallSumma);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                }
                    
                else
                    MessageBox.Show("Выберите конкретный товар!");

            }
            else
                MessageBox.Show("Ваша корзина пуста!");
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            if(numericUpDown2.Value > 1)
            {
                for (int i = 0; i < numericUpDown2.Value; i++)
                {
                    Summa.Text = "";
                    string temp = Slot2Label.Text + " " + PriceLabel2.Text;
                    listBox1.Items.Add(temp);

                    string TempString = PriceLabel2.Text;
                    string str1;
                    string[] TestString = TempString.Split(' ');
                    str1 = TestString[0];

                    double TempSumma = double.Parse(str1);

                    OverallSumma += TempSumma;

                    Summa.Text = Convert.ToString(OverallSumma);
                }
            }
            else
            {
                Summa.Text = "";
                string temp = Slot2Label.Text + " " + PriceLabel2.Text;
                listBox1.Items.Add(temp);

                string TempString = PriceLabel2.Text;
                string str1;
                string[] TestString = TempString.Split(' ');
                str1 = TestString[0];

                double TempSumma = double.Parse(str1);

                OverallSumma += TempSumma * (double)numericUpDown2.Value;

                Summa.Text = Convert.ToString(OverallSumma);
            }

        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            if(numericUpDown3.Value > 1)
            {
                for(int i = 0; i < numericUpDown3.Value; i++)
                {
                    Summa.Text = "";
                    string temp = Slot3Label.Text + " " + Price3Label.Text;
                    listBox1.Items.Add(temp);

                    string TempString = Price3Label.Text;
                    string str1;
                    string[] TestString = TempString.Split(' ');
                    str1 = TestString[0];

                    double TempSumma = double.Parse(str1);

                    OverallSumma += TempSumma;

                    Summa.Text = Convert.ToString(OverallSumma);
                }
            }
            else
            {
                Summa.Text = "";
                string temp = Slot3Label.Text + " " + Price3Label.Text;
                listBox1.Items.Add(temp);

                string TempString = Price3Label.Text;
                string str1;
                string[] TestString = TempString.Split(' ');
                str1 = TestString[0];

                double TempSumma = double.Parse(str1);

                OverallSumma += TempSumma * (double)numericUpDown3.Value;

                Summa.Text = Convert.ToString(OverallSumma);
            }
            
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            if(numericUpDown4.Value > 1)
            {
                for(int i = 0; i < numericUpDown4.Value; i++)
                {
                    Summa.Text = "";
                    string temp = Slot4Label.Text + " " + Price4Label.Text;
                    listBox1.Items.Add(temp);

                    string TempString = Price4Label.Text;
                    string str1;
                    string[] TestString = TempString.Split(' ');
                    str1 = TestString[0];

                    double TempSumma = double.Parse(str1);

                    OverallSumma += TempSumma;

                    Summa.Text = Convert.ToString(OverallSumma);
                }
            }
            else
            {
                Summa.Text = "";
                string temp = Slot4Label.Text + " " + Price4Label.Text;
                listBox1.Items.Add(temp);

                string TempString = Price4Label.Text;
                string str1;
                string[] TestString = TempString.Split(' ');
                str1 = TestString[0];

                double TempSumma = double.Parse(str1);

                OverallSumma += TempSumma * (double)numericUpDown4.Value;

                Summa.Text = Convert.ToString(OverallSumma);
            }
            
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if(listBox1.Items.Count>0)
            {
                MessageBox.Show($"Общая сумма заказа: {OverallSumma} грн.\nСпасибо за обращение!");
                listBox1.Items.Clear();
                Summa.Text = "";
                OverallSumma = 0;
            }
            else
                MessageBox.Show("Ваша корзина пуста!");
        }
    }
}
