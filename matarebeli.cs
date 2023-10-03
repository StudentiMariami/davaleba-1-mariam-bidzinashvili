using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class matarebeli
    {
        private int vagonebis_raod, vagonshi_mgzavr=35,mog;
        public int biletebis_fasi, biletebis_raod;
        public void gamotana(System.Windows.Forms.Label lab2)
        {
            if (biletebis_raod % vagonshi_mgzavr == 0)
            {
                vagonebis_raod = biletebis_raod / vagonshi_mgzavr;
            }
            else
            {
                vagonebis_raod=(biletebis_raod/vagonshi_mgzavr)+1;
            }
    
            lab2.Text="sul aris"+vagonebis_raod.ToString()+" vagoni"+
                "\n1 vagonshi eteva "+vagonshi_mgzavr.ToString()+"mgzavri+" +
                "\nbiletis fasia "+biletebis_fasi.ToString()+
                "\ngakiduli biletebis rodenobaa "+biletebis_raod.ToString();
        }
        public void mogeba(System.Windows.Forms.Label lab1)
        {
            mog = biletebis_raod * biletebis_fasi;
            lab1.Text = "sul shemosuli tanxaa: " + mog.ToString();
        }
    }
}
