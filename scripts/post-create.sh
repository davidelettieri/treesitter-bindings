git config --global --add safe.directory /workspaces/TreeSitter.Bindings/tree-sitter-ruby
git config --global --add safe.directory /workspaces/TreeSitter.Bindings/tree-sitter-html
git config --global --add safe.directory /workspaces/TreeSitter.Bindings/tree-sitter-json
git config --global --add safe.directory /workspaces/TreeSitter.Bindings/tree-sitter-embedded-template
git config --global --add safe.directory /workspaces/TreeSitter.Bindings/tree-sitter
dotnet tool restore
cp libClangSharp.so ~/.nuget/packages/clangsharppinvokegenerator/17.0.1/tools/net8.0/any/libClangSharp.so
chmod +x scripts/build.sh