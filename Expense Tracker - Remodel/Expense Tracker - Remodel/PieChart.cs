using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracker___Remodel
{
    public partial class PieChart : UserControl
    {
        public PieChart()
        {
            InitializeComponent();
        }

        private Dictionary<string, (float values, Color color)> data = new Dictionary<string, (float values, Color color)>();

        public Dictionary<string, (float values, Color color)> Data
        {
            get => data;
            set
            {
                data = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(BackColor);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            float sum = 0;
            foreach (var category in data.Keys)
            {
                sum += data[category].values;
            }
            float barWidth = (Width) * 0.16F;
            float startAngle = -90;
            int i = 0;
            foreach (var category in data.Keys)
            {
                i++;
                float angle = ((data[category].values / sum) * 360);
                using (Brush brush = new SolidBrush(data[category].color))
                {
                    e.Graphics.FillPie(brush, ClientRectangle, startAngle, angle);
                }
                using (Brush brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillEllipse(brush, new RectangleF(barWidth, barWidth, Width - 2 * barWidth, Height - 2 * barWidth));
                }
                startAngle += angle;

            }
            if(i==0)
            {
                using (Brush brush = new SolidBrush(Color.Black))
                {
                    e.Graphics.FillPie(brush, new Rectangle(2, 2, Width - 4, Height - 4), startAngle, 360);
                }
                using (Brush brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillEllipse(brush, new RectangleF(barWidth, barWidth, Width - 2 * barWidth, Height - 2 * barWidth));
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int min = Math.Min(Width, Height);
            this.Size = new Size(min, min);
            Invalidate();
        }
    }
}
