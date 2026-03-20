test_tests_2015_Day_02: build/2015_02_I_Was_Told_There_Would_Be_No_Math_test.exe build/2015_02_I_Was_Told_There_Would_Be_No_Math_test.exe.config

build/2015_02_I_Was_Told_There_Would_Be_No_Math_test.exe.config:
	aocst build\2015_02_I_Was_Told_There_Would_Be_No_Math_test.exe.config test 2015 02

build/2015_02_I_Was_Told_There_Would_Be_No_Math_test.exe: build/library/test/asserts.dll build/library/test/TestSuite.dll build/library/source/2015/Day_02/I_Was_Told_There_Would_Be_No_Math.dll test/tests/_2015/Day_02/I_Was_Told_There_Would_Be_No_Math_test.cs $\
                                                          | build
	csc -out:build\2015_02_I_Was_Told_There_Would_Be_No_Math_test.exe -r:build\library\test\asserts.dll;build\library\test\TestSuite.dll;build\library\source\2015\Day_02\I_Was_Told_There_Would_Be_No_Math.dll -nologo .\test\tests\_2015\Day_02\I_Was_Told_There_Would_Be_No_Math_test.cs