using System.Collections.Generic;

namespace AperamTest.Controllers
{
    public abstract class BaseController
    {
        public virtual List<string> AcoesProduto { get; set; }
        public virtual Dictionary<string, string> InformacoesProduto { get; set; }
    }
}