//using ProtoBuf;

namespace Benchmark.Shared.Models
{
    //[ProtoContract]
    public class GetUserModelResponse
    {
        //[ProtoMember(1)]
        public UserModel[] Users { get; set; }
    }
}
