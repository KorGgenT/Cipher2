using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher2
{
    public class CipherKey
    {
        public string ButtonText { get; set; }
        public string Symbol { get; set; }
        public int Value { get; set; }
    }
    public class Cipher
    {
        public string Name { get; set; }
        public List<CipherKey> Values { get; set; }
    }
}
