using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleExample.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "Address", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "9628 Smith Drives", "Germany", "Waters - Marvin" },
                    { 73, "371 Ferry Passage", "Anguilla", "Luettgen - West" },
                    { 72, "11241 Rosalyn Forge", "Saint Pierre and Miquelon", "Gottlieb, Becker and Hartmann" },
                    { 71, "8106 Major Springs", "Belarus", "Kirlin - Erdman" },
                    { 70, "82292 Bartell Harbors", "Sierra Leone", "Kutch, Stark and Crooks" },
                    { 69, "0595 Predovic Tunnel", "Burkina Faso", "Heidenreich Group" },
                    { 68, "03841 Vivian Hollow", "Cape Verde", "Prohaska, Hahn and Mosciski" },
                    { 67, "71633 Krajcik Garden", "Mauritania", "Cormier Group" },
                    { 66, "452 Morgan Plaza", "Ghana", "Kris - Leannon" },
                    { 65, "604 Simonis Plains", "Mayotte", "Goyette, King and Ortiz" },
                    { 64, "8158 Mayer Trace", "Poland", "Wisozk Inc" },
                    { 63, "80763 Suzanne Union", "Burundi", "West - Schamberger" },
                    { 62, "42071 Oliver Ramp", "Ghana", "Hane - Carter" },
                    { 61, "050 Kennedi Light", "Malawi", "Rippin, Ritchie and Walsh" },
                    { 60, "5694 Dickens Branch", "Kazakhstan", "Boyle - Haley" },
                    { 59, "6536 Littel Squares", "Singapore", "Ratke - Casper" },
                    { 58, "3628 Howell Junction", "Uzbekistan", "Osinski and Sons" },
                    { 57, "9808 Sauer Ridge", "Turks and Caicos Islands", "McDermott and Sons" },
                    { 56, "38961 Powlowski Highway", "British Indian Ocean Territory (Chagos Archipelago)", "Altenwerth, Larkin and Huels" },
                    { 55, "593 Toy Drive", "Cuba", "Shanahan - Greenholt" },
                    { 54, "03980 Glenna Stream", "Armenia", "Spinka, Windler and Hodkiewicz" },
                    { 53, "17145 Sim Stream", "Sudan", "Bernier - Metz" },
                    { 74, "0787 Mills Flat", "Singapore", "Reilly Group" },
                    { 52, "277 Daniel Harbor", "Hong Kong", "McClure and Sons" },
                    { 75, "82327 Walter Way", "Uganda", "Williamson and Sons" },
                    { 77, "83272 Mayer View", "Argentina", "Ullrich, Reilly and Rutherford" },
                    { 98, "1307 Daugherty Dale", "Canada", "Schumm, Runolfsdottir and Nienow" },
                    { 97, "6360 Whitney Drive", "Iceland", "Ruecker - Johnston" },
                    { 96, "782 Ryder Streets", "Wallis and Futuna", "Predovic - Walsh" },
                    { 95, "578 Jada Tunnel", "Poland", "Ortiz - Connelly" },
                    { 94, "9888 Warren Throughway", "Congo", "Baumbach, Kertzmann and Bergstrom" },
                    { 93, "5577 Daniel Ridge", "Bermuda", "Hagenes, Balistreri and Schaden" },
                    { 92, "6033 Roberts Summit", "Japan", "Moen - Herzog" },
                    { 91, "65810 Dameon Extension", "Taiwan", "Hermann - Denesik" },
                    { 90, "3647 Medhurst Lodge", "United States of America", "Yost - Wiegand" },
                    { 89, "7023 Bechtelar Roads", "Chad", "Jast and Sons" },
                    { 88, "94033 Lang Ramp", "San Marino", "Blick Group" },
                    { 87, "3444 Welch Ville", "Oman", "Lubowitz and Sons" },
                    { 86, "088 Jefferey Inlet", "Anguilla", "Cole - Greenholt" },
                    { 85, "08169 Glover Key", "Gabon", "Shields, Fritsch and Hauck" },
                    { 84, "81665 Leta Groves", "Philippines", "Gerlach - Upton" },
                    { 83, "6877 Stehr Estates", "Djibouti", "Langosh - Johns" }
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "Address", "Country", "Name" },
                values: new object[,]
                {
                    { 82, "21996 Miracle Shoals", "Lebanon", "Kunze, Crona and Willms" },
                    { 81, "406 Maye Underpass", "Egypt", "Johns and Sons" },
                    { 80, "7664 Bauch Creek", "Niger", "Fritsch - Robel" },
                    { 79, "01460 Doyle Corner", "Cayman Islands", "Cole - Smitham" },
                    { 78, "302 Johns Ports", "Kuwait", "Kub LLC" },
                    { 76, "1215 Catalina Wall", "Pitcairn Islands", "Marks LLC" },
                    { 51, "2717 Runte Curve", "Christmas Island", "Bosco, Bartell and Cormier" },
                    { 50, "57467 Marvin Crescent", "Cuba", "Bruen - McKenzie" },
                    { 49, "2552 Victor Trafficway", "Uzbekistan", "Herman LLC" },
                    { 22, "36883 Jody Mount", "Christmas Island", "Price LLC" },
                    { 21, "50497 Osinski Crescent", "Bulgaria", "Yost, Kuphal and Mraz" },
                    { 20, "1049 Okuneva Ranch", "Comoros", "Oberbrunner, O'Keefe and Hane" },
                    { 19, "03752 Abagail Forge", "Chile", "Stokes Inc" },
                    { 18, "1623 Savanah Dale", "Republic of Korea", "Crona, Harris and Kilback" },
                    { 17, "517 Lemke Harbor", "Uganda", "Cremin Group" },
                    { 16, "710 Linnea Fields", "Bahrain", "Herzog - Kihn" },
                    { 15, "39829 Jayne Ports", "Chad", "Watsica and Sons" },
                    { 14, "68088 Ezekiel Crossing", "Singapore", "Macejkovic and Sons" },
                    { 13, "2923 Megane Corner", "Slovenia", "O'Conner - Schuster" },
                    { 12, "11115 Reichel Spur", "France", "Mayer, Moen and Kessler" },
                    { 11, "736 Dooley Bridge", "Belarus", "O'Connell Inc" },
                    { 10, "965 Deborah Brooks", "Vietnam", "Pouros - Dicki" },
                    { 9, "525 Pat Burgs", "Bolivia", "Oberbrunner LLC" },
                    { 8, "788 Monserrate Branch", "Lao People's Democratic Republic", "Hermann Inc" },
                    { 7, "671 Rau Mill", "Iraq", "Ullrich, Mueller and Schmidt" },
                    { 6, "21084 Kamryn Haven", "Saudi Arabia", "Rohan - Treutel" },
                    { 5, "7139 Eladio Manors", "Samoa", "Jacobi, Bins and Gottlieb" },
                    { 4, "57561 Jo Loaf", "Cocos (Keeling) Islands", "Haag, Skiles and Weimann" },
                    { 3, "1593 Volkman Orchard", "New Zealand", "Fay, Little and Predovic" },
                    { 2, "182 Stamm Dam", "Canada", "Hand - Simonis" },
                    { 23, "109 Alfred Street", "Maldives", "Weimann LLC" },
                    { 24, "64328 Ullrich Mount", "Afghanistan", "Larkin Inc" },
                    { 25, "1620 Doyle Meadow", "Brazil", "Konopelski - Cummerata" },
                    { 26, "9405 Jennifer Estates", "El Salvador", "Boyle - Dach" },
                    { 48, "030 Rudy Gateway", "Congo", "Bartell, Davis and Beer" },
                    { 47, "771 West Stravenue", "Chile", "Kautzer LLC" },
                    { 46, "029 Reichel Lake", "Gabon", "Reilly, Rau and Gutmann" },
                    { 45, "1565 Aufderhar Stravenue", "Guernsey", "Bernhard, Bayer and Daugherty" },
                    { 44, "08551 Loy Brook", "India", "Swaniawski Group" },
                    { 43, "7393 Leola Street", "San Marino", "Hayes - Orn" },
                    { 42, "3239 Medhurst Estate", "Colombia", "Lebsack, Barton and Gutkowski" },
                    { 41, "7128 Leuschke Dale", "Venezuela", "Jacobs and Sons" }
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "Address", "Country", "Name" },
                values: new object[,]
                {
                    { 40, "88272 Stiedemann Plain", "Honduras", "Luettgen and Sons" },
                    { 39, "7177 Bogisich Extensions", "Russian Federation", "Krajcik Group" },
                    { 99, "5645 Ellis Dam", "Senegal", "Wolf, Wolf and Kemmer" },
                    { 38, "85650 Mueller Rue", "Brunei Darussalam", "Reichel, Schamberger and Koch" },
                    { 36, "808 Lonzo Fort", "Algeria", "Wiza - Schiller" },
                    { 35, "98633 Helen Shores", "Solomon Islands", "Rippin, Nolan and Johnson" },
                    { 34, "418 Ferry Mountains", "Kenya", "Hayes - Wyman" },
                    { 33, "991 Block Burg", "Malta", "Schroeder Inc" },
                    { 32, "9545 Addie Turnpike", "China", "Sanford - Kovacek" },
                    { 31, "55800 Willie Mills", "Somalia", "Abshire - Moore" },
                    { 30, "69937 Farrell Prairie", "Isle of Man", "Lehner - Lakin" },
                    { 29, "6084 Kiehn Wall", "Germany", "Johnson, Beahan and Corkery" },
                    { 28, "45971 Jamir Mews", "Indonesia", "Leannon and Sons" },
                    { 27, "5623 Schmidt Valleys", "Martinique", "Smith, Langosh and Lebsack" },
                    { 37, "965 Hauck Forks", "Venezuela", "Fadel, Abernathy and Rutherford" },
                    { 100, "263 Devon Corner", "Micronesia", "Beahan, Connelly and Bartoletti" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "Name", "Position" },
                values: new object[,]
                {
                    { 54, 1, new DateTime(1972, 5, 2, 2, 51, 14, 647, DateTimeKind.Local).AddTicks(4504), "Melody Jenkins", "Greenfelder - O'Kon" },
                    { 71, 61, new DateTime(1958, 4, 13, 0, 11, 0, 596, DateTimeKind.Local).AddTicks(9302), "Boyd Batz", "McDermott Inc" },
                    { 93, 61, new DateTime(1989, 10, 31, 2, 20, 33, 887, DateTimeKind.Local).AddTicks(5740), "Patricia Beahan", "Rau and Sons" },
                    { 158, 61, new DateTime(1955, 1, 22, 15, 38, 6, 202, DateTimeKind.Local).AddTicks(7940), "Lamar Fisher", "McClure, Kohler and Ullrich" },
                    { 161, 61, new DateTime(1962, 10, 17, 15, 29, 51, 380, DateTimeKind.Local).AddTicks(5012), "Roderick Nikolaus", "Auer - Rogahn" },
                    { 86, 62, new DateTime(1989, 12, 10, 15, 55, 5, 234, DateTimeKind.Local).AddTicks(2983), "Wilson Harris", "Rosenbaum, Feil and Grimes" },
                    { 151, 63, new DateTime(1963, 6, 27, 20, 52, 14, 157, DateTimeKind.Local).AddTicks(5994), "Otis Will", "Steuber and Sons" },
                    { 165, 63, new DateTime(1986, 7, 7, 4, 9, 37, 215, DateTimeKind.Local).AddTicks(8776), "Shirley Hammes", "Steuber - Towne" },
                    { 131, 64, new DateTime(1968, 9, 12, 17, 36, 48, 994, DateTimeKind.Local).AddTicks(9591), "Doyle Hansen", "Parker, Koelpin and Koch" },
                    { 3, 65, new DateTime(1981, 3, 1, 21, 4, 13, 913, DateTimeKind.Local).AddTicks(3539), "John Carroll", "Boyer Group" },
                    { 64, 65, new DateTime(1954, 6, 18, 18, 57, 42, 667, DateTimeKind.Local).AddTicks(371), "Drew O'Kon", "Berge - Jerde" },
                    { 157, 66, new DateTime(1953, 2, 26, 19, 45, 41, 635, DateTimeKind.Local).AddTicks(7207), "Camille Hilpert", "Ferry, Kohler and Boyer" },
                    { 4, 67, new DateTime(1998, 9, 28, 15, 14, 2, 47, DateTimeKind.Local).AddTicks(7457), "Jeannette Nitzsche", "Gusikowski LLC" },
                    { 57, 67, new DateTime(1972, 1, 1, 3, 43, 26, 743, DateTimeKind.Local).AddTicks(6212), "Terence Satterfield", "Grant, Wisoky and Steuber" },
                    { 96, 67, new DateTime(1954, 6, 23, 14, 28, 58, 802, DateTimeKind.Local).AddTicks(2841), "Roman Bashirian", "Goldner LLC" },
                    { 174, 67, new DateTime(1969, 11, 27, 13, 32, 59, 65, DateTimeKind.Local).AddTicks(1170), "Della Hintz", "Bosco - Lesch" },
                    { 21, 68, new DateTime(1982, 10, 23, 2, 39, 24, 246, DateTimeKind.Local).AddTicks(8911), "Hugo Boyle", "Nikolaus - Schimmel" },
                    { 115, 68, new DateTime(1988, 12, 23, 17, 37, 7, 380, DateTimeKind.Local).AddTicks(3630), "Harold Walker", "Walsh - Herzog" },
                    { 163, 68, new DateTime(1964, 11, 9, 21, 20, 5, 900, DateTimeKind.Local).AddTicks(9337), "Lucille Rowe", "Schowalter, Rogahn and Feil" },
                    { 169, 68, new DateTime(1993, 5, 31, 2, 25, 59, 297, DateTimeKind.Local).AddTicks(6496), "Phil Larson", "Boehm, McKenzie and Wilkinson" },
                    { 159, 69, new DateTime(1981, 5, 28, 15, 38, 31, 132, DateTimeKind.Local).AddTicks(2254), "Salvatore Smitham", "Rau, Keebler and Beier" },
                    { 84, 70, new DateTime(1965, 12, 22, 13, 25, 45, 623, DateTimeKind.Local).AddTicks(5599), "Pam Funk", "Shanahan Group" },
                    { 69, 61, new DateTime(2000, 10, 11, 23, 42, 21, 417, DateTimeKind.Local).AddTicks(6539), "Edwin McKenzie", "Gutmann, Koss and Hirthe" },
                    { 199, 71, new DateTime(1986, 3, 27, 12, 57, 26, 296, DateTimeKind.Local).AddTicks(3813), "Ignacio Gulgowski", "Corkery, Schroeder and Ward" },
                    { 47, 61, new DateTime(1961, 3, 9, 3, 53, 7, 757, DateTimeKind.Local).AddTicks(5779), "Antoinette Grant", "Cruickshank Group" },
                    { 187, 60, new DateTime(1986, 4, 28, 16, 17, 55, 790, DateTimeKind.Local).AddTicks(4656), "Horace Runolfsson", "Predovic, Gaylord and Steuber" },
                    { 17, 51, new DateTime(1968, 6, 11, 13, 25, 37, 620, DateTimeKind.Local).AddTicks(7208), "Greg Huel", "Doyle LLC" },
                    { 11, 52, new DateTime(1971, 11, 29, 19, 24, 52, 995, DateTimeKind.Local).AddTicks(8976), "Denise Schultz", "Tremblay - Hills" },
                    { 29, 52, new DateTime(1970, 6, 1, 23, 42, 16, 6, DateTimeKind.Local).AddTicks(8169), "Hugo Cruickshank", "Frami, Kovacek and Lakin" },
                    { 60, 52, new DateTime(1978, 8, 31, 17, 16, 29, 309, DateTimeKind.Local).AddTicks(163), "Stewart Spinka", "McKenzie and Sons" },
                    { 24, 53, new DateTime(1980, 1, 15, 0, 36, 14, 677, DateTimeKind.Local).AddTicks(4400), "Shaun Rogahn", "Luettgen Group" },
                    { 44, 53, new DateTime(1997, 8, 25, 16, 28, 24, 217, DateTimeKind.Local).AddTicks(3830), "Claire Stanton", "Aufderhar - Daugherty" },
                    { 88, 53, new DateTime(1954, 5, 22, 4, 16, 48, 163, DateTimeKind.Local).AddTicks(584), "Josefina Dibbert", "Lemke - Feeney" },
                    { 146, 53, new DateTime(1998, 4, 15, 5, 57, 44, 89, DateTimeKind.Local).AddTicks(8899), "Karla Quitzon", "Greenholt and Sons" },
                    { 150, 53, new DateTime(1968, 2, 2, 18, 56, 26, 578, DateTimeKind.Local).AddTicks(1350), "Mona Friesen", "Adams Group" },
                    { 148, 54, new DateTime(1970, 7, 25, 11, 39, 6, 963, DateTimeKind.Local).AddTicks(1375), "Amber Lehner", "Daniel Inc" },
                    { 194, 54, new DateTime(1965, 9, 16, 17, 31, 24, 840, DateTimeKind.Local).AddTicks(7989), "Pete Cruickshank", "Murphy LLC" },
                    { 10, 55, new DateTime(1970, 1, 4, 14, 12, 7, 563, DateTimeKind.Local).AddTicks(4442), "Blanche Oberbrunner", "Rohan - Sipes" },
                    { 15, 55, new DateTime(1957, 8, 13, 6, 19, 37, 465, DateTimeKind.Local).AddTicks(9026), "Angel Johnson", "Zboncak - Nolan" },
                    { 58, 56, new DateTime(1984, 7, 15, 3, 46, 40, 378, DateTimeKind.Local).AddTicks(1528), "Earl Murray", "Bernier and Sons" },
                    { 80, 57, new DateTime(1979, 1, 24, 16, 27, 14, 17, DateTimeKind.Local).AddTicks(2482), "Brandi Gulgowski", "Luettgen, Stracke and Bechtelar" },
                    { 147, 57, new DateTime(1980, 9, 3, 0, 18, 20, 829, DateTimeKind.Local).AddTicks(882), "Joseph Heidenreich", "Von, Muller and Rice" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "Name", "Position" },
                values: new object[,]
                {
                    { 134, 58, new DateTime(1966, 12, 27, 12, 18, 20, 395, DateTimeKind.Local).AddTicks(5289), "Leland Stiedemann", "Shields Inc" },
                    { 180, 58, new DateTime(1982, 12, 11, 5, 35, 6, 468, DateTimeKind.Local).AddTicks(441), "Sandra Glover", "Swift - Gottlieb" },
                    { 67, 59, new DateTime(1986, 2, 19, 13, 58, 3, 630, DateTimeKind.Local).AddTicks(2515), "Alfred Labadie", "Brakus Inc" },
                    { 140, 59, new DateTime(1982, 2, 25, 23, 22, 33, 860, DateTimeKind.Local).AddTicks(4396), "Elaine Marquardt", "McLaughlin, Grant and Jenkins" },
                    { 133, 60, new DateTime(1990, 1, 29, 14, 14, 57, 465, DateTimeKind.Local).AddTicks(9143), "Bryant Ankunding", "Greenfelder - Hermiston" },
                    { 33, 61, new DateTime(1957, 8, 16, 19, 13, 46, 805, DateTimeKind.Local).AddTicks(5452), "Antonia Russel", "Nitzsche Group" },
                    { 79, 49, new DateTime(1990, 8, 1, 2, 30, 5, 351, DateTimeKind.Local).AddTicks(9873), "Ollie Koelpin", "Gerlach Inc" },
                    { 18, 72, new DateTime(1985, 10, 1, 2, 38, 49, 327, DateTimeKind.Local).AddTicks(4837), "Damon Predovic", "Hoppe - Muller" },
                    { 145, 72, new DateTime(1984, 10, 14, 11, 41, 28, 813, DateTimeKind.Local).AddTicks(9944), "Johnathan Upton", "Smith, Roberts and Goyette" },
                    { 77, 88, new DateTime(1956, 3, 17, 1, 3, 29, 424, DateTimeKind.Local).AddTicks(3245), "Roderick Botsford", "Stroman, Pfeffer and Cummings" },
                    { 176, 88, new DateTime(1991, 3, 23, 13, 29, 46, 707, DateTimeKind.Local).AddTicks(9322), "Ralph Luettgen", "Mohr, Daniel and Effertz" },
                    { 196, 88, new DateTime(1993, 1, 16, 9, 56, 2, 432, DateTimeKind.Local).AddTicks(3949), "Betsy Satterfield", "Turner - Kilback" },
                    { 126, 89, new DateTime(1990, 10, 18, 14, 55, 25, 748, DateTimeKind.Local).AddTicks(9157), "Clifford Lind", "Christiansen LLC" },
                    { 186, 89, new DateTime(1972, 6, 18, 1, 33, 16, 801, DateTimeKind.Local).AddTicks(6146), "Winifred Mitchell", "Boehm - Harber" },
                    { 5, 91, new DateTime(1994, 5, 24, 1, 2, 32, 394, DateTimeKind.Local).AddTicks(2580), "Marco Johns", "Kassulke - Hudson" },
                    { 23, 91, new DateTime(2002, 3, 16, 17, 4, 27, 572, DateTimeKind.Local).AddTicks(8847), "Jackie Kovacek", "Shields - Graham" },
                    { 40, 91, new DateTime(1972, 8, 15, 12, 12, 7, 375, DateTimeKind.Local).AddTicks(8624), "Joanne Kozey", "Daniel, Ziemann and Moen" },
                    { 41, 91, new DateTime(1957, 4, 19, 13, 15, 12, 98, DateTimeKind.Local).AddTicks(4539), "Johnathan Larson", "Ernser, Koepp and Mohr" },
                    { 116, 91, new DateTime(1977, 6, 30, 22, 53, 45, 880, DateTimeKind.Local).AddTicks(6219), "Doreen Tillman", "Wuckert - Raynor" },
                    { 120, 91, new DateTime(1992, 9, 2, 18, 36, 22, 219, DateTimeKind.Local).AddTicks(8195), "Angelina Bergnaum", "Bayer - Berge" },
                    { 52, 92, new DateTime(1962, 5, 12, 23, 43, 39, 967, DateTimeKind.Local).AddTicks(3064), "Marilyn Rogahn", "Jakubowski LLC" },
                    { 135, 92, new DateTime(1968, 6, 19, 10, 28, 56, 23, DateTimeKind.Local).AddTicks(6741), "Marcella Nikolaus", "Friesen and Sons" },
                    { 153, 92, new DateTime(1953, 1, 15, 10, 55, 30, 179, DateTimeKind.Local).AddTicks(7339), "Isabel Towne", "Heidenreich Group" },
                    { 82, 93, new DateTime(1999, 7, 5, 6, 0, 34, 636, DateTimeKind.Local).AddTicks(4208), "Wm Skiles", "Barrows - Hegmann" },
                    { 123, 95, new DateTime(1967, 8, 2, 0, 27, 49, 927, DateTimeKind.Local).AddTicks(5737), "Roland McClure", "Jenkins Group" },
                    { 129, 95, new DateTime(1958, 8, 29, 15, 56, 56, 52, DateTimeKind.Local).AddTicks(6558), "Mandy Mann", "Schuppe - Nolan" },
                    { 87, 96, new DateTime(1966, 3, 1, 5, 10, 46, 753, DateTimeKind.Local).AddTicks(5738), "Eva Rosenbaum", "Collier, Gislason and Harvey" },
                    { 162, 97, new DateTime(1969, 5, 27, 21, 28, 6, 20, DateTimeKind.Local).AddTicks(4296), "Kristina Harber", "Bernhard, Swaniawski and Larkin" },
                    { 102, 98, new DateTime(1957, 12, 14, 7, 36, 16, 281, DateTimeKind.Local).AddTicks(7745), "Eduardo Renner", "Hettinger - Heidenreich" },
                    { 108, 98, new DateTime(1959, 11, 14, 2, 58, 9, 827, DateTimeKind.Local).AddTicks(5220), "Bradford Rath", "Sawayn - Hills" },
                    { 74, 88, new DateTime(1980, 10, 3, 21, 52, 15, 45, DateTimeKind.Local).AddTicks(2409), "Alberto Shields", "Morar - Dietrich" },
                    { 76, 72, new DateTime(1979, 1, 9, 18, 6, 47, 602, DateTimeKind.Local).AddTicks(2654), "Arthur Gutkowski", "Hand - Langosh" },
                    { 35, 88, new DateTime(1952, 3, 20, 7, 48, 7, 669, DateTimeKind.Local).AddTicks(561), "Ted Pollich", "Heidenreich, Lueilwitz and Parker" },
                    { 38, 86, new DateTime(1970, 8, 22, 23, 2, 20, 571, DateTimeKind.Local).AddTicks(3274), "Bryan Considine", "Berge - Hahn" },
                    { 62, 73, new DateTime(1967, 4, 11, 14, 16, 30, 879, DateTimeKind.Local).AddTicks(7126), "Dwight Nicolas", "Hettinger, Kohler and Hermiston" },
                    { 39, 74, new DateTime(1991, 4, 15, 23, 43, 16, 773, DateTimeKind.Local).AddTicks(6532), "Matthew Shields", "Kirlin LLC" },
                    { 65, 74, new DateTime(1997, 11, 7, 11, 36, 48, 549, DateTimeKind.Local).AddTicks(1400), "Oliver Durgan", "Bode and Sons" },
                    { 139, 75, new DateTime(1988, 3, 20, 7, 6, 38, 158, DateTimeKind.Local).AddTicks(6067), "Jon Heathcote", "Prohaska - Buckridge" },
                    { 119, 76, new DateTime(1991, 7, 24, 13, 21, 10, 257, DateTimeKind.Local).AddTicks(5852), "Margaret VonRueden", "Hodkiewicz and Sons" },
                    { 28, 77, new DateTime(1980, 2, 14, 17, 19, 53, 425, DateTimeKind.Local).AddTicks(5559), "Madeline Wolf", "Metz LLC" },
                    { 103, 77, new DateTime(1971, 1, 3, 21, 10, 38, 996, DateTimeKind.Local).AddTicks(8720), "Jacob Larson", "Lang - Simonis" },
                    { 144, 77, new DateTime(1996, 10, 30, 9, 30, 26, 616, DateTimeKind.Local).AddTicks(9132), "Anthony Kuvalis", "Walter, Crona and Bogisich" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "Name", "Position" },
                values: new object[,]
                {
                    { 122, 78, new DateTime(1989, 4, 3, 17, 35, 18, 233, DateTimeKind.Local).AddTicks(4917), "Roman Ziemann", "Koelpin - Kutch" },
                    { 195, 78, new DateTime(1991, 2, 27, 16, 14, 40, 958, DateTimeKind.Local).AddTicks(3785), "Jerald Jerde", "Pouros, Hermann and Becker" },
                    { 61, 79, new DateTime(1974, 3, 30, 6, 42, 54, 614, DateTimeKind.Local).AddTicks(7682), "Jenny Dooley", "Roob Inc" },
                    { 178, 79, new DateTime(1963, 2, 4, 10, 59, 1, 418, DateTimeKind.Local).AddTicks(8964), "Ethel Schmitt", "Ankunding LLC" },
                    { 30, 80, new DateTime(1992, 1, 27, 23, 13, 7, 543, DateTimeKind.Local).AddTicks(665), "Nicholas Torp", "Wisoky, McKenzie and McKenzie" },
                    { 92, 81, new DateTime(1953, 10, 8, 11, 39, 19, 724, DateTimeKind.Local).AddTicks(4250), "Edmond Olson", "Jacobi - Ernser" },
                    { 142, 81, new DateTime(1988, 3, 21, 7, 40, 32, 635, DateTimeKind.Local).AddTicks(9002), "Geneva Koepp", "Grant, Herman and O'Reilly" },
                    { 7, 82, new DateTime(1985, 6, 22, 7, 58, 52, 97, DateTimeKind.Local).AddTicks(2208), "Miriam Batz", "Pollich and Sons" },
                    { 8, 84, new DateTime(1977, 9, 29, 22, 47, 8, 809, DateTimeKind.Local).AddTicks(902), "Ramona Ondricka", "Larkin, Pagac and Kuhlman" },
                    { 34, 84, new DateTime(1989, 11, 24, 4, 11, 26, 655, DateTimeKind.Local).AddTicks(2063), "Bridget Monahan", "Leannon, Harvey and Graham" },
                    { 51, 84, new DateTime(1998, 1, 14, 2, 52, 16, 765, DateTimeKind.Local).AddTicks(8443), "Loretta Adams", "Rodriguez Group" },
                    { 36, 85, new DateTime(1991, 8, 20, 16, 55, 51, 355, DateTimeKind.Local).AddTicks(673), "Melissa Klein", "Berge LLC" },
                    { 154, 85, new DateTime(1994, 10, 12, 12, 47, 25, 991, DateTimeKind.Local).AddTicks(5744), "Gail Raynor", "Hirthe, Hirthe and Lang" },
                    { 124, 87, new DateTime(1954, 6, 21, 0, 53, 38, 537, DateTimeKind.Local).AddTicks(2542), "Austin Nader", "Schultz Group" },
                    { 59, 49, new DateTime(1975, 4, 10, 18, 24, 26, 414, DateTimeKind.Local).AddTicks(8926), "Sue Schultz", "Langosh - Strosin" },
                    { 182, 48, new DateTime(1957, 11, 19, 21, 21, 7, 27, DateTimeKind.Local).AddTicks(191), "Bonnie Koepp", "Schaden, Hahn and Dooley" },
                    { 168, 48, new DateTime(1992, 6, 25, 5, 22, 56, 424, DateTimeKind.Local).AddTicks(7962), "Gerald Cruickshank", "Block, Paucek and Green" },
                    { 37, 16, new DateTime(1996, 10, 20, 18, 32, 25, 457, DateTimeKind.Local).AddTicks(8343), "Tony West", "Hoppe, Davis and Bailey" },
                    { 63, 16, new DateTime(2000, 2, 22, 1, 5, 51, 286, DateTimeKind.Local).AddTicks(4334), "Eloise Smitham", "Bahringer - Erdman" },
                    { 185, 17, new DateTime(1961, 12, 11, 14, 48, 34, 415, DateTimeKind.Local).AddTicks(5925), "Terry Daugherty", "Botsford, Torp and Conn" },
                    { 198, 17, new DateTime(1970, 3, 12, 8, 42, 29, 173, DateTimeKind.Local).AddTicks(7929), "Roberto Hand", "Stokes, Hackett and Veum" },
                    { 170, 19, new DateTime(1992, 11, 10, 23, 14, 43, 500, DateTimeKind.Local).AddTicks(7027), "Molly Becker", "Dickinson, Funk and O'Kon" },
                    { 189, 19, new DateTime(1988, 11, 14, 10, 33, 28, 854, DateTimeKind.Local).AddTicks(7922), "Christian Block", "Cummings - Blick" },
                    { 6, 20, new DateTime(1957, 5, 6, 16, 16, 52, 466, DateTimeKind.Local).AddTicks(5821), "Byron Fahey", "Mills Inc" },
                    { 81, 20, new DateTime(1974, 11, 4, 17, 10, 42, 869, DateTimeKind.Local).AddTicks(6877), "Dianna Johnston", "Mante, Bogisich and Kuhn" },
                    { 121, 20, new DateTime(1962, 2, 6, 10, 15, 55, 564, DateTimeKind.Local).AddTicks(4389), "Abraham Shields", "Johnson, Glover and Bechtelar" },
                    { 137, 21, new DateTime(1998, 8, 31, 22, 45, 38, 773, DateTimeKind.Local).AddTicks(3762), "Jasmine Hudson", "Rodriguez - Homenick" },
                    { 141, 21, new DateTime(1978, 10, 6, 6, 18, 6, 490, DateTimeKind.Local).AddTicks(9652), "Jon Littel", "Denesik LLC" },
                    { 175, 21, new DateTime(1959, 7, 5, 8, 53, 30, 474, DateTimeKind.Local).AddTicks(4661), "Jody Bernhard", "Ledner - Feeney" },
                    { 177, 21, new DateTime(1979, 12, 22, 7, 3, 28, 109, DateTimeKind.Local).AddTicks(5260), "Judith Balistreri", "Bradtke - Lueilwitz" },
                    { 143, 22, new DateTime(1962, 5, 10, 9, 27, 18, 343, DateTimeKind.Local).AddTicks(9125), "Luis Gerhold", "Kub - Johnson" },
                    { 166, 22, new DateTime(1967, 3, 31, 16, 42, 8, 522, DateTimeKind.Local).AddTicks(3508), "Jeremiah Renner", "Cummings Inc" },
                    { 72, 23, new DateTime(1953, 3, 1, 20, 40, 44, 230, DateTimeKind.Local).AddTicks(4681), "Renee Rice", "Reynolds - Bernhard" },
                    { 188, 24, new DateTime(1976, 11, 22, 21, 59, 12, 185, DateTimeKind.Local).AddTicks(5169), "Oliver Bernier", "Kohler Inc" },
                    { 42, 25, new DateTime(1997, 2, 26, 22, 34, 29, 25, DateTimeKind.Local).AddTicks(9715), "Tim Terry", "Rolfson LLC" },
                    { 43, 25, new DateTime(1961, 5, 6, 10, 29, 4, 104, DateTimeKind.Local).AddTicks(2286), "Wilfred Kuhic", "Reichel Inc" },
                    { 53, 25, new DateTime(1986, 12, 1, 9, 38, 37, 195, DateTimeKind.Local).AddTicks(5783), "Kevin Ebert", "Gottlieb Group" },
                    { 83, 25, new DateTime(1964, 6, 28, 22, 29, 48, 791, DateTimeKind.Local).AddTicks(4771), "Shelly Hoeger", "West, Lang and Leuschke" },
                    { 172, 14, new DateTime(1996, 10, 12, 23, 27, 9, 968, DateTimeKind.Local).AddTicks(9951), "Darlene Ward", "King Inc" },
                    { 90, 25, new DateTime(1978, 5, 2, 11, 0, 40, 853, DateTimeKind.Local).AddTicks(1215), "Francisco Price", "Dach - Krajcik" },
                    { 95, 13, new DateTime(1955, 7, 4, 7, 26, 27, 576, DateTimeKind.Local).AddTicks(3784), "Marvin Torphy", "Fisher - Kuhic" },
                    { 98, 12, new DateTime(1965, 7, 31, 11, 37, 14, 542, DateTimeKind.Local).AddTicks(3563), "Kelli Turner", "Bahringer and Sons" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "Name", "Position" },
                values: new object[,]
                {
                    { 155, 1, new DateTime(1972, 12, 3, 19, 53, 55, 309, DateTimeKind.Local).AddTicks(1064), "Roman Howe", "Hudson, Block and Rippin" },
                    { 45, 2, new DateTime(1953, 4, 25, 16, 35, 23, 138, DateTimeKind.Local).AddTicks(3694), "Lana Parker", "Abernathy - Rutherford" },
                    { 110, 3, new DateTime(1995, 1, 31, 20, 33, 25, 899, DateTimeKind.Local).AddTicks(8790), "Christine Mertz", "Olson - Kuphal" },
                    { 136, 3, new DateTime(1976, 4, 6, 4, 15, 22, 251, DateTimeKind.Local).AddTicks(5952), "Carla Rohan", "Bernier, Smitham and Blanda" },
                    { 160, 3, new DateTime(1963, 8, 12, 7, 47, 38, 271, DateTimeKind.Local).AddTicks(4394), "Julian Considine", "Blick - Berge" },
                    { 167, 3, new DateTime(1975, 4, 24, 8, 14, 47, 369, DateTimeKind.Local).AddTicks(6099), "Elizabeth Stanton", "Sporer - Skiles" },
                    { 191, 3, new DateTime(1960, 9, 26, 23, 14, 9, 366, DateTimeKind.Local).AddTicks(9374), "Winifred Howell", "Schowalter - Morissette" },
                    { 22, 4, new DateTime(1962, 8, 8, 22, 9, 54, 553, DateTimeKind.Local).AddTicks(1180), "Raymond Kertzmann", "Beatty and Sons" },
                    { 75, 5, new DateTime(1982, 10, 20, 21, 50, 52, 391, DateTimeKind.Local).AddTicks(7239), "Roman Hammes", "White Group" },
                    { 32, 6, new DateTime(1989, 7, 24, 8, 25, 5, 194, DateTimeKind.Local).AddTicks(2189), "Vicky MacGyver", "Vandervort, Moen and Barton" },
                    { 49, 6, new DateTime(1963, 12, 25, 10, 55, 37, 884, DateTimeKind.Local).AddTicks(4628), "Wilma Kreiger", "Cruickshank and Sons" },
                    { 128, 6, new DateTime(1959, 2, 24, 17, 22, 10, 6, DateTimeKind.Local).AddTicks(1099), "Julio Ward", "Lehner - Schneider" },
                    { 1, 7, new DateTime(1962, 8, 30, 4, 34, 28, 0, DateTimeKind.Local).AddTicks(3452), "Bryan McGlynn", "Jaskolski - Schmitt" },
                    { 78, 8, new DateTime(1980, 8, 19, 21, 43, 54, 463, DateTimeKind.Local).AddTicks(7185), "Molly Leffler", "Schmitt - Blick" },
                    { 112, 8, new DateTime(1966, 5, 4, 11, 40, 15, 832, DateTimeKind.Local).AddTicks(6494), "Tammy Rosenbaum", "Klein - Stokes" },
                    { 127, 8, new DateTime(1972, 5, 10, 18, 47, 8, 182, DateTimeKind.Local).AddTicks(2959), "Marcos Ondricka", "Huels LLC" },
                    { 19, 10, new DateTime(1959, 10, 30, 3, 26, 13, 265, DateTimeKind.Local).AddTicks(4718), "Elaine Schoen", "Smith and Sons" },
                    { 197, 10, new DateTime(1991, 11, 29, 21, 24, 12, 14, DateTimeKind.Local).AddTicks(370), "Veronica Monahan", "Berge, Kohler and Borer" },
                    { 66, 11, new DateTime(1956, 10, 24, 21, 15, 12, 140, DateTimeKind.Local).AddTicks(2958), "Douglas Cassin", "Bernhard LLC" },
                    { 130, 11, new DateTime(1963, 7, 25, 14, 13, 38, 131, DateTimeKind.Local).AddTicks(6343), "Ellen Gibson", "Stanton, Lind and Powlowski" },
                    { 14, 12, new DateTime(1956, 3, 15, 10, 35, 43, 721, DateTimeKind.Local).AddTicks(8345), "Gerardo Altenwerth", "Langworth Inc" },
                    { 50, 13, new DateTime(1991, 8, 29, 9, 57, 1, 762, DateTimeKind.Local).AddTicks(4872), "Esther VonRueden", "Hane, Corwin and Waters" },
                    { 97, 25, new DateTime(1962, 8, 7, 0, 53, 49, 50, DateTimeKind.Local).AddTicks(232), "Max Ward", "Douglas - Emard" },
                    { 118, 25, new DateTime(1959, 9, 11, 15, 4, 26, 365, DateTimeKind.Local).AddTicks(6725), "Georgia Hermann", "Grant Group" },
                    { 193, 26, new DateTime(1982, 2, 25, 4, 27, 22, 231, DateTimeKind.Local).AddTicks(4579), "David Walker", "Boyer - Kilback" },
                    { 100, 39, new DateTime(1992, 11, 17, 5, 47, 25, 718, DateTimeKind.Local).AddTicks(4714), "Rachel Blick", "Schneider LLC" },
                    { 104, 39, new DateTime(1988, 5, 10, 2, 56, 12, 927, DateTimeKind.Local).AddTicks(5939), "Kerry Reinger", "Mertz, Bauch and Wilkinson" },
                    { 171, 39, new DateTime(1983, 1, 29, 11, 45, 7, 476, DateTimeKind.Local).AddTicks(3895), "Danielle Weimann", "Stokes, West and Heidenreich" },
                    { 99, 40, new DateTime(1958, 7, 2, 17, 15, 5, 62, DateTimeKind.Local).AddTicks(4140), "Jeannie Labadie", "Botsford, Schultz and Legros" },
                    { 94, 41, new DateTime(1968, 3, 19, 15, 39, 33, 672, DateTimeKind.Local).AddTicks(383), "Colleen Raynor", "Gleason - Muller" },
                    { 125, 41, new DateTime(1966, 7, 3, 17, 45, 43, 398, DateTimeKind.Local).AddTicks(923), "Darryl Ritchie", "Schumm, Reichel and Barrows" },
                    { 91, 42, new DateTime(1978, 1, 25, 5, 35, 37, 607, DateTimeKind.Local).AddTicks(8645), "Katrina Williamson", "Hagenes, Pfeffer and Daugherty" },
                    { 152, 42, new DateTime(1987, 10, 31, 14, 3, 47, 118, DateTimeKind.Local).AddTicks(3237), "Edmund Reichert", "Lesch, Stamm and Hamill" },
                    { 192, 42, new DateTime(1989, 2, 10, 20, 55, 47, 955, DateTimeKind.Local).AddTicks(5430), "Leticia Nolan", "Pollich - Wintheiser" },
                    { 16, 43, new DateTime(1958, 8, 14, 21, 27, 26, 767, DateTimeKind.Local).AddTicks(7347), "Leona Orn", "Swaniawski, Murazik and Bahringer" },
                    { 55, 43, new DateTime(1960, 10, 22, 5, 58, 24, 948, DateTimeKind.Local).AddTicks(7565), "Nathaniel Berge", "Wilkinson, Hudson and DuBuque" },
                    { 156, 43, new DateTime(1973, 5, 2, 16, 36, 50, 217, DateTimeKind.Local).AddTicks(3233), "Fannie Runolfsdottir", "Hahn and Sons" },
                    { 184, 43, new DateTime(1984, 5, 23, 18, 4, 30, 98, DateTimeKind.Local).AddTicks(2347), "Leticia Jacobi", "Weissnat Group" },
                    { 132, 44, new DateTime(2000, 10, 26, 8, 59, 0, 235, DateTimeKind.Local).AddTicks(7932), "Cora Turner", "Spencer - Kiehn" },
                    { 25, 45, new DateTime(1956, 7, 29, 10, 42, 19, 679, DateTimeKind.Local).AddTicks(433), "Lauren Lowe", "Gerlach - Donnelly" },
                    { 149, 45, new DateTime(1994, 12, 5, 20, 9, 20, 587, DateTimeKind.Local).AddTicks(8942), "Agnes Kshlerin", "O'Connell - Cormier" },
                    { 2, 46, new DateTime(1989, 12, 16, 3, 6, 7, 311, DateTimeKind.Local).AddTicks(118), "Vera Reichel", "Nitzsche Inc" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "Name", "Position" },
                values: new object[,]
                {
                    { 26, 47, new DateTime(1955, 5, 15, 16, 52, 36, 514, DateTimeKind.Local).AddTicks(7380), "Frank Deckow", "Gibson, Lebsack and D'Amore" },
                    { 56, 47, new DateTime(1982, 10, 15, 0, 59, 29, 618, DateTimeKind.Local).AddTicks(1839), "Inez Fadel", "Hamill - Bayer" },
                    { 13, 48, new DateTime(1978, 4, 25, 5, 38, 3, 526, DateTimeKind.Local).AddTicks(2103), "Kerry Prohaska", "Mayer, Koepp and Botsford" },
                    { 89, 48, new DateTime(1982, 10, 17, 21, 20, 31, 13, DateTimeKind.Local).AddTicks(3446), "Erick Windler", "Casper - Williamson" },
                    { 31, 39, new DateTime(1991, 2, 25, 15, 38, 26, 864, DateTimeKind.Local).AddTicks(1845), "Alma Rath", "Jerde and Sons" },
                    { 138, 38, new DateTime(1953, 11, 7, 0, 18, 40, 480, DateTimeKind.Local).AddTicks(5564), "Stewart Konopelski", "White, Olson and Konopelski" },
                    { 117, 38, new DateTime(2000, 9, 3, 10, 0, 45, 378, DateTimeKind.Local).AddTicks(5418), "Mildred Maggio", "Quigley Group" },
                    { 114, 38, new DateTime(1996, 8, 28, 1, 55, 56, 71, DateTimeKind.Local).AddTicks(1931), "Jonathan Cremin", "Grady, Langworth and Lueilwitz" },
                    { 46, 27, new DateTime(1955, 1, 27, 13, 37, 48, 799, DateTimeKind.Local).AddTicks(240), "Elizabeth Shields", "Batz - Stamm" },
                    { 27, 28, new DateTime(1986, 2, 8, 17, 50, 25, 393, DateTimeKind.Local).AddTicks(2870), "Eunice Carroll", "Feest, Larson and Willms" },
                    { 107, 28, new DateTime(2001, 3, 17, 5, 3, 59, 12, DateTimeKind.Local).AddTicks(4927), "Kent Schultz", "Wilkinson, Bahringer and Conn" },
                    { 179, 28, new DateTime(1981, 2, 20, 3, 6, 15, 101, DateTimeKind.Local).AddTicks(6050), "Amanda Zboncak", "Runolfsson - Langworth" },
                    { 48, 29, new DateTime(1959, 10, 16, 20, 57, 35, 51, DateTimeKind.Local).AddTicks(4304), "Julie Crona", "Stiedemann, Pacocha and Marvin" },
                    { 70, 30, new DateTime(1983, 10, 16, 11, 23, 50, 483, DateTimeKind.Local).AddTicks(6215), "Dorothy Blick", "Gibson - Lebsack" },
                    { 181, 30, new DateTime(1986, 3, 28, 7, 6, 52, 215, DateTimeKind.Local).AddTicks(8741), "Doug Littel", "Herman and Sons" },
                    { 173, 31, new DateTime(1969, 8, 19, 6, 51, 50, 194, DateTimeKind.Local).AddTicks(4517), "Santos Collier", "Tillman - Wolff" },
                    { 9, 32, new DateTime(2000, 1, 23, 19, 24, 27, 124, DateTimeKind.Local).AddTicks(9247), "Gerard Windler", "Hayes LLC" },
                    { 20, 32, new DateTime(1967, 4, 21, 4, 57, 35, 871, DateTimeKind.Local).AddTicks(8704), "Stephanie Gleichner", "Rutherford and Sons" },
                    { 73, 100, new DateTime(1957, 1, 6, 17, 34, 36, 477, DateTimeKind.Local).AddTicks(7607), "Cassandra Ziemann", "West - Moore" },
                    { 85, 32, new DateTime(1986, 11, 17, 1, 51, 24, 918, DateTimeKind.Local).AddTicks(5900), "Tom Kertzmann", "Crona, Lynch and Kiehn" },
                    { 111, 33, new DateTime(1982, 6, 23, 9, 52, 17, 143, DateTimeKind.Local).AddTicks(4753), "Cora Koch", "Becker, Moore and Leannon" },
                    { 109, 35, new DateTime(1981, 5, 6, 6, 10, 18, 82, DateTimeKind.Local).AddTicks(1493), "Casey Morar", "Auer, Gulgowski and Sauer" },
                    { 164, 35, new DateTime(1969, 3, 21, 0, 28, 50, 45, DateTimeKind.Local).AddTicks(7148), "Charlie Runte", "Brown - Bailey" },
                    { 12, 36, new DateTime(1960, 3, 22, 21, 47, 36, 867, DateTimeKind.Local).AddTicks(1340), "Shawna Huel", "Sanford Inc" },
                    { 106, 36, new DateTime(1962, 8, 24, 22, 11, 20, 350, DateTimeKind.Local).AddTicks(9813), "Abel Mann", "O'Keefe, Pfeffer and Sipes" },
                    { 183, 36, new DateTime(1979, 6, 6, 19, 38, 37, 214, DateTimeKind.Local).AddTicks(5212), "Shirley Christiansen", "Feest - Kreiger" },
                    { 190, 36, new DateTime(1973, 5, 3, 4, 46, 42, 783, DateTimeKind.Local).AddTicks(2483), "Marshall Balistreri", "Beatty - Hauck" },
                    { 101, 37, new DateTime(1983, 7, 25, 0, 8, 5, 673, DateTimeKind.Local).AddTicks(6736), "Heidi Nicolas", "Yundt - Treutel" },
                    { 113, 37, new DateTime(1957, 8, 25, 23, 35, 17, 37, DateTimeKind.Local).AddTicks(9414), "Everett Dietrich", "Brekke, Grady and Powlowski" },
                    { 105, 38, new DateTime(1974, 12, 13, 7, 6, 3, 300, DateTimeKind.Local).AddTicks(3704), "Kelly Hirthe", "Reinger, Barton and Bednar" },
                    { 68, 33, new DateTime(1971, 10, 16, 21, 42, 24, 604, DateTimeKind.Local).AddTicks(1019), "Lance Bailey", "Morissette, Raynor and Cole" },
                    { 200, 100, new DateTime(2000, 7, 17, 9, 51, 51, 780, DateTimeKind.Local).AddTicks(5864), "Jonathon Greenfelder", "Fahey - Beier" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
