﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CoreTests.Integration.Reports
{
    [TestFixture]
    public class Find : ApiWrapperTest
    {

        [Test]
        public void find_all()
        {
            var reports = Api.Reports.Find();
            Assert.IsNotNull(reports);
        }

        [Test]
        public void find_gst_report()
        {
            var reports = Api.Reports.Find("BalanceSheet");
            Assert.IsNotNull(reports);
        }

    }
}
