using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashMeInside
{
    public partial class Table : Form
    {
        public string tableNumber
        {
            get
            {
                return this.tableNumberLabel.Text;
            }

            set
            {
                this.tableNumberLabel.Text = value;
            }
        }

        public Table()
        {
            InitializeComponent();
        }
    }
}
