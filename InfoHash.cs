using System;
using System.Collections.Generic;

namespace Torrent
{
    public class InfoHash
    {
        /*
         * This class is mostly copied from this project
         * https://github.com/hexafluoride/byteflood
         */
        static Dictionary<char, byte> base32DecodeTable;

        static InfoHash()
        {
            base32DecodeTable = new Dictionary<char, byte>();
            string table = "abcdefghijklmnopqrstuvwxyz234567";
            for (int i = 0; i < table.Length; i++)
            {
                base32DecodeTable[table[i]] = (byte)i;
            }
        }
        public InfoHash(byte[] infoHash)
        {
            if (infoHash.Length != 20)
                throw new ArgumentException("Infohash must be exactly 20 bytes long");

            hash = (byte[])infoHash.Clone();
        }

        byte[] hash;
        internal byte[] Hash
        {
            get { return hash; }
        }

        public static InfoHash FromBase32(string infoHash)
        {
            if (infoHash.Length != 32)
                throw new ArgumentException("Infohash must be a base32 encoded 32 character string");

            infoHash = infoHash.ToLower();
            int infohashOffset = 0;
            byte[] hash = new byte[20];
            var temp = new byte[8];
            for (int i = 0; i < hash.Length;)
            {
                for (int j = 0; j < 8; ++j)
                {
                    if (!base32DecodeTable.TryGetValue(infoHash[infohashOffset++], out temp[j]))
                        throw new ArgumentException("infoHash", "Value is not a valid base32 encoded string");
                }

                //8 * 5bits = 40 bits = 5 bytes
                hash[i++] = (byte)((temp[0] << 3) | (temp[1] >> 2));
                hash[i++] = (byte)((temp[1] << 6) | (temp[2] << 1) | (temp[3] >> 4));
                hash[i++] = (byte)((temp[3] << 4) | (temp[4] >> 1));
                hash[i++] = (byte)((temp[4] << 7) | (temp[5] << 2) | (temp[6] >> 3));
                hash[i++] = (byte)((temp[6] << 5) | temp[7]);
            }

            return new InfoHash(hash);
        }

        public static InfoHash FromHex(string infoHash)
        {
            if (infoHash.Length != 40)
                throw new ArgumentException("Infohash must be 40 characters long");

            byte[] hash = new byte[20];
            for (int i = 0; i < hash.Length; ++i)
                hash[i] = byte.Parse(infoHash.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);

            return new InfoHash(hash);
        }

    }
}
