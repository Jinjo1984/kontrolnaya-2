using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input.StylusPlugIns;
using Microsoft.VisualBasic;
namespace контрольная_2
{
    internal class Utilites
    {
        
        

        public string[] completeMass(int lenght)//заполнение массива длиной lenght 
        {
            string[] str = new string[lenght];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Interaction.InputBox("Введите символ"); 
            }
            return str;
        }
        public string RepeatingChar(string[] chars)//находит самый используемый символ в строке
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
        public string[] DeleteChar( string[] Mass, string charDel)// удаляет символ с шагом через два
        {
            int k = 0;
            for (int i = 0; i < Mass.Length; i++)
            {
                if (charDel == Mass[i])
                {
                    k++;
                    if (k % 2 == 0)
                    {
                        Mass[i] = "";
                    }
                }

            }
            return Mass;
        }
        public string CharackterInTextBox(string[] str,string textBox)//метод для вывода символов с массива в TextBox
        {
            foreach(string item in str)
            {
                textBox += item;
            }
            return textBox;
        }
       
    }
}
