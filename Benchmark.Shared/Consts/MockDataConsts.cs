namespace Benchmark.Shared.Consts
{
    public static class MockDataConsts
    {
        public const string CHAR_SET = "abcdefghijklmnoprstuvyzABCDEFGHIJKLMNOPQRSTUVYZ0123456789 ";

        public const string DATA_10B = "TestDeneme";

        public static readonly int[] MOCK_DATA_MODEL_COUNT = { 1, 10, 50, 100, 250, 500, 750, 1000, 2500, 5000, 10000, };
     
        public const int _1B = 1;
        public const int _1KB = _1B * 1024;
        public const int _10KB = _1KB * 10;
        public const int _50KB = _1KB * 50;
        public const int _100KB = _1KB * 100;
        public const int _150KB = _1KB * 150;
        public const int _250KB = _1KB * 250;
        public const int _500KB = _1KB * 500;
        public const int _750KB = _1KB * 750;
        public const int _1MB = _1KB * 1024;
        public const int _1_5MB = (int)(_1MB * 1.5);
        public const int _2MB = _1MB * 2;
        public const int _2_5MB = (int)(_1MB * 2.5);
        public const int _5MB = _1MB * 5;
        public const int _7_5MB = (int)(_1MB * 7.5);
        public const int _10MB = _1MB * 10;

        public static readonly long[] MOCK_DATA_BYTES = {
            _1KB,
            _10KB,
            _50KB,
            _100KB,
            _150KB,
            _250KB,
            _500KB,
            _750KB,
            _1MB,
            _1_5MB,
            _2MB,
            _2_5MB,
            _5MB,
            _7_5MB,
            _10MB,
        };

        public static readonly string[] MOCK_DATA_FILES = {
            FileNameConsts.USER_INFORMATION_00012KB_00100,
            FileNameConsts.USER_INFORMATION_00093KB_00750,
            FileNameConsts.USER_INFORMATION_00248KB_02000,
            FileNameConsts.USER_INFORMATION_00496KB_04000,
            FileNameConsts.USER_INFORMATION_01240KB_10000,
            FileNameConsts.USER_INFORMATION_03720KB_30000,
            FileNameConsts.USER_INFORMATION_05581KB_45000,
            FileNameConsts.USER_INFORMATION_12700KB_99999,
        };
    }
}
