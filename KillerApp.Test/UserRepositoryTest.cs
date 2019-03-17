//using KillerApp.Api.Context;
//using KillerApp.Core.Models;
//using KillerApp.Repository.Interfaces;
//using KillerApp.Repository.Repositories;
//using System;
//using System.Linq;
//using System.Collections.Generic;
//using Xunit;

//namespace KillerApp.Test
//{
//    public class UserRepositoryTest
//    {
//        IGenericContext<Customer> context = new UserMemoryContext();

//        [Fact]
//        public void TestGetUser()
//        {
//            // Arrange
//            Account user1 = new Account()
//            {
//                Address = "1e Vijverstraat 2",
//                BirthDate = DateTime.Now,
//                City = "Berlicum",
//                Country = "Netherlands",
//                CountryCode = new char[2] { 'N', 'L' },
//                DateCreated = DateTime.Now,
//                Email = "409368@student.fontys.nl",
//                FirstName = "Kevin",
//                Id = 1,
//                LastName = "Beye",
//                Password = "123Test",
//                Status = DataStatus.None,
//                MiddleName = "",
//                Token = "",
//                ZipCode = "5258HS"
//            };
//            Account user2 = new Account()
//            {
//                Address = "2e Vijverstraat 2",
//                BirthDate = DateTime.Now,
//                City = "Den Bosch",
//                Country = "Netherlands",
//                CountryCode = new char[2] { 'N', 'L' },
//                DateCreated = DateTime.Now,
//                Email = "k.beye@student.fontys.nl",
//                FirstName = "Kevin",
//                Id = 1,
//                LastName = "Beye",
//                Password = "Kevin123",
//                Status = DataStatus.None,
//                MiddleName = "",
//                Token = "",
//                ZipCode = "5258HS"
//            };
//            context.Insert(user1);
//            context.Insert(user2);
//            IGenericRepository<Account> repo = new GenericRepository<Account>(context);

//            // Act
//            var users = repo.GetAll().ToList();

//            // Assert
//            Assert.Equal(2, users.Count);
//            Assert.Equal(user1, users[0]);
//            Assert.Equal(user2, users[1]);
//        }
//    }
//}
