﻿using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Seed.CollectMethods
{
    public class NewsTypesCollect
    {
        public static void Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                NewsType newsType = new NewsType
                {
                    Name = rawData.ReadString(row, 2)
                };

                unit.NewsTypes.Insert(newsType);
                unit.Save();
            }
        }
    }
}