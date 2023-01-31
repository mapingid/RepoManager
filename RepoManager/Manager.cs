using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoManager
{
  
  class Manager
  {
    Dictionary<string, object> MyRepo = new Dictionary<string, object>();
    public void Register( string itemName, object itemContent )
    {
      if( MyRepo.ContainsKey( itemName ) )
      {
        //DELEGATE EVENT
        Console.WriteLine( "itemName already exist" );
      }
      else
      {
        MyRepo.Add( itemName, itemContent );
        //DELEGATE EVENT
        Console.WriteLine( $"Register {itemName}" );
      }
    }
    public object Retrieve( string itemName )
    {
      if( MyRepo.ContainsKey( itemName ) )
      {
        //DELEGATE EVENT
        return MyRepo[itemName];
      }
      else
      {
        //DELEGATE EVENT
        return "Item Not Found";
      }
    }
    public string GetType( string itemName )
    {
      if( MyRepo.ContainsKey( itemName ) )
      {
        //DELEGATE EVENT
        return MyRepo[itemName].GetType().ToString();
      }
      else
      {
        //DELEGATE EVENT
        return "Item Not Found";
      }
    }
    public void Deregister( string itemName )
    {
      if( MyRepo.ContainsKey( itemName ) )
      {
        //DELEGATE EVENT
        Console.WriteLine( $"Deregister {itemName}" );
        MyRepo.Remove( itemName );
      }
      else
      {
        //DELEGATE EVENT
        Console.WriteLine( "Item Not Found" );
      }
    }
  }
}
