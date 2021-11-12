using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kurochkin.SampleFacts.Web.Data;
using Kurochkin.SampleFacts.Web.Infrastructure.Mappers.Base;
using Kurochkin.SampleFacts.Web.ViewModels;
using Calabonga.UnitOfWork;

namespace Kurochkin.SampleFacts.Web.Infrastructure.Mappers
{
    public class TagMapperConfiguration : MapperConfigurationBase
    {
        public TagMapperConfiguration()
        {
            CreateMap<Tag, TagViewModel>();
            CreateMap<Tag, TagUpdateViewModel>();
            CreateMap<TagUpdateViewModel, Tag>()
                .ForMember(x => x.Id, o => o.Ignore())
                .ForMember(x => x.Facts, o => o.Ignore());
        }
    }
}
