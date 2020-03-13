﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Max.NetCore.DI.Autofac
{
    public interface IResolver
    {
        T Resolve<T>();

        IEnumerable<T> ResolveAll<T>();
    }
}