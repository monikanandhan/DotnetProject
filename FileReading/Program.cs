using System.IO;
using System.Text;
using System;

namespace FileReading
{
    class Program
    {
        static void Main(string[] args)
        {
           string fpath=@"D:Demo.txt";
           if(File.Exists(fpath))
           {
            File.Delete(fpath);
           }


using(BinaryWriter bw=new BinaryWriter(File.Open(fpath,FileMode.Create)))
{
     bw.Write(1.25);
               bw.Write("Welcome to Tutlane");
               bw.Write(10);
               bw.Write(true);
               bw.Write("test");
}

 using (BinaryReader br = new BinaryReader(File.Open(fpath, FileMode.Open)))
            {
               Console.WriteLine(br.ReadDouble());
               Console.WriteLine(br.ReadString());
               Console.WriteLine(br.ReadInt32());
               Console.WriteLine(br.ReadBoolean());
               Console.WriteLine(br.ReadString());
            }
 Console.ReadLine();
        //    FileStream fs=new FileStream(fpath,FileMode.Create);

        //    using(StreamWriter sw=new StreamWriter(fs))
        //    {
        //     sw.WriteLine("welcome");
        //    }

        //    using(TextWriter fs=File.CreateText(fpath))
        //    {
        //    fs.WriteLine("hello");
        //    }

        //     string fpath=@"D:Demo.txt";
        //   if(File.Exists(fpath))
        //    {
        //     using(StreamReader wr=new StreamReader(fpath))
        //     {
        //         Console.WriteLine(wr.ReadLine());
        //     }
        //    }

        }

        // private static void AddTexttoFile(FileStream fs,string Value)
        // {
        //    byte[]  demo= new UTF8Encoding(true).GetBytes(Value);
        //    fs.Write(demo,0,demo.Length);

        // string fpath=@"D:Demo.text";
        // if(File.Exists(fpath))
        // {
        //     using(FileStream fs=File.OpenRead(fpath))
        //     {
        //         byte[] b=new byte[1024];
        //         UTF8Encoding encode=new UTF8Encoding(true);
        //        if( fs.Read(b,0,b.Length)>0)
        //        {
        //         Console.WriteLine(encode.GetString(b));
        //        }
        //     }
        // }
            // Console.ReadLine();

        }
    }

