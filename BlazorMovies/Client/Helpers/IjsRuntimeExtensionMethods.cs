using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public static class IjsRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSInProcessRuntime jSInProcessRuntime, string message)
        {
            await jSInProcessRuntime.InvokeVoidAsync("console.log", "Example Message");
            return await jSInProcessRuntime.InvokeAsync<bool>("confirm", message);
        }

        public static async ValueTask MyFunction(this IJSInProcessRuntime jSInProcessRuntime, string message) =>
            await jSInProcessRuntime.InvokeVoidAsync("my_function", message);
    }
}