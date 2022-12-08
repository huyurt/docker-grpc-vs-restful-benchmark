using Benchmark.MockData.MockStatic;
using Benchmark.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Benchmark.Api.Restful.Controllers
{
    [Route("[controller]/[action]")]
    public class RepeatedDataController : ControllerBase
    {
        [HttpPost]
        public async Task<ApiResponse> GetString([FromBody] GetRepeatedDataRequest request)
        {
            return await Task.Run(() => new ApiResponse
            {
                Message = RepeatedStringData.GetDataByCount(request.Count),
            });
        }

        [HttpPost]
        public async Task<GetRepeatedDataResponse> GetStringArray([FromBody] GetRepeatedDataRequest request)
        {
            return await Task.Run(() => new GetRepeatedDataResponse
            {
                Message = RepeatedStringArrayData.GetDataByCount(request.Count),
            });
        }
    }
}
