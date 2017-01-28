using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ev3Logger
{
    public partial class RecvDataForm : Form
    {
        private Ev3Lover mParent;

        public RecvDataForm()
        {
            InitializeComponent();
        }

        public void Init(Ev3Lover parent)
        {
            mParent = parent;
        }

        private void RecvDataBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                this.RecvDataBox.Text += "\r\n";
                mParent.SerialWrite("\r\n");
                e.Handled = true;
            }
            else
            {
                this.RecvDataBox.Text += e.KeyChar;
                mParent.SerialWrite(e.KeyChar.ToString());
            }
        }
    }
}
