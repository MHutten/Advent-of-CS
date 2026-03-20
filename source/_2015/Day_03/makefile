source_2015_Day_03: build/2015_03_Part_1.exe $\
                    build/2015_03_Part_2.exe $\
					build/2015_03_Part_1.exe.config $\
					build/2015_03_Part_2.exe.config

build/2015_03_Part_1.exe.config:
	aocst build\2015_03_Part_1.exe.config source 2015 03

build/2015_03_Part_2.exe.config:
	aocst build\2015_03_Part_2.exe.config source 2015 03

build/2015_03_Part_1.exe: build/library/source/file.dll build/library/source/2015/Day_03/Perfectly_Spherical_Houses_in_a_Vacuum.dll source/_2015/Day_03/Part_1.cs $\
                          | build/library/source/2015/Day_03
	csc -out:build\2015_03_Part_1.exe -r:build\library\source\2015\Day_03\Perfectly_Spherical_Houses_in_a_Vacuum.dll;build\library\source\file.dll -nologo .\source\_2015\Day_03\Part_1.cs

build/2015_03_Part_2.exe: build/library/source/file.dll build/library/source/2015/Day_03/Perfectly_Spherical_Houses_in_a_Vacuum.dll source/_2015/Day_03/Part_2.cs $\
                          | build/library/source/2015/Day_03
	csc -out:build\2015_03_Part_2.exe -r:build\library\source\2015\Day_03\Perfectly_Spherical_Houses_in_a_Vacuum.dll;build\library\source\file.dll -nologo .\source\_2015\Day_03\Part_2.cs

build/library/source/2015/Day_03/Perfectly_Spherical_Houses_in_a_Vacuum.dll: source/_2015/Day_03/Perfectly_Spherical_Houses_in_a_Vacuum.cs $\
                                                                             | build/library/source/2015/Day_03
	csc -t:library -out:build\library\source\2015\Day_03\Perfectly_Spherical_Houses_in_a_Vacuum.dll -nologo .\source\_2015\Day_03\Perfectly_Spherical_Houses_in_a_Vacuum.cs

build/library/source/2015/Day_03: | build/library/source/2015
	mkdir "$@"