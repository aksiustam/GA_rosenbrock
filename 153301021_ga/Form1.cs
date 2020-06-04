using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _GA_rosenbrock
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_basla_Click(object sender, EventArgs e)
        {

            double pop = decimal.ToDouble(num_pop.Value);
            double cap = decimal.ToDouble(num_cap.Value);
            double mut = decimal.ToDouble(num_mut.Value);
            double pen = decimal.ToDouble(num_pen.Value);
            double jen = decimal.ToDouble(num_jen.Value);
   
            while (chart_ga.Series.Count > 0) { chart_ga.Series.RemoveAt(0); } // Resetle
            
            Series series = this.chart_ga.Series.Add("Total");
            series.ChartType = SeriesChartType.Spline;
            chart_ga.Series["Total"].BorderWidth = 2;
            chart_ga.Series["Total"].Color = Color.Red;
            if (pop % 2 == 1)
                pop++;
            Pop p = new Pop(pop);
            Pop.penalty = pen.ToString().Length;
            p.Generate();

            for (int i = 0; i < jen; i++)
            {

                p.ScoreAll();
                if (i % (jen / 10) == 0)
                    series.Points.AddXY(i, p.BestGen.Score);
                p = GA.Sort(p);
                p.Updatetotalscore();
                p.Updatekumdeg();
                p = GA.Capraz(p, cap);
                p = GA.Mutasyon(p, mut);

            }
            p.ScoreAll();
            listBox1.Items.Add("----------------------");
            listBox1.Items.Add("Score = "+p.BestGen.Score);
            int j = 0;
            foreach (double g in p.BestGen.Genes)
            {
                j++;
                listBox1.Items.Add("Gen " + j + "=" +g);
            }
            listBox1.Items.Add("----------------------");


        }

        
    }
}
