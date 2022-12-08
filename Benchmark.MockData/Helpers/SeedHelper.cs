namespace Benchmark.MockData.Helpers
{
    public class SeedHelper
    {
        public static void SeedData()
        {
            MockStatic.StringData.PrepareData();
            MockStatic.IntArrayData.PrepareData();
            MockStatic.FileData.PrepareData();
            MockStatic.UserModelData.PrepareData();
            MockStatic.UserModelSerializedData.PrepareData();
            MockStatic.RepeatedStringData.PrepareData();
            MockStatic.RepeatedStringArrayData.PrepareData();
        }
    }
}
