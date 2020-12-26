using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MiServicio.Service1Client oCliente = new MiServicio.Service1Client();
            string res= oCliente.GetData(10,5);
            MessageBox.Show(res);

            MiServicio.CompositeType oData = new MiServicio.CompositeType();
            oData.BoolValue = true;
            var res2= oCliente.GetDataUsingDataContract(oData);
            MessageBox.Show(res2.StringValue);


        }
    }
}
