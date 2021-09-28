﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace movie_app_task_backend.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Release_year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isSeries = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MostRatedMoviesReports",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfRatings = table.Column<int>(type: "int", nullable: false),
                    MovieRating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MoviesWithMostScreeningsReports",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfScreenings = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MoviesWithMostSoldTicketsReports",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScreeningName = table.Column<int>(type: "int", nullable: false),
                    SoldTickets = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActorMedia",
                columns: table => new
                {
                    ActorsId = table.Column<int>(type: "int", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMedia", x => new { x.ActorsId, x.MediaId });
                    table.ForeignKey(
                        name: "FK_ActorMedia_Actors_ActorsId",
                        column: x => x.ActorsId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMedia_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating_value = table.Column<float>(type: "real", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Screenings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number_of_seats = table.Column<int>(type: "int", nullable: false),
                    Number_of_tickets = table.Column<int>(type: "int", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screenings_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchasedTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ScreeningId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasedTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasedTickets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ScreeningId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Screenings_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "Screenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Chris Hemsworth" },
                    { 34, "Scottie Fleming" },
                    { 35, "Mara Baldwin" },
                    { 36, "Kristina Hardy" },
                    { 37, "Chris Brandt" },
                    { 38, "Alva Compton" },
                    { 39, "Victoria Alston" },
                    { 40, "Victoria Alston" },
                    { 41, "Victoria Alston" },
                    { 42, "Victoria Alston" },
                    { 43, "Victoria Alston" },
                    { 44, "Victoria Alston" },
                    { 45, "Victoria Alston" },
                    { 46, "Victoria Alston" },
                    { 47, "Victoria Alston" },
                    { 48, "Victoria Alston" },
                    { 49, "Victoria Alston" },
                    { 50, "Victoria Alston" },
                    { 51, "Victoria Alston" },
                    { 52, "Victoria Alston" },
                    { 53, "Victoria Alston" },
                    { 54, "Victoria Alston" },
                    { 55, "Victoria Alston" },
                    { 57, "Victoria Alston" },
                    { 58, "Victoria Alston" },
                    { 59, "Victoria Alston" },
                    { 60, "Victoria Alston" },
                    { 61, "Victoria Alston" },
                    { 33, "Melissa Schwartz" },
                    { 32, "Carlos Ross" },
                    { 56, "Victoria Alston" },
                    { 30, "Walter Blankenship" },
                    { 31, "Dwayne Wun" },
                    { 2, "Natalie Portman" },
                    { 3, "Tom Hiddleston" },
                    { 4, "Brianna Howe" },
                    { 6, "James Hines" },
                    { 7, "Leon Jarvis" },
                    { 8, "Vinson Moran" },
                    { 9, "Simpson Evans" },
                    { 10, "Henry Molina" },
                    { 11, "Mccullough Curry" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 12, "Angelia Ruiz" },
                    { 13, "Hinton Love" },
                    { 14, "Adrienne Logan" },
                    { 15, "Broderick Moore" },
                    { 5, "Carver Wong" },
                    { 17, "Alisha Bentley" },
                    { 16, "Saundra West" },
                    { 28, "Bradly Obrien" },
                    { 29, "Demarcus Boyle" },
                    { 26, "Nellie Barr" },
                    { 25, "Alec Davila" },
                    { 24, "Rey Romero" },
                    { 27, "Odell Best" },
                    { 22, "Normand Hughes" },
                    { 21, "Miriam Cummings" },
                    { 20, "Deshawn Arias" },
                    { 19, "Larry Garcia" },
                    { 23, "Modesto Clements" },
                    { 18, "Hiram Strickland" }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[,]
                {
                    { 74, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Enola Holmes", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 65, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Kate", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 66, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Grown ups 2", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 67, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Grown ups", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 68, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Blended", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 70, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Playing with fire", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 71, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Monte Carlo", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 72, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "She is all that", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 73, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "47 ronin", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 69, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The Internship", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 64, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Work it", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 58, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "John Wick", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 62, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Red 2", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 61, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Just friends", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 60, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Rudy", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 59, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The perfect date", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 57, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "John Wick 2", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 56, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "John Wick 3", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 55, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Hangover part 1", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 54, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Hangover part 2", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 75, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Noah", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 53, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Hangover part 3", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 63, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Pitch perfect", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[,]
                {
                    { 76, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "In time", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 91, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Merlin", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 78, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The Mask", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 52, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Swiped", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 100, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Dare me", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 99, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Shadow hunters", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 98, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Shadow and Bone", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 97, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Good witch", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 96, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Superman and Louise", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 95, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Zero chill", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 94, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "How I met your mother", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 93, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Van Helsing", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 92, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The Walking Dead", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 77, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Midway", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 90, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Warrior nun", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 88, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Journey 2", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 87, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Star trek", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 86, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Kong : skull island", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 85, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Good boys", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 84, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Sweet girl", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 83, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Baywatch", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 82, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Be somebody", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 81, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Tomb Raidler", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 80, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Warcraft", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 79, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Holidate", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 89, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Constantine", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 51, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Creed", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 22, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Fate", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 49, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Creed 3", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 21, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Locke is key", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 20, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Invisible city", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 19, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Teen wolf", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 18, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Marlon", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 17, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Lucifer", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 16, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Vampire diaries", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 15, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "ELite", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 14, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The Flash", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 13, "A sixth-generation homesteader and devoted father, John Dutton controls the largest contiguous ranch in the United States. He operates in a corrupt world where politicians are compromised by influential oil and lumber corporations and land grabs make developers billions.", "2018-06-20", "Yellowstone", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN6RB1/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", true },
                    { 12, "Michael Burnham and her companions in the USS Discovery travel into the far reaches of space to meet new lifeforms and discover new planets.", "2017-09-24", "Star Trek: Discovery", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN8KT4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", true },
                    { 11, "In the wake of a zombie apocalypse, various survivors struggle to stay alive. As they search for safety and evade the undead, they are forced to grapple with rival groups and difficult choices.", "2010-10-31", "The Walking Dead", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN90WK/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", true },
                    { 10, "After having been missing for nearly 20 years, Rick Sanchez suddenly arrives at daughter Beth's doorstep to move in with her and her family.", "2013-09-17", "Rick and Morty", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN85RB/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", true },
                    { 9, "Bilbo fights against a number of enemies to save the life of his Dwarf friends and protects the Lonely Mountain after a conflict arises.", "2014-12-11", "The Hobbit: The Battle of the Five Armies", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZTH3PF/image?locale=en-nz&purposes=BoxArt&mode=scale&q=90&w=162", false }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[,]
                {
                    { 8, "Bilbo Baggins, a hobbit, and his companions face great dangers on their journey to Laketown. Soon, they reach the Lonely Mountain, where Bilbo comes face-to-face with the fearsome dragon Smaug.", "2013-12-12", "The Hobbit: The Desolation of Smaug", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZJ5NLV/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 7, "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.", "2013-09-17", "The Hobbit: An Unexpected Journey", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 6, "The former Fellowship members prepare for the final battle. While Frodo and Sam approach Mount Doom to destroy the One Ring, they follow Gollum, unaware of the path he is leading them to", "2013-09-17", "Lord Of The Rings: The Return Of The King", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162", false },
                    { 5, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Brooklyn Nine-Nine", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 4, "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.", "2012-12-13", "The Hobbit: An Unexpected Journey", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 3, "Frodo and Sam arrive in Mordor with the help of Gollum. A number of new allies join their former companions to defend Isengard as Saruman launches an assault from his domain", "2002-12-18", "Lord Of The Rings: The Two Towers", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162", false },
                    { 2, "After Princess Leia, the leader of the Rebel Alliance, is held hostage by Darth Vader, Luke and Han Solo must free her and destroy the powerful weapon created by the Galactic Empire.", "1977-05-17", "Star Wars: A New Hope", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZXZDZ3/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&", false },
                    { 1, "Luke Skywalker attempts to bring his father back to the light side of the Force. At the same time, the rebels hatch a plan to destroy the second Death Star.", "1983-05-25", "Star Wars: Return of the Jedi", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZZCMJ4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 50, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Creed 2", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 24, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Riverdale", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 23, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The Crew", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 26, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Family guy", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 48, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Takers", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 47, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Crash pad", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 46, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Shaft", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 45, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Zoung adult", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 44, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Transporter 1", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 43, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Transporter 2", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 42, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Transporter 3", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 41, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Wonder", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 40, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "POMS", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 25, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The Ranch", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 38, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Gladiator", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 39, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Defiance", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 36, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Robin Hood", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 35, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Endless love", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 34, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The half of it", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 33, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Before I fall", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 32, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Just like heaven", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false },
                    { 31, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The Ranch", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 30, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Money heist", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 29, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The Witcher", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 28, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Good Girls", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 27, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Cobra kai", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true },
                    { 37, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Aladdin", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[,]
                {
                    { 4, "123456", "user4" },
                    { 1, "123456", "user1" },
                    { 2, "123456", "user2" },
                    { 3, "123456", "user3" },
                    { 5, "123456", "user5" }
                });

            migrationBuilder.InsertData(
                table: "PurchasedTickets",
                columns: new[] { "Id", "Price", "ScreeningId", "UserId" },
                values: new object[,]
                {
                    { 10, 5.5f, 65, 2 },
                    { 8, 5.5f, 55, 1 },
                    { 7, 5.5f, 50, 1 },
                    { 6, 5.5f, 45, 1 },
                    { 5, 5.5f, 40, 1 },
                    { 4, 5.5f, 35, 1 },
                    { 3, 5.5f, 30, 1 },
                    { 2, 5.5f, 25, 1 },
                    { 1, 5.5f, 1, 1 },
                    { 9, 5.5f, 60, 1 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[,]
                {
                    { 12, 12, 4.5f },
                    { 11, 11, 4.5f },
                    { 10, 10, 4.5f },
                    { 6, 6, 4.5f },
                    { 8, 8, 4.5f },
                    { 7, 7, 4.5f },
                    { 13, 13, 4.6f },
                    { 9, 9, 4.6f },
                    { 14, 14, 4.5f },
                    { 19, 19, 4.5f },
                    { 16, 16, 4.5f },
                    { 17, 17, 4.6f },
                    { 18, 18, 4.5f },
                    { 5, 5, 4.6f },
                    { 20, 20, 4.5f },
                    { 21, 21, 4.6f },
                    { 22, 22, 4.5f },
                    { 24, 24, 4.5f },
                    { 15, 15, 4.5f },
                    { 4, 4, 4.5f },
                    { 23, 23, 4.5f },
                    { 1, 1, 4.6f },
                    { 2, 2, 4.5f },
                    { 3, 3, 4.5f }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "Date", "MediaId", "Number_of_seats", "Number_of_tickets", "Place", "Time" },
                values: new object[,]
                {
                    { 3, new DateTime(2021, 10, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3067), 1, 100, 100, "Sarajevo", "08:00" },
                    { 46, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3248), 83, 100, 100, "Sarajevo", "11:00" },
                    { 47, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3251), 83, 100, 100, "Sarajevo", "11:00" },
                    { 48, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3253), 83, 100, 100, "Sarajevo", "11:00" },
                    { 49, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3256), 83, 100, 100, "Sarajevo", "11:00" },
                    { 50, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3258), 84, 100, 100, "Sarajevo", "11:00" },
                    { 51, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3261), 84, 100, 100, "Sarajevo", "11:00" },
                    { 52, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3264), 84, 100, 100, "Sarajevo", "11:00" }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "Date", "MediaId", "Number_of_seats", "Number_of_tickets", "Place", "Time" },
                values: new object[,]
                {
                    { 53, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3266), 84, 100, 100, "Sarajevo", "11:00" },
                    { 54, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3268), 84, 100, 100, "Sarajevo", "11:00" },
                    { 55, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3271), 85, 100, 100, "Sarajevo", "11:00" },
                    { 56, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3273), 85, 100, 100, "Sarajevo", "11:00" },
                    { 57, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3276), 85, 100, 100, "Sarajevo", "11:00" },
                    { 58, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3279), 85, 100, 100, "Sarajevo", "11:00" },
                    { 59, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3281), 85, 100, 100, "Sarajevo", "11:00" },
                    { 2, new DateTime(2021, 10, 4, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3041), 1, 100, 100, "Sarajevo", "11:00" },
                    { 60, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3284), 86, 100, 100, "Sarajevo", "11:00" },
                    { 45, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3241), 83, 100, 100, "Sarajevo", "11:00" },
                    { 63, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3292), 86, 100, 100, "Sarajevo", "11:00" },
                    { 64, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3294), 86, 100, 100, "Sarajevo", "11:00" },
                    { 65, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3297), 87, 100, 100, "Sarajevo", "11:00" },
                    { 66, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3299), 87, 100, 100, "Sarajevo", "11:00" },
                    { 67, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3301), 87, 100, 100, "Sarajevo", "11:00" },
                    { 68, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3304), 87, 100, 100, "Sarajevo", "11:00" },
                    { 69, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3307), 87, 100, 100, "Sarajevo", "11:00" },
                    { 8, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3082), 1, 100, 100, "Sarajevo", "22:00" },
                    { 7, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3080), 1, 100, 100, "Sarajevo", "23:00" },
                    { 6, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3078), 1, 100, 100, "Sarajevo", "00:00" },
                    { 5, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3075), 1, 100, 100, "Sarajevo", "10:00" },
                    { 1, new DateTime(2022, 1, 6, 18, 31, 59, 547, DateTimeKind.Local).AddTicks(4577), 1, 100, 100, "Sarajevo", "10:00" },
                    { 4, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3072), 1, 100, 100, "Sarajevo", "09:00" },
                    { 61, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3287), 86, 100, 100, "Sarajevo", "11:00" },
                    { 62, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3289), 86, 100, 100, "Sarajevo", "11:00" },
                    { 44, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3238), 82, 100, 100, "Sarajevo", "11:00" },
                    { 42, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3231), 82, 100, 100, "Sarajevo", "11:00" },
                    { 28, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3189), 2, 100, 100, "Sarajevo", "11:00" },
                    { 27, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3185), 2, 100, 100, "Sarajevo", "11:00" },
                    { 26, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3179), 2, 100, 100, "Sarajevo", "11:00" },
                    { 25, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3177), 2, 100, 100, "Sarajevo", "11:00" },
                    { 24, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3174), 1, 100, 100, "Sarajevo", "11:00" },
                    { 23, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3171), 1, 100, 100, "Sarajevo", "11:00" },
                    { 22, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3119), 1, 100, 100, "Sarajevo", "11:00" },
                    { 21, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3116), 1, 100, 100, "Sarajevo", "11:00" },
                    { 20, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3113), 1, 100, 100, "Sarajevo", "11:00" },
                    { 19, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3111), 1, 100, 100, "Sarajevo", "12:00" },
                    { 18, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3107), 1, 100, 100, "Sarajevo", "13:00" },
                    { 17, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3105), 1, 100, 100, "Sarajevo", "14:00" },
                    { 16, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3102), 1, 100, 100, "Sarajevo", "15:00" },
                    { 15, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3100), 1, 100, 100, "Sarajevo", "16:00" },
                    { 14, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3097), 1, 100, 100, "Sarajevo", "17:00" }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "Date", "MediaId", "Number_of_seats", "Number_of_tickets", "Place", "Time" },
                values: new object[,]
                {
                    { 13, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3094), 1, 100, 100, "Sarajevo", "18:00" },
                    { 12, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3091), 1, 100, 100, "Sarajevo", "19:00" },
                    { 41, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3228), 82, 100, 100, "Sarajevo", "11:00" },
                    { 40, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3225), 82, 100, 100, "Sarajevo", "11:00" },
                    { 39, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3222), 81, 100, 100, "Sarajevo", "11:00" },
                    { 38, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3219), 81, 100, 100, "Sarajevo", "11:00" },
                    { 37, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3216), 81, 100, 100, "Sarajevo", "11:00" },
                    { 36, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3211), 81, 100, 100, "Sarajevo", "11:00" },
                    { 43, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3235), 82, 100, 100, "Sarajevo", "11:00" },
                    { 35, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3208), 81, 100, 100, "Sarajevo", "11:00" },
                    { 33, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3203), 80, 100, 100, "Sarajevo", "11:00" },
                    { 32, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3200), 80, 100, 100, "Sarajevo", "11:00" },
                    { 31, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3198), 80, 100, 100, "Sarajevo", "11:00" },
                    { 30, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3195), 80, 100, 100, "Sarajevo", "11:00" },
                    { 9, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3085), 1, 100, 100, "Sarajevo", "21:00" },
                    { 11, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3088), 1, 100, 100, "Sarajevo", "20:00" },
                    { 34, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3205), 80, 100, 100, "Sarajevo", "11:00" },
                    { 29, new DateTime(2022, 1, 2, 12, 51, 59, 549, DateTimeKind.Local).AddTicks(3192), 2, 100, 100, "Sarajevo", "11:00" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Price", "ScreeningId" },
                values: new object[,]
                {
                    { 1, 5.5f, 1 },
                    { 2, 5.5f, 25 },
                    { 3, 5.5f, 30 },
                    { 4, 5.5f, 35 },
                    { 5, 5.5f, 40 },
                    { 6, 5.5f, 45 },
                    { 7, 5.5f, 50 },
                    { 8, 5.5f, 55 },
                    { 9, 5.5f, 60 },
                    { 10, 5.5f, 65 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMedia_MediaId",
                table: "ActorMedia",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedTickets_UserId",
                table: "PurchasedTickets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_MediaId",
                table: "Ratings",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_MediaId",
                table: "Screenings",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ScreeningId",
                table: "Tickets",
                column: "ScreeningId");
            string GetMoviesWithMostSoldTicketsWithoutRating = @" CREATE PROCEDURE GetMoviesWithMostSoldTicketsWithoutRating
                                                             AS
                                                             BEGIN
                                                             SET NOCOUNT ON

                                                             SELECT   m.Title, s.Id AS ScreeningName,COUNT(t.Id) AS SoldTickets
                                                             FROM Medias m
                                                             JOIN Screenings s ON s.MediaId = m.Id
                                                             JOIN Tickets t ON t.ScreeningId = s.Id
                                                             WHERE (    SELECT COUNT(*) 
                                                                        FROM Ratings r 
                                                                        WHERE r.MediaId = m.Id ) = 0
                                                             AND isSeries = 0
                                                             GROUP BY m.Id,m.Title,s.Id
                                                             ORDER BY Count(t.Id) DESC;

                                                             END";

            string GetTopTenMoviesWithMostRating = @"CREATE PROCEDURE GetTopTenMoviesWithMostRating
                                             AS
                                             BEGIN
                                             SET NOCOUNT ON

                                             SELECT TOP 10  m.Title, Count(r.MediaId) as NumberOfRatings, avg(r.rating_value) AS MovieRating 
                                             FROM Medias m 
                                             JOIN Ratings r On r.MediaId = m.Id
                                             WHERE isSeries = 0 
                                             GROUP BY m.Id, Title
                                             ORDER BY avg(r.rating_value) DESC;

                                             END";




            string GetTopTenMoviesWithMostScreening = @"CREATE PROCEDURE GetTopTenMoviesWithMostScreening
                                             @start_date DateTime,@end_date DateTime
                                             AS
                                             BEGIN
                                             SET NOCOUNT ON

                                             SELECT TOP 10  m.Title, Count(s.Id) as NumberOfScreenings
                                             FROM Medias m 
                                             JOIN Screenings s On s.MediaId = m.Id
                                             WHERE s.Date BETWEEN @start_date AND @end_date AND isSeries = 0
                                             GROUP BY m.Id, Title
                                             ORDER BY Count(s.Id) DESC;

                                              END";


            migrationBuilder.Sql(GetTopTenMoviesWithMostScreening);
            migrationBuilder.Sql(GetTopTenMoviesWithMostRating);
            migrationBuilder.Sql(GetMoviesWithMostSoldTicketsWithoutRating);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMedia");

            migrationBuilder.DropTable(
                name: "MostRatedMoviesReports");

            migrationBuilder.DropTable(
                name: "MoviesWithMostScreeningsReports");

            migrationBuilder.DropTable(
                name: "MoviesWithMostSoldTicketsReports");

            migrationBuilder.DropTable(
                name: "PurchasedTickets");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Screenings");

            migrationBuilder.DropTable(
                name: "Medias");


            migrationBuilder.DropTable(
                name: "GetMoviesWithMostSoldTicketsWithoutRating");
            migrationBuilder.DropTable(
         name: "GetTopTenMoviesWithMostRating");
            migrationBuilder.DropTable(
         name: "GetTopTenMoviesWithMostScreening");
        }
    }
}
