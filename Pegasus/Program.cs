using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string customerRef = "CR04223";
        string customerName = "Test Customer";
        string fromTelecom = "PBU";
        string toTelecom = "PBU";
        string vendorTranId = "T002";
        string vendorCode = "WAPIPAY_PUSH";
        string password = "43L71IF023";
        string paymentDate = "2022-02-09";
        string tranType = "PUSH";
        string paymentCode = "1";
        string tranAmount = "1500";
        string fromAccount = "3010000007781";
        string toAccount = "3010000007781";


        string dataToSign = customerRef + customerName + fromTelecom + toTelecom + vendorTranId + vendorCode + password + paymentDate + tranType + paymentCode + tranAmount + fromAccount + toAccount;

        string certificate = "PKCS7.pfx";
        // Load the certificate
        X509Certificate2 cert = new X509Certificate2(certificate, "#Robert20noyce", X509KeyStorageFlags.UserKeySet);

        // Get the RSA private key
        RSA privateKey = cert.GetRSAPrivateKey();

        // Encode the data
        ASCIIEncoding encoding = new ASCIIEncoding();
        byte[] dataBytes = encoding.GetBytes(dataToSign);

        // Hash the data
        SHA1 sha1 = SHA1.Create();
        byte[] hash = sha1.ComputeHash(dataBytes);

        // Sign the data
        byte[] digitalSign = privateKey.SignHash(hash, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
        string strDigSign = Convert.ToBase64String(digitalSign);
        Console.WriteLine(strDigSign);
    }
}
