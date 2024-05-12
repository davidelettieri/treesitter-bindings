cd tree-sitter
make clean
make
cd ..
cd tree-sitter-json
make clean
make
cd ..
cd tree-sitter-html
make clean
make 
cd ..
cd tree-sitter-embedded-template
make clean
make
cd ..
cd tree-sitter-ruby
make clean
make
cd ..
cp tree-sitter/libtree-sitter.so.0 tree-sitter-packages/libtreesitter.runtime.linux-x64/libtree-sitter.so
cp tree-sitter-json/libtree-sitter-json.so.0.0 tree-sitter-packages/libtreesitter.runtime.linux-x64/libtree-sitter-json.so
cp tree-sitter-html/libtree-sitter-html.so.0.0 tree-sitter-packages/libtreesitter.runtime.linux-x64/libtree-sitter-html.so
cp tree-sitter-embedded-template/libtree-sitter-embedded-template.so.0.0 tree-sitter-packages/libtreesitter.runtime.linux-x64/libtree-sitter-embedded-template.so
cp tree-sitter-ruby/libtree-sitter-ruby.so.0.0 tree-sitter-packages/libtreesitter.runtime.linux-x64/libtree-sitter-ruby.so
dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitter.rsp
dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitterJson.rsp
dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitterRuby.rsp
dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitterHtml.rsp
dotnet tool run ClangSharpPInvokeGenerator @GenerateTreeSitterEmbeddedTemplate.rsp
dotnet build
dotnet test --no-build