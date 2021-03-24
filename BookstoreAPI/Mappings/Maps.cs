using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookstoreAPI.Data;
using BookstoreAPI.DTOs;

namespace BookstoreAPI.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<Book, BookDTO>().ReverseMap();
        }
    }
}
