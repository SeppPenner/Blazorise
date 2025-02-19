﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazorise.Base;
using Microsoft.JSInterop;
#endregion

namespace Blazorise
{
    /// <summary>
    /// Middleman between the NumericEdit component and javascript.
    /// </summary>
    public class NumericEditAdapter
    {
        private readonly INumericEdit numericEdit;

        public NumericEditAdapter( INumericEdit numericEdit )
        {
            this.numericEdit = numericEdit;
        }

        [JSInvokable]
        public Task SetValue( string value )
        {
            return numericEdit.SetValue( value );
        }
    }
}
