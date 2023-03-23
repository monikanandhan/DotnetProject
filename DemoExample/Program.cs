using System;
using System.IO;
using System.Text;

namespace DemoExample
{
    class Program
    {
        static void Main(string[] args)
        {
        //   string fpath=@"D:Test.txt";
        //   if(File.Exists(fpath))
        //   {
        //     File.Delete(fpath);
        //   }

        //   using(FileStream fs=File.Create(fpath))
        //   {
        //     AddTexttoFile(fs,"hi");
        //   }
        // }
        // private static void AddTexttoFile(FileStream fs,String value)
        // {
        //     byte[] demo = new UTF8Encoding(true).GetBytes(value);
        //     fs.Write(demo,0,demo.Length);
        // }



        String fpath=@"D:Test.txt";
        if(File.Exists(fpath))
        {
            using(FileStream fs=File.OpenRead(fpath))
            {
                byte[] b=new byte[1024];
                UTF8Encoding encode=new UTF8Encoding(true);
                while(fs.Read(b,0,b.Length)>0)
                {
                    Console.WriteLine(encode.GetString(b));
                }
            }
        }
    }
    }
}
