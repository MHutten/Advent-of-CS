source_2015_Day_10: build/2015_10_Part_1.exe $\
                    build/2015_10_Part_2.exe $\
					build/2015_10_Part_1.exe.config $\
					build/2015_10_Part_2.exe.config

build/2015_10_Part_1.exe.config:
	aocst build\2015_10_Part_1.exe.config source 2015 10

build/2015_10_Part_2.exe.config:
	aocst build\2015_10_Part_2.exe.config source 2015 10

build/2015_10_Part_1.exe: build/library/source/file.dll build/library/source/2015/Day_10/Elves_Look_Elves_Say.dll source/_2015/Day_10/Part_1.cs $\
                          | build/library/source/2015/Day_10
	csc -out:build\2015_10_Part_1.exe -r:build\library\source\2015\Day_10\Elves_Look_Elves_Say.dll;build\library\source\file.dll -nologo .\source\_2015\Day_10\Part_1.cs

build/2015_10_Part_2.exe: build/library/source/file.dll build/library/source/2015/Day_10/Elves_Look_Elves_Say.dll source/_2015/Day_10/Part_2.cs $\
                          | build/library/source/2015/Day_10
	csc -out:build\2015_10_Part_2.exe -r:build\library\source\2015\Day_10\Elves_Look_Elves_Say.dll;build\library\source\file.dll -nologo .\source\_2015\Day_10\Part_2.cs

build/library/source/2015/Day_10/Elves_Look_Elves_Say.dll: source/_2015/Day_10/Elves_Look_Elves_Say.cs $\
                                                           | build/library/source/2015/Day_10
	csc -t:library -out:build\library\source\2015\Day_10\Elves_Look_Elves_Say.dll -nologo .\source\_2015\Day_10\Elves_Look_Elves_Say.cs

build/library/source/2015/Day_10: | build/library/source/2015
	mkdir "$@"