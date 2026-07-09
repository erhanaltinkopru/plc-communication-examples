# PLC S7.Net Data Read/Write and Conversion Guide in C#

> [!NOTE]
> **TR:** Programı test edecek fiziksel bir PLC'niz yoksa, bilgisayar ortamında simüle ederek test edebilmeniz için gerekli resmi yazılım bağlantısını ve kurulum kılavuzunu sayfanın en altına ekledim. Oraya göz atabilirsiniz.
> 
> **EN:** If you do not have a physical PLC to test the application, you can simulate the connection on your PC. I have provided the link to the official software and a step-by-step setup guide at the bottom of this page.

When communicating with Siemens S7-1200/1500 PLCs using the **S7.Net** library in C#, direct type casting is not always sufficient. Due to differences in memory alignment and how data types are represented in PLC memory versus .NET memory, you must use specific extension methods provided by S7.Net to accurately read, write, and convert values.

This repository provides a comprehensive technical guide and C# code snippets demonstrating value conversions for all standard industrial data types.

---

## Technical Value Conversion Guide (English)

### 1. S7 Word (16-bit Unsigned Integer)
A `Word` in Siemens PLC corresponds directly to a 16-bit unsigned integer (`ushort` in C#). No special conversion methods are required; you can perform a direct cast.
*   **Reading a Word**:
    ```csharp
    // Read 16-bit unsigned value from DB1.DBW0 and cast directly to ushort
    ushort result = (ushort)plc.Read("DB1.DBW0");
    ```
*   **Writing a Word**:
    ```csharp
    // Write 16-bit unsigned integer to PLC
    ushort val = 40000; 
    plc.Write("DB1.DBW0", val);
    ```

### 2. S7 Int / Dec (16-bit Signed Integer)
A signed `Int` in Siemens memory can hold negative values (from -32,768 to 32,767). S7.Net reads this address as a `ushort` by default. To interpret it correctly as a signed `short` in C#, you must use the `ConvertToShort()` extension method. When writing, convert your C# `short` using `ConvertToUshort()`.
*   **Reading an Int**:
    ```csharp
    // Read and convert unsigned 16-bit to C# signed short
    short result = ((ushort)plc.Read("DB1.DBW0")).ConvertToShort();
    ```
*   **Writing an Int**:
    ```csharp
    // Convert signed C# short to ushort representation before writing to PLC
    short value = -100; 
    plc.Write("DB1.DBW0", value.ConvertToUshort());
    ```

### 3. S7 DWord (32-bit Unsigned Integer)
A `Double Word (DWord)` represents a 32-bit unsigned integer. It maps directly to C# `uint` type, allowing direct casting without extra helpers.
*   **Reading a DWord**:
    ```csharp
    // Read 32-bit unsigned value from DB1.DBD40 and cast directly to uint
    uint result = (uint)plc.Read("DB1.DBD40");
    ```
*   **Writing a DWord**:
    ```csharp
    // Write 32-bit unsigned integer to PLC
    uint val = 1000; 
    plc.Write("DB1.DBD40", val);
    ```

### 4. S7 DInt (32-bit Signed Integer)
A `Double Integer (DInt)` is a 32-bit signed integer (range from -2,147,483,648 to 2,147,483,647). When reading, S7.Net returns it as `uint`. Use the `ConvertToInt()` extension method to cast it to C# `int` correctly. Pushing values can be done directly.
*   **Reading a DInt**:
    ```csharp
    // Read and convert 32-bit unsigned word to signed C# int
    int result2 = ((uint)plc.Read("DB1.DBD60")).ConvertToInt();
    ```
*   **Writing a DInt**:
    ```csharp
    // Write signed C# int directly to PLC memory
    int value = -60000; 
    plc.Write("DB1.DBD60", value);
    ```

### 5. S7 Real (32-bit Floating Point / Floating Decimal)
Siemens `Real` corresponds to C# `float` or `double`. S7.Net reads a 32-bit real value as a raw `uint`. To decode it into a decimal representation, use `ConvertToDouble()`. To write a decimal value from C#, convert it using the `ConvertToUInt()` extension method.
*   **Reading a Real**:
    ```csharp
    // Read raw 32-bit uint and convert to C# double representation
    double result = ((uint)plc.Read("DB1.DBD40")).ConvertToDouble();
    ```
*   **Writing a Real**:
    ```csharp
    // Convert C# double to PLC-compatible uint format before writing
    double val = 35.687; 
    plc.Write("DB1.DBD40", val.ConvertToUInt());
    ```

### 6. Reading Boolean (Bit) from Byte
Sometimes, status indicators are grouped into a single `Byte` to save memory. S7.Net allows you to extract individual bits (boolean flags) from a raw byte using the `SelectBit(bitIndex)` extension method, where `bitIndex` ranges from 0 to 7.
*   **Bit Extraction Example**:
    ```csharp
    byte myByte = 5; // Binary: 0000 0101
    
    // Check state of individual bits (0-indexed)
    bool bit0 = myByte.SelectBit(0); // Returns true (LSB is 1)
    bool bit1 = myByte.SelectBit(1); // Returns false (second bit is 0)
    ```

---

## Teknik Veri Dönüşüm Kılavuzu (Türkçe)

C# üzerinde **S7.Net** kütüphanesi kullanarak Siemens S7-1200/1500 PLC'ler ile haberleşirken, verilerin doğrudan cast edilmesi her zaman doğru sonucu vermez. PLC hafıza yapısı (Memory Layout) ile .NET çalışma zamanı (Runtime) arasındaki veri gösterim farklarından dolayı, S7.Net tarafından sunulan özel uzantı metotlarını (extension methods) kullanmak gerekir.

Bu döküman, endüstriyel otomasyon yazılımlarında en sık kullanılan veri tiplerinin dönüşümlerini detaylı açıklamaları ve kod blokları ile sunmaktadır.

### 1. S7 Word (16-bit İşaretsiz Tamsayı)
Siemens PLC tarafındaki `Word` veri tipi, C# tarafında işaretsiz 16-bit tamsayı olan `ushort` tipine doğrudan karşılık gelir. Herhangi bir dönüşüm metoduna ihtiyaç duyulmadan doğrudan cast edilebilir.
*   **Word Okuma**:
    ```csharp
    // DB1.DBW0 adresinden 16-bit işaretsiz veriyi oku ve ushort tipine dönüştür
    ushort result = (ushort)plc.Read("DB1.DBW0");
    ```
*   **Word Yazma**:
    ```csharp
    // PLC'ye 16-bit işaretsiz tamsayı yaz
    ushort val = 40000;
    plc.Write("DB1.DBW0", val);
    ```

### 2. S7 Int / Dec (16-bit İşaretli Tamsayı)
İşaretli `Int` veri tipi, negatif değerleri de barındırır (-32,768 ile 32,767 arası). S7.Net bu adresi varsayılan olarak `ushort` okur. C#'ta bunu doğru yorumlamak için `ConvertToShort()` uzantısı kullanılmalıdır. Yazarken ise C# `short` değeri `ConvertToUshort()` ile dönüştürülmelidir.
*   **Int Okuma**:
    ```csharp
    // İşaretsiz 16-bit veriyi oku ve işaretli short (Int) tipine çevir
    short result = ((ushort)plc.Read("DB1.DBW0")).ConvertToShort();
    ```
*   **Int Yazma**:
    ```csharp
    // İşaretli C# short değerini PLC'nin kabul edeceği ushort formatına çevirip yaz
    short value = -100;
    plc.Write("DB1.DBW0", value.ConvertToUshort());
    ```

### 3. S7 DWord (32-bit İşaretsiz Tamsayı)
`Double Word (DWord)`, 32-bit işaretsiz tamsayıları temsil eder. C# tarafında doğrudan `uint` tipine karşılık gelir ve ek bir dönüştürücüye ihtiyaç duymaz.
*   **DWord Okuma**:
    ```csharp
    // DB1.DBD40 adresinden 32-bit işaretsiz veriyi oku ve uint olarak cast et
    uint result = (uint)plc.Read("DB1.DBD40");
    ```
*   **DWord Yazma**:
    ```csharp
    // PLC'ye 32-bit işaretsiz tamsayı yaz
    uint val = 1000;
    plc.Write("DB1.DBD40", val);
    ```

### 4. S7 DInt (32-bit İşaretli Tamsayı)
`Double Integer (DInt)`, 32-bit işaretli tamsayıları temsil eder (-2,147,483,648 ile 2,147,483,647 arası). Okurken kütüphane `uint` döner. Bunu C# `int` tipine eşlemek için `ConvertToInt()` uzantısı kullanılır. Yazma işlemi ise doğrudan yapılabilir.
*   **DInt Okuma**:
    ```csharp
    // 32-bit işaretsiz veriyi oku ve işaretli C# int (DInt) tipine çevir
    int result2 = ((uint)plc.Read("DB1.DBD60")).ConvertToInt();
    ```
*   **DInt Yazma**:
    ```csharp
    // İşaretli C# int değerini doğrudan PLC hafızasına yaz
    int value = -60000;
    plc.Write("DB1.DBD60", value);
    ```

### 5. S7 Real (32-bit Kayan Noktalı / Ondalıklı Sayı)
Siemens `Real` tipi, ondalıklı sayıları ifade eder. S7.Net bu veriyi ham `uint` olarak okur. Sayıyı C#'ta ondalıklı değere dönüştürmek için `ConvertToDouble()` kullanılır. C# üzerinden ondalıklı değer yazarken ise `ConvertToUInt()` uzantısı ile PLC'ye uygun formata çevrilir.
*   **Real Okuma**:
    ```csharp
    // Ham 32-bit uint veriyi oku ve C# double (ondalıklı) tipine dönüştür
    double result = ((uint)plc.Read("DB1.DBD40")).ConvertToDouble();
    ```
*   **Real Yazma**:
    ```csharp
    // C# ondalıklı double değerini PLC uyumlu uint formatına çevirip yaz
    double val = 35.687;
    plc.Write("DB1.DBD40", val.ConvertToUInt());
    ```

### 6. Byte İçinden Bool (Bit) Ayıklama
Hafıza tasarrufu sağlamak amacıyla PLC tarafında durum bilgileri tek bir `Byte` içinde toplanabilir. S7.Net, okunan bu ham byte değerinden `SelectBit(bitIndex)` metodunu kullanarak 0-7 arasındaki indekslere göre tekil bool (bit) durumlarını çekmenize olanak tanır.
*   **Bit Ayıklama Örneği**:
    ```csharp
    byte myByte = 5; // İkilik (Binary): 0000 0101
    
    // İlgili indeksteki bitin durumunu kontrol et (0. bit en sağdaki bittir)
    bool bit0 = myByte.SelectBit(0); // true döner (En sağdaki bit 1'dir)
    bool bit1 = myByte.SelectBit(1); // false döner (İkinci bit 0'dır)
    ```

---

## Simulation Setup / Simülasyon Kurulumu

To test this project without a physical PLC, you can use **PLCSIM** alongside **NetToPLCSim** to simulate an S7 connection over TCP/IP:
*   **Official Webpage / Resmi Web Sitesi**: [NetToPLCSim (SourceForge)](https://nettoplcsim.sourceforge.net/)
*   **Step-by-Step Setup Guide / Adım Adım Kurulum Kılavuzu**: [Download PDF / PDF Olarak İndir](NetToPLCSim_Rehberi.pdf)
*   This software binds your local network card's port 102 to redirect communication directly to PLCSIM.

---
*Developed for industrial automation integrations / Endüstriyel otomasyon entegrasyonları için geliştirilmiştir.*
