using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Class1
    {
        private List<String> myList = new List<String>();
        private String myTxt;

        public Class1(String txt)
        {
            //大文字にして格納
            myTxt = txt.ToUpper();

            separateTxt();

        }

        private void separateTxt()
        {
            //正規表現
            String myRegEx = "SELECT.+?FROM";

            //正規表現サーチ
            foreach (var txt in Regex.Matches(myTxt, myRegEx))
            {
                myList.Add(txt.ToString());
            }

        }

        public String getPartTxt(int x)
        {
            try { 
                return myList[x];
            }
            catch
            {
                return null;
            }
        }




    }
}
