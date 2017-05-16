using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Makes (Name) VALUES ('Make1')");
            migrationBuilder.Sql("Insert into Makes (Name) VALUES ('Make2')");
            migrationBuilder.Sql("Insert into Makes (Name) VALUES ('Make3')");

            migrationBuilder.Sql("Insert into Models (Name, MakeID) VALUES ('Make1-ModelA', (Select Id From Makes Where Name = 'Make1'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeID) VALUES ('Make1-ModelB', (Select Id From Makes Where Name = 'Make1'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeID) VALUES ('Make1-ModelC', (Select Id From Makes Where Name = 'Make1'))");

            migrationBuilder.Sql("Insert into Models (Name, MakeID) VALUES ('Make2-ModelA', (Select Id From Makes Where Name = 'Make2'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeID) VALUES ('Make2-ModelB', (Select Id From Makes Where Name = 'Make2'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeID) VALUES ('Make2-ModelC', (Select Id From Makes Where Name = 'Make2'))");

            migrationBuilder.Sql("Insert into Models (Name, MakeID) VALUES ('Make3-ModelA', (Select Id From Makes Where Name = 'Make3'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeID) VALUES ('Make3-ModelB', (Select Id From Makes Where Name = 'Make3'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeID) VALUES ('Make3-ModelC', (Select Id From Makes Where Name = 'Make3'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From Makes where Name in ('Make1', 'Make2', 'Make3')");
            migrationBuilder.Sql("Delete From Models");
        }
    }
}
