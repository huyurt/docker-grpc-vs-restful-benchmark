using Benchmark.Shared.Consts;

namespace Benchmark.MockData.MockStatic
{
    public static class RepeatedStringArrayData
    {
        private static readonly Dictionary<int, string[]> _values;

        static RepeatedStringArrayData()
        {
            _values = new Dictionary<int, string[]>();
        }

        public static string[] GetDataByCount(int count)
        {
            return CreateDataIfNotExists(count);
        }

        public static string[] CreateDataIfNotExists(int count)
        {
            if (!_values.TryGetValue(count, out var value))
            {
                value = Enumerable.Repeat(MockDataConsts.DATA_10B, count).ToArray();
                _values.Add(count, value);
            }
            return value;
        }

        public static void PrepareData()
        {
            for (var i = 1; i <= 10000; i *= 10)
            {
                CreateDataIfNotExists(i);
            }
        }
    }
}
