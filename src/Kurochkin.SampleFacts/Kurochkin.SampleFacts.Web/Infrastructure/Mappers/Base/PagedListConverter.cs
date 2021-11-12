﻿using System;
using Calabonga.UnitOfWork;
using AutoMapper;
using System.Collections;
using System.Collections.Generic;

namespace Kurochkin.SampleFacts.Web.Infrastructure.Mappers.Base
{
    public class PagedListConverter<TSource, TDestination> 
        : ITypeConverter<IPagedList<TSource>, IPagedList<TDestination>>
    {
        public IPagedList<TDestination> Convert(IPagedList<TSource> source,
                                                IPagedList<TDestination> destination,
                                                ResolutionContext context)
        {
        return source is null
            ? PagedList.Empty<TDestination>()
            : PagedList.From(source, x => context.Mapper.Map<IEnumerable<TDestination>>(x));
        }
    }
}
