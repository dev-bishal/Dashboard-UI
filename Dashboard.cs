using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_UI
{
    public partial class Dashboard: UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            chart1.ChartAreas[0].BackColor = Color.Transparent;
            chart2.ChartAreas[0].BackColor = Color.Transparent;
            chart3.ChartAreas[0].BackColor = Color.Transparent;

            chart1.Legends[0].Enabled = false;
            chart2.Legends[0].Enabled = false;
            chart3.Legends[0].Enabled = false;

            chart1.Series[0].Points.AddXY("Category1", 45); // Label and value
            chart1.Series[0].Points.AddXY("Category2", 30);
            chart1.Series[0].Points.AddXY("Category3", 25);
            chart1.Series[0].Points.AddXY("Category4", 45);
            chart1.Series[0].Points.AddXY("Category5", 30);
            chart1.Series[0].Points.AddXY("Category6", 25);

            chart2.Series[0].Points.AddXY("Category1", 45); // Label and value
            chart2.Series[0].Points.AddXY("Category2", 30);
            chart2.Series[0].Points.AddXY("Category3", 25);

            chart3.Series[0].Points.AddXY("Category1", 45); // Label and value
            chart3.Series[0].Points.AddXY("Category2", 30);
            chart3.Series[0].Points.AddXY("Category3", 25);
        }

        private void Panel_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
