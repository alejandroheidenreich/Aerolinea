using System.Collections.Generic;
using System.Security.Cryptography;

namespace Entidades
{
    public static class Data
    {
        public static List<Usuario> usuarios;
        public static List<Aeronave> aeronaves;
        public static List<Pasajero> pasajeros;
        public static int cantidadMaximaDeAereonaves;
        public static List<Vuelo> vuelos;
        public static List<string> destinos;

        static Data()
        {
            usuarios = new List<Usuario>()
            {
                new Usuario("HeidenreichAlejandro","contraseña123"),
                new Usuario("Pepito","asd123"),
                new Usuario("Roberto12","messipasion"),
                new Usuario("jugador73","aguantelarenga")
            };

            destinos = new List<string>()
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

            aeronaves = new List<Aeronave>()
            {
                new Aeronave(20,2,200),
                new Aeronave(15,1,150),
                new Aeronave(50,3,1000),
                new Aeronave(5,1,50),
                new Aeronave(30,2,350),
                new Aeronave(23,1,200),
                new Aeronave(27,2,300)
            };

            pasajeros = new List<Pasajero>()
            {
                new Pasajero("Elset Simononsky", 11927626, 27),
                new Pasajero("Rodolph Harrismith", 43098192, 38),
                new Pasajero("Robinette Alday", 54509138, 93),
                new Pasajero("Bernice Greneham", 27548849, 22),
                new Pasajero("Andriana Debrick", 23304487, 89),
                new Pasajero("Alanah Pepler", 87860936, 63),
                new Pasajero("Kacey Featley", 82538529, 99),
                new Pasajero("Eudora Beamond", 23950561, 84),
                new Pasajero("Sibilla Tomczak", 14191285, 80),
                new Pasajero("Guglielmo Pretswell", 63282101, 46),
                new Pasajero("Chelsea Furby", 20865859, 49),
                new Pasajero("Demetra Nassy", 79682556, 38),
                new Pasajero("Sawyer Antonellini", 18634101, 15),
                new Pasajero("Charlene Paydon", 93452126, 63),
                new Pasajero("Kit Kestin", 35326151, 54),
                new Pasajero("Patricio Morecomb", 29186495, 16),
                new Pasajero("Stephannie Coughlin", 32884723, 93),
                new Pasajero("Judon Callaghan", 58883191, 18),
                new Pasajero("Zabrina Seeler", 16869581, 74),
                new Pasajero("Cybill MacGuigan", 58657390, 64),
                new Pasajero("Jillane Buxcey", 90748554, 85),
                new Pasajero("Ceil Binks", 73507098, 51),
                new Pasajero("Steffane Clinkard", 50340079, 33),
                new Pasajero("Addia MacArthur", 53575301, 86),
                new Pasajero("Lyndsay Beverstock", 87868958, 37),
                new Pasajero("Amandy Ricardon", 78153384, 16),
                new Pasajero("Henrie Dulinty", 75798336, 15),
                new Pasajero("Phineas Falls", 49581557, 37),
                new Pasajero("Gabriella Stockney", 62581297, 77),
                new Pasajero("Amabel Gully", 37749369, 85),
                new Pasajero("Selene Eathorne", 82700086, 25),
                new Pasajero("Alonso Dowling", 42241487, 5),
                new Pasajero("Cirstoforo Sukbhans", 30613532, 79),
                new Pasajero("Brandtr Grindrod", 55886881, 21),
                new Pasajero("Carlie Treher", 18350740, 23),
                new Pasajero("Neel Partener", 49538477, 17),
                new Pasajero("Ingaberg Matusov", 48172175, 59),
                new Pasajero("Talbert Seater", 75426088, 66),
                new Pasajero("Jillana Azam", 80944087, 5),
                new Pasajero("Dela Neumann", 13113609, 36),
                new Pasajero("Berkeley Carayol", 63346816, 53),
                new Pasajero("Wallis Ankrett", 89832634, 18),
                new Pasajero("Mervin Von Gladbach", 37155204, 50),
                new Pasajero("April Overil", 62100343, 80),
                new Pasajero("Holly Chasteau", 42473075, 92),
                new Pasajero("Eden Raleston", 13755990, 99),
                new Pasajero("Conroy Dalbey", 28622455, 44),
                new Pasajero("Kerby Minghi", 35955687, 18),
                new Pasajero("Janene Farryann", 62569295, 6),
                new Pasajero("Haywood Wycliffe", 44060974, 34),
                new Pasajero("Pincas Topham", 41590963, 29),
                new Pasajero("Alysia Grieveson", 72927866, 7),
                new Pasajero("Klara Gathercole", 37060117, 48),
                new Pasajero("Erma Raft", 38426809, 30),
                new Pasajero("Jamaal Yeudall", 58678904, 67),
                new Pasajero("Josias Surphliss", 21820373, 80),
                new Pasajero("Irita Trussell", 20845610, 29),
                new Pasajero("Cullen Blaxeland", 72613670, 67),
                new Pasajero("Blondy Sydes", 69901989, 10),
                new Pasajero("Liliane Bail", 26898811, 45),
                new Pasajero("Tine Holdron", 18114494, 24),
                new Pasajero("Elicia Tinham", 20849445, 39),
                new Pasajero("Elmer Darrach", 29401174, 85),
                new Pasajero("Antonius Feavearyear", 28987647, 15),
                new Pasajero("Ulric Lacknor", 53671139, 49),
                new Pasajero("Zebulon Denholm", 53511553, 70),
                new Pasajero("Welsh Govier", 30020845, 89),
                new Pasajero("Lynna Christou", 82811159, 94),
                new Pasajero("Gasparo Tarr", 53229902, 52),
                new Pasajero("Daphna Revie", 68504921, 24),
                new Pasajero("Felice Kobera", 40986890, 63),
                new Pasajero("Demeter Bonhome", 13456973, 32),
                new Pasajero("Darda Behneke", 57006948, 89),
                new Pasajero("Jillian Stitch", 41939827, 89),
                new Pasajero("Harriot M Chirrie", 39541722, 21),
                new Pasajero("Rubetta Lacheze", 57817910, 91),
                new Pasajero("Elia Aires", 39929762, 59),
                new Pasajero("Rafferty Habeshaw", 88443960, 81),
                new Pasajero("Liuka Lewtey", 55797012, 29),
                new Pasajero("Wallie Cuerdall", 85454730, 9),
                new Pasajero("Mendie Mawditt", 29146817, 70),
                new Pasajero("Antonin Ommanney", 90822556, 67),
                new Pasajero("Jenni MacAlroy", 69932898, 83),
                new Pasajero("Betsey Hedau", 35606520, 43),
                new Pasajero("Kathrine Heymes", 36308212, 42),
                new Pasajero("Catlee Faull", 50535760, 63),
                new Pasajero("Alfred Kellard", 23190262, 16),
                new Pasajero("Brand Simao", 55030265, 54),
                new Pasajero("Yale Priestley", 17856243, 82),
                new Pasajero("Fair Grandin", 36288728, 72),
                new Pasajero("Vidovic Kiernan", 86008207, 36),
                new Pasajero("Iolande Gorke", 90391991, 9),
                new Pasajero("Jodie Hundal", 64842255, 7),
                new Pasajero("Reagen Neles", 22230279, 65),
                new Pasajero("Karin Tarply", 86312119, 66),
                new Pasajero("Marylou Andersen", 42430669, 42),
                new Pasajero("Henrietta Elcott", 61773618, 54),
                new Pasajero("Ynes Waszczyk", 11315628, 89),
                new Pasajero("Jillayne Kyberd", 93360395, 18),
                new Pasajero("Izak Bensen", 45334266, 36)
            };

            vuelos = new List<Vuelo>()
            {
                new Vuelo(2,aeronaves[5],destinos[4]),
                new Vuelo(19,aeronaves[3],destinos[18]),
                new Vuelo(1,aeronaves[5],destinos[12]),
                new Vuelo(4,aeronaves[5],destinos[15]),
                new Vuelo(15,aeronaves[0],destinos[1]),
                new Vuelo(3,aeronaves[2],destinos[6]),
                new Vuelo(1,aeronaves[3],destinos[4]),
                new Vuelo(12,aeronaves[5],destinos[8]),
                new Vuelo(5,aeronaves[4],destinos[4])
            };
        }
    }
}
