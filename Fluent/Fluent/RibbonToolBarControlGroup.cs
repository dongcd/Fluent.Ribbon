﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Fluent
{
    /// <summary>
    /// Represent logical container for toolbar items
    /// </summary>
    [ContentProperty("Children")]
    public class RibbonToolBarControlGroup : ItemsControl
    {
        #region Properties

        /// <summary>
        /// Gets whether the group is the fisrt control in the row
        /// </summary>
        public bool IsFirstInRow
        {
            get { return (bool)GetValue(IsFirstInRowProperty); }
            set { SetValue(IsFirstInRowProperty, value); }
        }

        /// <summary>
        /// Using a DependencyProperty as the backing store for IsFirstInRow.  
        /// This enables animation, styling, binding, etc...
        /// </summary>
        public static readonly DependencyProperty IsFirstInRowProperty =
            DependencyProperty.Register("IsFirstInRow", typeof(bool), typeof(RibbonToolBarControlGroup), new UIPropertyMetadata(true));

        /// <summary>
        /// Gets whether the group is the last control in the row
        /// </summary>
        public bool IsLastInRow
        {
            get { return (bool)GetValue(IsLastInRowProperty); }
            set { SetValue(IsLastInRowProperty, value); }
        }

        /// <summary>
        /// Using a DependencyProperty as the backing store for IsFirstInRow.  
        /// This enables animation, styling, binding, etc...
        /// </summary>
        public static readonly DependencyProperty IsLastInRowProperty =
            DependencyProperty.Register("IsLastInRow", typeof(bool), typeof(RibbonToolBarControlGroup), new UIPropertyMetadata(true));

        #endregion

        #region Initialization

        static RibbonToolBarControlGroup()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RibbonToolBarControlGroup), new FrameworkPropertyMetadata(typeof(RibbonToolBarControlGroup)));
            StyleProperty.OverrideMetadata(typeof(RibbonToolBarControlGroup), new FrameworkPropertyMetadata(null, new CoerceValueCallback(OnCoerceStyle)));
        }


        // Coerce control style
        private static object OnCoerceStyle(DependencyObject d, object basevalue)
        {
            if (basevalue == null) basevalue = ThemesManager.DefaultRibbonToolBarControlGroupStyle;
            return basevalue;
        }

        #endregion
    }
}