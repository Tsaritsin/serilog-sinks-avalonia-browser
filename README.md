# serilog-sinks-avalonia-browser

It almost the same like package Serilog.Sinks.BrowserConsole but use [JSImport] instead IJSRuntime (because it working without Blazor and aditional registrations).

```csharp

// dotnet add package Serilog.Sinks.Avalonia.Browser

 Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Browser()
            .CreateLogger();
```
![image](https://github.com/user-attachments/assets/1f7831df-ffde-4cc2-ab3f-9d0522f772aa)

![image](https://github.com/user-attachments/assets/8a55dc68-c4e5-4f01-9628-6ee54de74a5e)

A more detailed example is available [in this repository](https://github.com/Tsaritsin/serilog-sinks-avalonia-browser/tree/main/sample/AvaloniaSample).
