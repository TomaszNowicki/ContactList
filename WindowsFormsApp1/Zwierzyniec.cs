using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooZwierzyniec
{
    


    public partial class Zwierzyniec : Form
    {
      


        private Animal[] zoo = new Animal[1];

        public Zwierzyniec()
        {
            InitializeComponent();
        }
        private void Write(Animal obj)
        {
            StreamWriter sw = new StreamWriter("Zwierzyniec.txt");
            sw.WriteLine(zoo.Length + 1);
            sw.WriteLine(obj.Name);
            sw.WriteLine(obj.Breed);
            sw.WriteLine(obj.Age);

            for ( int x=0;x< zoo.Length; x++)
            {
                sw.WriteLine(zoo[x].Name);
                sw.WriteLine(zoo[x].Breed);
                sw.WriteLine(zoo[x].Age);
            }
            sw.Close();
        }

         private void Read()
         {
            StreamReader sr = new StreamReader("Zwierzyniec.txt");
            zoo = new Animal[Convert.ToInt32(sr.ReadLine())];

            for (int x = 0;x < zoo.Length; x++)
            {
                zoo[x] = new Animal();
                zoo[x].Name = sr.ReadLine();
                zoo[x].Breed = sr.ReadLine();
                zoo[x].Age = sr.ReadLine();

            }
            sr.Close();
         }

        private void Display()
        {
            lstAnimals.Items.Clear();

            for( int x = 0; x < zoo.Length; x++)
            {
                lstAnimals.Items.Add(zoo[x].ToString());
            }

        }

        private void ClearForm()
        {
            txtName.Text = String.Empty;
            txtBreed.Text = String.Empty;
            txtAge.Text = String.Empty;
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            Animal obj = new Animal();

            obj.Name = txtName.Text;
            obj.Breed = txtBreed.Text;
            obj.Age = txtAge.Text;

            Write(obj);
            Read();
            BubbleSort();
            Display();
            ClearForm();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Read();
            Display();

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            BubbleSort();
            Display();

        }

        private void BubbleSort() 
        {
            Animal temp;
            bool swap;

            do
            {
                swap = false;
                for(int x =0; x < zoo.Length - 1; x++)
                {
                    if(zoo[x].Breed.CompareTo(zoo[x+1].Breed)>0)
                    {
                    temp = zoo[x];
                    zoo[x] = zoo[x + 1];
                    zoo[x + 1] = temp;
                    swap = true;
                    }
                }
            } while (swap == true);
        }

        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
