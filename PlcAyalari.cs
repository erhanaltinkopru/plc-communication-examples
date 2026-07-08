using System;
using S7.Net;
using S7.Net.Types;

namespace PlcCommunicationExamples
{
    public class PlcAyalari
    {
        private Plc? _plc;
        
        public bool BagliMi => _plc != null && _plc.IsConnected;

        public void Baglan(CpuType cpu, string ip, short rack, short slot)
        {
            _plc = new Plc(cpu, ip, rack, slot);
            _plc.Open();
        }

        public void Kapat()
        {
            _plc?.Close();
        }

        public ushort WordOku(string adres)
        {
            if (!BagliMi) throw new Exception("Bağlantı yok.");
            return (ushort)_plc!.Read(adres)!;
        }

        public void WordYaz(string adres, ushort deger)
        {
            if (!BagliMi) throw new Exception("Bağlantı yok.");
            _plc!.Write(adres, deger);
        }

        public short IntOku(string adres)
        {
            if (!BagliMi) throw new Exception("Bağlantı yok.");
            return ((ushort)_plc!.Read(adres)!).ConvertToShort();
        }

        public void IntYaz(string adres, short deger)
        {
            if (!BagliMi) throw new Exception("Bağlantı yok.");
            _plc!.Write(adres, deger.ConvertToUshort());
        }

        public uint DWordOku(string adres)
        {
            if (!BagliMi) throw new Exception("Bağlantı yok.");
            return (uint)_plc!.Read(adres)!;
        }

        public void DWordYaz(string adres, uint deger)
        {
            if (!BagliMi) throw new Exception("Bağlantı yok.");
            _plc!.Write(adres, deger);
        }

        public int DIntOku(string adres)
        {
            if (!BagliMi) throw new Exception("Bağlantı yok.");
            return ((uint)_plc!.Read(adres)!).ConvertToInt();
        }

        public void DIntYaz(string adres, int deger)
        {
            if (!BagliMi) throw new Exception("Bağlantı yok.");
            _plc!.Write(adres, deger);
        }

        public double RealOku(string adres)
        {
            if (!BagliMi) throw new Exception("Bağlantı yok.");
            return ((uint)_plc!.Read(adres)!).ConvertToFloat();
        }

        public void RealYaz(string adres, double deger)
        {
            if (!BagliMi) throw new Exception("Bağlantı yok.");
            _plc!.Write(adres, ((float)deger).ConvertToUInt());
        }

        public bool BitOku(string adres, int bitIndex)
        {
            if (!BagliMi) throw new Exception("Bağlantı yok.");
            return ((byte)_plc!.Read(adres)!).SelectBit(bitIndex);
        }
    }
}
