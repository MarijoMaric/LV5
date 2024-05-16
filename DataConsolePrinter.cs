using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv5_Maric
{
    public class DataConsolePrinter
    {

        public void Print(IDataset dataset){

            ReadOnlyCollection<List<string>> data = dataset.GetData();

            if (data == null){
                Console.WriteLine("----------------");
            }

            else{

                foreach (var item in data){

                    foreach (var text in item){

                        Console.Write(text + " ");

                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
