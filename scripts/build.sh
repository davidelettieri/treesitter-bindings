dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitter.rsp
dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitterJson.rsp
dotnet build
dotnet test --no-build