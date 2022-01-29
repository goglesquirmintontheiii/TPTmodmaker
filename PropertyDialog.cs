using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPTmodmaker
{
    public partial class PropertyDialog : Form
    {
        public PropertyDialog(Control obj)
        {
            InitializeComponent();

            if (obj.Name.Contains("Label"))
            {

            }
        }
    }
}
