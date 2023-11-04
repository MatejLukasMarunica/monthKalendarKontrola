using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monthKalendarKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan dani = monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart;

            if (dani.Days < 1)
            {
                     MessageBox.Show("Tipkom SHIFT odaberite željeni datum sa brojem dana većim od 0.");
                   return;            
            }

            MessageBox.Show("Vaša rezervacija traje: " + dani.Days.ToString() + " dana.");

            MessageBox.Show("Vaša rezervacija počinje " + monthCalendar1.SelectionStart.ToShortDateString() + " i traje vam do " + monthCalendar1.SelectionEnd.ToShortDateString());
        }
    }
}
