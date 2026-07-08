using System;
using System.Drawing;
using System.Windows.Forms;
using S7.Net;

namespace PlcCommunicationExamples
{
    public partial class Form1 : Form
    {
        private readonly PlcAyalari _plcAyalari = new PlcAyalari();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string cpuText = cmbCpu.SelectedItem?.ToString() ?? "S71200";
                CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), cpuText);
                _plcAyalari.Baglan(cpu, txtIp.Text, (short)numRack.Value, (short)numSlot.Value);

                lblStatus.Text = "Bağlandı";
                lblStatus.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                _plcAyalari.Kapat();
                lblStatus.Text = "Bağlantı Kesildi";
                lblStatus.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnWordRead_Click(object sender, EventArgs e)
        {
            try
            {
                txtWordValue.Text = _plcAyalari.WordOku(txtWordAddress.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnWordWrite_Click(object sender, EventArgs e)
        {
            try
            {
                _plcAyalari.WordYaz(txtWordAddress.Text, ushort.Parse(txtWordValue.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnIntRead_Click(object sender, EventArgs e)
        {
            try
            {
                txtIntValue.Text = _plcAyalari.IntOku(txtIntAddress.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnIntWrite_Click(object sender, EventArgs e)
        {
            try
            {
                _plcAyalari.IntYaz(txtIntAddress.Text, short.Parse(txtIntValue.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnDWordRead_Click(object sender, EventArgs e)
        {
            try
            {
                txtDWordValue.Text = _plcAyalari.DWordOku(txtDWordAddress.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnDWordWrite_Click(object sender, EventArgs e)
        {
            try
            {
                _plcAyalari.DWordYaz(txtDWordAddress.Text, uint.Parse(txtDWordValue.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnDIntRead_Click(object sender, EventArgs e)
        {
            try
            {
                txtDIntValue.Text = _plcAyalari.DIntOku(txtDIntAddress.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnDIntWrite_Click(object sender, EventArgs e)
        {
            try
            {
                _plcAyalari.DIntYaz(txtDIntAddress.Text, int.Parse(txtDIntValue.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnRealRead_Click(object sender, EventArgs e)
        {
            try
            {
                txtRealValue.Text = _plcAyalari.RealOku(txtRealAddress.Text).ToString("F3");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnRealWrite_Click(object sender, EventArgs e)
        {
            try
            {
                _plcAyalari.RealYaz(txtRealAddress.Text, double.Parse(txtRealValue.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnBitRead_Click(object sender, EventArgs e)
        {
            try
            {
                bool sonuc = _plcAyalari.BitOku(txtByteAddress.Text, (int)numBitIndex.Value);
                lblBitResult.Text = "Sonuç: " + (sonuc ? "1" : "0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }
    }
}
