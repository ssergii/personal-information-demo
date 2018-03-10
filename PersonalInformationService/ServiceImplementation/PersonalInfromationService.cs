using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalInformationService.Messages;
using PersonalInformationService.ServiceContract;
using PersonalInformationService.DataTransferObjects;

namespace PersonalInformationService.ServiceImplementation
{
    public class PersonalInfromationService : IPersonalInfromationService
    {
        public PersonalInformationResponce GetPersonalInformation(PersonalInformationRequest request)
        {
            //request.Id = 1;

            var responce = new PersonalInformationResponce();
            responce.Persons = new List<PersonDto>()
            {
                new PersonDto { Id = request.Id, Name = "Sergii", Surname = "Safatiuk", Gender = GenderDto.Male }
            };

            return responce;
        }
    }
}
