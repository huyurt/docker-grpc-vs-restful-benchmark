using Benchmark.Api.Grpc.Protos.Data;
using Benchmark.MockData.MockStatic;
using Google.Protobuf;
using Grpc.Core;

namespace Benchmark.Api.Grpc.Services
{
    public class DataService : Protos.Data.DataService.DataServiceBase
    {
        public override async Task<ApiResponse> GetString(ApiRequest request, ServerCallContext context)
        {
            return await Task.Run(() => new ApiResponse
            {
                Message = StringData.GetDataByIndex(request.Index),
            });
        }

        public override async Task GetStringStream(ApiRequest request, IServerStreamWriter<ApiResponse> responseStream, ServerCallContext context)
        {
            await responseStream.WriteAsync(new ApiResponse
            {
                Message = StringData.GetDataByIndex(request.Index),
            });
        }

        public override async Task<GetIntArrayResponse> GetIntArray(GetRepeatedDataRequest request, ServerCallContext context)
        {
            return await Task.Run(() =>
            {
                var response = new GetIntArrayResponse();
                response.Message.AddRange(IntArrayData.GetDataByCount(request.Count));
                return response;
            });
        }

        public override async Task GetIntArrayStream(GetRepeatedDataRequest request, IServerStreamWriter<GetIntArrayResponse> responseStream, ServerCallContext context)
        {
            var response = new GetIntArrayResponse();
            response.Message.AddRange(IntArrayData.GetDataByCount(request.Count));
            await responseStream.WriteAsync(response);
        }

        public override async Task<GetFileResponse> GetFile(ApiRequest request, ServerCallContext context)
        {
            return await Task.Run(() =>
            {
                var fileBytes = FileData.GetDataByIndex(request.Index);
                return new GetFileResponse
                {
                    File = ByteString.CopyFrom(fileBytes),
                };
            });
        }

        public override async Task GetFileStream(ApiRequest request, IServerStreamWriter<GetFileResponse> responseStream, ServerCallContext context)
        {
            var fileBytes = FileData.GetDataByIndex(request.Index);
            await responseStream.WriteAsync(new GetFileResponse
            {
                File = ByteString.CopyFrom(fileBytes),
            });
        }

        public override async Task<GetUserModelResponse> GetUserModel(GetRepeatedDataRequest request, ServerCallContext context)
        {
            return await Task.Run(() =>
            {
                //var users = UserModelData.GetDataByIndex(request.Count);
                //var data = new Shared.Models.GetUserModelResponse
                //{
                //    Users = users,
                //};

                //using var stream = new MemoryStream();
                //ProtoBuf.Serializer.Serialize(stream, data);

                //var dataAsJson = System.Text.Json.JsonSerializer.Serialize(data);

                var users = UserModelSerializedData.GetDataByIndex(request.Count);
                var dataAsJson = $"{{\"Users\":{users}}}";

                var response = GetUserModelResponse.Parser.ParseJson(dataAsJson);
                //var response = GetUserModelResponse.Parser.ParseFrom(stream.ToArray());
                return response;
            });
        }

        public override async Task GetUserModelStream(GetRepeatedDataRequest request, IServerStreamWriter<GetUserModelResponse> responseStream, ServerCallContext context)
        {
            //var users = UserModelData.GetDataByIndex(request.Count);
            //var data = new Shared.Models.GetUserModelResponse
            //{
            //    Users = users,
            //};

            //using var stream = new MemoryStream();
            //ProtoBuf.Serializer.Serialize(stream, data);

            //var dataAsJson = System.Text.Json.JsonSerializer.Serialize(data);

            var users = UserModelSerializedData.GetDataByIndex(request.Count);
            var dataAsJson = $"{{\"Users\":{users}}}";

            var response = GetUserModelResponse.Parser.ParseJson(dataAsJson);
            //var response = GetUserModelResponse.Parser.ParseFrom(stream);
            await responseStream.WriteAsync(response);
        }
    }
}
