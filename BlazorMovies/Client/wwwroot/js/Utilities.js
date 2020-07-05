function my_function(message) {
    console.log("Utilities "  + message);
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazorMovies.Client", "GetCurrentCount")
        .then(result => {
            console.log("count from javascript " + result);
        });
}