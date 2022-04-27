using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHelloCS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("주희가 만들었다!!!!!!!", "안뇨오오오오오오오옹ㅎㅎ", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
