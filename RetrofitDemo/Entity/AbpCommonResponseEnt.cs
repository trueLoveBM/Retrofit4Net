﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrofitDemo.Entity
{
    public class AbpCommonResponseEnt<T>
    {

        /// <summary>
        /// 
        /// </summary>
        public T result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string targetUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Error error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool unAuthorizedRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool __abp { get; set; }


    }


    public class Error
    {
        /// <summary>
        /// 
        /// </summary>
        public int code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<ValidationErrorsItem> validationErrors { get; set; }

    }


    public class ValidationErrorsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> members { get; set; }
    }
}
