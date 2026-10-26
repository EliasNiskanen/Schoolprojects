using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Ristinolla
{
    public partial class Pelaajat : Form
    {

        public List<Käyttäjätiedot> lista;

        int valittuRivi = -1;
        bool muokkaus = false;


        public Pelaajat()
        {
            InitializeComponent();

            if (File.Exists("c:\\temp\\Pelaajat.xml"))
            {
                lista = DeserializeXML();
                dataGridView1.DataSource = lista;
                dataGridView2.DataSource = lista;
            }
            else
            {
                lista = new List<Käyttäjätiedot>();
            }
        }
        public void SerializeXML(List<Käyttäjätiedot> input)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(input.GetType());
            StreamWriter sw = new StreamWriter("c:\\temp\\Pelaajat.xml");
            serializer.Serialize(sw, input);
            sw.Close();
        }
        public List<Käyttäjätiedot> DeserializeXML()
        {
            if (File.Exists("c:\\temp\\Pelaajat.xml"))
            {
                StreamReader stream = new StreamReader("c:\\temp\\Pelaajat.xml");
                System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(List<Käyttäjätiedot>));
                object obj = ser.Deserialize(stream);
                stream.Close();
                return (List<Käyttäjätiedot>)obj;
            }
            else
                return null;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        public struct Käyttäjätiedot
        {
            public string Etunimi { get;  set; }
            public string Sukunimi { get;  set; }
            public string Syntymävuosi { get;  set; }
        }

        private void button1_Click(object sender, EventArgs e) // Tällä saadaan pelaajien etunimet pelaajanimiksi itse peliin form1:lle. 
        {

            Form1.Pelaajanimet(tb1Etunimi.Text, tb2Etunimi.Text);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // Tällä lisätään pelaaja 1 tiedot xml tiedostoon. 
        {
            Käyttäjätiedot Käyttäjätiedot = new Käyttäjätiedot();

            try
            {
                Käyttäjätiedot.Etunimi = tb1Etunimi.Text;
                Käyttäjätiedot.Sukunimi = tb1Sukunimi.Text;
                Käyttäjätiedot.Syntymävuosi = tb1Syntymävuosi.Text;
                if (muokkaus == false)
                {
                    lista.Add(Käyttäjätiedot);
                }
                else
                {
                    lista[valittuRivi] = Käyttäjätiedot;
                    //lista.RemoveAt(valittuRivi);
                    //lista.Insert(valittuRivi, asiakas);
                }
                SerializeXML(lista);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = lista;
                muokkaus = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e) // Tällä lisätään pelaaja 2 tiedot xml tiedostoon.
        {
            Käyttäjätiedot K = new Käyttäjätiedot();
            try
            {
                K.Etunimi = tb2Etunimi.Text;
                K.Sukunimi = tb2Sukunimi.Text;
                K.Syntymävuosi = tb2Syntymävuosi.Text;
                if (muokkaus == false)
                {
                    lista.Add(K);
                }
                else
                {
                    lista[valittuRivi] = K;
                    //lista.RemoveAt(valittuRivi);
                    //lista.Insert(valittuRivi, asiakas);
                }
                SerializeXML(lista);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = lista;
                muokkaus = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) // Tässä näkyy pelaajatiedot josta voidaan myös valita tiedot pelaaja 2 kohtaan. En tosin ymmärrä miksi ottaa vain sukunimeä klikkaamalla nuo tiedot.
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                tb2Etunimi.Text = row.Cells["Etunimi"].Value.ToString();
                tb2Sukunimi.Text = row.Cells["Sukunimi"].Value.ToString();
                tb2Syntymävuosi.Text = row.Cells["Syntymävuosi"].Value.ToString(); ;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // Tässä näkyy pelaajatiedot josta voidaan myös valita tiedot pelaaja 1 kohtaan. En tosin ymmärrä miksi ottaa vain sukunimeä klikkaamalla nuo tiedot.
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                tb1Etunimi.Text = row.Cells["Etunimi"].Value.ToString();
                tb1Sukunimi.Text = row.Cells["Sukunimi"].Value.ToString();
                tb1Syntymävuosi.Text = row.Cells["Syntymävuosi"].Value.ToString(); ;

            }
        }
    }
}
