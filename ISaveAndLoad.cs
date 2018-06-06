using System;
using System.Collections.Generic;
using System.Text;

namespace XPost.Dependencies
{
    public interface ISaveAndLoad
    {
        void SaveText(string filename, string text);
        string LoadText(string filename);
    }
}
