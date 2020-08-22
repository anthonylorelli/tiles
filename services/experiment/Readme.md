# Tiles Backend Services

Prereqs to run the Ux

* .NET Core 3.1(https://dotnet.microsoft.com/download/dotnet-core/thank-you/runtime-aspnetcore-3.1.7-windows-x64-installer)

## Setup the project
1. Install the certificate to Current User/Personal (My): The pfx is under the services/experiment folder, named api.tiles.local.pfx 
**Note: Password for the cert is available to true Avett fans only**
2. Install the same certificate to Current User/Trusted Root Certification Authorities (otherwise, Chrome, Edge, Firefox will not trust it).  You'll need to restart your browsers after install to TRCA
3. Modify your hosts file under Windows\system32\drivers\etc (**you'll need to do this as an administrator**)
```
api.tiles.local         127.0.0.1
```
 
## To build the project
```
dotnet build
```

## To run the project
```
dotnet run
```
This will spin up a server you can access in the browser at https://api.tiles.local/Tiles

Note that, unless you install the cert to your Trusted Root Certificates, you may see a message saying this site is unsecure

## See Ux [readme](../../ux/readme.md) for how to run the Ux -- it will access api.tiles.local via CORS xhr request, so the services project will need to be running