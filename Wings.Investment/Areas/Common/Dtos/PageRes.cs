using System;
using System.Collections.Generic;

namespace Wings.Investment.Areas.Common.Dtos
{

    public class PageData<T>
    {

        public List<T> items { get; set; }
        public long count { get; set; }

    }
    public class PageRes<T> 
    {

        public  PageData<T> data { get; set; }

        public bool ok { get; set; }

        public string msg { get; set; }


        public static PageRes<T>  success(List<T> items,long count,string msg=null)
        {
           var pageData= new PageData<T>() { items=items,count=count};
           return new PageRes<T>() { data=pageData,ok=true,msg=msg};
        }
      
    }
}
