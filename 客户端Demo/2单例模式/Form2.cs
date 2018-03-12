using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2单例模式
{
    public partial class Form2 : Form
    {
        private static Form2 FrmSingle;

        private Form2()
        {
            InitializeComponent();
        }

        public static Form2 GetSingLe()
        {
            if (FrmSingle == null)
            {
                FrmSingle = new Form2();
            }
            return FrmSingle;
        }
    }
}
