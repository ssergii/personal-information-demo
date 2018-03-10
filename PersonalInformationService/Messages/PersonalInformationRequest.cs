using System.Runtime.Serialization;

namespace PersonalInformationService.Messages
{
    [DataContract]
    public class PersonalInformationRequest
    {
        [DataMember]
        public int Id { get; set; }
    }
}
