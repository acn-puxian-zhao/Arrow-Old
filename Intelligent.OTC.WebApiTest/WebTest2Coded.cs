﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intelligent.OTC.WebApiTest
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.WebTesting;


    public class WebTest2Coded : WebTest
    {

        public WebTest2Coded()
        {
            this.PreAuthenticate = true;
            this.Proxy = "default";
        }

        public override IEnumerator<WebTestRequest> GetRequestEnumerator()
        {
            WebTestRequest request1 = new WebTestRequest("http://localhost/");
            request1.Method = "POST";
            request1.Encoding = System.Text.Encoding.GetEncoding("utf-8");
            StringHttpBody request1Body = new StringHttpBody();
            request1Body.ContentType = "";
            request1Body.InsertByteOrderMark = false;
            request1Body.BodyString = "";
            request1.Body = request1Body;
            yield return request1;
            request1 = null;
        }
    }
}
