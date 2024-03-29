﻿using AutoMapper;

namespace Cinema.Services
{
    public class MapperFactory<TSource, TDestination>
    {
        private readonly IMapper _mapper;

        public MapperFactory(IMapper mapper)
        {
            _mapper = mapper;
        }

        /*public PaginatedList<TDestination> ToPagedList(PaginatedList<TSource> sourceList)
        {
            PaginatedList<TDestination> destinationList = _mapper.Map<PaginatedList<TDestination>>(sourceList);

            return new PaginatedList<TDestination>(destinationList, sourceList.PageIndex, sourceList.TotalPages);
        }*/
    }
}
