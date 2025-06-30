using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Retntal");

            migrationBuilder.CreateTable(
                name: "actors",
                schema: "Retntal",
                columns: table => new
                {
                    Actor_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    First_name = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    Last_name = table.Column<string>(type: "text", nullable: false),
                    Last_update = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actors", x => x.Actor_id);
                });

            migrationBuilder.CreateTable(
                name: "Categories_List",
                schema: "Retntal",
                columns: table => new
                {
                    Category_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories_List", x => x.Category_id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                schema: "Retntal",
                columns: table => new
                {
                    Country_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Country_Name = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    Last_update = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Country_id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                schema: "Retntal",
                columns: table => new
                {
                    Language_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(65)", maxLength: 65, nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Language_id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                schema: "Retntal",
                columns: table => new
                {
                    Store_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Manager_staff_id = table.Column<string>(type: "text", nullable: false),
                    Address_id = table.Column<string>(type: "text", nullable: false),
                    Last_update = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "NOW()"),
                    inventory_id = table.Column<int>(type: "integer", nullable: false),
                    Customer_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Store_id);
                });

            migrationBuilder.CreateTable(
                name: "city",
                schema: "Retntal",
                columns: table => new
                {
                    City_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    City_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Country_id = table.Column<int>(type: "integer", nullable: false),
                    Last_update = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "NOW()"),
                    Country_id1 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.City_id);
                    table.ForeignKey(
                        name: "FK_city_Countries_Country_id1",
                        column: x => x.Country_id1,
                        principalSchema: "Retntal",
                        principalTable: "Countries",
                        principalColumn: "Country_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmList",
                schema: "Retntal",
                columns: table => new
                {
                    Film_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    Description = table.Column<string>(type: "character varying(1500)", maxLength: 1500, nullable: false),
                    @int = table.Column<int>(name: "int", type: "integer", nullable: false),
                    Rental_duration = table.Column<int>(type: "int", nullable: false),
                    Rental_Rate = table.Column<int>(type: "integer", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Replacement_Cost = table.Column<double>(type: "double precision", nullable: false),
                    Rating = table.Column<double>(type: "double precision", nullable: false),
                    Special_features = table.Column<string>(type: "text", nullable: true),
                    FullText = table.Column<string>(type: "character varying(6000)", maxLength: 6000, nullable: false),
                    Language_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmList", x => x.Film_id);
                    table.ForeignKey(
                        name: "FK_FilmList_Languages_Language_id",
                        column: x => x.Language_id,
                        principalSchema: "Retntal",
                        principalTable: "Languages",
                        principalColumn: "Language_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "addresses",
                schema: "Retntal",
                columns: table => new
                {
                    Address_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Address_1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Address_2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    District = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    City_id = table.Column<int>(type: "integer", nullable: false),
                    Postal_code = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Last_update = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "NOW()"),
                    City_id1 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.Address_id);
                    table.ForeignKey(
                        name: "FK_addresses_city_City_id1",
                        column: x => x.City_id1,
                        principalSchema: "Retntal",
                        principalTable: "city",
                        principalColumn: "City_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActorFilm",
                schema: "Retntal",
                columns: table => new
                {
                    ActorsActor_id = table.Column<int>(type: "integer", nullable: false),
                    FilmsFilm_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorFilm", x => new { x.ActorsActor_id, x.FilmsFilm_id });
                    table.ForeignKey(
                        name: "FK_ActorFilm_FilmList_FilmsFilm_id",
                        column: x => x.FilmsFilm_id,
                        principalSchema: "Retntal",
                        principalTable: "FilmList",
                        principalColumn: "Film_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorFilm_actors_ActorsActor_id",
                        column: x => x.ActorsActor_id,
                        principalSchema: "Retntal",
                        principalTable: "actors",
                        principalColumn: "Actor_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryFilm",
                schema: "Retntal",
                columns: table => new
                {
                    CategoriesCategory_id = table.Column<int>(type: "integer", nullable: false),
                    FilmsFilm_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryFilm", x => new { x.CategoriesCategory_id, x.FilmsFilm_id });
                    table.ForeignKey(
                        name: "FK_CategoryFilm_Categories_List_CategoriesCategory_id",
                        column: x => x.CategoriesCategory_id,
                        principalSchema: "Retntal",
                        principalTable: "Categories_List",
                        principalColumn: "Category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryFilm_FilmList_FilmsFilm_id",
                        column: x => x.FilmsFilm_id,
                        principalSchema: "Retntal",
                        principalTable: "FilmList",
                        principalColumn: "Film_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Film_Actors",
                schema: "Retntal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Actor_id = table.Column<int>(type: "integer", nullable: false),
                    Film_id = table.Column<int>(type: "integer", nullable: false),
                    Last_update = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "NOW()"),
                    Actor_id1 = table.Column<int>(type: "integer", nullable: true),
                    Film_id1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film_Actors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Film_Actors_FilmList_Film_id1",
                        column: x => x.Film_id1,
                        principalSchema: "Retntal",
                        principalTable: "FilmList",
                        principalColumn: "Film_id");
                    table.ForeignKey(
                        name: "FK_Film_Actors_actors_Actor_id1",
                        column: x => x.Actor_id1,
                        principalSchema: "Retntal",
                        principalTable: "actors",
                        principalColumn: "Actor_id");
                });

            migrationBuilder.CreateTable(
                name: "Film_Categories",
                schema: "Retntal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Film_id = table.Column<int>(type: "integer", nullable: false),
                    Film_id1 = table.Column<int>(type: "integer", nullable: false),
                    Category_id = table.Column<int>(type: "integer", nullable: false),
                    Category_id1 = table.Column<int>(type: "integer", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Film_Categories_Categories_List_Category_id1",
                        column: x => x.Category_id1,
                        principalSchema: "Retntal",
                        principalTable: "Categories_List",
                        principalColumn: "Category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Film_Categories_FilmList_Film_id1",
                        column: x => x.Film_id1,
                        principalSchema: "Retntal",
                        principalTable: "FilmList",
                        principalColumn: "Film_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                schema: "Retntal",
                columns: table => new
                {
                    Inventory_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Last_update = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "NOW()"),
                    Film_id = table.Column<int>(type: "integer", nullable: false),
                    Store_id = table.Column<int>(type: "integer", nullable: false),
                    Film_id1 = table.Column<int>(type: "integer", nullable: false),
                    Store_id1 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Inventory_id);
                    table.ForeignKey(
                        name: "FK_Inventories_FilmList_Film_id1",
                        column: x => x.Film_id1,
                        principalSchema: "Retntal",
                        principalTable: "FilmList",
                        principalColumn: "Film_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventories_Stores_Store_id1",
                        column: x => x.Store_id1,
                        principalSchema: "Retntal",
                        principalTable: "Stores",
                        principalColumn: "Store_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "customer",
                schema: "Retntal",
                columns: table => new
                {
                    Customer_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Address_id = table.Column<int>(type: "integer", nullable: false),
                    Store_id = table.Column<int>(type: "integer", nullable: false),
                    First_name = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: false),
                    Last_name = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: false),
                    Email = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    Activebool = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    Create_date = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "NOW()"),
                    Last_update = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "NOW()"),
                    Store_id1 = table.Column<int>(type: "integer", nullable: false),
                    Address_id1 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.Customer_id);
                    table.ForeignKey(
                        name: "FK_customer_Stores_Store_id1",
                        column: x => x.Store_id1,
                        principalSchema: "Retntal",
                        principalTable: "Stores",
                        principalColumn: "Store_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_customer_addresses_Address_id1",
                        column: x => x.Address_id1,
                        principalSchema: "Retntal",
                        principalTable: "addresses",
                        principalColumn: "Address_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                schema: "Retntal",
                columns: table => new
                {
                    Staff_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    First_name = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    Last_name = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false),
                    Address_id = table.Column<string>(type: "text", nullable: false),
                    Store_id = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    UserName = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Last_update = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Picture = table.Column<string>(type: "text", nullable: true),
                    Address_id1 = table.Column<int>(type: "integer", nullable: false),
                    StoreManagedStore_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Staff_id);
                    table.ForeignKey(
                        name: "FK_Staffs_Stores_StoreManagedStore_id",
                        column: x => x.StoreManagedStore_id,
                        principalSchema: "Retntal",
                        principalTable: "Stores",
                        principalColumn: "Store_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staffs_addresses_Address_id1",
                        column: x => x.Address_id1,
                        principalSchema: "Retntal",
                        principalTable: "addresses",
                        principalColumn: "Address_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                schema: "Retntal",
                columns: table => new
                {
                    Rental_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rental_Date = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "NOW()"),
                    inventory_id = table.Column<int>(type: "integer", nullable: false),
                    Customer_id = table.Column<int>(type: "integer", nullable: false),
                    Staff_id = table.Column<int>(type: "integer", nullable: false),
                    Return_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Last_update = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Inventory_id = table.Column<int>(type: "integer", nullable: false),
                    Customer_id1 = table.Column<int>(type: "integer", nullable: false),
                    Staff_id1 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.Rental_id);
                    table.ForeignKey(
                        name: "FK_Rentals_Inventories_Inventory_id",
                        column: x => x.Inventory_id,
                        principalSchema: "Retntal",
                        principalTable: "Inventories",
                        principalColumn: "Inventory_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rentals_Staffs_Staff_id1",
                        column: x => x.Staff_id1,
                        principalSchema: "Retntal",
                        principalTable: "Staffs",
                        principalColumn: "Staff_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rentals_customer_Customer_id1",
                        column: x => x.Customer_id1,
                        principalSchema: "Retntal",
                        principalTable: "customer",
                        principalColumn: "Customer_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                schema: "Retntal",
                columns: table => new
                {
                    Payment_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Customer_id = table.Column<int>(type: "integer", nullable: false),
                    Staff_id = table.Column<int>(type: "integer", nullable: false),
                    Rental_id = table.Column<int>(type: "integer", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    Payment_Date = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "NOW()"),
                    Rental_id1 = table.Column<int>(type: "integer", nullable: false),
                    Customer_id1 = table.Column<int>(type: "integer", nullable: false),
                    Staff_id1 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Payment_id);
                    table.ForeignKey(
                        name: "FK_Payments_Rentals_Rental_id1",
                        column: x => x.Rental_id1,
                        principalSchema: "Retntal",
                        principalTable: "Rentals",
                        principalColumn: "Rental_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Staffs_Staff_id1",
                        column: x => x.Staff_id1,
                        principalSchema: "Retntal",
                        principalTable: "Staffs",
                        principalColumn: "Staff_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_customer_Customer_id1",
                        column: x => x.Customer_id1,
                        principalSchema: "Retntal",
                        principalTable: "customer",
                        principalColumn: "Customer_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorFilm_FilmsFilm_id",
                schema: "Retntal",
                table: "ActorFilm",
                column: "FilmsFilm_id");

            migrationBuilder.CreateIndex(
                name: "IX_addresses_City_id1",
                schema: "Retntal",
                table: "addresses",
                column: "City_id1");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFilm_FilmsFilm_id",
                schema: "Retntal",
                table: "CategoryFilm",
                column: "FilmsFilm_id");

            migrationBuilder.CreateIndex(
                name: "IX_city_Country_id1",
                schema: "Retntal",
                table: "city",
                column: "Country_id1");

            migrationBuilder.CreateIndex(
                name: "IX_customer_Address_id1",
                schema: "Retntal",
                table: "customer",
                column: "Address_id1");

            migrationBuilder.CreateIndex(
                name: "IX_customer_Store_id1",
                schema: "Retntal",
                table: "customer",
                column: "Store_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Film_Actors_Actor_id1",
                schema: "Retntal",
                table: "Film_Actors",
                column: "Actor_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Film_Actors_Film_id1",
                schema: "Retntal",
                table: "Film_Actors",
                column: "Film_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Film_Categories_Category_id1",
                schema: "Retntal",
                table: "Film_Categories",
                column: "Category_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Film_Categories_Film_id1",
                schema: "Retntal",
                table: "Film_Categories",
                column: "Film_id1");

            migrationBuilder.CreateIndex(
                name: "IX_FilmList_Language_id",
                schema: "Retntal",
                table: "FilmList",
                column: "Language_id");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_Film_id1",
                schema: "Retntal",
                table: "Inventories",
                column: "Film_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_Store_id1",
                schema: "Retntal",
                table: "Inventories",
                column: "Store_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Customer_id1",
                schema: "Retntal",
                table: "Payments",
                column: "Customer_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Rental_id1",
                schema: "Retntal",
                table: "Payments",
                column: "Rental_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Staff_id1",
                schema: "Retntal",
                table: "Payments",
                column: "Staff_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_Customer_id1",
                schema: "Retntal",
                table: "Rentals",
                column: "Customer_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_Inventory_id",
                schema: "Retntal",
                table: "Rentals",
                column: "Inventory_id");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_Staff_id1",
                schema: "Retntal",
                table: "Rentals",
                column: "Staff_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_Address_id1",
                schema: "Retntal",
                table: "Staffs",
                column: "Address_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_StoreManagedStore_id",
                schema: "Retntal",
                table: "Staffs",
                column: "StoreManagedStore_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorFilm",
                schema: "Retntal");

            migrationBuilder.DropTable(
                name: "CategoryFilm",
                schema: "Retntal");

            migrationBuilder.DropTable(
                name: "Film_Actors",
                schema: "Retntal");

            migrationBuilder.DropTable(
                name: "Film_Categories",
                schema: "Retntal");

            migrationBuilder.DropTable(
                name: "Payments",
                schema: "Retntal");

            migrationBuilder.DropTable(
                name: "actors",
                schema: "Retntal");

            migrationBuilder.DropTable(
                name: "Categories_List",
                schema: "Retntal");

            migrationBuilder.DropTable(
                name: "Rentals",
                schema: "Retntal");

            migrationBuilder.DropTable(
                name: "Inventories",
                schema: "Retntal");

            migrationBuilder.DropTable(
                name: "Staffs",
                schema: "Retntal");

            migrationBuilder.DropTable(
                name: "customer",
                schema: "Retntal");

            migrationBuilder.DropTable(
                name: "FilmList",
                schema: "Retntal");

            migrationBuilder.DropTable(
                name: "Stores",
                schema: "Retntal");

            migrationBuilder.DropTable(
                name: "addresses",
                schema: "Retntal");

            migrationBuilder.DropTable(
                name: "Languages",
                schema: "Retntal");

            migrationBuilder.DropTable(
                name: "city",
                schema: "Retntal");

            migrationBuilder.DropTable(
                name: "Countries",
                schema: "Retntal");
        }
    }
}
