using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUID
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            ids_listbox.ScrollAlwaysVisible = true;
        }

        int[] GetData()
        {
            int data1=0;
            int data2=0;

            try
            {
                data1 =Convert.ToInt32(length_textbox.Text);
                data2 =Convert.ToInt32(amount_textbox.Text);

                if(data1<=0 || data2 <= 0)
                {
                    MessageBox.Show("Lütfen 0'dan büyük sayı girişi yapınız.");
                }
            }

            catch(FormatException)
            {
                MessageBox.Show("Lütfen tamsayı giriniz.");
            }

            catch (OverflowException)
            {
                MessageBox.Show("Lütfen daha küçük bir sayı giriniz.");
            }

            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return new int[] { data1, data2 };
        }

        string[] GenerateMethod(int[] data)
        {
            int length = data[0];
            int amount = data[1];

            string[] items = new string[amount];

            for (int i = 0; i < amount; i++)
            {
                string item = "";
                
                for(int j = 0; j < length; j++)
                {
                    item += (char)rand.Next(48,127);
                }

                items[i] = item;
            }

            return items;
        }

        void AddToListbox(string[] items)
        {
            ids_listbox.Items.Clear();

            foreach(string item in items)
            {
                ids_listbox.Items.Add(item);
            }
        }
        
        private void generate_button_Click(object sender, EventArgs e)
        {
            AddToListbox(GenerateMethod(GetData()));
        }
    }
}
