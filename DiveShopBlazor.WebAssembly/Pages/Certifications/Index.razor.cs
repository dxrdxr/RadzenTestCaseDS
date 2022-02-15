//
// Copyright (c) 2022 David Robinson  All Rights Reserved
//

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using DiveShop.ViewModels;
using Microsoft.AspNetCore.Components;
using Radzen;

namespace DiveShopBlazor.WebAssembly.Pages.Certifications
{
    public partial class Index
    {
        private IEnumerable<CertificationVM> certifications = Enumerable.Empty<CertificationVM>();
        private bool loading = false;
        private string errorMessage = string.Empty;
        private int count = 0;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        [Inject]
        private NavigationManager NavManager { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        /// <summary>
        /// Called when the page is initialized.
        /// </summary>
        protected override Task OnInitializedAsync() =>
            LoadDataAsync(new LoadDataArgs());

        private async Task LoadDataAsync(LoadDataArgs _)
        {
            loading = true;
            StateHasChanged();

            await Task.Delay(1);
            certifications = CertificationList.ToList();
            count = CertificationList.Count;

            loading = false;
            StateHasChanged();
        }

        private void RowSelect(CertificationVM certification)
        {
        }

#if false
        private void ShowErrorNotification(string message)
        {
            var notificationMessage = new NotificationMessage
            {
                Severity = NotificationSeverity.Error,
                Summary = "Error",
                Detail = message,
                Duration = 60 * 1000
            };

            notificationService.Notify(notificationMessage);
        }
#endif

        /// <summary>
        /// A collection of <see cref="CertificationVM"/>.
        /// </summary>
        public class CertificationCollection
            : KeyedCollection<string, CertificationVM>
        {
            /// <summary>
            /// Get the key from the <see cref="CertificationVM"/>.
            /// </summary>
            /// <param name="item">The item.</param>
            /// <returns>The key.</returns>
            protected override string GetKeyForItem([NotNull] CertificationVM item)
            {
                _ = item ?? throw new ArgumentNullException(nameof(item));

                return item.CertificationID;
            }
        }

        /// <summary>
        /// Pre-configured <see cref="CertificationVM"/> list.
        /// </summary>
        public static readonly CertificationCollection CertificationList = new()
        {
            // Generic
            new CertificationVM { CertificationID = "GNONE", Agency = "Generic", Name = "Uncertified" },
            // PADI                                                                                                                                                                                                                                      
            new CertificationVM { CertificationID = "PDJRSD", Agency = "PADI", Name = "Junior Scuba Diver" }
        };
    }
}
