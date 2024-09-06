version=$1

allArchs=('linux-arm' 'linux-arm64' 'linux-x64' 'linux-x86' 'windows-arm64' 'windows-x64' 'windows-x86')

for a in ${allArchs[@]}; do
  echo https://github.com/tree-sitter/tree-sitter/releases/download/v0.23.0/tree-sitter-${a}.gz
done

