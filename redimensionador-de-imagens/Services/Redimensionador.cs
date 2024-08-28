using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace redimensionador_de_imagens.Services
{
    public class Redimensionador
    {
        

        public Redimensionador()
        {
        }

        public void Redimensionar(string path)
        {
            var newPath = Path.Combine(path, "arquivos_redimensionados");            
            Console.WriteLine("Qual o novo tamanho (altura) que você quer deixar as imagens?");
            int newHeight = int.Parse(Console.ReadLine());
            Console.WriteLine("Uma nova pasta com as imagens redimensionadas vai ser criada...");

            if(!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            } else
            {
                return;
            }

            FileStream file;
            FileInfo fileInfo;
            while(true)
            {
                var arquivesInput = Directory.EnumerateFiles(path);
                
                foreach (var arquive in arquivesInput)
                {
                    using(file = new FileStream(arquive, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)){
                        fileInfo = new FileInfo(arquive);
                        string newFilePath = Path.Combine(newPath, fileInfo.Name);
                        CalculateRedimensionador(Image.FromStream(file) , newFilePath, newHeight);
                    }
                    Thread.Sleep(new TimeSpan(0, 0, 2));
                }
               
               if(Directory.Exists(newPath))
                Console.WriteLine("Finalizado! Obrigado por utilizar o redimensionador! ");
                Environment.Exit(0); 
            }
        }

        public Image CalculateRedimensionador(Image image, string newPath, int newHeight)
        {
            double ratio = (double)newHeight / image.Height;
            int newWidth = (int)(image.Width * ratio);
            int height = (int)(image.Height * ratio);

            Bitmap newImage = new Bitmap(newWidth, height);

            using(Graphics g = Graphics.FromImage(newImage))
            {
                g.DrawImage(image, 0, 0, newWidth, height);
            }

            newImage.Save(newPath);
            image.Dispose();
            return newImage;
        }
    }
}