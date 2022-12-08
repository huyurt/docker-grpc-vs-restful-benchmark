using Benchmark.Api.Grpc.Protos.RepeatedData;
using Benchmark.MockData.MockStatic;
using Grpc.Core;

namespace Benchmark.Api.Grpc.Services
{
    public class RepeatedDataService : Protos.RepeatedData.RepeatedDataService.RepeatedDataServiceBase
    {
        public override async Task<ApiResponse> GetString(GetRepeatedDataRequest request, ServerCallContext context)
        {
            return await Task.Run(() => new ApiResponse
            {
                Message = RepeatedStringData.GetDataByCount(request.Count),
            });
        }

        public override async Task GetStringStream(GetRepeatedDataRequest request, IServerStreamWriter<ApiResponse> responseStream, ServerCallContext context)
        {
            await responseStream.WriteAsync(new ApiResponse
            {
                Message = RepeatedStringData.GetDataByCount(request.Count),
            });
        }

        public override async Task<GetRepeatedDataResponse> GetStringArray(GetRepeatedDataRequest request, ServerCallContext context)
        {
            return await Task.Run(() =>
            {
                var response = new GetRepeatedDataResponse();
                response.Message.AddRange(RepeatedStringArrayData.GetDataByCount(request.Count));
                return response;
            });
        }

        public override async Task GetStringArrayStream(GetRepeatedDataRequest request, IServerStreamWriter<GetRepeatedDataResponse> responseStream, ServerCallContext context)
        {
            var response = new GetRepeatedDataResponse();
            response.Message.AddRange(RepeatedStringArrayData.GetDataByCount(request.Count));
            await responseStream.WriteAsync(response);
        }
    }
}
