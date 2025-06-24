git config --global --add safe.directory /workspaces/TreeSitter.Bindings/tree-sitter-ruby
git config --global --add safe.directory /workspaces/TreeSitter.Bindings/tree-sitter-html
git config --global --add safe.directory /workspaces/TreeSitter.Bindings/tree-sitter-json
git config --global --add safe.directory /workspaces/TreeSitter.Bindings/tree-sitter-embedded-template
git config --global --add safe.directory /workspaces/TreeSitter.Bindings/tree-sitter
dotnet tool restore
cp libClangSharp.so ~/.nuget/packages/clangsharppinvokegenerator/20.1.2/tools/net8.0/any/libClangSharp.so
cp libclang.so ~/.nuget/packages/clangsharppinvokegenerator/20.1.2/tools/net8.0/any/libclang.so
chmod +x scripts/build.sh