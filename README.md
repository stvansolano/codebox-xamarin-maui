# codebox-xamarin-maui


## MAUI (Multi-platform Application UI)

### 1) Install tools & workloads
```
dotnet tool install -g Redth.Net.Maui.Check
```
Then
```
maui-check
```
Then

```
dotnet new --install Microsoft.Maui.Templates
```

### 2) Create new project

```
dotnet new maui -n MobileApp
```

### 3) Run it (Android)

```
dotnet build -t:Run -f net6.0-android
```