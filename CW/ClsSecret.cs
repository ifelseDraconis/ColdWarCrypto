using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdWarCrypto
{
    public class CentralIntelligenceAgency
    {
        public string GetSecretMessage()
        {
            return "The eagle has landed.";
        }

        public string sendEncryptedData(string data)
        {
            // Simulate sending encrypted data
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(data));
        }

        public string receiveEncryptedData(string encryptedData)
        {
            // Simulate receiving and decrypting data
            byte[] dataBytes = Convert.FromBase64String(encryptedData);
            return Encoding.UTF8.GetString(dataBytes);
        }
    }
}
