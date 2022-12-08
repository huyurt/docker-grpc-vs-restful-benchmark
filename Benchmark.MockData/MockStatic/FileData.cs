using Benchmark.Shared.Consts;
using Benchmark.Shared.Helpers;

namespace Benchmark.MockData.MockStatic
{
    public static class FileData
    {
        private static readonly Dictionary<int, byte[]> _values;

        static FileData()
        {
            _values = new Dictionary<int, byte[]>();
        }

        public static byte[] GetDataByIndex(int index)
        {
            return CreateDataIfNotExists(index);
        }

        public static byte[] CreateDataIfNotExists(int index)
        {
            if (!_values.TryGetValue(index, out var value))
            {
                var fileName = MockDataConsts.MOCK_DATA_FILES[index]; // throw bound of index
                value = FileHelper.GetFile("MockJson/", fileName).Result;
                _values.Add(index, value);
            }
            return value;
        }

        public static void PrepareData()
        {
            for (var i = 0; i < MockDataConsts.MOCK_DATA_FILES.Length; i++)
            {
                CreateDataIfNotExists(i);
            }
        }
    }
}
