﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz.";
        internal static string MaintenanceTime = "Sistem Bakımda";
        internal static string ProductsListed = "Ürünler Listelendi";

        public static object MaintenaceTime { get; internal set; }
    }
}
