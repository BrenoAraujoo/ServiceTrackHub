﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceTrackHub.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class remove_task_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "tasks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
