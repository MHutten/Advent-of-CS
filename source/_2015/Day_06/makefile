source_2015_Day_06: build/2015_06_Part_1.exe $\
                    build/2015_06_Part_2.exe $\
					build/2015_06_Part_1.exe.config $\
					build/2015_06_Part_2.exe.config

build/2015_06_Part_1.exe.config:
	aocst build\2015_06_Part_1.exe.config source 2015 06

build/2015_06_Part_2.exe.config:
	aocst build\2015_06_Part_2.exe.config source 2015 06

build/2015_06_Part_1.exe: build/library/source/file.dll build/library/source/2015/Day_06/Probably_a_Fire_Hazard.dll source/_2015/Day_06/Part_1.cs $\
                          | build/library/source/2015/Day_06
	csc -out:build\2015_06_Part_1.exe -r:build\library\source\2015\Day_06\Probably_a_Fire_Hazard.dll;build\library\source\file.dll -nologo .\source\_2015\Day_06\Part_1.cs

build/2015_06_Part_2.exe: build/library/source/file.dll build/library/source/2015/Day_06/Probably_a_Fire_Hazard.dll source/_2015/Day_06/Part_2.cs $\
                          | build/library/source/2015/Day_06
	csc -out:build\2015_06_Part_2.exe -r:build\library\source\2015\Day_06\Probably_a_Fire_Hazard.dll;build\library\source\file.dll -nologo .\source\_2015\Day_06\Part_2.cs

build/library/source/2015/Day_06/Probably_a_Fire_Hazard.dll: source/_2015/Day_06/Probably_a_Fire_Hazard.cs $\
                                                             | build/library/source/2015/Day_06
	csc -t:library -out:build\library\source\2015\Day_06\Probably_a_Fire_Hazard.dll -nologo .\source\_2015\Day_06\Probably_a_Fire_Hazard.cs

build/library/source/2015/Day_06: | build/library/source/2015
	mkdir "$@"