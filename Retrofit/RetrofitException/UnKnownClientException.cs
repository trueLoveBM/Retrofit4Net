﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrofitFrame.RetrofitException
{
    public class UnKnownClientException : ApplicationException
    {
        private string error;
        private Exception innerException;
        public UnKnownClientException()
        {

        }
        //带一个字符串参数的构造函数，作用：当程序员用Exception类获取异常信息而非 MyException时把自定义异常信息传递过去
        public UnKnownClientException(string msg) : base(msg)
        {
            this.error = msg;
        }
        //带有一个字符串参数和一个内部异常信息参数的构造函数
        public UnKnownClientException(string msg, Exception innerException) : base(msg)
        {
            this.innerException = innerException;
            this.error = msg;
        }
    }
}
