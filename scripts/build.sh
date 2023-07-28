dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitter.rsp
dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitterJson.rsp
rm tests/TreeSitter.Bindings.UnitTests/TSLanguageTests.cs # this generated file is not compiling
dotnet build
dotnet test --no-build