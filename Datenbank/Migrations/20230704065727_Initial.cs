using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datenbank.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateSequence<int>(
                name: "ItemIds");

            migrationBuilder.CreateTable(
                name: "CableType",
                columns: table => new
                {
                    CableTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CableTypeName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CableType", x => x.CableTypeID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FormFactor",
                columns: table => new
                {
                    FormFactorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FormFactorName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormFactor", x => x.FormFactorID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LocationName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    ManufacturerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ManufacturerName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.ManufacturerID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NetworkDeviceType",
                columns: table => new
                {
                    NetworkDeviceTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NetworkDeviceTypeName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetworkDeviceType", x => x.NetworkDeviceTypeID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PeripheralType",
                columns: table => new
                {
                    PeripheralTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PeripheralTypeName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeripheralType", x => x.PeripheralTypeID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ScreenSize",
                columns: table => new
                {
                    ScreenSizeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ScreenSizeName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ScreenWidth = table.Column<int>(type: "int", nullable: false),
                    ScreenHeight = table.Column<int>(type: "int", nullable: false),
                    ScreenDiagonal = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreenSize", x => x.ScreenSizeID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR ItemIds)"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Label = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<double>(type: "double", nullable: false),
                    CableTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cable", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cable_CableType_CableTypeID",
                        column: x => x.CableTypeID,
                        principalTable: "CableType",
                        principalColumn: "CableTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cable_Location_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Other",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR ItemIds)"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Label = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    DetailedDescription = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Other", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Other_Location_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PC",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR ItemIds)"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Label = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    SerialNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ManufacturerID = table.Column<int>(type: "int", nullable: false),
                    InstalledKey = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PC", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PC_Location_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PC_Manufacturer_ManufacturerID",
                        column: x => x.ManufacturerID,
                        principalTable: "Manufacturer",
                        principalColumn: "ManufacturerID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StorageDevice",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR ItemIds)"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Label = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    SerialNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ManufacturerID = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<double>(type: "double", nullable: false),
                    FormFactorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageDevice", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StorageDevice_FormFactor_FormFactorID",
                        column: x => x.FormFactorID,
                        principalTable: "FormFactor",
                        principalColumn: "FormFactorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StorageDevice_Location_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StorageDevice_Manufacturer_ManufacturerID",
                        column: x => x.ManufacturerID,
                        principalTable: "Manufacturer",
                        principalColumn: "ManufacturerID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NetworkDevice",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR ItemIds)"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Label = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    SerialNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ManufacturerID = table.Column<int>(type: "int", nullable: false),
                    MacAdress = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NetworkDeviceTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetworkDevice", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NetworkDevice_Location_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NetworkDevice_Manufacturer_ManufacturerID",
                        column: x => x.ManufacturerID,
                        principalTable: "Manufacturer",
                        principalColumn: "ManufacturerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NetworkDevice_NetworkDeviceType_NetworkDeviceTypeID",
                        column: x => x.NetworkDeviceTypeID,
                        principalTable: "NetworkDeviceType",
                        principalColumn: "NetworkDeviceTypeID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Peripheral",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR ItemIds)"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Label = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    PeriphalTypeID = table.Column<int>(type: "int", nullable: false),
                    PeripheralTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peripheral", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Peripheral_Location_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Peripheral_PeripheralType_PeripheralTypeID",
                        column: x => x.PeripheralTypeID,
                        principalTable: "PeripheralType",
                        principalColumn: "PeripheralTypeID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Display",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(NEXT VALUE FOR ItemIds)"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Label = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    SerialNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ManufacturerID = table.Column<int>(type: "int", nullable: false),
                    ScreenSizeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Display", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Display_Location_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Display_Manufacturer_ManufacturerID",
                        column: x => x.ManufacturerID,
                        principalTable: "Manufacturer",
                        principalColumn: "ManufacturerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Display_ScreenSize_ScreenSizeID",
                        column: x => x.ScreenSizeID,
                        principalTable: "ScreenSize",
                        principalColumn: "ScreenSizeID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Cable_CableTypeID",
                table: "Cable",
                column: "CableTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Cable_LocationID",
                table: "Cable",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Display_LocationID",
                table: "Display",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Display_ManufacturerID",
                table: "Display",
                column: "ManufacturerID");

            migrationBuilder.CreateIndex(
                name: "IX_Display_ScreenSizeID",
                table: "Display",
                column: "ScreenSizeID");

            migrationBuilder.CreateIndex(
                name: "IX_NetworkDevice_LocationID",
                table: "NetworkDevice",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_NetworkDevice_ManufacturerID",
                table: "NetworkDevice",
                column: "ManufacturerID");

            migrationBuilder.CreateIndex(
                name: "IX_NetworkDevice_NetworkDeviceTypeID",
                table: "NetworkDevice",
                column: "NetworkDeviceTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Other_LocationID",
                table: "Other",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_PC_LocationID",
                table: "PC",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_PC_ManufacturerID",
                table: "PC",
                column: "ManufacturerID");

            migrationBuilder.CreateIndex(
                name: "IX_Peripheral_LocationID",
                table: "Peripheral",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Peripheral_PeripheralTypeID",
                table: "Peripheral",
                column: "PeripheralTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_StorageDevice_FormFactorID",
                table: "StorageDevice",
                column: "FormFactorID");

            migrationBuilder.CreateIndex(
                name: "IX_StorageDevice_LocationID",
                table: "StorageDevice",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_StorageDevice_ManufacturerID",
                table: "StorageDevice",
                column: "ManufacturerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cable");

            migrationBuilder.DropTable(
                name: "Display");

            migrationBuilder.DropTable(
                name: "NetworkDevice");

            migrationBuilder.DropTable(
                name: "Other");

            migrationBuilder.DropTable(
                name: "PC");

            migrationBuilder.DropTable(
                name: "Peripheral");

            migrationBuilder.DropTable(
                name: "StorageDevice");

            migrationBuilder.DropTable(
                name: "CableType");

            migrationBuilder.DropTable(
                name: "ScreenSize");

            migrationBuilder.DropTable(
                name: "NetworkDeviceType");

            migrationBuilder.DropTable(
                name: "PeripheralType");

            migrationBuilder.DropTable(
                name: "FormFactor");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Manufacturer");

            migrationBuilder.DropSequence(
                name: "ItemIds");
        }
    }
}
