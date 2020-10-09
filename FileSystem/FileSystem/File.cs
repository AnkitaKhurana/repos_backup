using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystem
{
    class File :Entity
    {
        string Content;
        Directory Parent;
        public File(string name, Directory parent):base(name,parent)
        {
            this.Name = name;          
            this.Parent = parent;
        }
        void SetContent(string contents, int newSize)
        {
            this.Content = contents;
            this.Size = newSize;
        }
        string GetContents()
        {
            return Content;
        }
        //override public void UpdateLastAccess(DateTime dt)
        //{

        //}
    }
}
