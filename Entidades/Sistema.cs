using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class Sistema
    {
        //TODO: llamada desde aerolinea pasa mano instanciada con validacion de datos para pasarle a sistema - SISTEMA ES INTERNAL AEROLINEA PUBLIC
        public static List<Usuario> usuarios;
        public static List<Aeronave> aeronaves;
        public static List<Pasajero> pasajeros;
        public static int cantidadMaximaDeAereonaves;
        public static List<Vuelo> vuelos;
        public static List<string> localidades;

        static Sistema()
        {
            CargarUsuarios();

            CargarLocalidades();

            CargarAeronaves();

            CargarPasajeros();

            CargarVuelos();

            AltaRandomDePasajeros();
        }

        private static void CargarVuelos()
        {
            vuelos = new List<Vuelo>()
            {
                new Vuelo(aeronaves[5],localidades[4],localidades[15],new DateTime(2022, 12, 2, 11, 30, 0)),
                new Vuelo(aeronaves[3],localidades[18],localidades[10],new DateTime(2023, 3, 11, 23, 00, 0)),
                new Vuelo(aeronaves[5],localidades[12],localidades[6],new DateTime(2023, 11, 9, 15, 30, 0)),
                new Vuelo(aeronaves[5],localidades[15],localidades[1],new DateTime(2022, 10, 28, 6, 30, 0)),
                new Vuelo(aeronaves[0],localidades[1],localidades[4],new DateTime(2022, 10, 16, 16, 30, 0)),
                new Vuelo(aeronaves[2],localidades[6],localidades[9],new DateTime(2022, 12, 11, 20, 10, 0)),
                new Vuelo(aeronaves[3],localidades[4],localidades[14],new DateTime(2022, 12, 7, 19, 30, 0)),
                new Vuelo(aeronaves[5],localidades[8],localidades[12],new DateTime(2022, 11, 22, 10, 40, 0)),
                new Vuelo(aeronaves[4],localidades[0],localidades[18],new DateTime(2023, 12, 30, 13, 30, 0)),
                new Vuelo(aeronaves[5],localidades[5],localidades[2],new DateTime(2022, 10, 30, 22, 10, 0)),
                new Vuelo(aeronaves[0],localidades[2],localidades[8],new DateTime(2022, 11, 1, 21, 0, 0)),
                new Vuelo(aeronaves[2],localidades[13],localidades[7],new DateTime(2022, 10, 28, 05, 30, 0)),
                new Vuelo(aeronaves[3],localidades[17],localidades[0],new DateTime(2022, 12, 25, 08, 30, 0)),
                new Vuelo(aeronaves[5],localidades[14],localidades[11],new DateTime(2022, 10, 16, 15, 15, 0)),
                new Vuelo(aeronaves[4],localidades[11],localidades[2],new DateTime(2022, 11, 12, 13, 15, 0)),
                new Vuelo(aeronaves[0],localidades[4],localidades[4],new DateTime(2022, 11, 2, 17, 20, 0)),
                new Vuelo(aeronaves[2],localidades[13],localidades[2],new DateTime(2022, 12, 10, 09, 15, 0)),
                new Vuelo(aeronaves[3],localidades[17],localidades[13],new DateTime(2022, 12, 22, 11, 0, 0)),
                new Vuelo(aeronaves[5],localidades[10],localidades[5],new DateTime(2023, 12, 12, 12, 30, 0))
            };
        }

        private static void CargarAeronaves()
        {
            aeronaves = new List<Aeronave>()
            {
                new Aeronave(20,2,2000),
                new Aeronave(15,1,1500),
                new Aeronave(50,3,10000),
                new Aeronave(5,1,500),
                new Aeronave(30,2,3500),
                new Aeronave(23,1,2000),
                new Aeronave(27,2,3000)
            };
        }

        private static void CargarLocalidades()
        {
            localidades = new List<string>()
            {
                "Santa Rosa",
                "Bariloche",
                "Corrientes",
                "Córdoba",
                "Jujuy",
                "Mendoza",
                "Neuquén",
                "Posadas",
                "Iguazú",
                "Salta",
                "Santiago del Estero",
                "Trelew",
                "Tucumán",
                "Puerto Madryn",
                "Ushuaia",
                "Recife(Brasil)",
                "Roma(Italia)",
                "Acapulco(México)",
                "Miami(EEUU)"
            };
        }

        private static void CargarPasajeros()
        {
            pasajeros = new List<Pasajero>()
            {
                new Pasajero("Peria", "Nealey", new DateTime(1968, 4, 21), 42725372, "pnealey0@nba.com"),
                new Pasajero("Luci", "Rossborough", new DateTime(1994, 10, 16), 70798854, "lrossborough1@ning.com"),
                new Pasajero("Joellyn", "Lawerence", new DateTime(1998, 11, 26), 40598910, "jlawerence2@google.pl"),
                new Pasajero("Anestassia", "Selliman", new DateTime(2000, 4, 28), 42228697, "aselliman3@hatena.ne.jp"),
                new Pasajero("Lizzie", "Emlen", new DateTime(2000, 8, 15), 32857834, "lemlen4@dmoz.org"),
                new Pasajero("Dael", "Scurman", new DateTime(1989, 12, 20), 81334786, "dscurman5@constantcontact.com"),
                new Pasajero("Rebe", "Heaney", new DateTime(1953, 1, 30), 50094288, "rheaney6@woothemes.com"),
                new Pasajero("Heloise", "Dach", new DateTime(1953, 3, 10), 77634856, "hdach7@1und1.de"),
                new Pasajero("Ortensia", "Hallihane", new DateTime(1952, 12, 7), 97328814, "oohallihane8@omniture.com"),
                new Pasajero("Claudetta", "Jerdon", new DateTime(1955, 2, 27), 93184976, "cjerdon9@phpbb.com"),
                new Pasajero("Joellen", "LaBastida", new DateTime(1990, 10, 1), 17215531, "jlabastidaa@cbslocal.com"),
                new Pasajero("Lexy", "Dundridge", new DateTime(1998, 5, 16), 13125797, "ldundridgeb@smh.com.au"),
                new Pasajero("Lenard", "Skullet", new DateTime(2007, 2, 3), 40287835, "lskulletc@amazon.co.jp"),
                new Pasajero("Brien", "Benito", new DateTime(1955, 3, 20), 92394651, "bbenitod@umn.edu"),
                new Pasajero("Becky", "Thatcher", new DateTime(2000, 9, 16), 92882243, "bthatchere@hao123.com"),
                new Pasajero("Fae", "Sharland", new DateTime(1973, 11, 2), 86963538, "fsharlandf@techcrunch.com"),
                new Pasajero("Robinet", "Charlon", new DateTime(1975, 9, 30), 20992933, "rcharlong@columbia.edu"),
                new Pasajero("Vitia", "Dowdell", new DateTime(1965, 1, 27), 77524064, "vdowdellh@bbc.co.uk"),
                new Pasajero("Austina", "Oxterby", new DateTime(1971, 8, 2), 26820299, "aoxterbyi@wix.com"),
                new Pasajero("Fanchette", "Coules", new DateTime(1976, 4, 11), 93110553, "fcoulesj@tripod.com"),
                new Pasajero("Roderic", "Swinbourne", new DateTime(1979, 4, 23), 28562946, "rswinbournek@netvibes.com"),
                new Pasajero("Wayland", "Dimitriou", new DateTime(1965, 4, 25), 91009933, "wdimitrioul@berkeley.edu"),
                new Pasajero("Ulrica", "Slorance", new DateTime(1994, 4, 21), 16404456, "uslorancem@example.com"),
                new Pasajero("Darb", "Fitzroy", new DateTime(1985, 1, 4), 29328642, "dfitzroyn@slate.com"),
                new Pasajero("Chantal", "Colten", new DateTime(1985, 10, 23), 31866080, "ccolteno@theatlantic.com"),
                new Pasajero("Anabel", "Hanrott", new DateTime(1961, 6, 30), 44957581, "ahanrottp@free.fr"),
                new Pasajero("Bertina", "Cleveley", new DateTime(1950, 12, 4), 70915606, "bcleveleyq@gravatar.com"),
                new Pasajero("Grove", "Confort", new DateTime(1994, 4, 7), 90960177, "gconfortr@nymag.com"),
                new Pasajero("Sammie", "Wrightem", new DateTime(1984, 7, 27), 79596114, "swrightems@last.fm"),
                new Pasajero("Gael", "Benza", new DateTime(1982, 9, 15), 95386469, "gbenzat@seesaa.net"),
                new Pasajero("Karee", "Spurling", new DateTime(1984, 6, 29), 76204521, "kspurlingu@mediafire.com"),
                new Pasajero("Toiboid", "Stanlack", new DateTime(1969, 6, 10), 40951373, "tstanlackv@pen.io"),
                new Pasajero("Jelene", "Shitliffe", new DateTime(1991, 3, 1), 77120539, "jshitliffew@sbwire.com"),
                new Pasajero("Lara", "Ruddell", new DateTime(1956, 9, 8), 16839058, "lruddellx@booking.com"),
                new Pasajero("Addia", "Boucher", new DateTime(2005, 4, 28), 62572270, "abouchery@thetimes.co.uk"),
                new Pasajero("Justin", "Felstead", new DateTime(1994, 2, 9), 49787875, "jfelsteadz@oracle.com"),
                new Pasajero("Tisha", "Worham", new DateTime(2010, 4, 15), 90914609, "tworham10@mit.edu"),
                new Pasajero("Dennie", "Edison", new DateTime(1954, 7, 1), 58105450, "dedison11@toplist.cz"),
                new Pasajero("Colline", "Halse", new DateTime(2003, 7, 6), 59965680, "chalse12@sogou.com"),
                new Pasajero("Cordey", "Frowen", new DateTime(1978, 2, 17), 34754829, "cfrowen13@slashdot.org"),
                new Pasajero("Leela", "Brothwood", new DateTime(1951, 4, 18), 59703340, "lbrothwood14@statcounter.com"),
                new Pasajero("Vittoria", "Sell", new DateTime(1979, 12, 23), 43190989, "vsell15@edublogs.org"),
                new Pasajero("Julita", "Benoi", new DateTime(2001, 3, 25), 86066431, "jbenoi16@google.de"),
                new Pasajero("Caty", "Cantu", new DateTime(1954, 11, 21), 76078095, "ccantu17@hubpages.com"),
                new Pasajero("Maurits", "Pomphrett", new DateTime(1982, 2, 15), 81549644, "mpomphrett18@csmonitor.com"),
                new Pasajero("Alexia", "McCarthy", new DateTime(2005, 12, 4), 84733613, "amccarthy19@google.nl"),
                new Pasajero("Roseanne", "Cubbon", new DateTime(1983, 5, 5), 27896918, "rcubbon1a@macromedia.com"),
                new Pasajero("Dionisio", "Sangar", new DateTime(1974, 4, 3), 95615194, "dsangar1b@utexas.edu"),
                new Pasajero("Ara", "Galero", new DateTime(1972, 9, 5), 35060193, "agalero1c@nasa.gov"),
                new Pasajero("Fernandina", "Joslow", new DateTime(1997, 7, 26), 74230124, "fjoslow1d@multiply.com"),
                new Pasajero("Vivyan", "Groundwator", new DateTime(1960, 3, 2), 67055247, "vgroundwator1e@parallels.com"),
                new Pasajero("Artemas", "Sirett", new DateTime(1991, 3, 7), 59880424, "asirett1f@google.co.uk"),
                new Pasajero("Clovis", "Prendeguest", new DateTime(2010, 11, 30), 18584899, "cprendeguest1g@wikipedia.org"),
                new Pasajero("Ewan", "Stockford", new DateTime(1967, 1, 24), 87341046, "estockford1h@eepurl.com"),
                new Pasajero("Keelia", "Predohl", new DateTime(1998, 7, 3), 49881254, "kpredohl1i@vk.com"),
                new Pasajero("Melissa", "Altham", new DateTime(1951, 10, 28), 33325137, "maltham1j@slate.com"),
                new Pasajero("Marnia", "Strathearn", new DateTime(1974, 1, 29), 76238581, "mstrathearn1k@scientificamerican.com"),
                new Pasajero("Mord", "Standingford", new DateTime(1981, 3, 15), 48937264, "mstandingford1l@usatoday.com"),
                new Pasajero("Kissie", "Risman", new DateTime(1971, 5, 13), 57585487, "krisman1m@elegantthemes.com"),
                new Pasajero("Hilton", "Suttle", new DateTime(1973, 12, 5), 14298190, "hsuttle1n@craigslist.org"),
                new Pasajero("Zaneta", "Boutcher", new DateTime(1986, 10, 15), 61633775, "zboutcher1o@theglobeandmail.com"),
                new Pasajero("Georgetta", "Miner", new DateTime(2009, 12, 9), 13054884, "gminer1p@lulu.com"),
                new Pasajero("Abraham", "Quaife", new DateTime(1954, 6, 11), 24840514, "aquaife1q@scientificamerican.com"),
                new Pasajero("Lesya", "Dolbey", new DateTime(1963, 11, 16), 46096591, "ldolbey1r@amazon.co.jp"),
                new Pasajero("Tatiania", "Beesley", new DateTime(1978, 12, 4), 47443204, "tbeesley1s@xinhuanet.com"),
                new Pasajero("Nikola", "Spaughton", new DateTime(1977, 1, 6), 79039407, "nspaughton1t@amazon.co.jp"),
                new Pasajero("Giorgia", "Kobierski", new DateTime(1999, 9, 27), 91480151, "gkobierski1u@narod.ru"),
                new Pasajero("Cullan", "Really", new DateTime(1972, 11, 16), 27814900, "creally1v@gnu.org"),
                new Pasajero("Vale", "Escale", new DateTime(1972, 5, 15), 91239545, "vescale1w@google.com.au"),
                new Pasajero("Cyndy", "Lunney", new DateTime(1952, 1, 22), 72244803, "clunney1x@reuters.com"),
                new Pasajero("Rikki", "Dolton", new DateTime(1983, 1, 17), 97297346, "rdolton1y@cocolog-nifty.com"),
                new Pasajero("Norton", "Leyborne", new DateTime(1975, 12, 17), 57147138, "nleyborne1z@baidu.com"),
                new Pasajero("Clea", "Hambers", new DateTime(1964, 5, 7), 20791370, "chambers20@so-net.ne.jp"),
                new Pasajero("Felike", "Boyall", new DateTime(1992, 2, 27), 33411722, "fboyall21@scribd.com"),
                new Pasajero("Aurilia", "Ilchuk", new DateTime(1977, 1, 2), 91677545, "ailchuk22@state.tx.us"),
                new Pasajero("Henrie", "Ong", new DateTime(1985,4,30), 49117563, "hong23@marketwatch.com"),
                new Pasajero("Pammie", "Raraty", new DateTime(1995, 7, 11), 35299771, "praraty24@tamu.edu"),
                new Pasajero("Leisha", "Mitskevich", new DateTime(2010, 11, 22), 68985381, "lmitskevich25@sakura.ne.jp"),
                new Pasajero("April", "Wabb", new DateTime(2002, 4, 9), 66134984, "awabb26@sohu.com"),
                new Pasajero("Jens", "Raywood", new DateTime(1978, 9, 8), 36384929, "jraywood27@chron.com"),
                new Pasajero("Jere", "Scrogges", new DateTime(2003, 10, 6), 64698387, "jscrogges28@ed.gov"),
                new Pasajero("Kliment", "Giraudo", new DateTime(1984, 4, 29), 74027287, "kgiraudo29@symantec.com"),
                new Pasajero("Dixie", "Lotte", new DateTime(1958, 2, 1), 38944989, "dlotte2a@netvibes.com"),
                new Pasajero("Hurleigh", "Ruzicka", new DateTime(1972, 2, 6), 14462804, "hruzicka2b@wsj.com"),
                new Pasajero("Connor", "Ashe", new DateTime(1965, 8, 28), 97398906, "cashe2c@tmall.com"),
                new Pasajero("Curtis", "Nurse", new DateTime(1956, 2, 21), 17612973, "cnurse2d@blogger.com"),
                new Pasajero("Rahal", "Shank", new DateTime(1992, 2, 13), 49822289, "rshank2e@europa.eu"),
                new Pasajero("Kelcey", "Vidgeon", new DateTime(1954, 4, 6), 36854868, "kvidgeon2f@networkadvertising.org"),
                new Pasajero("Bevon", "Hundall", new DateTime(1987, 7, 18), 28088090, "bhundall2g@topsy.com"),
                new Pasajero("Denis", "MacVaugh", new DateTime(1987, 10, 13), 96279391, "dmacvaugh2h@utexas.edu"),
                new Pasajero("Jazmin", "Dunstone", new DateTime(1983, 10, 13), 27880896, "jdunstone2i@unesco.org"),
                new Pasajero("Clementine", "Casebourne", new DateTime(1972, 10, 8), 82372158, "ccasebourne2j@amazon.co.uk"),
                new Pasajero("Finn", "Litzmann", new DateTime(1966, 2, 16), 21788675, "flitzmann2k@histats.com"),
                new Pasajero("Alfi", "Gresty", new DateTime(1972, 10, 6), 67763881, "agresty2l@google.fr"),
                new Pasajero("Brier", "Wehner", new DateTime(1967, 3, 17), 60058468, "bwehner2m@whitehouse.gov"),
                new Pasajero("Horst", "Hallows", new DateTime(2009, 10, 23), 61757110, "hhallows2n@independent.co.uk"),
                new Pasajero("Shelby", "Tommen", new DateTime(1997, 10, 16), 48152021, "stommen2o@instagram.com"),
                new Pasajero("Devon", "Forrington", new DateTime(1975, 11, 5), 21556189, "dforrington2p@usatoday.com"),
                new Pasajero("Wrennie", "Scully", new DateTime(1976, 7, 17), 40806491, "woscully2q@examiner.com"),
                new Pasajero("Marietta", "Orum",new DateTime(2004,1,13),28411279, "morum2r@wordpress.com")

            };
        }

        private static void CargarUsuarios()
        {
            usuarios = new List<Usuario>()
            {

                new Usuario("Alejandro","Heidenreich",new DateTime(1995,12,02),55555555,"ale@gmal.com","HeidenreichAlejandro","contraseña123"),
                new Usuario("José","Argento",new DateTime(1955,10,19),11111111,"pepe@gmal.com","pepe","pepe"),
                new Usuario("Lionel","Messi",new DateTime(1987,07,24),10101010,"leo@gmal.com","messi10","scaloneta"),
                new Usuario("Bartolomeo","Simpson",new DateTime(1981,12,13),66666666,"bart@gmal.com","elbarto","aycaramba"),
            };
        }

        private static void AltaRandomDePasajeros()
        {
            Random rnd = new Random();
            int cantidad;
            int index;
            bool completo = true;
            Pasajero altaPasajero;

            foreach (Vuelo item in Sistema.vuelos)
            {
                cantidad = rnd.Next(0, item.Aeronave.CantidadDeAsientosTotales);
                if (completo)
                {
                    cantidad = item.Aeronave.CantidadDeAsientosTotales;
                }
                for (int i = 0; i < cantidad; i++)
                {
                    index = rnd.Next(0, 99);
                    altaPasajero = pasajeros[index];
                    _ = item + altaPasajero;
                }
            }
        }

        public static Usuario VerificarUsuarioContrasenia(string nombreDeUsuario, string contrasenia)
        {
            foreach (Usuario item in usuarios)
            {
                if (item.NombreDeUsuario == nombreDeUsuario && item.VerificarContrasenia(contrasenia))
                {
                    return item;
                }
            }
            return null;    
        }

        public static void AltaDeVuelo(Vuelo vueloAAgregar)
        {
            if (vueloAAgregar is not null)
            {
                vuelos.Add(vueloAAgregar);
            }
        }

        public static void BajaDeVuelo(Vuelo vueloAEliminar)
        {
            if (vueloAEliminar is not null)
            {
                vuelos.Remove(vueloAEliminar);
            }
        }

        public static Aeronave BuscarAeronavePorMatricula(string matricula)
        {
            foreach (Aeronave item in aeronaves)
            {
                if (item.Matricula == matricula)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
