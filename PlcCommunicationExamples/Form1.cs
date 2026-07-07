namespace PlcCommunicationExamples
{
    public partial class Form1 : Form
    {
        private readonly PlcAyalari _plcAyalari;

        public Form1()
        {
            InitializeComponent();
            
            // PLC Haberleşme ayarlarımı ve servisimi başlatıyorum.
            _plcAyalari = new PlcAyalari();
            
            // Gerçek PLC yokken test edebilmek için Simülasyon Modunu aktif tutuyorum.
            _plcAyalari.SimulasyonModu = true;
        }

        /* 
         * KENDİME NOTLAR:
         * Arayüz tasarımı bittikten sonra butonlara bu metotları bağlayacağım.
         * 
         * // 1. PLC Bağlantısını Başlattığım Buton
         * private void btnBaglan_Click(object sender, EventArgs e)
         * {
         *     try
         *     {
         *         // Gerçek PLC'ye bağlanacaksam simülasyonu kapatıyorum:
         *         // _plcAyalari.SimulasyonModu = false;
         *         
         *         _plcAyalari.Baglan(S7.Net.CpuType.S71200, "192.168.0.1", 0, 1);
         *         lblDurum.Text = "Bağlandı";
         *         lblDurum.ForeColor = Color.Green;
         *     }
         *     catch (Exception ex)
         *     {
         *         MessageBox.Show($"Bağlanamadım: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
         *     }
         * }
         * 
         * // 2. Word (ushort) Değer Okuduğum Buton
         * private void btnWordOku_Click(object sender, EventArgs e)
         * {
         *     ushort deger = _plcAyalari.WordOku("DB1.DBW0");
         *     txtWord.Text = deger.ToString();
         * }
         * 
         * // 3. Int (short) Değer Yazdığım Buton
         * private void btnIntYaz_Click(object sender, EventArgs e)
         * {
         *     if (short.TryParse(txtInt.Text, out short deger))
         *     {
         *         _plcAyalari.IntYaz("DB1.DBW2", deger);
         *     }
         * }
         * 
         * // 4. Real (double) Değer Okuduğum Buton
         * private void btnRealOku_Click(object sender, EventArgs e)
         * {
         *     double deger = _plcAyalari.RealOku("DB1.DBD4");
         *     txtReal.Text = deger.ToString("F3"); // 3 basamaklı ondalık gösterim
         * }
         */
    }
}

