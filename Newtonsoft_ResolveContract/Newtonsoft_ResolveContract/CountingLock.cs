﻿using System;

namespace Newtonsoft_ResolveContract
{
    public class CountingLock1
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
    }

    [Serializable]
    public class CountingLock2
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
    }
}
