test: test_tests

include test/tests/makefile

build/library/test/asserts.dll: build/library/test/TestSuite.dll test/asserts.cs $\
                                | build/library/test
	csc -t:library -out:build\library\test\asserts.dll -r:build/library/test/TestSuite.dll -nologo .\test\asserts.cs

build/library/test/TestSuite.dll: test/TestSuite.cs $\
                                  | build/library/test
	csc -t:library -out:build\library\test\TestSuite.dll -nologo .\test\TestSuite.cs

build/library/test: | build/library
	mkdir "$@"