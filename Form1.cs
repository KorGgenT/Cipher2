using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cipher2
{
    public partial class Form1 : Form
    {
        // Ciphers by name
        Dictionary<string, Cipher> AllCiphers = new Dictionary<string, Cipher> { };
        List<CipherKey> cipher_values = new List<CipherKey> { };

        private void LoadCiphers()
        {
            string cipher_path = Application.StartupPath + "\\cipher.json";
            JArray parray = JArray.Parse(File.ReadAllText(cipher_path));
            List<Cipher> cipher_list = parray.ToObject<List<Cipher>>();
            foreach( Cipher cipher in cipher_list )
            {
                AllCiphers.Add(cipher.Name, cipher);
                cipherPickerComboBox.Items.Add(cipher.Name);
            }
        }

        public Form1()
        {
            InitializeComponent();
            LoadCiphers();
        }

        private void UpdateCipherLabels(object sender, EventArgs e)
        {
            string word_text = "";
            string symbol_breakdown_text = "";
            string sum_breakdown_text = "";
            int sym_count = 0;
            int word_sum = 0;
            foreach (CipherKey key in cipher_values)
            {
                word_text += key.Symbol;
                symbol_breakdown_text += key.Symbol;
                sum_breakdown_text += key.Value.ToString();
                if( sym_count < cipher_values.Count - 1)
                {
                    symbol_breakdown_text += " + ";
                    sum_breakdown_text += " + ";
                }
                word_sum += key.Value;
                sym_count++;
            }
            wordLabel.Text = word_text;
            symbolBreakdownLabel.Text = symbol_breakdown_text;
            sumBreakdownLabel.Text = sum_breakdown_text;
            cipherSumLabel.Text = word_sum.ToString();
        }

        private void cipherPickerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cipher cipher = AllCiphers[cipherPickerComboBox.Text];
            cipherButtonFlowLayoutPanel.Controls.Clear();
            foreach( CipherKey key in cipher.Values)
            {
                string cipher_text = key.ButtonText == null ?
                    (key.Symbol + " = " + key.Value.ToString()) :
                    key.ButtonText;
                CipherButton button = new CipherButton
                {
                    button_key = key,
                    keys = cipher_values,
                    Height = 20,
                    Width = 60,
                    Text = cipher_text
                };
                button.Click += UpdateCipherLabels;
                cipherButtonFlowLayoutPanel.Controls.Add(button);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            cipher_values.Clear();
            UpdateCipherLabels(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(cipher_values.Count == 0)
            {
                return;
            }
            cipher_values.RemoveAt(cipher_values.Count - 1);
            UpdateCipherLabels(sender, e);
        }
    }
}
