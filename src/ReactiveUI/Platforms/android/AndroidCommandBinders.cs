// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using System;
using System.Linq.Expressions;
using System.Reflection;
using Android.Views;

namespace ReactiveUI
{
    /// <summary>
    ///
    /// </summary>
    public class AndroidCommandBinders : FlexibleCommandBinder
    {
        public static Lazy<AndroidCommandBinders> Instance = new Lazy<AndroidCommandBinders>();

        public AndroidCommandBinders()
        {
            Type view = typeof(View);
            Register(view, 9, (cmd, t, cp)=> ForEvent(cmd, t, cp, "Click", view.GetRuntimeProperty("Enabled")));
        }
    }
}