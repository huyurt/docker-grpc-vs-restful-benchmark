using Benchmark.Shared.Consts;

namespace Benchmark.MockData.MockStatic
{
    public static class RepeatedStringData
    {
        private static readonly Dictionary<int, string> _values;

        static RepeatedStringData()
        {
            _values = new Dictionary<int, string>();
        }

        public static string GetDataByCount(int count)
        {
            return CreateDataIfNotExists(count);
        }

        public static string CreateDataIfNotExists(int count)
        {
            if (!_values.TryGetValue(count, out var value))
            {
                value = string.Concat(Enumerable.Repeat(MockDataConsts.DATA_10B, count));
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
