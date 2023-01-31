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
    //DELEGATE
    Dictionary<string, object> MyRepo = new Dictionary<string, object>();
    DelegateNotify OnDelegateNotify;
    DelegateNotify AddDelegateSubs(ref DelegateNotify delegateNotify )
    {
      delegateNotify += DelegateClass1.getNotif;
      delegateNotify += DelegateClass2.getNotif;
      delegateNotify += DelegateClass3.getNotif;
      return delegateNotify;
    }
    DelegateNotify ClearDelegateSubs( ref DelegateNotify delegateNotify )
    {
      delegateNotify = null;
      return delegateNotify;
    }

    //EVENT
    event DelegateNotify OnEventNotify;
    DelegateNotify AddEventSubs( ref DelegateNotify delegateNotify )
    {
      delegateNotify += EventClass1.getNotif;
      delegateNotify += EventClass2.getNotif;
      delegateNotify += EventClass3.getNotif;
      return delegateNotify;
    }
    DelegateNotify ClearEventSubs( ref DelegateNotify delegateNotify )
    {
      delegateNotify = null;
      return delegateNotify;
    }


    public void Register( string itemName, object itemContent )
    {
      AddDelegateSubs( ref OnDelegateNotify );
      AddEventSubs( ref OnEventNotify );
       
      if( MyRepo.ContainsKey( itemName ) )
      {
        OnDelegateNotify( $"{itemName} already Exist " );
        OnEventNotify( $"{itemName} already Exist " );
      }
      else
      {
        MyRepo.Add( itemName, itemContent );
        OnDelegateNotify( $"Register {itemName}" );
        OnEventNotify( $"Register {itemName}" );
      }
      ClearDelegateSubs( ref OnDelegateNotify );
      ClearEventSubs( ref OnEventNotify );
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
      AddDelegateSubs( ref OnDelegateNotify );

      if( MyRepo.ContainsKey( itemName ) )
      {
        //DELEGATE EVENT
        //Console.WriteLine( $"Deregister {itemName}" );
        OnDelegateNotify( $"Deregister {itemName}" );
        MyRepo.Remove( itemName );
      }
      else
      {
        //DELEGATE EVENT
        OnDelegateNotify( $"{itemName} Not Found" );
        Console.WriteLine( "Item Not Found" );
      }

      ClearDelegateSubs( ref OnDelegateNotify );
    }
  }
}
