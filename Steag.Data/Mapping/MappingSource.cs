using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steag.Data.Mapping
{
    public class MappingSource: IMappingSource
    {
        internal System.Data.Linq.Mapping.MappingSource DataContextMappingSource { get; set; }

        public string MappingSourceFile { get; protected set; }

        public MappingSource(string xmlMappingFile)
        {
            MappingSourceFile = xmlMappingFile;    
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                MappingSourceFile = null;
            }
        }
    }
}
