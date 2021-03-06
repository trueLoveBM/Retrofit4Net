﻿using RetrofitDemo.Entity;
using RetrofitFrame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrofitDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            Retrofit retrofit = new Retrofit.Builder()
                .AddHeader("testHeader5:thisIsHeader5")
                .setUrl("http://localhost:21021")
                .build();

            ILoginService service = retrofit.create<ILoginService>();
            Entity.UserLoginRequestEnt ent = new Entity.UserLoginRequestEnt()
            {
                userNameOrEmailAddress = "admin",
                password = "1q2w3E*",
                rememberClient = true
            };
            Call call = service.Login("admin","123456",ent,"dynamicHeader4");
            Respone<AbpCommonResponseEnt<UserLoginResponseEnt>> rep = call.Execute<AbpCommonResponseEnt<UserLoginResponseEnt>>();
            //rep.IsSuccess
            //rep.Msg
            //rep.Code
            //rep.Data
            Console.WriteLine(call.Msg);
            Console.ReadLine();
        }
    }
}
