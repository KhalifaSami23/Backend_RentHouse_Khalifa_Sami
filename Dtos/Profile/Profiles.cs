using AutoMapper;
using Backend_RentHouse_Khalifa_Sami.Model;
using Backend_RentHouse_Khalifa_Sami.Model.Property;

namespace Backend_RentHouse_Khalifa_Sami.Dtos
{
    public class Profiles : Profile
    {
        public Profiles(){

            //On Lie le model au DTO, source -> destination
            CreateMap<Contract,ContractDto>();//Lecture
            CreateMap<ContractDto,Contract>();//Ecriture
        }
    }
}