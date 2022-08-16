# Water Linked UGPS API Client

This repository contains a dotnet class library for accessing [the Water Linked Underwater GPS API](https://demo.waterlinked.com/swagger/).

To update the library run:

```shell
cd WaterLinked.UGPS

dotnet openapi refresh --updateProject WaterLinked.UGPS.csproj https://demo.waterlinked.com/swagger/swagger.json
```

And push to `main` to trigger a new CI build which will publish a NuGet package.