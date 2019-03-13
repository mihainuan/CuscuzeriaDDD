using AutoMapper;
using Cuscuzeria.Domain.Entities;
using CuscuzeriaDDD.MVC.ViewlModels;

namespace CuscuzeriaDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected void InitializeMapper()
        {
            Mapper.Initialize(config: cfg =>
            {
                cfg.CreateMap<OrderViewModel, Order>();
                cfg.CreateMap<UserViewModel, User>();
            });
        }
    }
}