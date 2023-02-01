using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoManager
{
  delegate void DelegateNotify( string text );

  class Manager
  {
    Dictionary<string, object> MyRepo = new Dictionary<string, object>();

    //DELEGATE
    static event DelegateNotify delegateNotify;
    public static void AddDelegate ( DelegateNotify d )
    {
      delegateNotify += d;
    }
    protected virtual void OnNotify( string text)
    {
      delegateNotify?.Invoke(text);
    }

    public void Register( string itemName, object itemContent )
    {
      if( MyRepo.ContainsKey( itemName ) )
      {
        OnNotify( $"{itemName} already Exist " );
      }
      else
      {
        MyRepo.Add( itemName, itemContent );
        OnNotify( $"Register {itemName}" );
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
        return MyRepo[itemName].GetType().ToString();
      }
      else
      {
        return "Item Not Found";
      }
    }
    public void Deregister( string itemName )
    {

      if( MyRepo.ContainsKey( itemName ) )
      {
        MyRepo.Remove( itemName );
      }
      else
      {
        Console.WriteLine( "Item Not Found" );
      }
    }
  }
}