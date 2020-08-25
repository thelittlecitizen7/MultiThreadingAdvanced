using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MultiThreadingAdvanced
{
    public class Ex
    {
        public Ex()
        {
        }

        // 1
        public IEnumerable<int> GetNumbers(IEnumerable<int> numbers)
        {
            return numbers.AsParallel().Where(n => n % 3 == 1).ToList();
        }

        // 2
        public async Task WriteTextAsync(string messsage)
        {
            string path = @"C:\Empire.txt";
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                await streamWriter.WriteLineAsync(messsage);
            }

        }


    }

}
