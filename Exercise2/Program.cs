﻿using System.Security.Claims;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tokenService = new TokenService();
            var permissionService = new PermissionService();

            var token = tokenService.IssueToken(1, "abc", "admin", new List<Claim>
                {
                new Claim("value1", "abc"),
                new Claim("value2", "def"),
                });

            var tokenDescription = tokenService.ExtractToken(token);
            Console.WriteLine($"{tokenDescription.userId} {tokenDescription.userName} {tokenDescription.role} {tokenDescription.claims}");

            permissionService.Add(new PermissionDto
            {
                Id = 1,
                PermisionName = "admin",
                PermissionValue = "issued"
            });

            var dto = permissionService.Get(1);
            Console.WriteLine($"Id = {dto.Id} Name = {dto.PermisionName} Value = {dto.PermissionValue}");
        }
    }
}
