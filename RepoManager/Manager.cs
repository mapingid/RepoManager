using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoManager
{
  class Manager : IManager
  {
    List<Repo> LRepo = new List<Repo>();

    bool ValidationCheck( string itemName, string itemContent, Types itemType )
    {
      foreach( Repo r in LRepo )
      {
        if( itemName == r.name )
        {
          return true;
        }
      }
      return false;
    }

    public void Register( string itemName, string itemContent, Types itemType )
    {
      bool nameCheck = ValidationCheck( itemName, itemContent, itemType );
      if( !nameCheck )
      {
        Console.WriteLine( $"Create {itemName} in {itemType} types" );
        LRepo.Add( new Repo() { name = itemName, content = itemContent, type = (int)itemType } );
      }
      else
      {
        Console.WriteLine( $"Item Name : {itemName} already exist" );
      }
    }

    public string Retrieve( string itemName )
    {
      foreach( Repo r in LRepo )
      {
        if( itemName == r.name )
        {
          return r.content;
        }
      }
      return "Not Found";
    }

    public int GetType( string itemName )
    {
      foreach( Repo r in LRepo )
      {
        if( itemName == r.name )
        {
          return r.type;
        }
      }
      return -1;
    }

    public void Deregister( string itemName )
    {
      foreach( Repo r in LRepo )
      {
        if( itemName == r.name )
        {
          LRepo.Remove( r );
          return;
        }
      }
      Console.WriteLine( "Not Found" );
    }



  }
}
