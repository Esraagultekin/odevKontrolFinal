﻿using AutoMapper;
using Internet_1.Models;
using Internet_1.ViewModels;

namespace Internet_1.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Homework, HomeworkModel>().ReverseMap();
           // CreateMap<Student, StudentModel>().ReverseMap();
            CreateMap<Category, CategoryModel>().ReverseMap();
            CreateMap<AppUser, UserModel>().ReverseMap();
            CreateMap<AppUser, RegisterModel>().ReverseMap();
            
            CreateMap<Tosubmit, TosubmitModel>().ReverseMap();
        }
    }
}
