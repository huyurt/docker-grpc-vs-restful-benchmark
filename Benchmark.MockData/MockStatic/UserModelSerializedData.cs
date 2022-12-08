using Benchmark.MockData.Helpers;
using Benchmark.Shared.Consts;
using Benchmark.Shared.Models;

namespace Benchmark.MockData.MockStatic
{
    public static class UserModelSerializedData
    {
        private static readonly Dictionary<int, string> _values;
        private static readonly UserModel[] _data;

        static UserModelSerializedData()
        {
            _values = new Dictionary<int, string>();
            _data = GenerateDataHelper.GenerateUserModelData();
        }

        public static string GetDataByIndex(int count)
        {
            return CreateDataIfNotExists(count);
        }

        public static string CreateDataIfNotExists(int count)
        {
            if (!_values.TryGetValue(count, out var value))
            {
                _values.Add(count, System.Text.Json.JsonSerializer.Serialize(_data.Take(count).ToArray()));
            }
            return value;
        }

        public static void PrepareData()
        {
            for (var i = 0; i < MockDataConsts.MOCK_DATA_MODEL_COUNT.Length; i++)
            {
                var count = MockDataConsts.MOCK_DATA_MODEL_COUNT[i];
                CreateDataIfNotExists(count);
            }
        }

        public static UserModel[] GetDataByFilter(GetUserModelByFilterRequest filter)
        {
            return _data.WhereIf(filter.Id.HasValue, d => d.Id == filter.Id)
                .WhereIf(filter.ReferenceKey.HasValue, d => d.ReferenceKey == filter.ReferenceKey)
                .WhereIf(!string.IsNullOrWhiteSpace(filter.Name), d => d.Name == filter.Name || d.MiddleName == filter.Name)
                .WhereIf(!string.IsNullOrWhiteSpace(filter.Surname), d => d.Surname == filter.Surname)
                .WhereIf(!string.IsNullOrWhiteSpace(filter.Email), d => d.Email == filter.Email)
                .ToArray();
        }
    }
}
