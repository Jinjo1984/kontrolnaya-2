using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input.StylusPlugIns;
using Microsoft.VisualBasic;
namespace контрольная_2
{
    internal class Utilites
    {
        // Microsoft.VisualBasic.Interaction.InputBox(""); 
        

        public string[] completeMass(int lenght)//заполнение массива длиной lenght 
        {
            string[] str = new string[lenght];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Interaction.InputBox("Введите символ"); 
            }
            return str;
        }
        public string RepeatingChar(string[] chars)
        {
            
            var count = 0;//количесвто повторов
            var index = -1;//индекс в массиве
            for (var i = 0; i < chars.Length; ++i)
            {
                var k = 1;
                for (var j = i + 1; j < chars.Length; ++j)
                    if (chars[i] == chars[j]) k++;
                if (k <= count) continue;
                count = k;
                index = i;
            }
         
            return chars[index]; //возвращает самое повторяющиеся число 
        }
    }
}
