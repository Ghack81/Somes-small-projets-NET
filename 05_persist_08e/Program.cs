using System;
using System.Data;
using Microsoft.Data.Sqlite;

namespace persist_08
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using IDbConnection cnct = new SqliteConnection("Data Source=:memory:");

                cnct.Open();

                var cmd = cnct.CreateCommand();
                cmd.CommandText = InitBase;
                cmd.ExecuteNonQuery();
                // Created a sql file for save DB
                cmd.CommandText = @"
                    SELECT newsletter, nom, prenom 
                    FROM utilisateurs 
                    WHERE nom LIKE @recherche
                    ORDER BY nom";
                
                var param = cmd.CreateParameter();
                param.ParameterName = "recherche";
                param.Value = "A%";
                cmd.Parameters.Add(param);
                using (var u = cmd.ExecuteReader()) 
                {
                    while(u.Read()) 
                    {
                        Console.WriteLine(" [{0}] {1} {2}",
                            u.GetBoolean(0) ? 'x':' ',
                            u.GetString(1),
                            u.GetString(2)                        
                        );
                    }
                }
            }
            catch(DataException e) 
            {
                Console.Error.WriteLine(e.Message);
            }
            


        }

        const string InitBase = @"create table utilisateurs (
                id INTEGER PRIMARY KEY,
                prenom TEXT NOT NULL,
                nom TEXT NOT NULL,
                email TEXT NOT NULL UNIQUE,
                newsletter INTEGER(1) NOT NULL DEFAULT 0
            );
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (1, 'Thomasine', 'Arkill', 'tarkill0@europa.eu', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (2, 'Ruggiero', 'Sodory', 'rsodory1@printfriendly.com', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (3, 'Joseph', 'Gunter', 'jgunter2@auda.org.au', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (4, 'Kora', 'Peedell', 'kpeedell3@state.gov', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (5, 'Brittany', 'Eatttok', 'beatttok4@cnbc.com', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (6, 'Lucine', 'Brownlie', 'lbrownlie5@webs.com', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (7, 'Bendicty', 'Amort', 'bamort6@simplemachines.org', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (8, 'Eilis', 'Truss', 'etruss7@networkadvertising.org', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (9, 'Roda', 'Hogbin', 'rhogbin8@acquirethisname.com', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (10, 'Deni', 'Neary', 'dneary9@senate.gov', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (11, 'Stephanus', 'Keune', 'skeunea@newyorker.com', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (12, 'Ferdinande', 'Kraft', 'fkraftb@slate.com', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (13, 'Amalea', 'Borwick', 'aborwickc@nature.com', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (14, 'Bryanty', 'Plan', 'bpland@loc.gov', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (15, 'Susi', 'Battleson', 'sbattlesone@japanpost.jp', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (16, 'Nickolaus', 'Doeg', 'ndoegf@smh.com.au', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (17, 'Erinn', 'Janusz', 'ejanuszg@vinaora.com', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (18, 'Noam', 'Christin', 'nchristinh@xrea.com', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (19, 'Wain', 'Hannent', 'whannenti@illinois.edu', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (20, 'Orville', 'Jefford', 'ojeffordj@desdev.cn', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (21, 'Ginelle', 'Edgeler', 'gedgelerk@blinklist.com', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (22, 'Floyd', 'Disman', 'fdismanl@acquirethisname.com', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (23, 'Consuela', 'Richardes', 'crichardesm@nsw.gov.au', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (24, 'Dalt', 'Upstell', 'dupstelln@microsoft.com', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (25, 'Jasun', 'Simmgen', 'jsimmgeno@walmart.com', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (26, 'Amble', 'MacAlpyne', 'amacalpynep@prweb.com', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (27, 'Andrew', 'Yosifov', 'ayosifovq@homestead.com', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (28, 'Arri', 'Beston', 'abestonr@utexas.edu', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (29, 'Hildagarde', 'Gook', 'hgooks@boston.com', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (30, 'Dalia', 'Sherington', 'dsheringtont@bizjournals.com', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (31, 'Thaine', 'Wooffitt', 'twooffittu@ameblo.jp', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (32, 'Genevra', 'Valentin', 'gvalentinv@hud.gov', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (33, 'Brinna', 'Belward', 'bbelwardw@princeton.edu', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (34, 'Ulrica', 'Tumioto', 'utumiotox@phpbb.com', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (35, 'Bobbe', 'Burke', 'bburkey@hubpages.com', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (36, 'Bartolomeo', 'Alexandrou', 'balexandrouz@ask.com', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (37, 'Hanson', 'Londer', 'hlonder10@cbc.ca', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (38, 'Cathyleen', 'Le Jean', 'clejean11@springer.com', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (39, 'Reeva', 'Gerdes', 'rgerdes12@admin.ch', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (40, 'Dinny', 'Adan', 'dadan13@rediff.com', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (41, 'Bonnie', 'Hamshaw', 'bhamshaw14@youtube.com', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (42, 'Troy', 'Stachini', 'tstachini15@chronoengine.com', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (43, 'Lynn', 'Lennox', 'llennox16@state.tx.us', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (44, 'Ethan', 'Foro', 'eforo17@cam.ac.uk', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (45, 'Evonne', 'Stoppe', 'estoppe18@redcross.org', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (46, 'Vivie', 'Moodie', 'vmoodie19@networksolutions.com', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (47, 'Enrique', 'Strangward', 'estrangward1a@irs.gov', 0);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (48, 'Phylis', 'Wakenshaw', 'pwakenshaw1b@google.com.au', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (49, 'Doralin', 'Bridgstock', 'dbridgstock1c@howstuffworks.com', 1);
            insert into utilisateurs (id, prenom, nom, email, newsletter) values (50, 'Reuben', 'Seeking', 'rseeking1d@china.com.cn', 1);
        ";
    }
}
