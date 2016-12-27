﻿using System;
using System.Data.Entity;

namespace EntityFramework.Interception
{
    [AttributeUsage(AttributeTargets.Method)]
    internal class InterceptorMethodAttribute : Attribute
    {
        public InterceptorMethodAttribute(EntityState state, bool isPostSave)
        {
            State = state;
            IsPostSave = isPostSave;
        }

        public EntityState State { get; private set; }

        public bool IsPostSave { get; private set; }
    }
}