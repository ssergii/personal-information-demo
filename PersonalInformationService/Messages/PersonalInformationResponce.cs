using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using PersonalInformationService.DataTransferObjects;

namespace PersonalInformationService.Messages
{
    [DataContract]
    public class PersonalInformationResponce
    {
        [DataMember]
        public IEnumerable<PersonDto> Persons { get; set; }
    }
}
