using System.Runtime.Serialization;

namespace PersonalInformationService.DataTransferObjects
{
    [DataContract(Name = "Person", Namespace = "PersonalInformationService")]
    public class PersonDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public GenderDto Gender { get; set; }
    }

    [DataContract(Name = "Gender", Namespace = "PersonalInformationService")]
    public enum GenderDto
    {
        [EnumMember]
        Female,
        [EnumMember]
        Male
    }
}
