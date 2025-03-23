using System;
using System.Collections.Generic;
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
            Contract.Requires(title != null, "Judul video tidak boleh null.");
            Contract.Requires(title.Length <= 100, "Judul video tidak boleh lebih dari 100 karakter.");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;

            Contract.Ensures(this.title == title, "Judul harus sesuai dengan input.");
            Contract.Ensures(this.playCount == 0, "Play count harus diinisialisasi ke 0.");
        }

        public void IncreasePlayCount(int increment)
        {
            Contract.Requires(increment > 0, "Penambahan play count harus lebih dari 0.");
            Contract.Requires(increment <= 10000000, "Penambahan play count tidak boleh lebih dari 10.000.000.");

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

            Contract.Ensures(this.playCount >= 0, "Play count harus selalu positif.");
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID Video: {id}");
            Console.WriteLine($"Judul: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this.id >= 10000 && this.id <= 99999, "ID harus 5 digit.");
            Contract.Invariant(this.playCount >= 0, "Play count tidak boleh negatif.");
            Contract.Invariant(!string.IsNullOrEmpty(this.title), "Judul tidak boleh kosong.");
        }
    }

}
