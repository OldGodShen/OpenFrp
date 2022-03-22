#include "work.cpp"
#include "libs.h"

#define Arch "arm"

OpenFrp openfrp(get_cur_executable_path_(), Arch);

int main() {
	return openfrp.main();
}