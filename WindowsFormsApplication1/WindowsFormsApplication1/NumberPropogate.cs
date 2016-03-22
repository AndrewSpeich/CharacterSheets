using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class NumberPropogate
    {


       
        public int getmod(int input)
        {
            if (input <= 10 && (input%2) == 1)
            {
                input -= 1;
            }
            input -= 10;
            input /= 2;
           
            return input;
        }
        public List<TextBox> setmod(List<TextBox> input, TextBox stat)
        {
            int mod = 0;
            try {
                 mod = getmod(int.Parse(stat.Text));
            }
            catch
            {


            }
            foreach(TextBox text in input)
            {
                text.Text = string.Concat(mod);
            }
            return input;

        }
        public int addUp(List<TextBox> input)
        {
            int total = 0;
            for(int index = 1; input.Count > index; index++)
            {
                try {
                    total += int.Parse(input[index].Text);
                }
                catch
                {
                    total += 0;
                }
            }
            input[0].Text = string.Concat(total);

            return total;
        }



    }
}
