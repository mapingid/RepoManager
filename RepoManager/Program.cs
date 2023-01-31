using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoManager
{

  class Program
  {

    static void Main( string[] args )
    {
      string jsonDummy = @"{'name':'Popeye','age':'20'}";
      string xmlDummy = "<name> Popeye </name> <age> 20 </age> ";
      int intDummy = 7;
      double doubleDummy = 3.7;

      Manager Repository = new Manager();

      Repository.Register( "NameA", xmlDummy );
      Repository.Register( "NameB", intDummy );

      Console.Read();

    }
  }
}
