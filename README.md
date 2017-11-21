# Performance Counter Service

Host Performance Counter as a Web Service.

### How to install?

1. Download latest release of PerformanceCounterService.zip. [https://github.com/supershowwei/performance-counter-service/releases](https://github.com/supershowwei/performance-counter-service/releases)
2. Unzip files to the directory you wanted on target server.
3. Run `cmd` as Administrator.
4. Execute `PerformanceCounterService.exe install` to install `PerformanceCounterService` as a Windows Service.
![](https://i.imgur.com/9Xq9A5I.png)
5. Execute `PerformanceCounterService.exe start` to start `PerformanceCounterService`.
![](https://i.imgur.com/NE4Vrr1.png)
6. Add a firewall `Inbound Rule`, default port is 9527. (We can change port number and performance counters in PerformanceCounterService.exe.config.)

### How to use?

Browse the url `http://{host}:{port}/performance-counters` and we will get performance counter values.
![](https://i.imgur.com/67cMTAH.png)
