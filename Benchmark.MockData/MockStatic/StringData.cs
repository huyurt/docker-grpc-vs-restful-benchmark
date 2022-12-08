using Benchmark.MockData.Helpers;
using Benchmark.Shared.Consts;

namespace Benchmark.MockData.MockStatic
{
    public static class StringData
    {
        private static readonly Dictionary<int, string> _values;

        static StringData()
        {
            _values = new Dictionary<int, string>();
        }

        public static string GetDataByIndex(int index)
        {
            return CreateDataIfNotExists(index);
        }

        public static string CreateDataIfNotExists(int index)
        {
            if (!_values.TryGetValue(index, out var value))
            {
                var size = MockDataConsts.MOCK_DATA_BYTES[index]; // throw bound of index
                value = GenerateDataHelper.GenerateTextBySize(size);
                _values.Add(index, value);
            }
            return value;
        }

        public static void PrepareData()
        {
            for (var i = 0; i < MockDataConsts.MOCK_DATA_BYTES.Length; i++)
            {
                CreateDataIfNotExists(i);
            }
        }
    }
}
