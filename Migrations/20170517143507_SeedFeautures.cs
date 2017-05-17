using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedFeautures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Features (Name) VALUES ('Feature1')");
            migrationBuilder.Sql("Insert into Features (Name) VALUES ('Feature2')");
            migrationBuilder.Sql("Insert into Features (Name) VALUES ('Feature3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From Features where Name in ('Feature1', 'Feature2', 'Feature3')");
        }
    }
}
