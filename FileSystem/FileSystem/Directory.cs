using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystem
{
    class Directory: Entity
    {
        List<Entity> ListOfEntities;
        public Directory(string name, Directory parent) : base(name,parent)
        {
            ListOfEntities = new List<Entity>();
        }
        override public void UpdateLastAccess(DateTime dt)
        {
           
        }    
        public long getSize()
        {

        }
    }
}
