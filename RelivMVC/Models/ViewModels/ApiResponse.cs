using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelivMVC.Models.ViewModels
{
    public class ApiResponse<T>
    {
            public T Data { get; set; }
            public bool Success { get; set; }
            public string ErrorMessage { get; set; }
    }
}
