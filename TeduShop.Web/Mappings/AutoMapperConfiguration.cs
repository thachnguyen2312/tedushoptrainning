using AutoMapper;
using System.Collections.Generic;
using TeduShop.Model.Models;
using TeduShop.Web.Models;


namespace TeduShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<DomainToModelMappingProfile>();
                
            });
            Mapper.Map<IEnumerable<Post>>(new List<Post>());
        }
    }
}