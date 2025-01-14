﻿using Business.Models;
using Business.Services;

namespace Business.Tests.Services;

public class UserService_Tests
{
    [Fact]
    public void AddUser_ShouldAddUserToList()
    {
        // arrange
        File.WriteAllText("users.json", "[]");
        var userService = new UserService();
        var newUser = new User("Joakim", "N", "Joakim.N@domain.com", "1234567891", "TacoStreet", "204 62", "Tacotown");

        // act
        userService.AddUser(newUser);

        // assert
        var users = userService.GetAllUsers();
        Assert.Contains(newUser, users);
    }

    [Fact] 

    public void GetAllUsers_ShouldReturnEmptyList_WhenListIsEmpty()
    {
        // Arraange
        File.WriteAllText("users.json", "[]");
        var userService = new UserService();

        // Act
        var result = userService.GetAllUsers();

        // Assert
        Assert.Empty(result);
    }

    [Fact]

    public void GetAllUsers_ShouldReturnAllUsers()
    {

        // arrange
        File.WriteAllText("users.json", "[]");
        var userService = new UserService();

        var newUser1 = new User("Joakim", "N", "Joakim.N@domain.com", "1234567891", "TacoStreet", "204 62", "Tacotown");
        var newUser2 = new User("Linnea", "N", "Linnea.N@domain.com", "1234566991", "TacoStreet", "204 62", "Tacotown");
        var newUser3 = new User("Gavin", "Strut", "Gavin.Strut@domain.com", "1234568891", "TacoStreet", "204 62", "Tacotown");

        userService.AddUser(newUser1);
        userService.AddUser(newUser2);
        userService.AddUser(newUser3);
        // act
        List<User> usersInList = userService.GetAllUsers();
        /*Code not generated by Chat GPT 4o, but i did get some help with the Assert.Equal,
        I didn't quite find the correct method to use for it myself. So i asked for some advice on that one.
        What it does is taking an expected number, and the actual number.
        In my case i have added 3 new users, so the expected number is 3. 
        And then for the second requirement i put in the list with the count method on it, 
        to return the actual amount of elements in the list.
        */

        // assert
        Assert.Equal(3, usersInList.Count);
        Assert.Contains(newUser1, usersInList);
        Assert.Contains(newUser2, usersInList);
        Assert.Contains(newUser3, usersInList);

    }
}
