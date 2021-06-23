# WeatherForecast API

Notes : 
- About Configuration 
- About Record Type in minutes 26:00
- 28:00 GetFromJson Async Method auto deserialization for us
- typo for weathers on forecast record
- 36: 08 Add Polly
- Add Circuit Breaker
- 46:36 Add Health Check
## Setup VSCode
- Add "group": {"kind": "build","isDefault": true} on tasks.json to set default is build / shortcut so the build propmt doesn't pop up again in the he next section when we hit ctrl + shift + b
- Set "uriFormat": "%s/swagger" on launch.json for set endpoint or default path when launch 
- // Enable and Disable launching a web browser when ASP.NET Core starts. For more information: https://aka.ms/VSCode-CS-LaunchJson-WebBrowser with add or remove the "serverReadyAction": { "action": "openExternally", "pattern": "\\bNow listening on:\\s+(https?://\\S+)", "uriFormat": "%s/swagger" }, property on launch.json file
- 