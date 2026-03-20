test_tests_2015_Day_03: build/2015_03_Perfectly_Spherical_Houses_in_a_Vacuum_test.exe build/2015_03_Perfectly_Spherical_Houses_in_a_Vacuum_test.exe.config

build/2015_03_Perfectly_Spherical_Houses_in_a_Vacuum_test.exe.config:
	aocst build\2015_03_Perfectly_Spherical_Houses_in_a_Vacuum_test.exe.config test 2015 03

build/2015_03_Perfectly_Spherical_Houses_in_a_Vacuum_test.exe: build/library/test/asserts.dll build/library/test/TestSuite.dll build/library/source/2015/Day_03/Perfectly_Spherical_Houses_in_a_Vacuum.dll test/tests/_2015/Day_03/Perfectly_Spherical_Houses_in_a_Vacuum_test.cs $\
                                                               | build
	csc -out:build\2015_03_Perfectly_Spherical_Houses_in_a_Vacuum_test.exe -r:build\library\test\asserts.dll;build\library\test\TestSuite.dll;build\library\source\2015\Day_03\Perfectly_Spherical_Houses_in_a_Vacuum.dll -nologo .\test\tests\_2015\Day_03\Perfectly_Spherical_Houses_in_a_Vacuum_test.cs