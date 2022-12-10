using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    /*1.-IShootable adlı interface yaradin icinde Shoot deye metodunuz olsun. -Weapon adlı class yaradın
       içərisində Name fieldi ve Label metodu olsun.Label metodu weapon-un adını(Name) consola yazacaq 
       məsələn “This is X!”--Gun classi yaradin hansi ki Wapon classindan torensin və Name fieldi -i bərabər
       olsun “Gun”.Shoot metodun implement edib ekrana mesaj cixarsin.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Label("XXXX");
            Console.WriteLine(gun);
            Console.ReadLine();
            

        }
    } 

}
