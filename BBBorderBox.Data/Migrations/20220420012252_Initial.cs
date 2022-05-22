using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BBBorderBox.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Telegram");

            migrationBuilder.EnsureSchema(
                name: "Sales");

            migrationBuilder.EnsureSchema(
                name: "Common");

            migrationBuilder.EnsureSchema(
                name: "HR");

            migrationBuilder.EnsureSchema(
                name: "Shipment");

            migrationBuilder.CreateTable(
                name: "ChatsUpdates",
                schema: "Telegram",
                columns: table => new
                {
                    UpdateId = table.Column<long>(type: "bigint", nullable: false),
                    MessageId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageText = table.Column<string>(type: "VARCHAR(MAX)", nullable: true),
                    AppUserId = table.Column<long>(type: "bigint", nullable: false),
                    FirstName = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LastName = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LanguageCode = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    ChatId = table.Column<long>(type: "bigint", nullable: false),
                    TypedCommand = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    ReturnResponse = table.Column<string>(type: "VARCHAR(MAX)", nullable: true),
                    NeedHuman = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    TalkingWithHuman = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    EmployId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatsUpdates_UpdateId", x => x.UpdateId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                schema: "Common",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrKey = table.Column<string>(type: "VARCHAR(2)", nullable: false),
                    CountryName = table.Column<string>(type: "VARCHAR(70)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries_CountryId", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "PackageTabs",
                schema: "Shipment",
                columns: table => new
                {
                    PackageTabId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageTypeId = table.Column<long>(type: "bigint", nullable: false),
                    MinWeight = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    MaxWeight = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    CreatedUser = table.Column<long>(type: "bigint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<long>(type: "bigint", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageTabs_PackageTabId", x => x.PackageTabId);
                });

            migrationBuilder.CreateTable(
                name: "TaxOrganizations",
                schema: "Common",
                columns: table => new
                {
                    TaxOrganizationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrKey = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    OrgDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxOrganizations_TaxOrganizationId", x => x.TaxOrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Common",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    SaltPswd = table.Column<string>(type: "VARCHAR(MAX)", nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(MAX)", nullable: false),
                    SessionOpen = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    FailedAttempts = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    UserBlocked = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "DATETIME", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_UserId", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_UserId",
                        column: x => x.CreatedUserId,
                        principalSchema: "Common",
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ZipCodes",
                schema: "Common",
                columns: table => new
                {
                    ZipCodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZipCodeVal = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZipCodes_Id", x => x.ZipCodeId);
                });

            migrationBuilder.CreateTable(
                name: "TaxOrganizationTypes",
                schema: "Common",
                columns: table => new
                {
                    TaxOrganizationTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxOrganizationId = table.Column<int>(type: "int", nullable: false),
                    StrKey = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TypeDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxOrganizationTypes_TaxOrganizationTypeId", x => x.TaxOrganizationTypeId);
                    table.ForeignKey(
                        name: "FK_TaxOrganizationTypes_TaxOrganizationId",
                        column: x => x.TaxOrganizationId,
                        principalSchema: "Common",
                        principalTable: "TaxOrganizations",
                        principalColumn: "TaxOrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPswdHistory",
                schema: "Common",
                columns: table => new
                {
                    UserPswdHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    OldPassword = table.Column<string>(type: "VARCHAR(MAX)", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPswdHistory_UserPswdHistoryId", x => x.UserPswdHistoryId);
                    table.ForeignKey(
                        name: "FK_UserPswdHistory_UserId",
                        column: x => x.UserId,
                        principalSchema: "Common",
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                schema: "Sales",
                columns: table => new
                {
                    ClientId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    TaxOrganizationTypeId = table.Column<int>(type: "int", nullable: true),
                    TaxValue = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    Anniversary = table.Column<DateTime>(type: "DATE", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreatedUser = table.Column<long>(type: "bigint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    ModifiedUser = table.Column<long>(type: "bigint", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients_ClientId", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_Clients_TaxOrganizationTypeId",
                        column: x => x.TaxOrganizationTypeId,
                        principalSchema: "Common",
                        principalTable: "TaxOrganizationTypes",
                        principalColumn: "TaxOrganizationTypeId");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "HR",
                columns: table => new
                {
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    LastName = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    TaxOrganizationTypeId = table.Column<int>(type: "int", nullable: true),
                    TaxValue = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    Birthbay = table.Column<DateTime>(type: "DATE", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreatedUser = table.Column<long>(type: "bigint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    ModifiedUser = table.Column<long>(type: "bigint", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "DATETIME", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees_EmployeeId", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Clients_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Common",
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_TaxOrganizationTypeId",
                        column: x => x.TaxOrganizationTypeId,
                        principalSchema: "Common",
                        principalTable: "TaxOrganizationTypes",
                        principalColumn: "TaxOrganizationTypeId");
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddresses",
                schema: "Sales",
                columns: table => new
                {
                    CustomerAddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<long>(type: "bigint", nullable: false),
                    Street = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    OutdoorNumber = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    InteriorNumber = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    Colony = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    ZipCodeId = table.Column<int>(type: "int", nullable: false),
                    References = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainAddress = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    BillingAddress = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedUser = table.Column<long>(type: "bigint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    ModifiedUser = table.Column<long>(type: "bigint", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddresses_CustomerAddressId", x => x.CustomerAddressId);
                    table.ForeignKey(
                        name: "FK_CustomerAddresses_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "Sales",
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerAddresses_ZipCodeId",
                        column: x => x.ZipCodeId,
                        principalSchema: "Common",
                        principalTable: "ZipCodes",
                        principalColumn: "ZipCodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesAddress",
                schema: "HR",
                columns: table => new
                {
                    EmployeeAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    Street = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    OutdoorNumber = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    InteriorNumber = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    Colony = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    ZipCodeId = table.Column<int>(type: "int", nullable: false),
                    References = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainAddress = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedUser = table.Column<long>(type: "bigint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    ModifiedUser = table.Column<long>(type: "bigint", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesAddress_Id", x => x.EmployeeAddressId);
                    table.ForeignKey(
                        name: "FK_EmployeesAddress_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "HR",
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeesAddress_ZipCodeId",
                        column: x => x.ZipCodeId,
                        principalSchema: "Common",
                        principalTable: "ZipCodes",
                        principalColumn: "ZipCodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                schema: "Sales",
                columns: table => new
                {
                    SaleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<long>(type: "bigint", nullable: false),
                    VendorId = table.Column<long>(type: "bigint", nullable: false),
                    OfficeId = table.Column<int>(type: "int", nullable: false),
                    OrderNumber = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    Subtotal = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    Tax = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    CreatedUser = table.Column<long>(type: "bigint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    ModifiedUser = table.Column<long>(type: "bigint", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales_SaleId", x => x.SaleId);
                    table.ForeignKey(
                        name: "FK_Sales_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "Sales",
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_VendorId",
                        column: x => x.VendorId,
                        principalSchema: "HR",
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                schema: "Shipment",
                columns: table => new
                {
                    PackageId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleId = table.Column<long>(type: "bigint", nullable: false),
                    PiceId = table.Column<string>(type: "VARCHAR(21)", nullable: true),
                    TrackNumber = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    PackageTabId = table.Column<int>(type: "int", nullable: false),
                    TrueWeight = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    CreatedUser = table.Column<long>(type: "bigint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    ModifiedUser = table.Column<long>(type: "bigint", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages_PackageId", x => x.PackageId);
                    table.ForeignKey(
                        name: "FK_Package_SaleId",
                        column: x => x.SaleId,
                        principalSchema: "Sales",
                        principalTable: "Sales",
                        principalColumn: "SaleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Packages_PackageTabId",
                        column: x => x.PackageTabId,
                        principalSchema: "Shipment",
                        principalTable: "PackageTabs",
                        principalColumn: "PackageTabId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Countries",
                columns: new[] { "CountryId", "CountryName", "StrKey" },
                values: new object[,]
                {
                    { 1, "NDORRA", "AD" },
                    { 2, "NITED ARAB EMIRATES", "AE" },
                    { 3, "FGHANISTAN", "AF" },
                    { 4, "NTIGUA AND BARBUDA", "AG" },
                    { 5, "NGUILLA", "AI" },
                    { 6, "LBANIA", "AL" },
                    { 7, "RMENIA", "AM" },
                    { 8, "NGOLA", "AO" },
                    { 9, "NTARCTICA", "AQ" },
                    { 10, "RGENTINA", "AR" },
                    { 11, "MERICAN SAMOA", "AS" },
                    { 12, "USTRIA", "AT" },
                    { 13, "USTRALIA", "AU" },
                    { 14, "RUBA", "AW" },
                    { 15, "LAND ISLANDS", "AX" },
                    { 16, "ZERBAIJAN", "AZ" },
                    { 17, "OSNIA AND HERZEGOVINA", "BA" },
                    { 18, "ARBADOS", "BB" },
                    { 19, "ANGLADESH", "BD" },
                    { 20, "ELGIUM", "BE" },
                    { 21, "URKINA FASO", "BF" },
                    { 22, "ULGARIA", "BG" },
                    { 23, "AHRAIN", "BH" },
                    { 24, "URUNDI", "BI" },
                    { 25, "ENIN", "BJ" },
                    { 26, "AINT BARTHÉLEMY", "BL" },
                    { 27, "ERMUDA", "BM" },
                    { 28, "RUNEI DARUSSALAM", "BN" },
                    { 29, "OLIVIA (PLURINATIONAL STATE OF)", "BO" },
                    { 30, "ONAIRE, SINT EUSTATIUS AND SABA", "BQ" },
                    { 31, "RAZIL", "BR" },
                    { 32, "AHAMAS", "BS" },
                    { 33, "HUTAN", "BT" },
                    { 34, "OUVET ISLAND", "BV" },
                    { 35, "OTSWANA", "BW" },
                    { 36, "ELARUS", "BY" },
                    { 37, "ELIZE", "BZ" },
                    { 38, "ANADA", "CA" },
                    { 39, "OCOS (KEELING) ISLANDS", "CC" },
                    { 40, "ONGO, DEMOCRATIC REPUBLIC OF THE", "CD" },
                    { 41, "ENTRAL AFRICAN REPUBLIC", "CF" },
                    { 42, "ONGO", "CG" }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Countries",
                columns: new[] { "CountryId", "CountryName", "StrKey" },
                values: new object[,]
                {
                    { 43, "WITZERLAND", "CH" },
                    { 44, "ÔTE D''IVOIRE", "CI" },
                    { 45, "COOK ISLANDS", "CK" },
                    { 46, "CHILE", "CL" },
                    { 47, "CAMEROON", "CM" },
                    { 48, "CHINA", "CN" },
                    { 49, "COLOMBIA", "CO" },
                    { 50, "COSTA RICA", "CR" },
                    { 51, "CUBA", "CU" },
                    { 52, "CABO VERDE", "CV" },
                    { 53, "CURAÇAO", "CW" },
                    { 54, "CHRISTMAS ISLAND", "CX" },
                    { 55, "CYPRUS", "CY" },
                    { 56, "CZECHIA", "CZ" },
                    { 57, "GERMANY", "DE" },
                    { 58, "DJIBOUTI", "DJ" },
                    { 59, "DENMARK", "DK" },
                    { 60, "DOMINICA", "DM" },
                    { 61, "DOMINICAN REPUBLIC", "DO" },
                    { 62, "ALGERIA", "DZ" },
                    { 63, "ECUADOR", "EC" },
                    { 64, "ESTONIA", "EE" },
                    { 65, "EGYPT", "EG" },
                    { 66, "WESTERN SAHARA", "EH" },
                    { 67, "ERITREA", "ER" },
                    { 68, "SPAIN", "ES" },
                    { 69, "ETHIOPIA", "ET" },
                    { 70, "FINLAND", "FI" },
                    { 71, "FIJI", "FJ" },
                    { 72, "FALKLAND ISLANDS (MALVINAS)", "FK" },
                    { 73, "MICRONESIA (FEDERATED STATES OF)", "FM" },
                    { 74, "FAROE ISLANDS", "FO" },
                    { 75, "FRANCE", "FR" },
                    { 76, "GABON", "GA" },
                    { 77, "UNITED KINGDOM OF GREAT BRITAIN AND NORTHERN IRELAND", "GB" },
                    { 78, "GRENADA", "GD" },
                    { 79, "GEORGIA", "GE" },
                    { 80, "FRENCH GUIANA", "GF" },
                    { 81, "GUERNSEY", "GG" },
                    { 82, "GHANA", "GH" },
                    { 83, "GIBRALTAR", "GI" },
                    { 84, "GREENLAND", "GL" }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Countries",
                columns: new[] { "CountryId", "CountryName", "StrKey" },
                values: new object[,]
                {
                    { 85, "GAMBIA", "GM" },
                    { 86, "GUINEA", "GN" },
                    { 87, "GUADELOUPE", "GP" },
                    { 88, "EQUATORIAL GUINEA", "GQ" },
                    { 89, "GREECE", "GR" },
                    { 90, "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS", "GS" },
                    { 91, "GUATEMALA", "GT" },
                    { 92, "GUAM", "GU" },
                    { 93, "GUINEA-BISSAU", "GW" },
                    { 94, "GUYANA", "GY" },
                    { 95, "HONG KONG", "HK" },
                    { 96, "HEARD ISLAND AND MCDONALD ISLANDS", "HM" },
                    { 97, "HONDURAS", "HN" },
                    { 98, "CROATIA", "HR" },
                    { 99, "HAITI", "HT" },
                    { 100, "HUNGARY", "HU" },
                    { 101, "INDONESIA", "ID" },
                    { 102, "IRELAND", "IE" },
                    { 103, "ISRAEL", "IL" },
                    { 104, "ISLE OF MAN", "IM" },
                    { 105, "INDIA", "IN" },
                    { 106, "BRITISH INDIAN OCEAN TERRITORY", "IO" },
                    { 107, "IRAQ", "IQ" },
                    { 108, "IRAN (ISLAMIC REPUBLIC OF)", "IR" },
                    { 109, "ICELAND", "IS" },
                    { 110, "ITALY", "IT" },
                    { 111, "JERSEY", "JE" },
                    { 112, "JAMAICA", "JM" },
                    { 113, "JORDAN", "JO" },
                    { 114, "JAPAN", "JP" },
                    { 115, "KENYA", "KE" },
                    { 116, "KYRGYZSTAN", "KG" },
                    { 117, "CAMBODIA", "KH" },
                    { 118, "KIRIBATI", "KI" },
                    { 119, "COMOROS", "KM" },
                    { 120, "SAINT KITTS AND NEVIS", "KN" },
                    { 121, "KOREA (DEMOCRATIC PEOPLE''S REPUBLIC OF)", "KP" },
                    { 122, "KOREA, REPUBLIC OF", "KR" },
                    { 123, "KUWAIT", "KW" },
                    { 124, "CAYMAN ISLANDS", "KY" },
                    { 125, "KAZAKHSTAN", "KZ" },
                    { 126, "LAO PEOPLE''S DEMOCRATIC REPUBLIC", "LA" }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Countries",
                columns: new[] { "CountryId", "CountryName", "StrKey" },
                values: new object[,]
                {
                    { 127, "LEBANON", "LB" },
                    { 128, "SAINT LUCIA", "LC" },
                    { 129, "LIECHTENSTEIN", "LI" },
                    { 130, "SRI LANKA", "LK" },
                    { 131, "LIBERIA", "LR" },
                    { 132, "LESOTHO", "LS" },
                    { 133, "LITHUANIA", "LT" },
                    { 134, "LUXEMBOURG", "LU" },
                    { 135, "LATVIA", "LV" },
                    { 136, "LIBYA", "LY" },
                    { 137, "MOROCCO", "MA" },
                    { 138, "MONACO", "MC" },
                    { 139, "MOLDOVA, REPUBLIC OF", "MD" },
                    { 140, "MONTENEGRO", "ME" },
                    { 141, "SAINT MARTIN (FRENCH PART)", "MF" },
                    { 142, "MADAGASCAR", "MG" },
                    { 143, "MARSHALL ISLANDS", "MH" },
                    { 144, "NORTH MACEDONIA", "MK" },
                    { 145, "MALI", "ML" },
                    { 146, "MYANMAR", "MM" },
                    { 147, "MONGOLIA", "MN" },
                    { 148, "MACAO", "MO" },
                    { 149, "NORTHERN MARIANA ISLANDS", "MP" },
                    { 150, "MARTINIQUE", "MQ" },
                    { 151, "MAURITANIA", "MR" },
                    { 152, "MONTSERRAT", "MS" },
                    { 153, "MALTA", "MT" },
                    { 154, "MAURITIUS", "MU" },
                    { 155, "MALDIVES", "MV" },
                    { 156, "MALAWI", "MW" }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Countries",
                columns: new[] { "CountryId", "CountryName", "IsActive", "StrKey" },
                values: new object[] { 157, "MEXICO", true, "MX" });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Countries",
                columns: new[] { "CountryId", "CountryName", "StrKey" },
                values: new object[,]
                {
                    { 158, "MALAYSIA", "MY" },
                    { 159, "MOZAMBIQUE", "MZ" },
                    { 160, "NAMIBIA", "NA" },
                    { 161, "NEW CALEDONIA", "NC" },
                    { 162, "NIGER", "NE" },
                    { 163, "NORFOLK ISLAND", "NF" },
                    { 164, "NIGERIA", "NG" },
                    { 165, "NICARAGUA", "NI" },
                    { 166, "NETHERLANDS", "NL" },
                    { 167, "NORWAY", "NO" },
                    { 168, "NEPAL", "NP" }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Countries",
                columns: new[] { "CountryId", "CountryName", "StrKey" },
                values: new object[,]
                {
                    { 169, "NAURU", "NR" },
                    { 170, "NIUE", "NU" },
                    { 171, "NEW ZEALAND", "NZ" },
                    { 172, "OMAN", "OM" },
                    { 173, "PANAMA", "PA" },
                    { 174, "PERU", "PE" },
                    { 175, "FRENCH POLYNESIA", "PF" },
                    { 176, "PAPUA NEW GUINEA", "PG" },
                    { 177, "PHILIPPINES", "PH" },
                    { 178, "PAKISTAN", "PK" },
                    { 179, "POLAND", "PL" },
                    { 180, "SAINT PIERRE AND MIQUELON", "PM" },
                    { 181, "PITCAIRN", "PN" },
                    { 182, "PUERTO RICO", "PR" },
                    { 183, "PALESTINE, STATE OF", "PS" },
                    { 184, "PORTUGAL", "PT" },
                    { 185, "PALAU", "PW" },
                    { 186, "PARAGUAY", "PY" },
                    { 187, "QATAR", "QA" },
                    { 188, "RÉUNION", "RE" },
                    { 189, "ROMANIA", "RO" },
                    { 190, "SERBIA", "RS" },
                    { 191, "RUSSIAN FEDERATION", "RU" },
                    { 192, "RWANDA", "RW" },
                    { 193, "SAUDI ARABIA", "SA" },
                    { 194, "SOLOMON ISLANDS", "SB" },
                    { 195, "SEYCHELLES", "SC" },
                    { 196, "SUDAN", "SD" },
                    { 197, "SWEDEN", "SE" },
                    { 198, "SINGAPORE", "SG" },
                    { 199, "SAINT HELENA, ASCENSION AND TRISTAN DA CUNHA", "SH" },
                    { 200, "SLOVENIA", "SI" },
                    { 201, "SVALBARD AND JAN MAYEN", "SJ" },
                    { 202, "SLOVAKIA", "SK" },
                    { 203, "SIERRA LEONE", "SL" },
                    { 204, "SAN MARINO", "SM" },
                    { 205, "SENEGAL", "SN" },
                    { 206, "SOMALIA", "SO" },
                    { 207, "SURINAME", "SR" },
                    { 208, "SOUTH SUDAN", "SS" },
                    { 209, "SAO TOME AND PRINCIPE", "ST" },
                    { 210, "EL SALVADOR", "SV" }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Countries",
                columns: new[] { "CountryId", "CountryName", "StrKey" },
                values: new object[,]
                {
                    { 211, "SINT MAARTEN (DUTCH PART)", "SX" },
                    { 212, "SYRIAN ARAB REPUBLIC", "SY" },
                    { 213, "ESWATINI", "SZ" },
                    { 214, "TURKS AND CAICOS ISLANDS", "TC" },
                    { 215, "CHAD", "TD" },
                    { 216, "FRENCH SOUTHERN TERRITORIES", "TF" },
                    { 217, "TOGO", "TG" },
                    { 218, "THAILAND", "TH" },
                    { 219, "TAJIKISTAN", "TJ" },
                    { 220, "TOKELAU", "TK" },
                    { 221, "TIMOR-LESTE", "TL" },
                    { 222, "TURKMENISTAN", "TM" },
                    { 223, "TUNISIA", "TN" },
                    { 224, "TONGA", "TO" },
                    { 225, "TURKEY", "TR" },
                    { 226, "TRINIDAD AND TOBAGO", "TT" },
                    { 227, "TUVALU", "TV" },
                    { 228, "TAIWAN, PROVINCE OF CHINA", "TW" },
                    { 229, "TANZANIA, UNITED REPUBLIC OF", "TZ" },
                    { 230, "UKRAINE", "UA" },
                    { 231, "UGANDA", "UG" },
                    { 232, "UNITED STATES MINOR OUTLYING ISLANDS", "UM" }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Countries",
                columns: new[] { "CountryId", "CountryName", "IsActive", "StrKey" },
                values: new object[] { 233, "UNITED STATES OF AMERICA", true, "US" });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Countries",
                columns: new[] { "CountryId", "CountryName", "StrKey" },
                values: new object[,]
                {
                    { 234, "URUGUAY", "UY" },
                    { 235, "UZBEKISTAN", "UZ" },
                    { 236, "HOLY SEE", "VA" },
                    { 237, "SAINT VINCENT AND THE GRENADINES", "VC" },
                    { 238, "VENEZUELA (BOLIVARIAN REPUBLIC OF)", "VE" },
                    { 239, "VIRGIN ISLANDS (BRITISH)", "VG" },
                    { 240, "VIRGIN ISLANDS (U.S.)", "VI" },
                    { 241, "VIET NAM", "VN" },
                    { 242, "VANUATU", "VU" },
                    { 243, "WALLIS AND FUTUNA", "WF" },
                    { 244, "SAMOA", "WS" },
                    { 245, "YEMEN", "YE" },
                    { 246, "MAYOTTE", "YT" },
                    { 247, "SOUTH AFRICA", "ZA" },
                    { 248, "ZAMBIA", "ZM" },
                    { 249, "ZIMBABWE", "ZW" }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "TaxOrganizations",
                columns: new[] { "TaxOrganizationId", "CountryId", "OrgDescription", "StrKey" },
                values: new object[,]
                {
                    { 1, 157, "Servicio de Administración Tributaria", "SAT" },
                    { 2, 233, "Internal Revenue Service", "IRS" }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Users",
                columns: new[] { "UserId", "CreatedUserId", "CreationDate", "Password", "SaltPswd", "UserName" },
                values: new object[] { 1L, null, null, "bbborderbox", "", "superadmin" });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Users",
                columns: new[] { "UserId", "CreatedUserId", "CreationDate", "Password", "SaltPswd", "UserName" },
                values: new object[] { 2L, null, null, "bbborderbox", "", "testadmin" });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_TaxOrganizationTypeId",
                schema: "Sales",
                table: "Clients",
                column: "TaxOrganizationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_StrKey",
                schema: "Common",
                table: "Countries",
                column: "StrKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_ClientId",
                schema: "Sales",
                table: "CustomerAddresses",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_ZipCodeId",
                schema: "Sales",
                table: "CustomerAddresses",
                column: "ZipCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CountryId",
                schema: "HR",
                table: "Employees",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TaxOrganizationTypeId",
                schema: "HR",
                table: "Employees",
                column: "TaxOrganizationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesAddress_EmployeeId",
                schema: "HR",
                table: "EmployeesAddress",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesAddress_ZipCodeId",
                schema: "HR",
                table: "EmployeesAddress",
                column: "ZipCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_PackageTabId",
                schema: "Shipment",
                table: "Packages",
                column: "PackageTabId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_SaleId",
                schema: "Shipment",
                table: "Packages",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ClientId",
                schema: "Sales",
                table: "Sales",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_VendorId",
                schema: "Sales",
                table: "Sales",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxOrganizations_StrKey",
                schema: "Common",
                table: "TaxOrganizations",
                column: "StrKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaxOrganizationTypes_StrKey",
                schema: "Common",
                table: "TaxOrganizationTypes",
                column: "StrKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaxOrganizationTypes_TaxOrganizationId",
                schema: "Common",
                table: "TaxOrganizationTypes",
                column: "TaxOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPswdHistory_UserId",
                schema: "Common",
                table: "UserPswdHistory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreatedUserId",
                schema: "Common",
                table: "Users",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                schema: "Common",
                table: "Users",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ZipCodes_ZipCodeVal",
                schema: "Common",
                table: "ZipCodes",
                column: "ZipCodeVal",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatsUpdates",
                schema: "Telegram");

            migrationBuilder.DropTable(
                name: "CustomerAddresses",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "EmployeesAddress",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Packages",
                schema: "Shipment");

            migrationBuilder.DropTable(
                name: "UserPswdHistory",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "ZipCodes",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Sales",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "PackageTabs",
                schema: "Shipment");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Clients",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Countries",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "TaxOrganizationTypes",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "TaxOrganizations",
                schema: "Common");
        }
    }
}
