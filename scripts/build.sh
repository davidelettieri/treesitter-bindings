dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitter.rsp
dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitterJson.rsp
dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitterRuby.rsp
dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitterHtml.rsp
dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitterEmbeddedTemplate.rsp
dotnet build
dotnet test --no-build