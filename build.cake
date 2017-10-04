var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
  Information("Hello World!");
});

Task("BuildTest")
    .Does(() => 
    {
        MSBuild("./Calculadora.Tests/Calculadora.Tests.csproj", 
            new MSBuildSettings {
                Verbosity = Verbosity.Minimal,
                Configuration = "Debug"
            }
        );
    });

RunTarget(target);