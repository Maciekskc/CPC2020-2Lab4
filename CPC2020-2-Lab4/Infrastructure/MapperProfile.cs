using AutoMapper;
using CPC2020_2_Lab4.Models.Entities;
using CPC2020_2_Lab4.ViewModels;

namespace CPC2020_2_Lab4.Infrastructure
{
    public class MapperProfile : Profile
    {
        /// <summary>
        /// Klasa z profilem mapowania, zawier konfiguracje map
        /// </summary>
        public MapperProfile()
        {
            //mapa dla pproszczonnego modelu książki która jest tylko okrojeniem klasy 'book'
            CreateMap<Book, BookSimpleViewModel>();


            //bardziej złożona mapa na wiew model książki tlumacząca skąd mają być pobierane dane do nowych zmiennych
            CreateMap<Book, BookViewModel>()
                .ForMember(b => b.AuthorFirstName, opt => opt.MapFrom(src => src.Author.FirstName))
                .ForMember(b => b.AuthorLastName, opt => opt.MapFrom(src => src.Author.LastName))
                .ForMember(b => b.Genre, opt => opt.MapFrom(src => src.Genre.Name));
            //budowa
                //.ForMember(ktora zmienna chcemy przypisać, skąd chcemy ją pobrać)
                //zby zmmapować z obiektu który jest mapowany należy zastosować taki zabieg w drugim parametrze jak wyżej
                //options=>options.MapFrom(source=>source.<to co chcemy z obiektu źródłowego>)
        }
    }
}
