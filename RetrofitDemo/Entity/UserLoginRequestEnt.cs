﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrofitDemo.Entity
{
    /// <summary>
    /// 用户登录时的请求实体
    /// </summary>
    public class UserLoginRequestEnt
    {
        /// <summary>
        /// 
        /// </summary>
        public string userNameOrEmailAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool rememberClient { get; set; }


    }
}
