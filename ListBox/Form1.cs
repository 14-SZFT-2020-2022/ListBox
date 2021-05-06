using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FelveszBtn_Click(object sender, EventArgs e)
        {
            string feltolt = beviteliTB.Text;
            feltoltottLista.Items.Add(feltolt);
            szamlalo.Value++;
            beviteliTB.Text = "";
        }

        private void BeszurBtn_Click(object sender, EventArgs e)
        {
            string feltolt = beviteliTB.Text;
            feltoltottLista.Items.Insert((int)szamlalo.Value, feltolt);
            beviteliTB.Text = "";
            szamlalo.Value = feltoltottLista.Items.Count;
        }

        private void TorolBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int torol = (int)szamlalo.Value - 1;
                feltoltottLista.Items.RemoveAt(torol);
                szamlalo.Value = feltoltottLista.Items.Count;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Nincs ilyen index!");
            }
        }

        private void TorolMindBtn_Click(object sender, EventArgs e)
        {
            feltoltottLista.Items.Clear();
            szamlalo.Value = feltoltottLista.Items.Count;
        }

        private void AtmasolBtn_Click(object sender, EventArgs e)
        {
            if (feltoltottLista.SelectedItems.Count == 0)
            {
                try
                {
                    string masolas = feltoltottLista.Items[(int)szamlalo.Value].ToString();
                    atmasoltLista.Items.Add(masolas);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Nincs ilyen index!");
                }
            }
            else
            {
                string masolas = feltoltottLista.SelectedItem.ToString();
                atmasoltLista.Items.Add(masolas);
            }
        }

        private void AtmozgatBtn_Click(object sender, EventArgs e)
        {
            if (feltoltottLista.SelectedItems.Count == 0)
            {
                try
                {
                    string atmozgat = feltoltottLista.Items[(int)szamlalo.Value].ToString();
                    atmasoltLista.Items.Add(atmozgat);
                    feltoltottLista.Items.Remove(feltoltottLista.Items[(int)szamlalo.Value]);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Nincs ilyen index!");
                }
            }
            else
            {
                string atmozgat = feltoltottLista.SelectedItem.ToString();
                atmasoltLista.Items.Add(atmozgat);
                feltoltottLista.Items.Remove(feltoltottLista.SelectedItem);
            }
        }

        private void KeresBtn_Click(object sender, EventArgs e)
        {
            if (beviteliTB.Text != "")
            {
                int index = feltoltottLista.FindString(beviteliTB.Text);
                MessageBox.Show(index.ToString());
                if (index != -1)
                {
                    feltoltottLista.SetSelected(index, true);
                }
            }
        }
    }
}
