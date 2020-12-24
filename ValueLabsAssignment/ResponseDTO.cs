using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValueLabsAssignment
{
    public class ResponseDTO
    {

        [JsonProperty(PropertyName = "is_success")]
        public bool IsSuccess { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "content")]
        public dynamic Data { get; set; }
    }
}
