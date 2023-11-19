﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ModenovaAP.Sprint5.Task0.V11.Lib;

namespace Tyuiu.ModenovaAP.Sprint5.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = $@"C:\Users\rusal\source\repos\Tyuiu.ModenovaAP.Sprint5\Tyuiu.ModenovaAP.Sprint5.Task0.V11\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
