using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystem
{
    abstract class Entity
    {
        protected string Name;
        protected long Size;
        protected DateTime LastAccess;
        protected DateTime CreatedAt;
        protected DateTime lastUpdatedAt;
        protected Directory Parent;
        protected Entity(string name,Directory parent)
        {
            this.Name = name;
            this.Size = 0;
            this.LastAccess = DateTime.Now;
            this.CreatedAt = DateTime.Now;
            this.lastUpdatedAt = DateTime.Now;
            this.Parent = parent;

        }
        protected void UpdateLastAccess()
        {
            LastAccess = DateTime.Now;
        }
        protected void UpdatelastUpdatedAt()
        {
            lastUpdatedAt = DateTime.Now;
        }

    }
}
