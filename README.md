# RadzenTestCaseDS
Radzen test case

Repeat by:

- Build
- Run `DiveShopBlazor.Server` in Visual Studio with Debuuger
- Click `Certifications`
- Click `Refresh` [^R]
- Observe exceptions in Output Window:
```
Exception thrown: 'Microsoft.JSInterop.JSDisconnectedException' in Microsoft.AspNetCore.Components.Server.dll
Exception thrown: 'Microsoft.JSInterop.JSDisconnectedException' in Microsoft.JSInterop.dll
Exception thrown: 'Microsoft.JSInterop.JSDisconnectedException' in System.Private.CoreLib.dll
Exception thrown: 'Microsoft.JSInterop.JSDisconnectedException' in Microsoft.AspNetCore.Components.Server.dll
Exception thrown: 'Microsoft.JSInterop.JSDisconnectedException' in Microsoft.JSInterop.dll
Exception thrown: 'Microsoft.JSInterop.JSDisconnectedException' in System.Private.CoreLib.dll
Exception thrown: 'Microsoft.JSInterop.JSDisconnectedException' in Microsoft.AspNetCore.Components.Server.dll
Exception thrown: 'Microsoft.JSInterop.JSDisconnectedException' in Microsoft.JSInterop.dll
Exception thrown: 'Microsoft.JSInterop.JSDisconnectedException' in System.Private.CoreLib.dll
```
