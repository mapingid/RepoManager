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
      Repository.Register( "NameA", jsonDummy );
      Repository.Register( "NameB", intDummy );
      Repository.Register( "NameC", doubleDummy );

      Console.WriteLine( Repository.Retrieve( "NameC" ) );
      Console.WriteLine( Repository.GetType( "NameC" ) );

      Repository.Deregister( "NameA" );
      Console.WriteLine( Repository.Retrieve( "NameA" ) );







      /*
      Repository.Register( "NameA", xmlDummy, Types.XML ); // itemName itemContent<T>
      Repository.Register( "NameB", jsonDummy, Types.JSON );
      Repository.Register( "NameC", xmlDummy, Types.XML );

      Console.WriteLine( Repository.Retrieve( "NameB" ) ); //
      Console.WriteLine( Repository.GetType( "NameB" ) );

      Repository.Deregister( "NameB" );

      Console.WriteLine( Repository.Retrieve( "NameB" ) );
      Console.WriteLine( Repository.GetType( "NameB" ) );
      Repository.Deregister( "NameB" );

      Repository.Register( "NameA", jsonDummy, Types.JSON );
      Repository.Register( "NameB", xmlDummy, Types.XML );

      Console.WriteLine( Repository.Retrieve( "NameB" ) );
      */
      Console.Read();
     
  }
  }
}
