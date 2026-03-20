test_tests_2015_Day_08: build/2015_08_Matchsticks_test.exe build/2015_08_Matchsticks_test.exe.config

build/2015_08_Matchsticks_test.exe.config:
	aocst build\2015_08_Matchsticks_test.exe.config test 2015 08

build/2015_08_Matchsticks_test.exe: build/library/test/asserts.dll build/library/test/TestSuite.dll build/library/source/2015/Day_08/Matchsticks.dll test/tests/_2015/Day_08/Matchsticks_test.cs $\
                                    | build
	csc -out:build\2015_08_Matchsticks_test.exe -r:build\library\test\asserts.dll;build\library\test\TestSuite.dll;build\library\source\2015\Day_08\Matchsticks.dll -nologo .\test\tests\_2015\Day_08\Matchsticks_test.cs