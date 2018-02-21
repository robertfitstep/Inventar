using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inventar
{
    public partial class Inventar_Form : Form
    {
        public Inventar_Form()
        {
            InitializeComponent();
            cbTyp.DataSource = Enum.GetValues(typeof(ItemType));
            cbTyp.SelectedItem = null;
        }

        private int cenaVeci;
        private int pocetVeci;
        private double vahaVeci;
        private string sprava;
        private Inventory inventarVeci = new Inventory();

        void btPridaj_Click(Object sender, EventArgs e)
        {
            if(Validator.ValidujVstup(tbCena.Text,tbPocet.Text,tbVaha.Text,tbNazov.Text,cbTyp.SelectedIndex, out cenaVeci, out pocetVeci, out vahaVeci, out sprava))
            {
                inventarVeci.CreateItem(cenaVeci, pocetVeci, vahaVeci, tbNazov.Text, (ItemType)cbTyp.SelectedItem);
                lbInventar.Items.Add(inventarVeci.Items[inventarVeci.Items.Count - 1]);
                Console.WriteLine("Úspešne pridaná vec\veci: {0}\nPočet vecí: {1}\nVáha vecí: {2}\nCena:{3}\nTyp: {4}",tbNazov.Text, pocetVeci, vahaVeci ,cenaVeci, cbTyp.SelectedItem.ToString());
            }
            else zobrazSpravu(sprava);
        }

        void btVymaz_Click(Object sender, EventArgs e)
        {
            List<ItemBase> toDelete = new List<ItemBase>();
            foreach (ItemBase o in lbInventar.CheckedItems)
            {
                Console.WriteLine("zapisujem: {0}",o);
                toDelete.Add(o);
            }
            foreach (ItemBase o in toDelete)
            {
                Console.WriteLine("vymazávam: {0}",o);
                lbInventar.Items.Remove(o);
            }
        }

        private void zobrazSpravu(string message)
        {
            string caption = "Pozor!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
        }
    }
}
