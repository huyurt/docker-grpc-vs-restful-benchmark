using Benchmark.MockData.Helpers;

namespace Benchmark.MockData.MockStatic
{
    public static class IntArrayData
    {
        private static readonly Dictionary<int, int[]> _values;

        static IntArrayData()
        {
            _values = new Dictionary<int, int[]>();
        }

        public static int[] GetDataByCount(int count)
        {
            return CreateDataIfNotExists(count);
        }

        public static int[] CreateDataIfNotExists(int count)
        {
            if (!_values.TryGetValue(count, out var value))
            {
                value = GenerateDataHelper.GenerateIntArray(count);
                _values.Add(count, value);
            }
            return value;
        }

        public static void PrepareData()
        {
            for (var i = 10; i <= 10000; i *= 10)
            {
                CreateDataIfNotExists(i);
            }
        }
    }
}
