﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrofitDemo.Entity
{
    public class UserLoginResponseEnt
    {
        /// <summary>
        /// 
        /// </summary>
        public string accessToken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string encryptedAccessToken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int expireInSeconds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int userId { get; set; }
    }
}
