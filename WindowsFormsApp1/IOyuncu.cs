using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface IOyuncu
    {
         int hamleMaliyet { get; set; }
        int hedefBelirlemeMaliyet { get; set; }
        
        int kasadakiAltinMiktari { get; set; }
        int toplamAdim { get; set; }
        int harcananAltinMiktari { get; set; }
        int toplananAltin { get; set; }

        List<string> adimlar { get; set; }


    }
}
