using Benchmark.MockData.MockStatic;
using Benchmark.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Benchmark.Api.Restful.Controllers
{
    [Route("[controller]/[action]")]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public async Task<ApiResponse> GetGetString([FromRoute] int index)
        {
            return await Task.Run(() => new ApiResponse
            {
                Message = StringData.GetDataByIndex(index),
            });
        }

        [HttpGet]
        public async Task<GetUserModelResponse> GetGetUserModel([FromRoute] int count)
        {
            return await Task.Run(() => new GetUserModelResponse
            {
                Users = UserModelData.GetDataByIndex(count),
            });
        }

        [HttpPost]
        public async Task<ApiResponse> GetString([FromBody] ApiRequest request)
        {
            return await Task.Run(() => new ApiResponse
            {
                Message = StringData.GetDataByIndex(request.Index),
            });
        }

        [HttpPost]
        public async Task<GetIntArrayResponse> GetIntArray([FromBody] GetRepeatedDataRequest request)
        {
            return await Task.Run(() => new GetIntArrayResponse
            {
                Message = IntArrayData.GetDataByCount(request.Count),
            });
        }

        [HttpPost]
        public async Task<GetFileResponse> GetFile([FromBody] ApiRequest request)
        {
            return await Task.Run(() => new GetFileResponse
            {
                File = FileData.GetDataByIndex(request.Index),
            });
        }

        [HttpPost]
        public async Task<GetUserModelResponse> GetUserModel([FromBody] GetRepeatedDataRequest request)
        {
            return await Task.Run(() => new GetUserModelResponse
            {
                Users = UserModelData.GetDataByIndex(request.Count),
            });
        }

        [HttpPost]
        public async Task<GetUserModelResponse> GetUserModelByFilter([FromBody] GetUserModelByFilterRequest request)
        {
            return await Task.Run(() => new GetUserModelResponse
            {
                Users = UserModelData.GetDataByFilter(request),
            });
        }
    }
}
