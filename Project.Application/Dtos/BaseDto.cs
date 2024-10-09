using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Dtos
{
    public class BaseDto<T>
    {

        public BaseDto(T data, List<string> massages, bool isSuccess)
        {
            Data = data;
            Massages = massages;
            IsSuccess = isSuccess;


        }
        public T Data {get; private set;}
        public List<String> Massages { get; private set;}
        public bool IsSuccess { get; private set;}
    }

    public class BaseDto
    {

        public BaseDto(List<string> massages, bool isSuccess)
        {
            Massages = massages;
            IsSuccess = isSuccess;
        }
        public List<String> Massages { get; private set; }
        public bool IsSuccess { get; private set; }
    }
}
