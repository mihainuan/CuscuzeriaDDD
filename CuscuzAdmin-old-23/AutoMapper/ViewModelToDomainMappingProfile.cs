using AutoMapper;
using CuscuzAdmin.Models;
using Cuscuzeria.Domain.Entities;

namespace CuscuzeriaDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected void InitializeMapper()
        {
            Mapper.Initialize(config: cfg =>
            {
                cfg.CreateMap<Order, OrderViewModel>();
                cfg.CreateMap<User, UserViewModel>();
            });
        }
    }
}