using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cipher2
{
    class CipherButton : Button
    {
        public CipherKey button_key;
        public List<CipherKey> keys;
        private void CipherButtonEvent(object sender, EventArgs e)
        {
            if(button_key == null || keys == null)
            {
                return;
            }
            keys.Add(button_key);
        }
        public CipherButton()
        {
            Click += CipherButtonEvent;
        }
    }
}
