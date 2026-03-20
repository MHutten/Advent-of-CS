source: source_2015

include source/_2015/makefile

build/library/source/file.dll: source/file.cs | build/library/source
	csc -t:library -out:build\library\source\file.dll -nologo .\source\file.cs

build/library/source: | build/library
	mkdir "$@"