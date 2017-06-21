using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIAPP
{
    public partial class ProcessSTOP : Form
    {
        public ProcessSTOP()
        {
            InitializeComponent();
        }

        private void stopTime_Tick(object sender, EventArgs e)
        {
            stopTime.Stop();
            ProcessHandle stoper = new ProcessHandle(txtBoxProcess.Text);
            if (!stoper.identifyProcess())
            {
                MessageBox.Show("process doesnt exist");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(txtBoxTime.Text) && Validations.numberVal(txtBoxTime.Text))
            {
                stopTime.Interval = Convert.ToInt32(Convert.ToDecimal(txtBoxTime.Text) * 60 * 1000);
                MessageBox.Show(Validations.errMsg);
                stopTime.Start();
            }
            else 
            {
                int index = cmbBoxTime.SelectedIndex;
                if ( index> 0)
                {
                    //int time;

                    switch (index)
                    {
                        case 1:
                            stopTime.Interval = Convert.ToInt32(30 * 60 * 1000);
                            break;
                        case 2:
                            stopTime.Interval = Convert.ToInt32(60 * 60 * 1000);
                            break;
                        case 3:
                            stopTime.Interval = Convert.ToInt32(90 * 60 * 1000);
                            break;
                        case 4:
                            stopTime.Interval = Convert.ToInt32(105 * 60 * 1000);
                            break;
                        case 5:
                            stopTime.Interval = Convert.ToInt32(120 * 60 * 1000);
                            break;
                                                
                    }

                    stopTime.Start();

                }


            }


            MessageBox.Show(Validations.errMsg);
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
