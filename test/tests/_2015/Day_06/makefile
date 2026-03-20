test_tests_2015_Day_06: build/2015_06_Probably_a_Fire_Hazard_test.exe build/2015_06_Probably_a_Fire_Hazard_test.exe.config

build/2015_06_Probably_a_Fire_Hazard_test.exe.config:
	aocst build\2015_06_Probably_a_Fire_Hazard_test.exe.config test 2015 06

build/2015_06_Probably_a_Fire_Hazard_test.exe: build/library/test/asserts.dll build/library/test/TestSuite.dll build/library/source/2015/Day_06/Probably_a_Fire_Hazard.dll test/tests/_2015/Day_06/Probably_a_Fire_Hazard_test.cs $\
                                               | build
	csc -out:build\2015_06_Probably_a_Fire_Hazard_test.exe -r:build\library\test\asserts.dll;build\library\test\TestSuite.dll;build\library\source\2015\Day_06\Probably_a_Fire_Hazard.dll -nologo .\test\tests\_2015\Day_06\Probably_a_Fire_Hazard_test.cs