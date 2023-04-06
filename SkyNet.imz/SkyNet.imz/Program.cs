using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace SkyNet.imz
{
    public partial class Program
    {



    static void Main(string[] args)
        {
            while (Menu()) ;
        }

    static void espaceador()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");

        }
        static void skyNetIMZrojo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
  ______   _______       _        ______ _____  _____   ____  _____    
 |  ____/\|__   __|/\   | |      |  ____|  __ \|  __ \ / __ \|  __ \ _ 
 | |__ /  \  | |  /  \  | |      | |__  | |__) | |__) | |  | | |__) (_)
 |  __/ /\ \ | | / /\ \ | |      |  __| |  _  /|  _  /| |  | |  _  /   
 | | / ____ \| |/ ____ \| |____  | |____| | \ \| | \ \| |__| | | \ \ _ 
 |_|/_/    \_\_/_/    \_\______| |______|_|  \_\_|  \_\\____/|_|  \_(_)                                                                      
");
            Console.ResetColor();


        }

        static void skyNetIMZ() 
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("   ______ ____  ___  ____________      _                          _ ____        __\r\n  / __/ //_/\\ \\/ / |/ / __/_  __/     (_)_ _  ___   _  _____ ____(_) _(_)__ ___/ /\r\n _\\ \\/ ,<    \\  /    / _/  / /   _   / /  ' \\/_ /  | |/ / -_) __/ / _/ / -_) _  / \r\n/___/_/|_|   /_/_/|_/___/ /_/   (_) /_/_/_/_//__/  |___/\\__/_/ /_/_//_/\\__/\\_,_/  \r\n                                                                                  ");
            Console.ResetColor();
            

        }
        static void destruirskyeNetIMZ()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed; 
            Console.Clear();
            Console.WindowHeight = 60;
            Console.WindowWidth = 106;
            

            skyNetIMZrojo();
            
            Console.BackgroundColor = ConsoleColor.DarkRed;
            espaceador();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNKkl,.......................'cxKNWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMWKkdl:,...,:lloddllcccllllodxkxxdo:...,:cox0NMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMNkl,.......;xkOkkkkxxxxxxxxxxkkkOOOOd;.'...  .c0WMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMWKo'..;ldkOOo:;,,,;;;;;,''',;:ccccccc::cxOOkxl,. .oKWMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMNx;...oO000000OkxxkkkkOk:....'d0000OOkkO0000000Ol.  ,xNMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMNkc..':lllx00000000000000Oc    .d000000000000000Oocc;. .:ONMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMNk:...:k00Ol;d00Oxx000000000klcccoO000000000xdO00Oc,d00x,  .cOWMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMKl....;k0000o.cO00kk0000000000000000000000000kkO00k''x000l..  .dXMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMXo'  ;:cO0000o.;O0000000000000000000000000000000000d.'x000o,,.  .dNMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWk;. 'dclO0000o.'k0000000000000000000000000000000000l.'k000x;:c.  'OMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMNd'..okco00000d..d00OkO00000000000000000000000Okk00O: 'k000O::d;  .xMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMKl..l0xlx00000d..o00kxO00000000000000000000000Odx00O; 'k0000l:xk; .dWMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMKc.;k0olO00000d..l000000000000000000000000000000000x' ,k0000d;oOo..dWMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMKl'cOklcdO00K0d. :O00000000000000000000000000000000d. ,k000kc,cxo..dMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMKl'ckodxlkOkO0x. ;O00000000000000000000000000000000o. ,kOxOk:ccll..xMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMO:'lkooodOOxdxo. ,k0000000Oxk00000K00000xxO00000000l  ,dolk0d:;cl..xMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMk;'oOoclk000l..  'x0000000kcck000000000kcck00000000:   ..d00k:'lo..xMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMk,,oOl';loddc.   .x0000000kl,',,;;::::::cdO0000K00O;    .oxdc'.:l..dMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMO;,dk;'cc:;.      ,cloddoc..,clooooooddoc;:okOOkxd:.     .':cc,.;..dWMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMM0:'oO::O00Oxl:,'..     ...;odoolllllllooxxo::;...   ...,;cxOO0o;:..xMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMKc.cOl:d:,:ldxkkkkdol:;:dOklcoddxxxxxxdoclO0ko:;clodxxxxol:,;xo::..OMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMKl.:kl:l.   ...';:cloodxxo;:k00Ol,,;d000d,;dxxdoll:;,'...   .ol;' ;KMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMNo.,o::l.              .. ..;x0d.   ,kOo'   ..              .lo'  :NMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMNd'.'.;c.   ..      ...   ..,x0l.   .dkc.     ..       ..   .od.  :NMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWx'..:;cl.  ..       .  .,'.:OO:     l0O; ... ..       ..  .cxc'. ,0MMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWx'.'do:dko;'.......';:c:..;lll'     ,dl,. ,::;'..    ...,lkOo;l; .OMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMk;..lOdloddooddol:,;;'.':dO0x,       ,dko,...,;,',::::cdkxdccdx' ,KMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMM0:. .oOOkxxxkkdlc;',;cdk0000Oc..'''..:O00Odc,.. .,lxOkdoooodkx;  lNMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMXl. .cok000xllodkOOOO0000000x:cxdodd::x000000kxdolcccldO00Oxl:. .xWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMWO;..,cdk00klldoc:::ccdO000kc;co' ,oc;lk000Odcc::lxko;lO00xc;,..cXMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMWKd;. ..,ll;..,:lxOkdllokxc;;ol. .ol,'ckkolldxdl;'''cddl;'. .;kNMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMNk;.  ;,  .:dO00000kdl,..,d:   co. .;ldk00000kc. .,,   .l0WMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMNo...cl.    'lk00000Oxc,cd'   ;x:,cxO00000Ol'.   ::   ,KMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMWx''lxx,      ;k0000OkOOOkc,',lOOOkkO0000x;     .od,  cNMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMWx,'o0O: .::.  c000000000000O00000000000O:  .:' 'x0c  lWMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMO;'c00l. ;kl. .:odkO00000000000000OOkxd:. 'dd. :OO;  dWMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMKc.:k0x' .lo;..;:::;;::;,,;::::;;;;;;:;. .;o; .o0x' .OMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMNd''d00l. ;d:..;lxkdddooollclddoododkxo,..:l. :O0l. :XMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMKc.:k0Oc..lc..cloolloddddl:ldddol;:llc,.'l:.,x0x' 'OMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMW0;.:k0Ol.':.'lllldddxlcoc,cl:cooolcol:.';.,x0x, 'OWMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMW0c.;x0Ol.',:kOxooollcclc:cl::cclooxOo;,.,xOd' ,OWMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMXd.'oOO:..ldldO00OOOOkkkkkOOkkO0kldkl..dOl. ;0MMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMWk,.lOx:cxc..oO0Oxk0000000kx00k; 'do,lkc..cXMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMWO,.:kO0k;  .d0Ollk00000xcoOk;  .oOOkc..oNMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMW0;.;x00x:. :O0kclO000kclO0o. .lO0k:..oNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXd'.cxOOo':O00d:clll:lk00o';xOkl'.'xNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKo,';lkkkO000OkxxxkO000Oxxd:...oXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXkc'';okO00Odc;cx000Od:...:xKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd;..,:clc:::clc:'..;kXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNkc.. ..........,dNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
            espaceador();
        }
        
    static bool Menu()
        {
            Console.Clear();
            skyNetIMZ();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("─────────────────────────────────────────────────────");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"                        MENU");
            Console.ResetColor();

            bool continuar = true;
            
            Console.WriteLine("1. Ingresar Eliminador");
            Console.WriteLine("2. Mostrar Eliminador");
            Console.WriteLine("3. Buscar Eliminador");
            Console.WriteLine("0. Destruir SkyNet");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("─────────────────────────────────────────────────────");
            Console.ResetColor();
            switch (Console.ReadLine().Trim())

            {
                case "1":
                    IngresarEliminador();
                    break;
                case "2":
                    MostrarEliminador();
                    break;
                case "3":
                    BuscarEliminador();
                    break;
                case "0":
                    Console.Clear();

                    destruirskyeNetIMZ();
                    Thread.Sleep(600);
                    continuar = false;
                    break;
                default:
                    Console.Clear();
                    break;
            }

            return continuar;
        }
    }
}
