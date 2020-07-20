msbuild src/TextCopy.sln /t:restore /p:Configuration=LinuxTest -verbosity:quiet

msbuild src/TextCopy.sln /t:build /p:Configuration=LinuxTest -verbosity:quiet

dotnet test src --configuration LinuxTest --no-build --no-restore