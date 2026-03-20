all: source test

include source/makefile
include test/makefile

build/library: | build
	mkdir "$@"

build:
	mkdir "$@"