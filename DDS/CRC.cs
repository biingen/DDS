using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRC
{
    class CRC16
    {
        /// <summary>
        /// CRC16_Modbus效驗
        /// </summary>
        /// <param name="byteData">要進行計算的位元組陣列</param>
        /// <returns>計算後的陣列</returns>
        public static byte[] ToModbus(byte[] byteData)
        {
            byte[] CRC = new byte[2];

            UInt16 wCrc = 0xFFFF;
            for (int i = 0; i < byteData.Length; i++)
            {
                wCrc ^= Convert.ToUInt16(byteData[i]);
                for (int j = 0; j < 8; j++)
                {
                    if ((wCrc & 0x0001) == 1)
                    {
                        wCrc >>= 1;
                        wCrc ^= 0xA001;//異或多項式
                    }
                    else
                    {
                        wCrc >>= 1;
                    }
                }
            }

            CRC[1] = (byte)((wCrc & 0xFF00) >> 8);//高位在後
            CRC[0] = (byte)(wCrc & 0x00FF);       //低位在前
            return CRC;
        }

        /// <summary>
        /// CRC16_LSB-MSB效驗
        /// </summary>
        /// <param name="byteData">要進行計算的位元組陣列</param>
        /// <returns>計算後的陣列</returns>
        public static byte[] ToMsbLsb(byte[] byteData)
        {
            byte[] CRC = new byte[2];
            byte[] crcSwtich = new byte[2];
            CRC = ToModbus(byteData);

            crcSwtich[0] = CRC[1]; //高位在後
            crcSwtich[1] = CRC[0]; //低位在前

            return crcSwtich;
        }
    }

    public static class HexConverter
    {
        public static byte[] HexToByte(this string hexString)
        {
            //運算後的位元組長度:16進位數字字串長/2
            byte[] byteOUT = new byte[hexString.Length / 2];
            for (int i = 0; i < hexString.Length; i = i + 2)
            {
                //每2位16進位數字轉換為一個10進位整數
                byteOUT[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }
            return byteOUT;
        }

        public static string BToHex(this byte[] Bdata)
        {
            return BitConverter.ToString(Bdata).Replace("-", "");
        }

        //取出字串右邊開始的指定數目字元
        public static string Right(this string str, int len)
        {
            return str.Substring(str.Length - len, len);
        }
        //取出字串右邊開始的指定數目字元(跳過幾個字元)
        public static string Right(this string str, int len, int skiplen)
        {
            return str.Substring(str.Length - len - skiplen, len);
        }
    }
}
