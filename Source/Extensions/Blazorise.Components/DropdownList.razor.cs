﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise.Components
{
    public abstract class BaseDropdownList<TItem> : ComponentBase
    {
        #region Members

        #endregion

        #region Methods

        protected async Task HandleItemClicked( object value )
        {
            SelectedValue = value;
            await SelectedValueChanged.InvokeAsync( SelectedValue );
        }

        #endregion

        #region Properties

        [Parameter] public Color Color { get; set; }

        [Parameter] public IEnumerable<TItem> Data { get; set; }

        [Parameter] public Func<TItem, string> TextField { get; set; }

        [Parameter] public Func<TItem, object> ValueField { get; set; }

        [Parameter] public object SelectedValue { get; set; }

        [Parameter] public EventCallback<object> SelectedValueChanged { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        #endregion
    }
}
