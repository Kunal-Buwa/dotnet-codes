using Player;
using System.Collections.Generic;



Class1 p1 = new Class1("vk",45,77,7000);
Class1 p2 = new Class1("Dk",58,97,98000);
Class1 p3 = new Class1("RS",59,88,87000);
Class1 p4 = new Class1("RP",59,55,84000);

List<player> indianplayer=new List<player>();

indianplayer.Add(p1);
indianplayer.Add(p2);
indianplayer.Add(p3);
indianplayer.Add(p4);

foreach (Class1 x in indianplayer)
{
    Console.WriteLine(x);
}