using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoManager
{
  class DelegateClass1
  {
    public DelegateClass1()
    {
      Manager.AddDelegate( OnRegister );
    }
    public static void OnRegister( string text )
    {
      Console.WriteLine( "DelegateClass1 : " + text );
    }

    //bikin dispose untuk clear delegate
  }
  class DelegateClass2
  {
    public DelegateClass2()
    {
      Manager.AddDelegate( OnRegister );
    }
    public static void OnRegister( string text )
    {
      Console.WriteLine( "DelegateClass2 : " + text );
    }
  }
  class DelegateClass3
  {
    public DelegateClass3()
    {
      Manager.AddDelegate( OnRegister );
    }
    public static void OnRegister( string text )
    {
      Console.WriteLine( "DelegateClass3 : " + text );
    }
  }

  /*
  class EventClass1
  {
    public EventClass1()
    {
      Manager.AddEvent(getNotif);
    }

    void Clear()
    {
      Manager.eventNotify += getNotif;
    }

    public static void getNotif( string text )
    {
      Console.WriteLine( "EventClass1 : " + text );
    }
  }
  class EventClass2
  {
    public static void getNotif( string text )
    {
      Console.WriteLine( "EventClass2 : " + text );
    }
  }
  class EventClass3
  {
    public static void getNotif( string text )
    {
      Console.WriteLine( "EventClass3 : " + text );
    }
  }
*/
}
