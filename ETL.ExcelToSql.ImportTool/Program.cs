﻿using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using ETL.ExcelToSql.BLL;
using ETL.ExcelToSql.DAL.Migrations;
using ETL.ExcelToSql.DAL.Models;
using ETL.ExcelToSql.ImportTool.Helpers;

namespace ETL.ExcelToSql.ImportTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path to file");
            var input = Console.ReadLine();
            Console.WriteLine("Enter the name for the database (Note: it will render as dbo.tablename");
            var databaseName = Console.ReadLine();
            var excelHelper = new ExcelHelpers(input);
            var excelObjects = excelHelper.GetHeadersFromExcel();        
            //use headers to create the custom concrete type using the dynamic model with private properties

            //use headers to create a class object
            foreach (var exObj in excelObjects)
            {
                if (!Database.Exists(databaseName))
                {
                    var entityObject = new EtlTypeBuilder(exObj.Worksheet, "value");
                }
            }
            //create database from class object
            var config = new Configuration();
            //get data to import to database
            var import = excelHelper.GetDataFromExcel<DynamicModel>();

            

            //using (var context = new DynamicContext())
            //{
            //    context.DynamicModels.AddRange();
            //    context.SaveChanges();
            //}
            excelHelper.Dispose();
        }
    }
}
