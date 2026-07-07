using System;
using S7.Net;
using S7.Net.Types;

namespace PlcCommunicationExamples
{
    public class PlcAyalari
    {
        private Plc? _plc;
        
        /// <summary>
        /// PLC bağlantımın aktif olup olmadığını kontrol ediyorum.
        /// </summary>
        public bool BaglantiVarMi
        {
            get
            {
                if (SimulasyonModu) return true;
                return _plc != null && _plc.IsConnected;
            }
        }

        /// <summary>
        /// Yanımda fiziksel PLC yokken arayüzü test edebilmek için bu simülasyon modunu açık tutuyorum.
        /// </summary>
        public bool SimulasyonModu { get; set; } = true;

        /// <summary>
        /// Belirttiğim IP ve CPU tipine göre PLC bağlantımı başlatıyorum.
        /// </summary>
        public void Baglan(CpuType cpuTipi, string ipAdresi, short rack, short slot)
        {
            if (SimulasyonModu)
            {
                // NOT: Simülasyon modu açıkken gerçek bağlantı kurmuyorum, direkt geçiyorum.
                return;
            }

            _plc = new Plc(cpuTipi, ipAdresi, rack, slot);
            _plc.Open();
        }

        /// <summary>
        /// İşimi bitirdiğimde PLC bağlantısını güvenli bir şekilde kapatıyorum.
        /// </summary>
        public void BaglantiyiKes()
        {
            if (SimulasyonModu || _plc == null) return;
            
            if (_plc.IsConnected)
            {
                _plc.Close();
            }
        }

        // ==========================================
        // 1. S7 Word (16-bit İşaretsiz Tamsayı - ushort)
        // ==========================================
        public ushort WordOku(string adres)
        {
            if (SimulasyonModu)
            {
                return 40000; // Test için uydurduğum bir değer
            }

            if (!BaglantiVarMi || _plc == null) throw new InvalidOperationException("Önce PLC bağlantısını kurmam gerekiyor!");
            return (ushort)_plc.Read(adres);
        }

        public void WordYaz(string adres, ushort deger)
        {
            if (SimulasyonModu) return;

            if (!BaglantiVarMi || _plc == null) throw new InvalidOperationException("Bağlantı olmadan yazma yapamam.");
            _plc.Write(adres, deger);
        }

        // ==========================================
        // 2. S7 Int / Dec (16-bit İşaretli Tamsayı - short)
        // ==========================================
        public short IntOku(string adres)
        {
            if (SimulasyonModu)
            {
                return -100; // Simülasyon için negatif bir değer dönüyorum
            }

            if (!BaglantiVarMi || _plc == null) throw new InvalidOperationException("Bağlantı yok.");
            
            // NOT: S7.Net DBW adresini ushort okuduğu için ConvertToShort() metoduyla işaretli short'a çevirdim.
            ushort hamDeger = (ushort)_plc.Read(adres);
            return hamDeger.ConvertToShort();
        }

        public void IntYaz(string adres, short deger)
        {
            if (SimulasyonModu) return;

            if (!BaglantiVarMi || _plc == null) throw new InvalidOperationException("Bağlantı yok.");
            
            // C# tarafındaki short değerimi PLC'nin anlayacağı ushort formatına çevirip yazıyorum.
            _plc.Write(adres, deger.ConvertToUshort());
        }

        // ==========================================
        // 3. S7 DWord (32-bit İşaretsiz Tamsayı - uint)
        // ==========================================
        public uint DWordOku(string adres)
        {
            if (SimulasyonModu)
            {
                return 1234567; // Test değeri
            }

            if (!BaglantiVarMi || _plc == null) throw new InvalidOperationException("Bağlantı yok.");
            return (uint)_plc.Read(adres);
        }

        public void DWordYaz(string adres, uint deger)
        {
            if (SimulasyonModu) return;

            if (!BaglantiVarMi || _plc == null) throw new InvalidOperationException("Bağlantı yok.");
            _plc.Write(adres, deger);
        }

        // ==========================================
        // 4. S7 DInt (32-bit İşaretli Tamsayı - int)
        // ==========================================
        public int DIntOku(string adres)
        {
            if (SimulasyonModu)
            {
                return -654321; // Simülasyon test değeri
            }

            if (!BaglantiVarMi || _plc == null) throw new InvalidOperationException("Bağlantı yok.");
            
            // NOT: DBD adresini uint okuyorum, ConvertToInt() uzantısıyla int tipine dönüştürdüm.
            uint hamDeger = (uint)_plc.Read(adres);
            return hamDeger.ConvertToInt();
        }

        public void DIntYaz(string adres, int deger)
        {
            if (SimulasyonModu) return;

            if (!BaglantiVarMi || _plc == null) throw new InvalidOperationException("Bağlantı yok.");
            _plc.Write(adres, deger);
        }

        // ==========================================
        // 5. S7 Real (32-bit Ondalıklı Sayı - double)
        // ==========================================
        public double RealOku(string adres)
        {
            if (SimulasyonModu)
            {
                return 35.687; // Simülasyon sıcaklık/basınç test değeri
            }

            if (!BaglantiVarMi || _plc == null) throw new InvalidOperationException("Bağlantı yok.");
            
            // S7.Net 32-bit Real değerini raw uint okur, ConvertToDouble() ile double'a çevirdim.
            uint hamDeger = (uint)_plc.Read(adres);
            return hamDeger.ConvertToDouble();
        }

        public void RealYaz(string adres, double deger)
        {
            if (SimulasyonModu) return;

            if (!BaglantiVarMi || _plc == null) throw new InvalidOperationException("Bağlantı yok.");
            
            // NOT: Double değerimi PLC'ye yazmadan önce ConvertToUInt() ile uint formatına çevirmeyi unutmuyorum!
            _plc.Write(adres, deger.ConvertToUInt());
        }

        // ==========================================
        // 6. Byte İçerisinden Bit (Boolean) Okuma
        // ==========================================
        public bool ByteIcerisindenBitOku(string adres, int bitIndeksi)
        {
            if (SimulasyonModu)
            {
                return bitIndeksi % 2 == 0; // Bit testi için simülasyon mantığı
            }

            if (!BaglantiVarMi || _plc == null) throw new InvalidOperationException("Bağlantı yok.");
            
            // NOT: Byte değerini okuyorum ve SelectBit(bitIndeksi) ile istediğim biti (0-7 arası) çekiyorum.
            // Önemli: bitIndeksi 0 ile 7 arasında olmalıdır!
            if (bitIndeksi < 0 || bitIndeksi > 7) throw new ArgumentOutOfRangeException(nameof(bitIndeksi), "Bit indeksi 0-7 arasında olmalı!");
            
            byte hamByte = (byte)_plc.Read(adres);
            return hamByte.SelectBit(bitIndeksi);
        }
    }
}
