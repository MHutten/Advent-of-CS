source_2015_Day_05: build/2015_05_Part_1.exe $\
                    build/2015_05_Part_2.exe $\
					build/2015_05_Part_1.exe.config $\
					build/2015_05_Part_2.exe.config

build/2015_05_Part_1.exe.config:
	aocst build\2015_05_Part_1.exe.config source 2015 05

build/2015_05_Part_2.exe.config:
	aocst build\2015_05_Part_2.exe.config source 2015 05

build/2015_05_Part_1.exe: build/library/source/file.dll build/library/source/2015/Day_05/Doesnt_He_Have_Intern-Elves_For_This.dll source/_2015/Day_05/Part_1.cs $\
                          | build/library/source/2015/Day_05
	csc -out:build\2015_05_Part_1.exe -r:build\library\source\2015\Day_05\Doesnt_He_Have_Intern-Elves_For_This.dll;build\library\source\file.dll -nologo .\source\_2015\Day_05\Part_1.cs

build/2015_05_Part_2.exe: build/library/source/file.dll build/library/source/2015/Day_05/Doesnt_He_Have_Intern-Elves_For_This.dll source/_2015/Day_05/Part_2.cs $\
                          | build/library/source/2015/Day_05
	csc -out:build\2015_05_Part_2.exe -r:build\library\source\2015\Day_05\Doesnt_He_Have_Intern-Elves_For_This.dll;build\library\source\file.dll -nologo .\source\_2015\Day_05\Part_2.cs

build/library/source/2015/Day_05/Doesnt_He_Have_Intern-Elves_For_This.dll: source/_2015/Day_05/Doesnt_He_Have_Intern-Elves_For_This.cs $\
                                                                             | build/library/source/2015/Day_05
	csc -t:library -out:build\library\source\2015\Day_05\Doesnt_He_Have_Intern-Elves_For_This.dll -nologo .\source\_2015\Day_05\Doesnt_He_Have_Intern-Elves_For_This.cs

build/library/source/2015/Day_05: | build/library/source/2015
	mkdir "$@"