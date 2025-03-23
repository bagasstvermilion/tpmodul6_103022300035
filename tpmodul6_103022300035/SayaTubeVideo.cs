using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300035
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (title == null)
                throw new ArgumentNullException("Judul video tidak boleh null.");
            if (title.Length > 100)
                throw new ArgumentException("Judul video tidak boleh lebih dari 100 karakter.");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;

            ValidateInvariant();
        }

        public void IncreasePlayCount(int increment)
        {
            if (increment <= 0)
                throw new ArgumentException("Penambahan play count harus lebih dari 0.");
            if (increment > 10000000)
                throw new ArgumentException("Penambahan play count tidak boleh lebih dari 10.000.000.");

            try
            {
                checked
                {
                    this.playCount += increment;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR: Play count melebihi batas integer.");
            }

            ValidateInvariant();
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID Video: {id}");
            Console.WriteLine($"Judul: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }

        private void ValidateInvariant()
        {
            Debug.Assert(this.id >= 10000 && this.id <= 99999, "ID harus 5 digit.");
            Debug.Assert(this.playCount >= 0, "Play count tidak boleh negatif.");
            Debug.Assert(!string.IsNullOrEmpty(this.title), "Judul tidak boleh kosong.");
        }
    }
}
