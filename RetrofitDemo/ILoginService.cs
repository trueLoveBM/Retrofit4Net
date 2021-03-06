﻿using RetrofitDemo.Entity;
using RetrofitFrame;
using RetrofitFrame.RetrofitAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrofitDemo
{
    public interface ILoginService
    {
        [Header("testHeader1: application/javascript")]
        [Header("testHeader2: zh-cn")]
        [POST("/api/TokenAuth/Login")]
        Call Login([Query]string username, [Query] string password, [Body]UserLoginRequestEnt ent, [DynamicHeader("testHeader4")]string header3);

        [POST("/api/TokenAuth/Login")]
        Call Login([Query]string username, [Query] string password);


        ///文件上传接口，这个暂时用不了,因为服务器端
        //[POST("")]
        //[Header("Accept-Language:zh-cn")]
        //[Header("Accept-Encoding:gzip, deflate")]
        //[UploadFile]
        //Call UploadFile([FilePath] string filePath);
    }
}
