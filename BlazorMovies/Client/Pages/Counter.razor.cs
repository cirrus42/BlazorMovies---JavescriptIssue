using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        [Inject]
        SingletonService Singleton { get; set; }
        [Inject] 
        TransientService Transient { get; set; }
        [Inject]
        IJSRuntime JsRuntime { get; set; }

        private int _currentCount = 0;
        private static int _currentCountStatic = 0;

        private async Task IncrementCount()
        {
            _currentCount++;
            Transient.Value = _currentCount;
            Singleton.Value = _currentCount;
            _currentCountStatic++;
            await JsRuntime.InvokeVoidAsync("dotnetStaticInvocation");
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(_currentCountStatic);
        }
    }
}

