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
    [DefaultEvent("Click")]
    public partial class PictureTextButton : UserControl
    {
        private static List<PictureTextButton> collection = new List<PictureTextButton>();
        public PictureTextButton()
        {
            InitializeComponent();
            collection.Add(this);
            Disposed += PictureTextButton_Disposed;
            IsSelected = false;
        }
        private bool isSelected;
        private Image buttonImage;
        private string buttonName;
        private Font buttonFont;
        public bool IsSelected
        {
            get => isSelected;
            set
            {
                isSelected = value;
                if (value)
                    BackColor = SystemColors.ControlDark;
                else
                    BackColor = SystemColors.Control;
            }
        }
        [Browsable(true)]
        [Category("Picture Button")]
        public Image ButtonImage
        {
            get => buttonImage;
            set
            {
                buttonImage = value;
                pictureBox1.Image = value;
            }
        }
        [Browsable(false)]
        public override string Text { get => base.Text; set => base.Text = value; }
        [Browsable(false)]
        public override Font Font { get => base.Font; set => base.Font = value; }

        [Browsable(true)]
        [Category("Picture Button")]
        public string ButtonName
        {
            get => buttonName;
            set
            {
                buttonName = value;
                label1.Text = value;
            }
        }

        [Browsable(true)]
        [Category("Picture Button")]
        public Font ButtonFont
        {
            get => buttonFont;
            set
            {
                buttonFont = value;
                label1.Font = value;
            }
        }

        private void PictureTextButton_Disposed(object sender, EventArgs e)
        {
            collection.Remove(this);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            foreach(var control in collection)
            {
                control.IsSelected = false;
            }
            IsSelected = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
