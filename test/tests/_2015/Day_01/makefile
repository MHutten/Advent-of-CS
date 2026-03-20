test_tests_2015_Day_01: build/2015_01_Not_Quite_Lisp_test.exe build/2015_01_Not_Quite_Lisp_test.exe.config

build/2015_01_Not_Quite_Lisp_test.exe.config:
	aocst build\2015_01_Not_Quite_Lisp_test.exe.config test 2015 01

build/2015_01_Not_Quite_Lisp_test.exe: build/library/test/asserts.dll build/library/test/TestSuite.dll build/library/source/2015/Day_01/Not_Quite_Lisp.dll test/tests/_2015/Day_01/Not_Quite_Lisp_test.cs $\
                                       | build
	csc -out:build\2015_01_Not_Quite_Lisp_test.exe -r:build\library\test\asserts.dll;build\library\test\TestSuite.dll;build\library\source\2015\Day_01\Not_Quite_Lisp.dll -nologo .\test\tests\_2015\Day_01\Not_Quite_Lisp_test.cs