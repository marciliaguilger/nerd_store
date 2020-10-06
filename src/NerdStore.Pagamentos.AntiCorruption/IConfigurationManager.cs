using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Pagamentos.AntiCorruption
{
    public interface IConfigurationManager
    {
        string GetValue(string node);
    }
}
