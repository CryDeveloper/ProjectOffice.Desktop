using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice.Desktop.Models
{
    public partial class Project
    {
        public string ShortName
        {
            get
            {
                string shortName = "";
                var wordInTitle = FullTitle.Split(' ');
                if(wordInTitle.Length == 1)
                {
                    shortName = FullTitle[0].ToString()+ FullTitle[1].ToString();
                }                    
                else if(wordInTitle.Length > 1)
                {
                    for (int i = 0; i <= 2; i++)
                    {
                        shortName += (wordInTitle[i].ToUpper())[0];
                    }
                }
                else
                {
                    shortName = FullTitle;
                }
                return shortName;
            }
        }
    }
}
