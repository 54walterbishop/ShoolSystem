﻿using DatabaseHandle;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DatabaseHandle_test
{
    
    
    /// <summary>
    ///这是 DBExecuteTest 的测试类，旨在
    ///包含所有 DBExecuteTest 单元测试
    ///</summary>
    [TestClass()]
    public class DBExecuteTest
    {


        

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            BuildTestDB.createTestTable();
        }
        
        
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            BuildTestDB.dropTestTable();
        }

        [TestMethod()]
        public void getFieldsFromDBTest()
        {
            DBExecute.useTable("TestDB");
            
        }
    }
}
