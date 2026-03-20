test_tests_2015_Day_05: build/2015_05_Doesnt_He_Have_Intern-Elves_For_This_test.exe build/2015_05_Doesnt_He_Have_Intern-Elves_For_This_test.exe.config

build/2015_05_Doesnt_He_Have_Intern-Elves_For_This_test.exe.config:
	aocst build\2015_05_Doesnt_He_Have_Intern-Elves_For_This_test.exe.config test 2015 05

build/2015_05_Doesnt_He_Have_Intern-Elves_For_This_test.exe: build/library/test/asserts.dll build/library/test/TestSuite.dll build/library/source/2015/Day_05/Doesnt_He_Have_Intern-Elves_For_This.dll test/tests/_2015/Day_05/Doesnt_He_Have_Intern-Elves_For_This_test.cs $\
                                                             | build
	csc -out:build\2015_05_Doesnt_He_Have_Intern-Elves_For_This_test.exe -r:build\library\test\asserts.dll;build\library\test\TestSuite.dll;build\library\source\2015\Day_05\Doesnt_He_Have_Intern-Elves_For_This.dll -nologo .\test\tests\_2015\Day_05\Doesnt_He_Have_Intern-Elves_For_This_test.cs