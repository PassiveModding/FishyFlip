using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishyFlip.Models;

public class ErrorBody
{
    [System.Text.Json.Serialization.JsonPropertyName("error")]
    public string Error { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("message")]
    public string Message { get; set; }
}