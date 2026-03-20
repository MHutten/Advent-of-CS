source_2015_Day_02: build/2015_02_Part_1.exe $\
                    build/2015_02_Part_2.exe $\
					build/2015_02_Part_1.exe.config $\
					build/2015_02_Part_2.exe.config

build/2015_02_Part_1.exe.config:
	aocst build\2015_02_Part_1.exe.config source 2015 02

build/2015_02_Part_2.exe.config:
	aocst build\2015_02_Part_2.exe.config source 2015 02

build/2015_02_Part_1.exe: build/library/source/file.dll build/library/source/2015/Day_02/I_Was_Told_There_Would_Be_No_Math.dll source/_2015/Day_02/Part_1.cs $\
                          | build/library/source/2015/Day_02
	csc -out:build\2015_02_Part_1.exe -r:build\library\source\2015\Day_02\I_Was_Told_There_Would_Be_No_Math.dll;build\library\source\file.dll -nologo .\source\_2015\Day_02\Part_1.cs

build/2015_02_Part_2.exe: build/library/source/file.dll build/library/source/2015/Day_02/I_Was_Told_There_Would_Be_No_Math.dll source/_2015/Day_02/Part_2.cs $\
                          | build/library/source/2015/Day_02
	csc -out:build\2015_02_Part_2.exe -r:build\library\source\2015\Day_02\I_Was_Told_There_Would_Be_No_Math.dll;build\library\source\file.dll -nologo .\source\_2015\Day_02\Part_2.cs

build/library/source/2015/Day_02/I_Was_Told_There_Would_Be_No_Math.dll: source/_2015/Day_02/I_Was_Told_There_Would_Be_No_Math.cs $\
                                                     | build/library/source/2015/Day_02
	csc -t:library -out:build\library\source\2015\Day_02\I_Was_Told_There_Would_Be_No_Math.dll -nologo .\source\_2015\Day_02\I_Was_Told_There_Would_Be_No_Math.cs

build/library/source/2015/Day_02: | build/library/source/2015
	mkdir "$@"