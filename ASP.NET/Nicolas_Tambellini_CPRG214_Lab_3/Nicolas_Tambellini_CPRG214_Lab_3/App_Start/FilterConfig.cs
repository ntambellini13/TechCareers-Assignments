﻿using System.Web;
using System.Web.Mvc;

namespace Nicolas_Tambellini_CPRG214_Lab_3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
