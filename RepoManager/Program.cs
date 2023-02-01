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
      DelegateClass1 a = new DelegateClass1();
      DelegateClass2 b = new DelegateClass2();
      DelegateClass3 c = new DelegateClass3();


      Repository.Register( "NameA", xmlDummy );
      Repository.Register( "NameB", intDummy );
      Repository.Register( "NameB", jsonDummy );

      Console.Read();

    }
  }
}
