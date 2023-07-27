##

Download runtime

https://www.nuget.org/packages/libClangSharp.runtime.linux-x64/15.0.0

Install 

sudo dnf install ncurses-compat-libs.x86_64

### Troubleshooting 

For errors like 

```
tree-sitter/lib/include/tree_sitter/parser.h:8:10: fatal error: 'stdbool.h' file not found
```

check the `--include-directory` option in the rsp files and be sure that is pointing to the correct clang folder