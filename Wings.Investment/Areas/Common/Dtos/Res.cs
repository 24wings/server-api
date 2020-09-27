using System;
namespace Wings.Investment.Areas.Common.Dtos
{
    public class Res<T>
    {
       public string msg { get; set; }

        public bool ok { get; set; }

        public T data { get; set; }
    }
}
