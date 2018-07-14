using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace 开发实战1200例VS2010._1_046
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtEncryptKey.Text.Length!=8)
            {
                MessageBox.Show("加密密钥长度不正确。");
                return;
            }
            try
            {
                byte[] key=Encoding.Default.GetBytes(txtEncryptKey.Text);
                byte[] data=Encoding.Default.GetBytes(txtEncryptPre.Text);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, new DESCryptoServiceProvider().CreateEncryptor(key, key), CryptoStreamMode.Write);
                cs.Write(data, 0, data.Length);
                cs.FlushFinalBlock();
                byte[] temp = ms.ToArray();
                txtEncryptAfter.Text = Convert.ToBase64String(temp);
                cs.Close();
                ms.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txtDecryptKey.Text.Length != 8)
            {
                MessageBox.Show("加密密钥长度不正确。");
                return;
            }

            try
            {
                byte[] data = Convert.FromBase64String(txtDecryptPre.Text);
                byte[] key=Encoding.Default.GetBytes(txtEncryptKey.Text);
                MemoryStream ms = new MemoryStream(data);
                CryptoStream cs = new CryptoStream(ms, new DESCryptoServiceProvider().CreateDecryptor(key, key), CryptoStreamMode.Read);
                List<byte> res = new List<byte>();
                byte[] temp = new byte[200];
                MemoryStream msTemp = new MemoryStream();
                int i = 0;
                while ((i=cs.Read(temp,0,temp.Length))>0)
                {
                    msTemp.Write(temp, 0, i);
                    byte[] temp1 = new byte[i];
                    Array.Copy(temp, 0, temp1, 0, temp1.Length);
                    res.AddRange(temp1);
                }
                txtDecryptAfter.Text = Encoding.Default.GetString(res.ToArray());
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
