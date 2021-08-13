using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Colours
{
    public partial class Index
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private List<Colour> Colours;
        protected async override Task OnInitializedAsync()
        {
            Console.WriteLine("[Colours][OnInitializedAsync] => (In code behind)");
            this.Colours = await _client.GetFromJsonAsync<List<Colour>>("api/colours");
        }

        async Task Delete(int colourId)
        {
            Colour colour = this.Colours.First(q => q.Id == colourId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Are you sure you want to delete colour '{colour.Name}'?");
            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.ColoursEndpoint}/{colourId}");
                await OnInitializedAsync();
            }
        }
    }
}
