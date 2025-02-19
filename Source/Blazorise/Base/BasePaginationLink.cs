﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise.Base
{
    public abstract class BasePaginationLink : BaseComponent
    {
        #region Members

        #endregion

        #region Methods

        protected override void RegisterClasses()
        {
            ClassMapper
                .Add( () => ClassProvider.PaginationLink() )
                .If( () => ClassProvider.PaginationLinkActive(), () => ParentPaginationItem?.IsActive == true );

            base.RegisterClasses();
        }

        protected Task ClickHandler( UIMouseEventArgs eventArgs )
        {
            return Clicked.InvokeAsync( Page );
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the page name.
        /// </summary>
        [Parameter]
        protected string Page { get; set; }

        /// <summary>
        /// Occurs when the item link is clicked.
        /// </summary>
        [Parameter] protected EventCallback<string> Clicked { get; set; }

        [Parameter] protected RenderFragment ChildContent { get; set; }

        [CascadingParameter] protected BasePaginationItem ParentPaginationItem { get; set; }

        #endregion
    }
}
