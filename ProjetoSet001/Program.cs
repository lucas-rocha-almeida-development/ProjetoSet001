using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoSet001.Entitides;

namespace ProjetoSet001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //iremos implementar o HasSet justamente porque não estaremos preocupados com a ordem do conjunto
            // quando existe preocupação , usamos o SortSet
            HashSet<RegistroLog> set = new HashSet<RegistroLog>();


            Console.Write("Insira o caminha do arquivo: ");//utilize um arquivo no formato 
            string path = Console.ReadLine();
            try
            { using (StreamReader sr = File.OpenText(path))
                {while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];//nome sera o primeiro elemento 0
                        DateTime instant = DateTime.Parse(line[1]);// instante sera segundo elemento 1
                        set.Add(new RegistroLog { UserName= name,Instant = instant });
                        /*Caso tente adicionar um usuario repetido (já existente)
                         Ira ser negado, porque ira de encontro com metodo ja criado na CLASS =Registro log
                        GetHasCode-ira constar o UserName repetido (bloqueado)*/
             
                    }
                Console.WriteLine("Total de Usuarios: " + set.Count);
                    //ira retornar elementos não repetidos
                    
                }


            } 
            catch(IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
