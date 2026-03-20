source_2015_Day_08: build/2015_08_Part_1.exe $\
                    build/2015_08_Part_2.exe $\
					build/2015_08_Part_1.exe.config $\
					build/2015_08_Part_2.exe.config

build/2015_08_Part_1.exe.config:
	aocst build\2015_08_Part_1.exe.config source 2015 08

build/2015_08_Part_2.exe.config:
	aocst build\2015_08_Part_2.exe.config source 2015 08

build/2015_08_Part_1.exe: build/library/source/file.dll build/library/source/2015/Day_08/Matchsticks.dll source/_2015/Day_08/Part_1.cs $\
                          | build/library/source/2015/Day_08
	csc -out:build\2015_08_Part_1.exe -r:build\library\source\2015\Day_08\Matchsticks.dll;build\library\source\file.dll -nologo .\source\_2015\Day_08\Part_1.cs

build/2015_08_Part_2.exe: build/library/source/file.dll build/library/source/2015/Day_08/Matchsticks.dll source/_2015/Day_08/Part_2.cs $\
                          | build/library/source/2015/Day_08
	csc -out:build\2015_08_Part_2.exe -r:build\library\source\2015\Day_08\Matchsticks.dll;build\library\source\file.dll -nologo .\source\_2015\Day_08\Part_2.cs

build/library/source/2015/Day_08/Matchsticks.dll: source/_2015/Day_08/Matchsticks.cs $\
                                                  | build/library/source/2015/Day_08
	csc -t:library -out:build\library\source\2015\Day_08\Matchsticks.dll -nologo .\source\_2015\Day_08\Matchsticks.cs

build/library/source/2015/Day_08: | build/library/source/2015
	mkdir "$@"