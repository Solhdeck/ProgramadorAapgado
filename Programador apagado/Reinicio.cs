using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Programador_apagado
{
    public partial class Reinicio : Form
    {
        public Reinicio()
        {
            InitializeComponent();
        }

        private void Reinicio_Load(object sender, EventArgs e)
        {
            int posX = (Screen.FromControl(this).Bounds.Width - this.ClientSize.Width) / 2;
            int posY = (Screen.FromControl(this).Bounds.Height - this.ClientSize.Height) / 2;
            this.Location = new System.Drawing.Point(posX, posY);
        }

        private void Horas1_Click(object sender, EventArgs e)
        {
            try
            {
                Process ProcesoActivacion1 = Process.Start("shutdown", "-s -t 3600");
            }
            catch (Exception) { }
        }

        private void Bt_30m_Click(object sender, EventArgs e)
        {
            try
            {
                Process ProcesoActivacion1 = Process.Start("shutdown", "-s -t 1800");
            }
            catch (Exception) { }
        }

        private void Manual_Click(object sender, EventArgs e)
        {

            try
            {
                int tiempo = int.Parse(textBox1.Text.ToString()) * 3600 + int.Parse(textBox2.Text.ToString()) * 60;
                Process ProcesoActivacion1 = Process.Start("shutdown", "-s -t " + tiempo.ToString());
            }
            catch (Exception) { }
        }

        private void Bt_cancel_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "-a");
        }

    }
}
