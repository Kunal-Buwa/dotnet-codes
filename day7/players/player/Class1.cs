namespace Player;
using System.Collections;
using System.Collections.Generic;
public class Class1:IComparable
{
private string name;
  private int age;
  private int matches;
  private int runs;

  public Class1(string name,int age,int matches ,int runs)
  {
    this.name=name;
    this.age=age;
    this.matches=matches;
    this.runs =runs;

  }
  public int CompareTo(object? obj)
  {
    players anotherplayer = (players) obj;

    if(this.runs > anotherplayer.runs)
    {
        return 1;
    }
    else if(this.runs < anotherplayer.runs)
    {
        return -1;
    }
    else {
    return 0;
    }
  }
}
