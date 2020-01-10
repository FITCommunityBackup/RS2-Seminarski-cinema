﻿using Cinema.Domain.Entities;
using Cinema.Web.Data;
using Cinema.Domain.Entities.Identity;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Cinema.Services.DatabaseSeed
{
    public static class UsersCollect
    {        
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            var store = new UserStore<ApplicationUser>(context);
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            var userManager = new UserManager<ApplicationUser>(store, null, passwordHasher, null, null, null, null, null, null);

            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                /*User user = new User
                {
                    Username = rawData.ReadString(row, 2),
                    Password = rawData.ReadString(row, 3),
                    FirstName = rawData.ReadString(row, 4),
                    LastName = rawData.ReadString(row, 5),
                    EmailAddress = rawData.ReadString(row, 6),
                    Role = context.AppRoles.Find(rawData.ReadInteger(row, 7))
                };*/

                int oldId = rawData.ReadInteger(row, 1);

                ApplicationUser appUser = new ApplicationUser
                {
                    UserName = rawData.ReadString(row, 2),
                    EmailConfirmed = true,
                    //Hashing needs to be implemented here:
                    //PasswordHash = rawData.ReadString(row, 3),
                    FirstName = rawData.ReadString(row, 4),
                    LastName = rawData.ReadString(row, 5),
                    Email = rawData.ReadString(row, 6),
                    //Role = context.AppRoles.Find(rawData.ReadInteger(row, 7))
                };

                var password = rawData.ReadString(row, 3);
                userManager.CreateAsync(appUser, password);
                //context.Add(user);
                //context.Add(appUser);               
                //context.SaveChanges();
                //SeedUtilities.UsersDictionary.Add(oldId, context.Users.Find(appUser.Id).Id);
            }
        }
    }
}
