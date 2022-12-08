using Benchmark.MockData.Helpers;
using Benchmark.Shared.Consts;
using Benchmark.Shared.Models;

namespace Benchmark.MockData.MockStatic
{
    public static class UserModelData
    {
        private static readonly Dictionary<int, UserModel[]> _values;
        private static readonly UserModel[] _data;

        static UserModelData()
        {
            _values = new Dictionary<int, UserModel[]>();
            _data = GenerateDataHelper.GenerateUserModelData();
        }

        public static UserModel[] GetDataByIndex(int count)
        {
            return CreateDataIfNotExists(count);
        }

        public static UserModel[] CreateDataIfNotExists(int count)
        {
            if (!_values.TryGetValue(count, out var value))
            {
                _values.Add(count, _data.Take(count).ToArray());
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
