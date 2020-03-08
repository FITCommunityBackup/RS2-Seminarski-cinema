﻿using Cinema.DAL.Data;
using Microsoft.AspNetCore.Identity;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using Cinema.Domain.Entities;

namespace Cinema.Seed.CollectMethods
{
    public static class SeedUtilities
    {
        public static Dictionary<int, string> RolesDictionary = new Dictionary<int, string>();
        public static Dictionary<int, string> UsersDictionary = new Dictionary<int, string>();
        public static void SeedDatabase(this UnitOfWork unit, FileInfo fileData)
        {
            /*This methods drops the database, creates a new one, 
             * and performs the defined collect methods upon all tables*/
            unit.Context.Database.EnsureDeleted();
            unit.Context.Database.EnsureCreated();
            unit.Context.ChangeTracker.AutoDetectChangesEnabled = false;

            using (ExcelPackage package = new ExcelPackage(fileData))
            {
                //Type entities seed
                GenresCollect.Collect(package.Workbook.Worksheets["Genres"], unit);
                RolesCollect.Collect(package.Workbook.Worksheets["AppRoles"], unit);
                NewsTypesCollect.Collect(package.Workbook.Worksheets["NewsTypes"], unit);
                EventTypesCollect.Collect(package.Workbook.Worksheets["EventTypes"], unit);
                PricingsCollect.Collect(package.Workbook.Worksheets["Pricings"], unit);

                //Other entities seed
                UsersCollect.Collect(package.Workbook.Worksheets["Users"], unit);
                HallsCollect.Collect(package.Workbook.Worksheets["Halls"], unit);
                MoviesCollect.Collect(package.Workbook.Worksheets["Movies"], unit);
                ReviewsCollect.Collect(package.Workbook.Worksheets["Reviews"], unit);
                ScreeningsCollect.Collect(package.Workbook.Worksheets["Screenings"], unit);
                ReservationsCollect.Collect(package.Workbook.Worksheets["Reservations"], unit);
                InvoicesCollect.Collect(package.Workbook.Worksheets["Invoices"], unit);
                SeatsCollect.Collect(package.Workbook.Worksheets["Seat"], unit);
                SeatReservationsCollect.Collect(package.Workbook.Worksheets["SeatReservations"], unit);
                GenreMoviesCollect.Collect(package.Workbook.Worksheets["GenreMovies"], unit);
                EventsCollect.Collect(package.Workbook.Worksheets["Events"], unit);
                NewsCollect.Collect(package.Workbook.Worksheets["News"], unit);
            }

            Console.WriteLine("Seed complete!");
        }

        public static string ReadString(this ExcelWorksheet sht, int row, int col) => sht.Cells[row, col].Value.ToString().Trim();

        public static int ReadInteger(this ExcelWorksheet sht, int row, int col) => int.Parse(sht.ReadString(row, col));

        public static DateTime ReadDate(this ExcelWorksheet sht, int row, int col)
        {
            var data = sht.Cells[row, col].Value;
            if (data == null) return DateTime.MinValue;
            return DateTime.Parse(data.ToString());
        }
        public static DateTime ReadDateValue(this ExcelWorksheet sht, int row, int col)
        {
            var data = sht.Cells[row, col].Value;
            if (data == null) return DateTime.MinValue;
            
            /*If the date cell in Excel is set to format 'Date' that equals to the set System date format, 
            the package will read it as a DateTime object, and not a OA value*/
            if (data is DateTime)
            {
                DateTime date = DateTime.Parse(data.ToString());
                return date;
            }

            double dateValue = double.Parse(data.ToString());            
            return DateTime.FromOADate(dateValue);
        }

        public static bool ReadBool(this ExcelWorksheet sht, int row, int col) => sht.ReadString(row, col) == "-1";

        public static decimal ReadDecimal(this ExcelWorksheet sht, int row, int col) => decimal.Parse(sht.ReadString(row, col));

    }
}