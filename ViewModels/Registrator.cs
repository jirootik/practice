﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiascanPraktika.ViewModels
{
    static class ViewModelRegistrator
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services) => services
                .AddSingleton<MainViewModel>()
            ;
    }
}

