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
      Manager Repository = new Manager();
            
      Repository.Register( "NameA", "Content A", Types.XML );
      Repository.Register( "NameB", "Content B", Types.JSON );
      Repository.Register( "NameC", "Content C", Types.XML );

      Console.WriteLine( Repository.Retrieve( "NameB" ) );
      Console.WriteLine( Repository.GetType( "NameB" ) );

      Repository.Deregister( "NameB" );

      Console.WriteLine( Repository.Retrieve( "NameB" ) );
      Console.WriteLine( Repository.GetType( "NameB" ) );
      Repository.Deregister( "NameB" );

      Repository.Register( "NameA", "Content A", Types.JSON );
      Repository.Register( "NameB", "Content B", Types.JSON );

      Console.WriteLine( Repository.Retrieve( "NameB" ) );

      Console.Read();
    }
  }
}
