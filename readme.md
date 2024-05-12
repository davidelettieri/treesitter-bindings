# Tree sitter bindings

This repo is **poorly** hacked together, in particular because I have no knowledge or experience with c/c++ development.

The sample project is working within the dev container, it is working also on my fedora 39 box with the additional requirement of installing `libcxx`.
That library is installed also in the dev container and it is used to build and user `libtree-sitter-ruby`. I could package in the runtime package but I'm not sure it's the best solution.

I messed up a bit with the runtime packages versioning, the most updated version, and the one recommended to be used is `0.20.8-extra.1`. This includes compiled libraries for tree-sitter and all the languages used in my sample project. It will be pulled automatically when using `	TreeSitter.Bindings`.

Packages are published on `nuget.org`, if you happen to use it let me know!

## How to run it

Open the folder with `Dev Containers`.

Run the `build.sh` script from the root folder to generate the bindings. 

```bash
bash scripts/build.sh
```

Run the sample from the root folder

```
dotnet run --project samples/TreeSitter.Bindings.Sample/TreeSitter.Bindings.Sample.csproj 
```

## Remove submodule

git rm <submodule name>
remove folder .git/module/<submodule name>