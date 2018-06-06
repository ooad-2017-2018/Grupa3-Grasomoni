namespace ProASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kartica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StanjeRacuna = c.Double(nullable: false),
                        DatumIsteka = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Korisnik",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        Jmbg = c.Long(nullable: false),
                        Email = c.String(),
                        KorisnickoIme = c.String(),
                        Lozinka = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stanica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazivStanice = c.String(),
                        Lokacija = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vozilo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VrstaVozila = c.String(),
                        RegistracijskiBroj = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vozilo");
            DropTable("dbo.Stanica");
            DropTable("dbo.Korisnik");
            DropTable("dbo.Kartica");
        }
    }
}
