using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2SToken
{
    public class TokenHistory
    {
        public List<GenerateInfo> History { get; set; }
    }

    public class GenerateInfo
    {
        public string Alias { get; set; }

        public string ClientId { get; set; }
        
        public string ClientSecret { get; set; }
        
        public string ResourceId { get; set; }

        public string Authority { get; set; }
    }
}
