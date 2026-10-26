using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Teema 6 KT 1
 */
namespace Projekti
{
    class Program
    {
         static void Main()
         {
            DirectoryInfo drInfo = new DirectoryInfo("c:/temp");
            int i;

            if(drInfo.Exists !=true)
            {

                drInfo.Create();

            }
            for ( i = 1; i < 11; i++)
            {
                drInfo.CreateSubdirectory("hakemisto" + i);


            }
            string[] hakemistot = Directory.GetDirectories("c:/temp");
            foreach (string hakemisto in hakemistot)
            {

                Directory.Delete(hakemisto);

            }


         }
            
    }
}
