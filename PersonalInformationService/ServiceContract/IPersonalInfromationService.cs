using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalInformationService.Messages;
using System.ServiceModel;

namespace PersonalInformationService.ServiceContract
{
    [ServiceContract]
    public interface IPersonalInfromationService
    {
        [OperationContract]
        PersonalInformationResponce GetPersonalInformation(PersonalInformationRequest request);
    }
}
