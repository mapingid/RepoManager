using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoManager
{
  enum Types
  {
    JSON = 0,
    XML = 1
  }
  interface IManager
  {
    void Register(string itemName, string itemContent, Types itemType);
    string Retrieve(string itemName);
    int GetType(string itemName);
    void Deregister(string itemName);

  }
}
