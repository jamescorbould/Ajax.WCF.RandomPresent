using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Ajax.WCF.RandomPresent
{
    [ServiceContract(Namespace = "http://schemas.ajax/randompresentservice")]
    public interface IRandomPresentService
    {
        [OperationContract]
        string ObtainPresent();
    }
}
