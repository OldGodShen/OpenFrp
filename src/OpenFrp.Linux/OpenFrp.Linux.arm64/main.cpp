#include "work.cpp"
#include "libs.h"

#define Arch "arm64"

OpenFrp openfrp(get_cur_executable_path_(), Arch);

int main() {
	return openfrp.main();
}