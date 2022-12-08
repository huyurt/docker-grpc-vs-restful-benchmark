using Benchmark.Shared.Consts;
using Benchmark.Shared.Helpers;
using Benchmark.Shared.Models;
using System.Text;
using System.Text.Json;

namespace Benchmark.MockData.Helpers
{
    public class GenerateDataHelper
    {
        public static string GenerateTextBySize(long size)
        {
            var sb = new StringBuilder();
            var rd = new Random();
            var numOfChars = size;
            var length = MockDataConsts.CHAR_SET.Length;
            for (var i = 0; i < numOfChars; i++)
            {
                var index = rd.Next(length);
                var text = MockDataConsts.CHAR_SET[index];
                sb.Append(text);
            }
            return sb.ToString();
        }

        public static int[] GenerateIntArray(int count)
        {
            var array = new int[count];
            var rd = new Random();
            for (var i = 0; i < count; i++)
            {
                var number = rd.Next(10, 100);
                array[i] = number;
            }
            return array;
        }

        public static UserModel[] GenerateUserModelData()
        {
            var dataAsString = FileHelper.GetFileContent("MockJson/", FileNameConsts.USER_MODEL_05000).Result;
            var data = JsonSerializer.Deserialize<UserModel[]>(dataAsString);
            return data.OrderBy(u => u.ReferenceKey).ToArray();
        }
    }
}
