using System;
namespace Micro.Services.AuthAPI.Models.Dto
{
    public class ResponseDto
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "";
    }
    //public record ResponseDto(
    //     object? Result ,
    //     bool IsSuccess  = true,
    //     string Message = ""
    //);
}

