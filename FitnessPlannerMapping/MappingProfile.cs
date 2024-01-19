using AutoMapper;
using FitnessPlannerMapping.ModelDTOs;
using FitnessPlannerRepository.Entities;
using FitnessPlannerRepository.Entities.WeekDays;
using System.Collections.ObjectModel;


namespace FitnessPlannerMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //TODO: add day enum and reverse maps
            CreateMap<ModuleEntity, ModuleDTO>()
                .ForMember(dest => dest.Day, opt => opt.Ignore());


            CreateMap<CalendarEntity, CalendarDTO>()
                .ForMember(dest => dest.Monday, opt => opt.MapFrom(src => MapCalendarEntity(src.Monday.Modules, Days.Monday)))
                .ForMember(dest => dest.Tuesday, opt => opt.MapFrom(src => MapCalendarEntity(src.Tuesday.Modules, Days.Tuesday)))
                .ForMember(dest => dest.Wednesday, opt => opt.MapFrom(src => MapCalendarEntity(src.Wednesday.Modules, Days.Wednesday)))
                .ForMember(dest => dest.Thursday, opt => opt.MapFrom(src => MapCalendarEntity(src.Thursday.Modules, Days.Thursday)))
                .ForMember(dest => dest.Friday, opt => opt.MapFrom(src => MapCalendarEntity(src.Friday.Modules, Days.Friday)))
                .ForMember(dest => dest.Saturday, opt => opt.MapFrom(src => MapCalendarEntity(src.Saturday.Modules, Days.Saturday)))
                .ForMember(dest => dest.Sunday, opt => opt.MapFrom(src => MapCalendarEntity(src.Sunday.Modules, Days.Sunday)));


            CreateMap<CalendarDTO, CalendarEntity>()
                .ForMember(dest => dest.Monday, opt => opt.MapFrom(src => new MondayEntity
                {
                    Modules = src.Monday.Select(x => new ModuleEntity
                    {
                        Title = x.Title,
                        Text = x.Text,
                        Filename = x.Filename,
                        Base64Img = x.Base64Img,
                        ContentType = x.ContentType,
                    }).ToList()
                }))
                 .ForMember(dest => dest.Monday, opt => opt.MapFrom(src => new MondayEntity
                 {
                     Modules = src.Monday.Select(x => new ModuleEntity
                     {
                         Title = x.Title,
                         Text = x.Text,
                         Filename = x.Filename,
                         Base64Img = x.Base64Img,
                         ContentType = x.ContentType,
                     }).ToList()
                 }))
                  .ForMember(dest => dest.Monday, opt => opt.MapFrom(src => new TuesdayEntity
                  {
                      Modules = src.Monday.Select(x => new ModuleEntity
                      {
                          Title = x.Title,
                          Text = x.Text,
                          Filename = x.Filename,
                          Base64Img = x.Base64Img,
                          ContentType = x.ContentType,
                      }).ToList()
                  }))
                   .ForMember(dest => dest.Monday, opt => opt.MapFrom(src => new WednesdayEntity
                   {
                       Modules = src.Monday.Select(x => new ModuleEntity
                       {
                           Title = x.Title,
                           Text = x.Text,
                           Filename = x.Filename,
                           Base64Img = x.Base64Img,
                           ContentType = x.ContentType,
                       }).ToList()
                   }))
                    .ForMember(dest => dest.Monday, opt => opt.MapFrom(src => new ThursdayEntity
                    {
                        Modules = src.Monday.Select(x => new ModuleEntity
                        {
                            Title = x.Title,
                            Text = x.Text,
                            Filename = x.Filename,
                            Base64Img = x.Base64Img,
                            ContentType = x.ContentType,
                        }).ToList()
                    }))
                     .ForMember(dest => dest.Monday, opt => opt.MapFrom(src => new FridayEntity
                     {
                         Modules = src.Monday.Select(x => new ModuleEntity
                         {
                             Title = x.Title,
                             Text = x.Text,
                             Filename = x.Filename,
                             Base64Img = x.Base64Img,
                             ContentType = x.ContentType,
                         }).ToList()
                     }))
                      .ForMember(dest => dest.Monday, opt => opt.MapFrom(src => new SaturdayEntity
                      {
                          Modules = src.Monday.Select(x => new ModuleEntity
                          {
                              Title = x.Title,
                              Text = x.Text,
                              Filename = x.Filename,
                              Base64Img = x.Base64Img,
                              ContentType = x.ContentType,
                          }).ToList()
                      }))
                    .ForMember(dest => dest.Monday, opt => opt.MapFrom(src => new SundayEntity
                    {
                        Modules = src.Monday.Select(x => new ModuleEntity
                        {
                            Title = x.Title,
                            Text = x.Text,
                            Filename = x.Filename,
                            Base64Img = x.Base64Img,
                            ContentType = x.ContentType,
                        }).ToList()
                    }));

        }



        private IEnumerable<ModuleDTO> MapCalendarEntity(IEnumerable<ModuleEntity>? src, Days day)
        {
            var modules = new Collection<ModuleDTO>();

            if (src is null)
            {
                return Enumerable.Empty<ModuleDTO>();
            }

            return src.Select(item => new ModuleDTO()
            {
                Text = item.Text,
                Title = item.Title,
                Base64Img = item.Base64Img,
                ContentType = item.ContentType,
                Filename = item.Filename,
                Day = day
            });

        }
    }
}
