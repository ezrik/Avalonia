﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using Perspex.Controls;
using Xunit;

namespace Perspex.Layout.UnitTests
{
    public class LayoutManagerTests
    {
        [Fact]
        public void Invalidating_Child_Should_Remeasure_Parent()
        {
            Border border;
            StackPanel panel;

            var root = new TestLayoutRoot
            {
                Child = panel = new StackPanel
                {
                    Children = new Controls.Controls
                    {
                        (border = new Border())
                    }
                }
            };

            root.LayoutManager.ExecuteLayoutPass();
            Assert.Equal(new Size(0, 0), root.DesiredSize);

            border.Width = 100;
            border.Height = 100;

            root.LayoutManager.ExecuteLayoutPass();
            Assert.Equal(new Size(100, 100), panel.DesiredSize);
        }
    }
}