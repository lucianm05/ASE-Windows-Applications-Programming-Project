using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect.Entities;

namespace Proiect
{
    public partial class ChartForm : Form
    {
        private readonly List<Vanzare> Vanzari = new List<Vanzare>();
        private List<float> Percents = new List<float>();

        public ChartForm()
        {
            InitializeComponent();
        }

        public ChartForm(List<Vanzare> vanzari)
        {
            Vanzari = vanzari;

            int totalSales = 0;
            foreach (Vanzare vanzare in Vanzari)
            {
                totalSales += vanzare.Count;
            }


            foreach (Vanzare vanzare in Vanzari)
            {
                float percent = (vanzare.Count * 100) / totalSales;
                Percents.Add(percent);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics graphic = e.Graphics)
            {
                float PiePercentTotal = 0;

                Color[] colors = { Color.AliceBlue, Color.Violet, Color.OrangeRed, Color.BlanchedAlmond, Color.Green, Color.Lime };

                Point location = new Point(0, 0);

                Size size = new Size(200, 200);

                for (int i = 0; i < Percents.Count; i++)
                {
                    using (SolidBrush brush = new SolidBrush(colors[i]))
                    {
                        graphic.FillPie(
                            brush,
                            new Rectangle(location, size),
                            Convert.ToSingle(PiePercentTotal * 360 / 100),
                            Convert.ToSingle(Percents[i] * 360 / 100)
                            );
                    }

                    Label label = new Label();
                    label.Text = Vanzari[i].Denumire;
                    label.ForeColor = Color.Black;
                    label.BackColor = colors[i];
                    label.Width = 100;
                    label.Location = new Point(location.X + size.Width + 20, location.Y + 20 + (i * 50));

                    this.Controls.Add(label);

                    PiePercentTotal += Percents[i];
                }

            }
        }
    }
}
