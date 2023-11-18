cp tree-sitter/libtree-sitter.so tree-sitter-packages/libtreesitter.runtime.linux-x64/
cp tree-sitter-json/libtree-sitter-json.so tree-sitter-packages/libtreesitter.runtime.linux-x64/
cp tree-sitter-html/libtree-sitter-html.so tree-sitter-packages/libtreesitter.runtime.linux-x64/
cp tree-sitter-embedded-template/libtree-sitter-embedded-template.so tree-sitter-packages/libtreesitter.runtime.linux-x64/
cp tree-sitter-ruby/libtree-sitter-ruby.so tree-sitter-packages/libtreesitter.runtime.linux-x64/
dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitter.rsp
dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitterJson.rsp
dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitterRuby.rsp
dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitterHtml.rsp
dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitterEmbeddedTemplate.rsp
dotnet build
dotnet test --no-build