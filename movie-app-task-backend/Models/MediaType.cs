using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace movie_app_task_backend.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MediaType
    {
        Movie,
        Series
    }
}
