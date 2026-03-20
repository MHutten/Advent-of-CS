test_tests_2015_Day_10: build/2015_10_Elves_Look_Elves_Say_test.exe build/2015_10_Elves_Look_Elves_Say_test.exe.config

build/2015_10_Elves_Look_Elves_Say_test.exe.config:
	aocst build\2015_10_Elves_Look_Elves_Say_test.exe.config test 2015 10

build/2015_10_Elves_Look_Elves_Say_test.exe: build/library/test/asserts.dll build/library/test/TestSuite.dll build/library/source/2015/Day_10/Elves_Look_Elves_Say.dll test/tests/_2015/Day_10/Elves_Look_Elves_Say_test.cs $\
                                             | build
	csc -out:build\2015_10_Elves_Look_Elves_Say_test.exe -r:build\library\test\asserts.dll;build\library\test\TestSuite.dll;build\library\source\2015\Day_10\Elves_Look_Elves_Say.dll -nologo .\test\tests\_2015\Day_10\Elves_Look_Elves_Say_test.cs