source_2015_Day_01: build/2015_01_Part_1.exe $\
                    build/2015_01_Part_2.exe $\
					build/2015_01_Part_1.exe.config $\
					build/2015_01_Part_2.exe.config

build/2015_01_Part_1.exe.config:
	aocst build\2015_01_Part_1.exe.config source 2015 01

build/2015_01_Part_2.exe.config:
	aocst build\2015_01_Part_2.exe.config source 2015 01

build/2015_01_Part_1.exe: build/library/source/file.dll build/library/source/2015/Day_01/Not_Quite_Lisp.dll source/_2015/Day_01/Part_1.cs $\
                          | build/library/source/2015/Day_01
	csc -out:build\2015_01_Part_1.exe -r:build\library\source\2015\Day_01\Not_Quite_Lisp.dll;build\library\source\file.dll -nologo .\source\_2015\Day_01\Part_1.cs

build/2015_01_Part_2.exe: build/library/source/file.dll build/library/source/2015/Day_01/Not_Quite_Lisp.dll source/_2015/Day_01/Part_2.cs $\
                          | build/library/source/2015/Day_01
	csc -out:build\2015_01_Part_2.exe -r:build\library\source\2015\Day_01\Not_Quite_Lisp.dll;build\library\source\file.dll -nologo .\source\_2015\Day_01\Part_2.cs

build/library/source/2015/Day_01/Not_Quite_Lisp.dll: source/_2015/Day_01/Not_Quite_Lisp.cs $\
                                                     | build/library/source/2015/Day_01
	csc -t:library -out:build\library\source\2015\Day_01\Not_Quite_Lisp.dll -nologo .\source\_2015\Day_01\Not_Quite_Lisp.cs

build/library/source/2015/Day_01: | build/library/source/2015
	mkdir "$@"