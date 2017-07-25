namespace Portal.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSegmentTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('002ca8c7-a24a-5f03-7ead-b41ab718a7a3', 'Organization', '2017-06-09 12:00')");   //1
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('006edbb7-d550-f517-ee37-da6748a00039', 'City', '2017-06-09 12:00')");           //2
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('00a51405-d0b8-dce1-2c59-7dd41c46f226', 'Organization', '2017-06-09 12:00')");   //3
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('00f95d1b-c5b0-5b1f-176a-5a675d997239', 'City', '2017-06-09 12:00')");           //4
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('010ff070-5596-0d82-3f3b-72585bf82b9d', 'City', '2017-06-09 12:00')");           //5
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('01193ece-c2ff-9ce3-f46a-87a450c1c34f', 'City', '2017-06-09 12:00')");           //6
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('011ce8f5-2a0b-a674-50c1-3727f548e573', 'City', '2017-06-09 12:00')");           //7
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('015c6d70-3c23-e7c6-119d-7fe87b62146d', 'Organization', '2017-06-09 12:00')");   //8
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('019af91f-f79a-6f5f-cf9a-13712fd24000', 'City', '2017-06-09 12:00')");           //9
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('01e9cbd9-51e3-218d-719d-83499fec51b1', 'City', '2017-06-09 12:00')");           //10
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('023e2ea1-d333-3dfb-6efb-b4df97c17a3f', 'City', '2017-06-09 12:00')");           //11
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('0275ab35-0823-b669-a5cc-6f9f75cefc94', 'City', '2017-06-09 12:00')");           //12
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('02899209-3c0b-ea7f-7d9e-ef3756d2278a', 'City', '2017-06-09 12:00')");           //13
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('02933b3a-acef-1ff6-4c8d-9e8977dd1fde', 'City', '2017-06-09 12:00')");           //14
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('029e1919-044b-faab-60ff-097a346ed7d4', 'Organization', '2017-06-09 12:00')");   //15
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('02a43b99-0573-0147-b61b-2d43f26f3834', 'City', '2017-06-09 12:00')");           //16
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('02b4d2ae-763b-2286-ea9a-c693321b7b9c', 'City', '2017-06-09 12:00')");           //17
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('02cffecb-df14-475e-0033-57759502c742', 'Organization', '2017-06-09 12:00')");   //18
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('02d249c7-e82a-e5d3-57e7-00812b683ecc', 'City', '2017-06-09 12:00')");           //19
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('02db306e-8688-e737-7f87-a14f6fe1be11', 'Organization', '2017-06-09 12:00')");   //20
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('02fc29dc-a40c-8f2a-8dab-e73b390788f8', 'City', '2017-06-09 12:00')");           //21
            Sql("INSERT INTO Segments (SatoriId,Type,LastUpdated) VALUES ('03599489-e810-5f88-b3ef-c5be55b020a2', 'City', '2017-06-09 12:00')");           //22
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Segments *");
        }
    }
}
