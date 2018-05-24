﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PhoneNumberMask
{
    public class PhoneNumberMaskBehavior : Behavior<Entry>
    {
        ///
        /// Attaches when the page is first created.
        /// 

        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        ///
        /// Detaches when the page is destroyed.
        /// 

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            if (!string.IsNullOrWhiteSpace(args.NewTextValue))
            {
                // If the new value is longer than the old value, the user is
                if (args.OldTextValue != null && args.NewTextValue.Length < args.OldTextValue.Length)
                    return;

                var value = args.NewTextValue;

                if (value.Length == 3)
                {
                    ((Entry)sender).Text += "-";
                    return;
                }

                if (value.Length == 7)
                {
                    ((Entry)sender).Text += "-";
                    return;
                }

                ((Entry)sender).Text = args.NewTextValue;
            }
        }
    }
}
