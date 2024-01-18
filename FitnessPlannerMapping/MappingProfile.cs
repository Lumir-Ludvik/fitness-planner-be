using AutoMapper;
using FitnessPlannerMapping.ModelDTOs;
using FitnessPlannerRepository.Entities;


namespace FitnessPlannerMapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            //TODO: add day enum and reverse maps
            CreateMap<ModuleEntity, ModuleDTO>()
                .ForMember(dest => dest.Day, opt => opt.Ignore());


            CreateMap<CalendarEntity, CalendarDTO>()
                .ForMember(dest => dest.Monday, opt=> opt.MapFrom(src => MapCalendarEntity(src.Monday.Modules, Days.Monday)))
                .ForMember(dest => dest.Tuesday, opt=> opt.MapFrom(src => MapCalendarEntity(src.Tuesday.Modules, Days.Tuesday)))
                .ForMember(dest => dest.Wednesday, opt=> opt.MapFrom(src => MapCalendarEntity(src.Wednesday.Modules, Days.Wednesday)))
                .ForMember(dest => dest.Thursday, opt=> opt.MapFrom(src => MapCalendarEntity(src.Thursday.Modules, Days.Thursday)))
                .ForMember(dest => dest.Friday, opt=> opt.MapFrom(src => MapCalendarEntity(src.Friday.Modules, Days.Friday)))
                .ForMember(dest => dest.Saturday, opt=> opt.MapFrom(src => MapCalendarEntity(src.Saturday.Modules, Days.Saturday)))
                .ForMember(dest => dest.Sunday, opt=> opt.MapFrom(src => MapCalendarEntity(src.Sunday.Modules, Days.Sunday)));


        }



        private IEnumerable<ModuleDTO> MapCalendarEntity(IEnumerable<ModuleEntity>? src, Days day)
        {
            var modules = new List<ModuleDTO>();

            if(src is null)
            {
                return modules;
            }
                


            foreach (var item in src)
            {
                modules.Add(new ModuleDTO
                {
                    Text = item.Text,
                    Title = item.Title,
                    Base64Img = item.Base64Img,
                    ContentType = item.ContentType,
                    Filename = item.Filename,
                    Day = day

                });
            }


            return modules.AsEnumerable();
        }
    }
}
